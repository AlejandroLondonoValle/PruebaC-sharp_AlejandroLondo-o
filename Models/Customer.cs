using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_Sharp_LuisAlejandroLondoñoValle.Models;
public class Customer : User
{
    public string MembershipLevel { get; set; }
    public string PreferredPaymentMethod { get; set; }

    public Customer(string membership, string preferredPaymentMethod, string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthdate, string email, string phoneNumber, string address) : base(name, lastName, typeDocument, identificationNumber, birthdate, email, phoneNumber, address)
    {
        MembershipLevel = membership;
        PreferredPaymentMethod = preferredPaymentMethod;
    }

    public static List<Customer> ListCustomers = new List<Customer>
    {
        new Customer("Gold","Tarjeta de Credito","Maria Alejandra","Lopez Arias","CC","1084606642",new DateOnly(2002,06,10),"lopez.mariaja@example.com","4197164178","Calle 75A # 99 - 55"),
        new Customer("Platinum","Pago en Efectivo","Jose","Lopez Arias","CC","1084606643",new DateOnly(1993,07,15),"lopez.joseja@example.com","4197164179","Calle 85A # 100 - 56"),
        new Customer("Diamond","Tarjeta de Credito","Juan Guillermo","Ruiz Alvarez","CC","10846064466",new DateOnly(2000,12,22),"guillo.alvarez@example.com","974199816","Calle 67 # 45"),
        new Customer("Platinum","Pago en Efectivo","Valentina","Agudelo Arias","CC","1084606642",new DateOnly(2002,08,18),"agudelo.mariaja@example.com","4197164178","Calle 75A # 99 - 55"),
        new Customer("Silver","Tarjeta de Credito","Jorge","Benavidez Pulgarin","CC","94197195",new DateOnly(1991,06,21),"Jorge.Benavidez@example.com","4197164178","Calle 99B # 99 - 67"),
    };
    public void UpdateMembershipLevel()
    {
        Console.Write("Ingrese el numero de documento del cliente al que desea actualizarle el nivel de Membresia ");
        string? numberIdentification;
        while (string.IsNullOrWhiteSpace(numberIdentification = Console.ReadLine()))
        {
            Console.WriteLine("El numero de documento del cliente no puede estar vacío. Intente de nuevo.");
            Thread.Sleep(4000);
            return;
        }

        var customerUpdateMembership = ListCustomers.FirstOrDefault(c => c.IdentificationNumber == numberIdentification);
        if (customerUpdateMembership == null)
        {
            Console.WriteLine("No se encontró el cliente con el numero de documento ingresado.");
            Thread.Sleep(4000);
            return;
        }
        Console.Write("Ingrese el nuevo nivel de membresia: ");
        string? membershipLevel;
        while (string.IsNullOrWhiteSpace(membershipLevel = Console.ReadLine()))
        {
            Console.WriteLine("la categoria de la Licencia no puede estar vacía. Intente de nuevo.");
            Thread.Sleep(4000);
            return;
        }
        customerUpdateMembership.MembershipLevel = membershipLevel;
        Console.WriteLine("la membresia fue actualizada con exito.");
        Thread.Sleep(4000);
    }


    public static void ShowCustomers()
    {
        Console.WriteLine("=========================================================================");
        Console.WriteLine("                           Lista de Clientes                             ");
        Console.WriteLine("=========================================================================");
        foreach (var customer in ListCustomers)
        {
            Console.WriteLine($"ID: {customer.Id}");
            Console.WriteLine($"Nombre: {customer.Name}");
            Console.WriteLine($"Apellido: {customer.LastName}");
            Console.WriteLine($"Tipo de Documento: {customer.TypeDocument}");
            Console.WriteLine($"Numero de Identificacion: {customer.IdentificationNumber}");
            Console.WriteLine($"Fecha de Nacimiento: {customer.BirthDate}");
            Console.WriteLine($"Email: {customer.Email}");
            Console.WriteLine($"Numero de telefono: {customer.PhoneNumber}");
            Console.WriteLine($"Direccion: {customer.Address}");
            Console.WriteLine($"Membresia: {customer.MembershipLevel}");
            Console.WriteLine($"Preferencias de pago: {customer.PreferredPaymentMethod}");
            customer.ShowAge();
            Console.WriteLine("------------------------------------------------------------------------");
            Thread.Sleep(800);
        }
        Console.WriteLine("=========================================================================");
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey();
        Console.WriteLine("¡Continuando con el programa!");
        Thread.Sleep(800);
    }

    public static void ShowCustomersWithMoreThanThirtyYearsOld()
    {
        Console.WriteLine("=========================================================================");
        Console.WriteLine("                       Lista de Clientes Mayores de 30 años                     ");
        Console.WriteLine("=========================================================================");
        foreach (var customer in ListCustomers.Where(c => c.BirthDate.AddYears(30) < DateOnly.FromDateTime(DateTime.Now)))
        {
            Console.WriteLine($"ID: {customer.Id}");
            Console.WriteLine($"Nombre: {customer.Name}");
            Console.WriteLine($"Apellido: {customer.LastName}");
            Console.WriteLine($"Tipo de Documento: {customer.TypeDocument}");
            Console.WriteLine($"Numero de Identificacion: {customer.IdentificationNumber}");
            Console.WriteLine($"Fecha de Nacimiento: {customer.BirthDate}");
            Console.WriteLine($"Email: {customer.Email}");
            Console.WriteLine($"Numero de telefono: {customer.PhoneNumber}");
            Console.WriteLine($"Direccion: {customer.Address}");
            Console.WriteLine($"Membresia: {customer.MembershipLevel}");
            Console.WriteLine($"Preferencias de pago: {customer.PreferredPaymentMethod}");
            customer.ShowAge();
            Console.WriteLine("------------------------------------------------------------------------");
            Thread.Sleep(800);
        }
        Console.WriteLine("=========================================================================");
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey();
        Console.WriteLine("¡Continuando con el programa!");
        Thread.Sleep(800);
    }

    public static void ShowCustomersWithCreditCardPayment()
    {
        Console.WriteLine("=========================================================================");
        Console.WriteLine("              Lista de Clientes Preferenciales con tarjeta               ");
        Console.WriteLine("=========================================================================");
        foreach (var customer in ListCustomers.Where(c => c.PreferredPaymentMethod == "Tarjeta de Credito").ToList())
        {
            Console.WriteLine($"ID: {customer.Id}");
            Console.WriteLine($"Nombre: {customer.Name}");
            Console.WriteLine($"Apellido: {customer.LastName}");
            Console.WriteLine($"Tipo de Documento: {customer.TypeDocument}");
            Console.WriteLine($"Numero de Identificacion: {customer.IdentificationNumber}");
            Console.WriteLine($"Fecha de Nacimiento: {customer.BirthDate}");
            Console.WriteLine($"Email: {customer.Email}");
            Console.WriteLine($"Numero de telefono: {customer.PhoneNumber}");
            Console.WriteLine($"Direccion: {customer.Address}");
            Console.WriteLine($"Membresia: {customer.MembershipLevel}");
            Console.WriteLine($"Preferencias de pago: {customer.PreferredPaymentMethod}");
            customer.ShowAge();
            Console.WriteLine("------------------------------------------------------------------------");
            Thread.Sleep(800);
        }
        Console.WriteLine("=========================================================================");
        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadKey();
        Console.WriteLine("¡Continuando con el programa!");
        Thread.Sleep(800);
    }


}
