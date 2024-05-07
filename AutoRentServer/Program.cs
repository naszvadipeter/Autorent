using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoRentServer.Auth;
using AutoRentServer.Models;
using AutoRentServer.Models.Autorent;
using AutoRentServer.WebSocket;
using AutoRentServer.WebSocket.Handlers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);
// Authentication
builder.Services.AddAuthentication("Bearer").AddJwtBearer("Bearer", options =>
{
    var key = builder.Configuration["Authentication:Schemes:Bearer:SigningKeys:0"];

    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidIssuer = builder.Configuration["Authentication:Schemes:Bearer:ValidIssuer"],
        ValidateAudience = true,
        ValidAudiences = builder.Configuration.GetSection("Authentication:Schemes:Bearer:ValidAudiences").Get<List<string>>(),
        ValidateLifetime = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key ?? throw new InvalidOperationException("Signing Key not found."))),
        ValidateIssuerSigningKey = true
    };
});

// Authorization
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("user", policy => policy.RequireRole("user"));
    options.AddPolicy("admin", policy => policy.RequireRole("admin"));
});

// WEBSOCKET
builder.Services.AddWebSocketManager();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

// LogIn
app.MapPost("/login", (LoginUser login) =>
{
    AutorentContext _autorent = new AutorentContext();
    User? user = _autorent.Users.FirstOrDefault(x => x.Username.Equals(login.username) && x.Password.Equals(login.password));

    if (user == null)
        return Results.NotFound("User not found!");

    user.Password = string.Empty;
    string token = new AuthHelper(builder).GenerateJtwBearer(user);
    return Results.Ok(new { Token = token, User = user});
});

// GetUser
app.MapGet("/getUser", (int id) =>
{
    AutorentContext _autorent = new AutorentContext();
    User? user = _autorent.Users.FirstOrDefault(x => x.Id == id);
    
    return JsonConvert.SerializeObject(user, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
}).RequireAuthorization("admin");

// GetAllUsers
app.MapGet("/getAllUsers", () =>
{
    AutorentContext _autorent = new AutorentContext();
    List<User> users = _autorent.Users.ToList();
    
    return JsonConvert.SerializeObject(users, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
}).RequireAuthorization("admin");

// GetAllCars
app.MapGet("/getAllCars", () =>
{
    AutorentContext _autorent = new AutorentContext();
    _autorent.Categories.ToList();

    var cars = _autorent.Cars.Select(x => new { 
        Id = x.Id,
        CategoryId = x.CategoryId,
        Brand = x.Brand,
        Model = x.Model,
        DailyPrice = x.DailyPrice,
        Category = x.Category,
        Rentals = x.Rentals,
        Sale = x.Sale,
        ByteImage = File.Exists($"img/{x.Id}.jpg") ? File.ReadAllBytes($"img/{x.Id}.jpg") : null
    }).ToList();

    return JsonConvert.SerializeObject(cars, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
}).RequireAuthorization();

// GetCarImage
app.MapGet("/getCarImage", (int carId) =>
{
    byte[]? imageBytes = File.Exists($"img/{carId}.jpg") ? File.ReadAllBytes($"img/{carId}.jpg") : null;

    return JsonConvert.SerializeObject(imageBytes, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
}).RequireAuthorization();

// GetAllCategories
app.MapGet("/getAllCategories", () =>
{
    AutorentContext _autorent = new AutorentContext();
    _autorent.Cars.ToList();
    List<Category> categories = _autorent.Categories.ToList();

    return JsonConvert.SerializeObject(categories, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }); ;
}).RequireAuthorization();

// Add New Rental
app.MapPost("/addRental", (Rental rental) =>
{
    // Data check (DATE)
    if(rental.ToDate < rental.FromDate || new AutorentContext().Rentals.Where(x => x.CarId == rental.CarId).Any(x => (x.FromDate <= rental.FromDate && x.ToDate >= rental.FromDate) || (x.FromDate <= rental.ToDate && x.ToDate >= rental.ToDate)))
        return Results.Ok("ERROR");

    rental.Created = DateTime.Now;
    
    AutorentContext _autorent = new AutorentContext();
    _autorent.Rentals.Add(rental);
    int n = _autorent.SaveChanges();

    if (n == 0)
        return Results.Ok("ERROR");
    else
        return Results.Ok("OK");
}).RequireAuthorization("user");

// WEBSOCKET
var serviceScopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
var serviceProvider = serviceScopeFactory.CreateScope().ServiceProvider;
app.UseWebSockets();
app.MapWebSocketManager("/ws/users", serviceProvider.GetService<UserHandler>());

// GetRentals
app.MapGet("/getRentals", (int userID) =>
{
    AutorentContext _autorent = new AutorentContext();
    _autorent.Rentals.ToList();
    _autorent.Cars.ToList();
    _autorent.Sales.ToList();
    _autorent.Categories.ToList();
    _autorent.Users.ToList();

    var rentals = _autorent.Rentals.Where(x => x.UserId == userID).ToList();

    //return Results.Ok(rentals);
    return JsonConvert.SerializeObject(rentals, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
}).RequireAuthorization("user");

//// GetCar
//app.MapGet("/getCar", (int carID) =>
//{
//    AutorentContext _autorent = new AutorentContext();
//    _autorent.Categories.ToList();

//    var car = _autorent.Cars.FirstOrDefault(x => x.Id == carID);

//    return JsonConvert.SerializeObject(car, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
//}).RequireAuthorization("user");

//// GetSale
//app.MapGet("/getSale", (int saleID) =>
//{
//    AutorentContext _autorent = new AutorentContext();
//    _autorent.Categories.ToList();

//    var sale = _autorent.Sales.FirstOrDefault(x => x.Id == saleID);

//    return JsonConvert.SerializeObject(sale, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
//}).RequireAuthorization("user");

app.Run();