using AutoRentServer.Models.Autorent;
using Newtonsoft.Json;
using System.Drawing;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

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

    return JsonConvert.SerializeObject(user, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }); ;
});


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

    return JsonConvert.SerializeObject(cars, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }); ;
});

app.MapGet("/getCarImage", (int carId) =>
{
    byte[]? imageBytes = File.Exists($"img/{carId}.jpg") ? File.ReadAllBytes($"img/{carId}.jpg") : null;

    return JsonConvert.SerializeObject(imageBytes, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
});

    return JsonConvert.SerializeObject(base64String, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
});

app.Run();

#region Extra classes

public class LoginUser
{
    public string username { get; set; }
    public string password { get; set; }
}

#endregion