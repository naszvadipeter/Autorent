using AutoRentServer.Models.Autorent;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/getAllCars", () =>
{
    AutorentContext _autorent = new AutorentContext();
    _autorent.Categories.ToList();

    List<Car> cars = _autorent.Cars.ToList();

    return JsonConvert.SerializeObject(cars, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }); ;
});

app.Run();