using MedicalClinic.DataBase.Models;
using MedicalClinic.DataBase;

namespace MedicalClinic.Core;

public static class SampleDataGenerator
{
    private static readonly Context context = new Context();
    public static void clearAndAddSampleData()
    {
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        context.Add(new Patient { firstName = "John", lastName = "Doe", pesel = "12345678901", email = "test1@test.com", city = "Krakow", street = "Krakowska", zipCode = "00-000" });
        context.Add(new Patient { firstName = "Jane", lastName = "Doe", pesel = "12345678902", email = "test2@test.com", city = "Warsaw", street = "Warszawska", zipCode = "00-000" });
        context.Add(new Patient { firstName = "Alice", lastName = "Smith", pesel = "12345678903", email = "test3@test.com", city = "Gdansk", street = "Gdanska", zipCode = "00-000" });
        context.Add(new Patient { firstName = "Bob", lastName = "Smith", pesel = "12345678904", email = "test4@test.com", city = "Wroclaw", street = "Wroclawska", zipCode = "00-000" });
        context.Add(new Patient { firstName = "Charlie", lastName = "Brown", pesel = "12345678905", email = "test5@test.com", city = "Poznan", street = "Poznanska", zipCode = "00-000" });
        context.SaveChanges();
    }

    public static void addRandom() 
    {
        Random rand = new Random();
        var names = new string[] { "John", "Jane", "Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Henry" };
        var lastNames = new string[] { "Doe", "Smith", "Brown", "White", "Black", "Green", "Blue", "Red", "Yellow", "Pink" };
        var cities = new string[] { "Krakow", "Warsaw", "Gdansk", "Wroclaw", "Poznan", "Lodz", "Szczecin", "Lublin", "Katowice", "Gdynia" };
        var streets = new string[] { "Krakowska", "Warszawska", "Gdanska", "Wroclawska", "Poznanska", "Lodzka", "Szczecinska", "Lubelska", "Katowicka", "Gdynska" };
        var zipCodes = new string[] { "00-000", "11-111", "22-222", "33-333", "44-444", "55-555", "66-666", "77-777", "88-888", "99-999" };

        context.Add(new Patient { 
            firstName = names[rand.Next(0, 10)],
            lastName = lastNames[rand.Next(0, 10)],
            pesel = rand.Next(100000, 999999).ToString() + rand.Next(10000, 99999).ToString(),
            email = $"test{rand.Next(1, 100)}@test.com",
            city = cities[rand.Next(0, 10)],
            street = streets[rand.Next(0, 10)],
            zipCode = zipCodes[rand.Next(0, 10)] });

        context.SaveChanges();
    }
}