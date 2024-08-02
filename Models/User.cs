using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
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
    }

    int age = 0;
    protected int CalculateAge(int age)
    {
        age = DateTime.Today.Year - BirthDate.Year;
        int monthDiff = DateTime.Today.Month - BirthDate.Month;
        if (monthDiff < 0 || (monthDiff == 0 && DateTime.Today.Day < BirthDate.Day))
        {
            age--;
        }
        return age;
    }

    protected void ShowAge()
    {
        Console.WriteLine($"Edad: {CalculateAge(age)}");

    }



}
