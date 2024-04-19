using Tutor5.Models;

namespace Tutor5.DataBase;

public class DBVisits
{
    public static List<Visit> Visits { get; set; } = new List<Visit>()
    {
        new Visit{DataVisit = DateTime.Now, Opis = "first", Price = 1000, Zwierze = new Animal{Id = 1, Kategoria = "cat", Kolor = "black", Masa = 3, Name = "Pop"}},
        new Visit{DataVisit = DateTime.Today , Opis = "second", Price = 500, Zwierze = new Animal{Id = 1, Kategoria = "cat", Kolor = "black", Masa = 3, Name = "Pop"}},
        new Visit{DataVisit = DateTime.Now, Opis = "first", Price = 700, Zwierze = new Animal{Id = 3, Kategoria = "tortilla", Kolor = "green", Masa = 1.5, Name = "Kapa"}},
    };

    public DBVisits()
    {
        Visits.Add(new Visit());
    }
    
    public static List<Visit> GetAllVisits()
    {
        return Visits;
    }
    public static Visit GetAllVisitsId(int id)
    {
        foreach (var tmp in Visits)
        {
            if (tmp.Zwierze.Id == id)
            {
                return tmp;
            }
        }
        return null;
    }
    
    public static void DeleteVisit(DateTime date)
    {
        Visit del = new Visit();
        foreach (Visit tmp in Visits)
        {
            if (tmp.DataVisit == date)
            {
                del = tmp;
            }
        }

        Visits.Remove(del);
    }
}