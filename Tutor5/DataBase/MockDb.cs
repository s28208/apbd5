using Tutor5.Models;

namespace Tutor5.DataBase;

public class MockDb
{
    public static List<Animal> Animals { get; set; } = new List<Animal>()
    {
        new Animal{Id = 1, Kategoria = "cat", Kolor = "black", Masa = 3, Name = "Pop"},
        new Animal{Id = 2, Kategoria = "dog", Kolor = "white", Masa = 10, Name = "Chiko"},
        new Animal{Id = 3, Kategoria = "tortilla", Kolor = "green", Masa = 1.5, Name = "Kapa"}
    };

    public MockDb()
    {
        Animals.Add(new Animal());
    }
    
    public static Animal GetAnimalById(int id)
    {
        foreach (Animal tmp in Animals)
        {
            if (tmp.Id == id){ return tmp;}
        }
        return null;
    }

    public static List<Animal> GetAllAnimals()
    {
        return Animals;
    }

    public static void DeleteAnimal(int id)
    {
        Animal del = new Animal();
        foreach (Animal tmp in Animals)
        {
            if (tmp.Id == id)
            {
                del = tmp;
            }
        }

        Animals.Remove(del);
    }
}
