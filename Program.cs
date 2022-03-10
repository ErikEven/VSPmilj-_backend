using VSPmiljø_backend.Models;
using VSPmiljø_backend.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IBeerService, BeerService>();

var app = builder.Build();

app.MapPost("/create",
    (BeerModel Beer, IBeerService service) =>
    {
        var result = service.Create(Beer);
        return Results.Ok(result);
    });

app.MapGet("/get",
    (int id, IBeerService service) =>
    {
        var Beer = service.Get(id);
        if (Beer == null) return Results.NotFound("Beer not found");
        return Results.Ok(Beer);
    });
app.MapGet("/list",
    (IBeerService service) =>
    {
        var Beers = service.List();
        return Results.Ok(Beers);
    });

app.MapPut("/update",
    (BeerModel newBeer, IBeerService service) =>
    {
        var updatedBeer = service.Update(newBeer);
        if (updatedBeer != null) Results.NotFound("Beer not found");

        return Results.Ok(updatedBeer);
    });

app.MapDelete("/delete",
    (int id, IBeerService service) =>
    {
        var result = service.Delete(id);

        if (!result) Results.BadRequest("Something went wrong");

        return Results.Ok(result);
    });

app.Run();
