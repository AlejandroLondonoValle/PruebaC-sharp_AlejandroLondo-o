using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_Sharp_LuisAlejandroLondoñoValle.Models;

public class User
{
    protected Guid Id { get; set; }
    protected string Name { get; set; }
    protected string LastName { get; set; }
    protected string TypeDocument { get; set; }
    protected string IdentificationNumber { get; set; }
    protected DateOnly BirthDate { get; set; }
    protected string Email { get; set; }
    protected string PhoneNumber { get; set; }
    protected string Address { get; set; }


    protected User(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthdate, string email, string phoneNumber, string address)
    {
        Id = Guid.NewGuid();
        Name = name;
        LastName = lastName;
        TypeDocument = typeDocument;
        IdentificationNumber = identificationNumber;
        BirthDate = birthdate;
        Email = email;
        PhoneNumber = phoneNumber;
        Address = address;
    }

    // public static User Create(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthdate, string email, string phoneNumber, string address)
    // {
    //     return new User(name, lastName, typeDocument, identificationNumber, birthdate, email, phoneNumber, address);
    // }

    protected void ShowDetails()
    {
        Console.WriteLine("================================================================");
        Console.WriteLine("                      Detalles del Usuario                      ");
        Console.WriteLine("================================================================");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombre: {Name}");
        Console.WriteLine($"Apellido: {LastName}");
        Console.WriteLine($"Tipo de Documento: {TypeDocument}");
        Console.WriteLine($"Numero de Identificacion: {IdentificationNumber}");
        Console.WriteLine($"Fecha de Nacimiento: {BirthDate}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Numero de telefono: {PhoneNumber}");
        Console.WriteLine($"Direccion: {Address}");
        Console.WriteLine("================================================================");
    }

    protected int CalculateAge()
    {
        DateTime Today = DateTime.Now;
        int age = Today.Year - BirthDate.Year / 365;
        int months = Today.Month - BirthDate.Month;
        if (months < 0 || (months == 0 && Today.Day < BirthDate.Day))
        {
            age--;
        }
        int userAge = (Today.Year - BirthDate.Year) - (Today.Month < BirthDate.Month || (Today.Month == BirthDate.Month && Today.Day < BirthDate.Day)? 1 : 0);
        // int userAge = Math.Floor(age);
        return userAge;
    }
    public int miAge()
    {
        return CalculateAge();
    }

        protected void ShowAge()
    {
        Console.WriteLine($"Edad: {miAge}");

    }

    

}
