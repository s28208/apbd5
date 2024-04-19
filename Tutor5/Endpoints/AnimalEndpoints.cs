using Tutor5.Controller;
using Tutor5.Models;
using Tutor5.DataBase;

namespace Tutor5.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        /* app.MapGet("/animals", () =>
        {
            //200-ok
            var animals = StaticData.animals;
            return Results.Ok();
        });
        app.MapGet("/animals{id}", (int id) =>
        {
            return Results.Ok(id);
        });
        app.MapPost("/animals", (Animal animal) =>
        {
            return Results.Created("", animal);
        });*/
        
        app.MapPost("/animal", (Animal animal) =>
        {
            if (MockDb.GetAnimalById(animal.Id) == null)
            {
                MockDb.Animals.Add(animal);
                return Results.Created("", animal);
            }
            else
            {
                return Results.BadRequest("ID just exists");
            }
        });
        
        app.MapGet("/animals", () =>
        {
            return Results.Ok(MockDb.GetAllAnimals());
        });
        
        
        
        app.MapGet("/animal/{id}", (int id) =>
        {
            if (MockDb.GetAnimalById(id)==null)
            {
                return Results.NotFound("Animal not found");
            }

            return Results.Ok(MockDb.GetAnimalById(id));
        });
        
        
        
        
        app.MapPut("/animal/{id}", (int id, Animal updatedAnimal) =>
        {
            Animal existingAnimal = MockDb.GetAnimalById(id);
            if (existingAnimal == null)
            {
                return Results.NotFound("Animal not found");
            }
            existingAnimal.Name = updatedAnimal.Name;
            existingAnimal.Kategoria = updatedAnimal.Kategoria;
            existingAnimal.Kolor = updatedAnimal.Kolor;
            existingAnimal.Masa = updatedAnimal.Masa;
            return Results.Ok();
        });
        
        app.MapDelete("/animal/{id}", (int id) =>
        {
            if (MockDb.GetAnimalById(id) == null)
            {
                return Results.NotFound("Animal not found");
            }
            MockDb.DeleteAnimal(id);
            return Results.Ok();
        });
        
        
    }
}