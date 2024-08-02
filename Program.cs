
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PruebaC_Sharp_LuisAlejandroLondoñoValle.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=========================================================================");
            Console.WriteLine("                             < TransRiwi >                               ");
            Console.WriteLine("=========================================================================");
            Console.WriteLine("| {0,-1} | {1,-43} |", " No ", "                           Opción                             ");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(1) ", "Añadir experiencia a conductor                                ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(2) ", "Actualizar categoria de licencia                              ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(3) ", "Mostrar todos los clientes registrados                        ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(4) ", "Mostrar todos los conductores registrados                     ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(5) ", "Mostrar todos los usuarios con mas de 30 años de edad         ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(6) ", "Conductores mas experimentados                                ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(7) ", "Clientes que prefieren pagar con Tarjeta de credito           ");
            Console.WriteLine("| {0,-1} | {1,-43} |", "(8) ", "Conductores de motocicleta (A2)                               ");
            Console.WriteLine("| {0,-1} | {1,-53} |", "(0) ", "Salir                                                         ");
            Console.WriteLine("=========================================================================");
            Console.Write("Seleccione una opción del menú: ");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 0 || opcion > 8)
            {
                Console.WriteLine("UPS!! OPCION INVALIDA, INTENTE DE NUEVO...");
                Thread.Sleep(1800);
                continue;
            }

            switch (opcion)
            {
                case 0:
                    Console.WriteLine("Gracias por utilizar nuestro Software < TransRiwi > , Hasta pronto! :)");
                    Thread.Sleep(1500);
                    Environment.Exit(0);
                    break;
                case 1:
                    Driver.AddExperience();
                    break;
                case 2:
                    Driver.UpdateLicenseCategory();
                    break;
                case 3:
                    Customer.ShowCustomers();
                    break;
                case 4:
                    Driver.ShowDrivers();
                    break;
                case 5:
                    Customer.ShowCustomersWithMoreThanThirtyYearsOld();
                    break;
                case 6:
                    Driver.ShowDriversMoreexperienced();
                    break;
                case 7:
                    Customer.ShowCustomersWithCreditCardPayment();
                    break;
                case 8:
                    Driver.ShowDriversWhitCategoryA2();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }
}