using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaC_Sharp_LuisAlejandroLondoñoValle.Models;

namespace PruebaC_Sharp_LuisAlejandroLondoñoValle.Models;

public class Vehicle
{
    public int Id { get; set; }
    public string Placa { get; set; }
    public string Type { get; set; }
    public string EngineNumber { get; set; }
    public string SerialNumber { get; set; }
    public byte PeopleCapacity { get; set; }
    public Driver Owner { get; set; }


    public Vehicle(int id, string placa, string type, string engineNumber, string serialNumber, byte peopleCapacity, Driver owner)
    {
        Id = id;
        Placa = placa;
        Type = type;
        EngineNumber = engineNumber;
        SerialNumber = serialNumber;
        PeopleCapacity = peopleCapacity;
        Owner = owner;
    }
    public static List<Vehicle> ListVehicles = new List<Vehicle>
    {
        new Vehicle(1, "PIX091", "Moto", "544124871121","197465481",2, new Driver("123214422","A2",5,"Luis Alejandro","Londoño Valle","CC","1027806641",new DateOnly(2006,07,11),"alejandro.londono@example.com","4438418721","Calle 6A # 78 - 56")),
        new Vehicle(2, "ABC123", "Carro", "1671575278","235564665423",5, new Driver("456789123","B2",3,"Maria","Lopez","CC","1027806642",new DateOnly(2005,03,10),"lopez.maria@example.com","4438418722","Calle 7A # 89 - 55")),
        new Vehicle(3, "DEF456", "Camión", "4234256334","34223556432",10, new Driver("456789123","A2",2,"Mario","Londoño","CC","102780667",new DateOnly(1990,07,8),"mario.londono@example.com","44648676416","carrera 75 a # 45 - 22")),
        new Vehicle(4, "GHI789", "limosina", "3423456789","567891234567",15, new Driver("789123456","B2",1,"Pedro","Perez","CC","1027806643",new DateOnly(1995,12,25),"perez.pedro@example.com","4438418723","Calle 8A # 90 - 54")),
        new Vehicle(5, "JKL901", "Moto", "7896543210","987654321098",2, new Driver("123456789","A2",4,"Jose Benito","Martinez Ocasio","CC","1027806644",new DateOnly(2001,05,15),"martinez.jose@example.com","4438418724","Calle 9A # 100 - 56")),
        new Vehicle(6, "MNO012", "Camioneta", "9876543210","123456789012",8, new Driver("987654321","B2",5,"Laura","Garcia","CC","1027806645",new DateOnly(2006,07,11),"garcia.laura@example.com","4438418725","Calle 10A # 78 - 56")),
    };

    public void DeleteVehicle(int id)
    {
        Console.Write("Ingrese el id de el Vehiculo ");
        int idVehicle;
        while (!int.TryParse(Console.ReadLine(), out idVehicle) || idVehicle <= 0)
        {
            Console.WriteLine("El id de el Vehiculo r debe ser un número válido mayor que cero. Intente de nuevo.");
            Thread.Sleep(4000);
            return;
        }

        var idToDelete = ListVehicles.FirstOrDefault(v => v.Id == idVehicle);
        if (idToDelete == null)
        {
            Console.WriteLine("No se encontró el empleado con el nombre y apellido ingresados.");
            Thread.Sleep(4000);
            return;
        }

        ListVehicles.Remove(idToDelete);
        Console.WriteLine($"El vehiculo con el id {idToDelete.Id} ha sido eliminado exitosamente.");
        Console.WriteLine($"la placas del vehiculo eliminado es {idToDelete.Placa}");
        Console.WriteLine("=========================================================================");
        Thread.Sleep(5000);
    }
}
