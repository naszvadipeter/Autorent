using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoRentServer.Auth;
using AutoRentServer.Models.Autorent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);
// Authentication
builder.Services.AddAuthentication("Bearer").AddJwtBearer("Bearer", options =>
{
    var key = builder.Configuration["Authentication:Schemes:Bearer:SigningKeys:0:Value"];

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

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

// LogIn
app.MapPost("/login", (LoginUser login) =>
{
    AutorentContext _autorent = new AutorentContext();
    User? user = _autorent.Users.FirstOrDefault(x => x.Username.Equals(login.username) && x.Password.Equals(login.password));

    return Results.Json(user?.Id);
});

// GetUser
app.MapGet("/getUser", (int id) =>
{
    AutorentContext _autorent = new AutorentContext();
    User? user = _autorent.Users.FirstOrDefault(x => x.Id == id);

    return JsonConvert.SerializeObject(user, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
});

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
});

// GetCarImage
app.MapGet("/getCarImage", (int carId) =>
{
    byte[]? imageBytes = File.Exists($"img/{carId}.jpg") ? File.ReadAllBytes($"img/{carId}.jpg") : null;

    return JsonConvert.SerializeObject(imageBytes, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
});

// GetAllCategories
app.MapGet("/getAllCategories", () =>
{
    AutorentContext _autorent = new AutorentContext();
    _autorent.Cars.ToList();
    List<Category> categories = _autorent.Categories.ToList();

    return JsonConvert.SerializeObject(categories, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }); ;
});

app.Run();

#region Extra classes

public class LoginUser
{
    public string username { get; set; }
    public string password { get; set; }
}

#endregion