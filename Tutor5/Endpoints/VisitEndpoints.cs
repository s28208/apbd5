using Microsoft.AspNetCore.Builder;
using Tutor5.DataBase;
using Tutor5.Models;

namespace Tutor5.Endpoints;

public static class VisitEndpoints
{
    public static void MapVisitEndpoints(this WebApplication app)
    {
        app.MapPost("/visit", (Visit visit) =>
        {
            if (MockDb.GetAnimalById(visit.Zwierze.Id) != null)
            {
                DBVisits.Visits.Add(visit);
                return Results.Created("", visit);
            }
            else
            {
                return Results.NotFound("Animal not found");
            }
        });

        app.MapGet("/visits/{id}", (int id) =>
        {
            if (DBVisits.GetAllVisitsId(id) != null)
            {
                return Results.Ok(DBVisits.GetAllVisitsId(id));
            }else
            {
                return Results.NotFound("Animal not found");
            }
        });
        
        app.MapGet("/visits/", () =>
        {
            return Results.Ok(DBVisits.GetAllVisits());

        });
        
       /* app.MapDelete("/animal/{date}", (DateTime date) =>
        {
            if (DBVisits.Visits.Find(dateT => dateT.DataVisit == date) == null)
            {
                return Results.NotFound("Visit not found");
            }
            DBVisits.DeleteVisit(date);
            return Results.Ok();
        });*/
    }

}