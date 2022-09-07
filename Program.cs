using System.Globalization;
using ex01_no_interfaces.Entities;
using ex01_no_interfaces.Services;

Console.WriteLine("Entre com os dados do aluguel");
Console.Write("Modelo do carro: ");
string model = Console.ReadLine();
Console.Write("Início (dd/MM/yyyy hh:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.Write("Final (dd/MM/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Digite o preço por hora: ");
double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Digite o preço por dia: ");
double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

CarRental carRental = new CarRental(start, finish, new Vehicle(model));

RentalService rentalService = new RentalService(hour, day);

rentalService.ProcessInvoice(carRental);

Console.WriteLine("Aluguel: ");
Console.WriteLine(carRental.Invoice);