using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace PruebaC_Sharp_LuisAlejandroLondoñoValle.Models;

public class Driver : User
{
    public string LicenseNumber { get; set; }
    public string LicenseCategory { get; set; }
    public int DrivingExperience { get; set; }



    public Driver(string licenseNumber, string licenseCategory, int drivingExperience, string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthdate, string email, string phoneNumber, string address)
    : base(name, lastName, typeDocument, identificationNumber, birthdate, email, phoneNumber, address)
    {
        LicenseNumber = licenseNumber;
        LicenseCategory = licenseCategory;
        DrivingExperience = drivingExperience;
    }

    public void UpdateLicenseCategory(string newCategory)
    {
        Console.Write("Ingrese la categoria de la Licencia actualizada: ");
        string? category;
        while (string.IsNullOrWhiteSpace(category = Console.ReadLine()))
        {
            Console.WriteLine("la categoria de la Licencia no puede estar vacía. Intente de nuevo.");
            Thread.Sleep(4000);
            return;
        }
        newCategory = category;

    }

    public void AddExperience(int years)
    {
        Console.Write("Ingrese la experiencia del conductor ");
        int experience;
        while (!int.TryParse(Console.ReadLine(), out experience) || experience <= 0)
        {
            Console.WriteLine("La experiencia del conductor debe ser un número válido mayor que cero. Intente de nuevo.");
            Thread.Sleep(4000);
            return;
        }
        years = experience;
    }
}
