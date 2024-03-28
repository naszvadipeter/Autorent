using AutoRentServer.Models.Autorent;
using Newtonsoft.Json;

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

    List<Car> cars = _autorent.Cars.ToList();

    return JsonConvert.SerializeObject(cars, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }); ;
});

app.Run();

#region Extra classes

public class LoginUser
{
    public string username { get; set; }
    public string password { get; set; }
}

#endregion