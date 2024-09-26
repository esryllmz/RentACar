
//CarService ve Repository classlarında CarDetailDto türünde bazı işlemler yapmanız beklenmektedir.

using RentACar.Models;
using RentACar.Models.Dtos;
using RentACar.Repository;
using System;
using System.Drawing;


namespace RentACar.Services;

public class CarService
{
    CarRepository carRepository=new CarRepository();
    //ColorRepository colorRepository=new ColorRepository();
    //FuelRepository fuelRepository=new FuelRepository();
    //TransmissionRepository transmissionRepository=new TransmissionRepository();


    public void GetAll()
    {
        List<Car> cars = carRepository.GetAll();

        foreach (Car car in cars)
        {
            Console.WriteLine(car);
        }
    }

    public void GetById(int id)
    {

        Car? car = carRepository.GetById(id);
        if (car is null)
        {
            Console.WriteLine($"Aradığınız Id ye göre Araba bulunamadı : {id}");
            return;
        }

        Console.WriteLine(car);

    }
    public void Add(Car car)
    {
        Car created = carRepository.Add(car);
        Console.WriteLine("Araba eklendi : ");
        Console.WriteLine(created);
    }
    public void Delete(int id)
    {
        Car? deletedCar = carRepository.Delete(id);
        if (deletedCar is null)
        {
            Console.WriteLine("Aradığınız araba bulunamadı(Zaten Yok)");
            return;
        }
        Console.WriteLine(deletedCar);
    }

    //public void Update(int id)
    //{
    //    Car? updatedCar = carRepository.Delete(id);
    //    if (updatedCar is not null)
    //    {
    //        Console.WriteLine("Renk Id:");
    //        int colorId = Convert.ToInt32(Console.ReadLine());

    //        Console.WriteLine("Yakıt Id:");
    //        int fuelId = Convert.ToInt32(Console.ReadLine());

    //        Console.WriteLine("Vites Id:");
    //        int transmissionId = Convert.ToInt32(Console.ReadLine());

    //        Console.WriteLine("Araba Durumu:");
    //        string carState = Console.ReadLine();

    //        Console.WriteLine("Kilometre:");
    //        int kiloMeter = Convert.ToInt32(Console.ReadLine());

    //        Console.WriteLine("Model Yılı:");
    //        short modelYear =Convert.ToSByte(Console.ReadLine());

    //        Console.WriteLine("Plaka:");
    //        string plate = Console.ReadLine();

    //        Console.WriteLine("Marka Adı:");
    //        string brandName = Console.ReadLine();

    //        Console.WriteLine("Model Adı:");
    //        string modelName = Console.ReadLine();

    //        Console.WriteLine("Günlük Fiyatı:");
    //        double dailyPrice = Convert.ToDouble(Console.ReadLine());

    //    }
    //    else
    //    {
    //        Console.WriteLine("Aradığınız araba bulunamadı(Zaten Yok)");
    //        return;
    //    }

    //    Add(updatedCar);



    //}
    public void GetDetails(int id)
    {
        List<CarDetailDto> cars = carRepository.GetAllDetailsByColorId(id);

        foreach (CarDetailDto carDetail in cars)
        {
            Console.WriteLine(carDetail);
        }

    }


   
    public void GetAllDetailsByFuelId(int fuelId)
    {
        List<CarDetailDto> cars = carRepository.GetDetails(fuelId);

        foreach (CarDetailDto carDetail in cars)
        {
            Console.WriteLine(carDetail);
        }
    }
    public void GetAllDetailsByColorId(int colorId)
    {
        List<CarDetailDto> cars = carRepository.GetAllDetailsByColorId(colorId);

        foreach (CarDetailDto carDetail in cars)
        {
            Console.WriteLine(carDetail);
        }
    }
    public void GetAllDetailsByPriceRange(double min, double max)
    {
        List<CarDetailDto> cars = carRepository.GetAllDetailsByPriceRange(min, max);

        cars.ForEach(car => Console.WriteLine(car));

    }
    public void GetAllDetailsByBrandNameContains(string brandName)
    {
        List<CarDetailDto> cars = carRepository.GetAllDetailsByBrandNameContains(brandName);

        foreach (CarDetailDto  car in cars)
        {
            Console.WriteLine(car);
        }

    }
    public void GetAllDetailsByModelNameContains(string modelName)
    {
        List<CarDetailDto> cars = carRepository.GetAllDetailsByModelNameContains(modelName);

        foreach (CarDetailDto car in cars)
        {
            Console.WriteLine(car);
        }
    }
    public void GetAllDetailsByKilometerRange(int min, int max)

    {
        List<CarDetailDto> cars = carRepository.GetAllDetailsByKilometerRange(min, max);

        foreach (CarDetailDto car in cars)
        {
            Console.WriteLine(car);
        }
    }

    
}
