
using RentACar.Models;
using RentACar.Models.Dtos;
using RentACar.Repository;
using RentACar.Services;

CarService carService=new CarService();
FuelService fuelService=new FuelService();
ColorService colorService=new ColorService();
TransmissionService transmissionService=new TransmissionService();

carService.GetAll();
carService.GetById(3);
//carService.Add();
//carService.Delete(2);
//carService.Update(4);
carService.GetDetails();

Car GetBookInputs()
{
    Console.WriteLine("Araba Id giriniz: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Renk Id giriniz:");
    int colorId = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Yakıt Id giriniz:");
    int fuelId = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Vites Id giriniz:");
    int transmissionId = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Araba Durumu giriniz:");
    string carState = Console.ReadLine();

    Console.WriteLine("Kilometre giriniz:");
    int kiloMeter = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Model Yılı giriniz:");
    short modelYear = Convert.ToSByte(Console.ReadLine());

    Console.WriteLine("Plaka giriniz:");
    string plate = Console.ReadLine();

    Console.WriteLine("Marka Adı giriniz:");
    string brandName = Console.ReadLine();

    Console.WriteLine("Model Adı giriniz:");
    string modelName = Console.ReadLine();

    Console.WriteLine("Günlük Fiyatı giriniz:");
    double dailyPrice = Convert.ToDouble(Console.ReadLine());

    Car car = new Car(id,colorId,fuelId,transmissionId,carState,kiloMeter,modelYear,plate,brandName,modelName,dailyPrice);
    return car;
}






