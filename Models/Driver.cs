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

    public static List<Driver> ListDrivers = new List<Driver>
    {
        new Driver("123214422","A2",5,"Luis Alejandro","Londoño Valle","CC","1027806641",new DateOnly(2006,07,11),"alejandro.londono@example.com","4438418721","Calle 6A # 78 - 56"),
        new Driver("456789123","B2",3,"Maria","Lopez","CC","1027806642",new DateOnly(2005,03,10),"lopez.maria@example.com","4438418722","Calle 7A # 89 - 55"),
        new Driver("456789123","A2",2,"Mario","Londoño","CC","102780667",new DateOnly(1990,07,8),"mario.londono@example.com","44648676416","carrera 75 a # 45 - 22"),
        new Driver("789123456","B2",1,"Pedro","Perez","CC","1027806643",new DateOnly(1995,12,25),"perez.pedro@example.com","4438418723","Calle 8A # 90 - 54"),
        new Driver("123456789","A2",4,"Jose Benito","Martinez Ocasio","CC","1027806644",new DateOnly(2001,05,15),"martinez.jose@example.com","4438418724","Calle 9A # 100 - 56"),
        new Driver("987654321","B2",5,"Laura","Garcia","CC","1027806645",new DateOnly(2006,07,11),"garcia.laura@example.com","4438418725","Calle 10A # 78 - 56"),
    };


    public static void UpdateLicenseCategory()
    {
        Console.Write("Ingrese el numero de documento del conductor al que desea actualizarle la licensia ");
        string? numberIdentification;
        while (string.IsNullOrWhiteSpace(numberIdentification = Console.ReadLine()))
        {
            Console.WriteLine("El numero de documento del conductor no puede estar vacío. Intente de nuevo.");
            Thread.Sleep(4000);
            return;
        }

        var driverUpdate = ListDrivers.FirstOrDefault(d => d.IdentificationNumber == numberIdentification);
        if (driverUpdate == null)
        {
            Console.WriteLine("No se encontró el conductor con el numero de documento ingresado.");
            Thread.Sleep(4000);
            return;
        }
        Console.Write("Ingrese la categoria de la Licencia actualizada: ");
        string? category;
        while (string.IsNullOrWhiteSpace(category = Console.ReadLine()))
        {
            Console.WriteLine("la categoria de la Licencia no puede estar vacía. Intente de nuevo.");
            Thread.Sleep(4000);
            return;
        }
        string newCategory = category;
        driverUpdate.LicenseCategory = newCategory;
        Console.WriteLine("la categoria de la Licencia fue actualizada con exito.");
        Thread.Sleep(6000);

    }
    public static void AddExperience()
    {
        Console.Write("Ingrese el numero de documento del conductor al que desea actualizarle la licensia ");
        string? numberIdentification;
        while (string.IsNullOrWhiteSpace(numberIdentification = Console.ReadLine()))
        {
            Console.WriteLine("El numero de documento del conductor no puede estar vacío. Intente de nuevo.");
            Thread.Sleep(4000);
            return;
        }

        var driverAddExperience = ListDrivers.FirstOrDefault(d => d.IdentificationNumber == numberIdentification);
        if (driverAddExperience == null)
        {
            Console.WriteLine("No se encontró el conductor con el numero de documento ingresado.");
            Thread.Sleep(4000);
            return;
        }
        Console.Write("Ingrese la experiencia del conductor ");
        int experience;
        while (!int.TryParse(Console.ReadLine(), out experience) || experience <= 0)
        {
            Console.WriteLine("La experiencia del conductor debe ser un número válido mayor que cero. Intente de nuevo.");
            Thread.Sleep(4000);
            return;
        }
        int years = experience;
        driverAddExperience.DrivingExperience += years;
        Console.WriteLine("La experiencia del conductor fue actualizada con exito.");
        Thread.Sleep(6000);
    }
    public static void ShowDrivers()
    {
        Console.WriteLine("=========================================================================");
        Console.WriteLine("                           Lista de Conductores                          ");
        Console.WriteLine("=========================================================================");
        foreach (var driver in ListDrivers)
        {
            Console.WriteLine($"ID: {driver.Id}");
            Console.WriteLine($"Nombre: {driver.Name}");
            Console.WriteLine($"Apellido: {driver.LastName}");
            Console.WriteLine($"Tipo de Documento: {driver.TypeDocument}");
            Console.WriteLine($"Numero de Identificacion: {driver.IdentificationNumber}");
            Console.WriteLine($"Fecha de Nacimiento: {driver.BirthDate}");
            Console.WriteLine($"Email: {driver.Email}");
            Console.WriteLine($"Numero de telefono: {driver.PhoneNumber}");
            Console.WriteLine($"Direccion: {driver.Address}");
            Console.WriteLine($"Licencia: {driver.LicenseNumber}");
            Console.WriteLine($"Licencia Categoria: {driver.LicenseCategory}");
            Console.WriteLine($"Experiencia: {driver.DrivingExperience} años");
            driver.ShowAge();
            Console.WriteLine("------------------------------------------------------------------------");
            Thread.Sleep(800);
        }
        Console.WriteLine("=========================================================================");
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey();

        Console.WriteLine("¡Continuando con el programa!");
    }

    public static void ShowDriversMoreexperienced()
    {
        Console.WriteLine("=========================================================================");
        Console.WriteLine("               Lista de Conductores Mas Experimentados                   ");
        Console.WriteLine("=========================================================================");
        foreach (var driver in ListDrivers.OrderByDescending(d => d.DrivingExperience))
        {
            Console.WriteLine($"ID: {driver.Id}");
            Console.WriteLine($"Nombre: {driver.Name}");
            Console.WriteLine($"Apellido: {driver.LastName}");
            Console.WriteLine($"Tipo de Documento: {driver.TypeDocument}");
            Console.WriteLine($"Numero de Identificacion: {driver.IdentificationNumber}");
            Console.WriteLine($"Fecha de Nacimiento: {driver.BirthDate}");
            Console.WriteLine($"Email: {driver.Email}");
            Console.WriteLine($"Numero de telefono: {driver.PhoneNumber}");
            Console.WriteLine($"Direccion: {driver.Address}");
            Console.WriteLine($"Licencia: {driver.LicenseNumber}");
            Console.WriteLine($"Licencia Categoria: {driver.LicenseCategory}");
            Console.WriteLine($"Experiencia: {driver.DrivingExperience} años");
            driver.ShowAge();
            Console.WriteLine("------------------------------------------------------------------------");
            Thread.Sleep(800);
        }
        Console.WriteLine("=========================================================================");
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey();

        Console.WriteLine("¡Continuando con el programa!");
    }
    public static void ShowDriversWhitCategoryA2()
    {
        Console.WriteLine("=========================================================================");
        Console.WriteLine("               Lista de Conductores Mas Experimentados                   ");
        Console.WriteLine("=========================================================================");
        foreach (var driver in ListDrivers.Where(d => d.LicenseCategory == "A2").ToList())
        {
            Console.WriteLine($"ID: {driver.Id}");
            Console.WriteLine($"Nombre: {driver.Name}");
            Console.WriteLine($"Apellido: {driver.LastName}");
            Console.WriteLine($"Tipo de Documento: {driver.TypeDocument}");
            Console.WriteLine($"Numero de Identificacion: {driver.IdentificationNumber}");
            Console.WriteLine($"Fecha de Nacimiento: {driver.BirthDate}");
            Console.WriteLine($"Email: {driver.Email}");
            Console.WriteLine($"Numero de telefono: {driver.PhoneNumber}");
            Console.WriteLine($"Direccion: {driver.Address}");
            Console.WriteLine($"Licencia: {driver.LicenseNumber}");
            Console.WriteLine($"Licencia Categoria: {driver.LicenseCategory}");
            Console.WriteLine($"Experiencia: {driver.DrivingExperience} años");
            driver.ShowAge();
            Console.WriteLine("------------------------------------------------------------------------");
            Thread.Sleep(800);
        }
        Console.WriteLine("=========================================================================");
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey();

        Console.WriteLine("¡Continuando con el programa!");
    }


}
