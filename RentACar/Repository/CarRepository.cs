
//Bütün Repository classlarda GetById, GetAll,
//Update, Delete, Add metodları olmalıdır

//CarService ve Repository classlarında CarDetailDto türünde bazı işlemler yapmanız beklenmektedir.


using RentACar.Models;
using System.Drawing;
using static System.Reflection.Metadata.BlobBuilder;
using RentACar.Models.Dtos;
using RentACar.Services;
using RentACar.Repository;
using Color = RentACar.Models.Color;
using System.Linq;
//using Color = RentACar.Models.Color;

namespace RentACar.Repository;
public class CarRepository
{
    public List<Car> cars = new List<Car>()


    {
        new Car(1,1,2,1,"İkinci el",26100,2023,"54 EY 048","Fiat","Fiorino Combi",4800),
        new Car(2,2,1,2,"İkinci el",52000,2017,"25 TZ 166","Volkswagen","Passat",6200),
        new Car(3,1,1,1,"İkinci el",23000,2024,"35 MN 223","Ford","Focus",4500),
        new Car(4,3,3,2,"İkinci el",87000,2017,"44 ZA 567","Mercedes","Vito",9600),
        new Car(5,3,1,1,"İkinci el",54000,2019,"13 KU 932","Renault","Clio",4400),
        new Car(6,2,3,2,"İkinci el",32000,2020,"07 VR 418","Ford","Fiesta",5100),
        new Car(7,1,2,2,"İkinci el",95000,2015,"34 PR 042","Volvo","XC-90",8600),
        new Car(8,2,1,1,"İkinci el",71000,2018,"80 YT 317","Opel","Astra",5100),
        new Car(9,3,2,1,"İkinci el",12000,2024,"62 EF 895","Fiat","Egea",6300),

    };
   
    public List<Car> GetAll()
    {
        return cars;
    }

    public Car? GetById(int id)
    {
        Car? car = cars.SingleOrDefault(x => x.Id == id);
        return car;


    }

    public Car Add(Car created)
    {
        cars.Add(created);
        return created;
    }

    public Car? Delete(int id)
    {
        Car? deletedCar = GetById(id);

        if (deletedCar is null)
        {
            return null;
        }
        cars.Remove(deletedCar);
        return deletedCar;
    }

    //public void Update(int id)
    //{
    //    Car? updatedCar = GetById(id);

    //    if (updatedCar is null)
    //    {
    //        return;
    //    }
    //    cars.Remove(updatedCar);
    //    return updatedCar;

    //}

    //public  List<CarDetailDto> GetDetails()
    //{
        
    //    var result =
    //        from c in cars
    //        join o in colors on c.ColorName equals o.Name
    //        join f in fuels on c.FuelName equals f.Name
    //        join t in transmissions on c.TransmissionName equals t.Name



    //        select new CarDetailDto(
    //            Id:c.Id,
    //            ColorName:o.Name,
    //            FuelName:f.Name,
    //            TransmissionName:f.Name,
    //            CarState:c.CarState,
    //            KiloMeter:c.KiloMeter,
    //            ModelYear:c.ModelYear,
    //            Plate:c.Plate,
    //            BrandName:c.BrandName,
    //            ModelName:c.ModelName
    //             );
    //    return result.ToList();


    //}


    public List<CarDetailDto> GetAllDetailsByFuelId(int fuelId)
    {

        Car car= cars.Where(x => x.FuelId== fuelId).SingleOrDefault();

        //Car car = cars.FirstOrDefault(x => x.FuelId==fuelId);
        return car;
    }

    //public List<CarDetailDto> GetAllDetailsByColorId(int colorId)
    //{
    //    Car car = cars.SingleOrDefault(x => x.ColorId == colorId);
    //    return car;
    //}
    //public List<CarDetailDto> GetAllDetailsByPriceRange(double min, double max)
    //{
    //    List<Car> result = (from b in cars
    //                        where b.DailyPrice <= max && b.DailyPrice >= min
    //                        select b).ToList();

    //    List<Car> result = car.Where(b => b.DailyPrice <= max && b.DailyPrice >= min).ToList();


    //}
    //public List<CarDetailDto> GetAllDetailsByBrandNameContains(string brandName)
    //{
    //    List<Car> filteredCars = cars.FindAll(x => x.BrandName.Contains(brandName, StringComparison.InvariantCultureIgnoreCase));
    //    return filteredCars;

    //}

    //public List<CarDetailDto> GetAllDetailsByModelNameContains(string modelName)
    //{
    //    List<Car> filteredCars = cars.FindAll(x => x.ModelName.Contains(modelName, StringComparison.InvariantCultureIgnoreCase));
    //    return filteredCars;
    //}

    //public CarDetailDto? GetDetailById(int Id)
    //{
    //    Car car = cars.SingleOrDefault(x => x.Id == x.Id);
    //    return car;
    //}

    //public List<CarDetailDto> GetAllDetailsByKilometerRange(int min, int max)

    //{
    //    List<Car> result = cars.FindAll(x => x.KiloMeter <= max && x.KiloMeter >= min);
    //    return result;


    //}


}


