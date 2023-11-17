using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesChemikalia.Data;
using System;
using System.Linq;

namespace RazorPagesChemikalia.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesChemikaliaContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesChemikaliaContext>>()))
        {
            if (context == null || context.Chemikalium == null)
            {
                throw new ArgumentNullException("Null RazorPagesChemikaliaContext");
            }
            
            if (context.Chemikalium.Any())
            {
                return;   // DB has been seeded
            }

            context.Chemikalium.AddRange(
                new Chemikalium
                {
                    Nazwa = "snieg",
                    DataOdkrycia = DateTime.Parse("0001-01-01"),
                    Ph = "obojetne",
                    Rozpuszczalnosc = "slaba",
                    Toksycznosc = "niska",
                    Zapach = "nie ma zapachu",
                    StanSkupienia = "ciecz",
                    Barwa = "biala",
                    TemperaturaTopnienia = "nie topi sie",
                    Uzytecznosc = "nie najgorsza"
                    
                    
                },

                new Chemikalium
                {
                    Nazwa = "woda",
                    DataOdkrycia = DateTime.Parse("0001-01-01"),
                    Ph = "obojetne",
                    Rozpuszczalnosc = "tak",
                    Toksycznosc = "niska",
                    Zapach = "nie ma zapachu",
                    StanSkupienia = "ciecz",
                    Barwa = "bezbarwna",
                    TemperaturaTopnienia = "0",
                    Uzytecznosc = "nie da sie zyc bez niej"
                },

                new Chemikalium
                {
                    Nazwa = "keczup",
                    DataOdkrycia = DateTime.Parse("1900-01-01"),
                    Ph = "kwasny",
                    Rozpuszczalnosc = "slaba",
                    Toksycznosc = "niska",
                    Zapach = "pomidorowy z octem",
                    StanSkupienia = "gesta zawiesina",
                    Barwa = "czerwony",
                    TemperaturaTopnienia = "0",
                    Uzytecznosc = "niektorzy jedza z nim jajecznice"
                },

                new Chemikalium
                {
                    Nazwa = "majonez",
                    DataOdkrycia = DateTime.Parse("1900-01-01"),
                    Ph = "dobre pytanie",
                    Rozpuszczalnosc = "tak",
                    Toksycznosc = "niska",
                    Zapach = "tlustym jajkiem",
                    StanSkupienia = "eeeeee stan skupienia majonezu",
                    Barwa = "bialy albo zolty",
                    TemperaturaTopnienia = "0",
                    Uzytecznosc = "czasem zamiast masla"
                }
            );
            context.SaveChanges();
        }
    }
}