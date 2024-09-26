
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

    List<Color> colors = new List<Color>
    {
        new Color(1,"Gri"),
        new Color(2,"Siyah"),
        new Color(3,"Beyaz")

    };
    List<Fuel> fuels = new List<Fuel>
    {
        new Fuel(1,"Benzin"),
        new Fuel(2,"Dizel"),
        new Fuel(3,"Elektrik")

    };
    List<Transmission> transmissions = new List<Transmission>
    {
        new Transmission(1,"Manuel"),
        new Transmission(2,"Otomatik"),
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
    public List<CarDetailDto> GetDetails(int id)
    {

        var result =
            from c in cars
            join o in colors on c.ColorId equals o.Id
            join f in fuels on c.FuelId equals f.Id
            join t in transmissions on c.TransmissionId equals t.Id



            select new CarDetailDto(
                Id: c.Id,
                ColorName: o.Name,
                FuelName: f.Name,
                TransmissionName: f.Name,
                CarState: c.CarState,
                KiloMeter: c.KiloMeter,
                ModelYear: c.ModelYear,
                Plate: c.Plate,
                BrandName: c.BrandName,
                ModelName: c.ModelName,
                Dailyprice:c.DailyPrice
                 );
        return result.ToList();


        }
    public List<CarDetailDto> GetAllDetailsByFuelId(int fuelId)
    {

        var result =
 
         from c in cars
         where c.FuelId == fuelId
         join o in colors on c.ColorId equals o.Id
         join f in fuels on c.FuelId equals f.Id
         join t in transmissions on c.TransmissionId equals t.Id



         select new CarDetailDto(
             Id: c.Id,
             ColorName: o.Name,
             FuelName: f.Name,
             TransmissionName: t.Name,
             CarState: c.CarState,
             KiloMeter: c.KiloMeter,
             ModelYear: c.ModelYear,
             Plate: c.Plate,
             BrandName: c.BrandName,
             ModelName: c.ModelName,
             Dailyprice:c.DailyPrice
              );
        return result.ToList();
    }
    public List<CarDetailDto> GetAllDetailsByColorId(int colorId)
    {

        var result =

         from c in cars
             where c.ColorId==colorId
         join o in colors on c.ColorId equals o.Id
         join f in fuels on c.FuelId equals f.Id
         join t in transmissions on c.TransmissionId equals t.Id



         select new CarDetailDto(
             Id: c.Id,
             ColorName: o.Name,
             FuelName: f.Name,
             TransmissionName: t.Name,
             CarState: c.CarState,
             KiloMeter: c.KiloMeter,
             ModelYear: c.ModelYear,
             Plate: c.Plate,
             BrandName: c.BrandName,
             ModelName: c.ModelName,
             Dailyprice:c.DailyPrice
              );
        return result.ToList();
    }
    public List<CarDetailDto> GetAllDetailsByPriceRange(double min, double max)
    {
        var result = (from c in cars
                      where c.DailyPrice <= max && c.DailyPrice >= min
                      join o in colors on c.ColorId equals o.Id
                      join f in fuels on c.FuelId equals f.Id
                      join t in transmissions on c.TransmissionId equals t.Id

                      select new CarDetailDto(
                                Id: c.Id,
                                ColorName: o.Name,
                                FuelName: f.Name,
                                TransmissionName: t.Name,
                                CarState: c.CarState,
                                KiloMeter: c.KiloMeter,
                                ModelYear: c.ModelYear,
                                Plate: c.Plate,
                                BrandName: c.BrandName,
                                ModelName: c.ModelName, 
                                Dailyprice:c.DailyPrice
                                 ));
        return result.ToList();




    }
    public List<CarDetailDto> GetAllDetailsByBrandNameContains(string brandName)
    {
        var result = (from c in cars
                      where c.BrandName.Contains(brandName, StringComparison.InvariantCultureIgnoreCase)
                      join o in colors on c.ColorId equals o.Id
                      join f in fuels on c.FuelId equals f.Id
                      join t in transmissions on c.TransmissionId equals t.Id

                      select new CarDetailDto(
                                Id: c.Id,
                                ColorName: o.Name,
                                FuelName: f.Name,
                                TransmissionName: t.Name,
                                CarState: c.CarState,
                                KiloMeter: c.KiloMeter,
                                ModelYear: c.ModelYear,
                                Plate: c.Plate,
                                BrandName: c.BrandName,
                                ModelName: c.ModelName,
                                Dailyprice:c.DailyPrice
                                 ));
        return result.ToList();
     
    }
    public List<CarDetailDto> GetAllDetailsByModelNameContains(string modelName)
    {

        var result = (from c in cars
                      where c.ModelName.Contains(modelName, StringComparison.InvariantCultureIgnoreCase)
                      join o in colors on c.ColorId equals o.Id
                      join f in fuels on c.FuelId equals f.Id
                      join t in transmissions on c.TransmissionId equals t.Id

                      select new CarDetailDto(
                                Id: c.Id,
                                ColorName: o.Name,
                                FuelName: f.Name,
                                TransmissionName: t.Name,
                                CarState: c.CarState,
                                KiloMeter: c.KiloMeter,
                                ModelYear: c.ModelYear,
                                Plate: c.Plate,
                                BrandName: c.BrandName,
                                ModelName: c.ModelName,
                                Dailyprice:c.DailyPrice
                                 ));
        return result.ToList();
      
    }
    public List<CarDetailDto> GetAllDetailsByKilometerRange(int min, int max)

    {

        var result = (from c in cars
                      where c.KiloMeter<= max && c.KiloMeter >= min
                      join o in colors on c.ColorId equals o.Id
                      join f in fuels on c.FuelId equals f.Id
                      join t in transmissions on c.TransmissionId equals t.Id

                      select new CarDetailDto(
                                Id: c.Id,
                                ColorName: o.Name,
                                FuelName: f.Name,
                                TransmissionName: t.Name,
                                CarState: c.CarState,
                                KiloMeter: c.KiloMeter,
                                ModelYear: c.ModelYear,
                                Plate: c.Plate,
                                BrandName: c.BrandName,
                                ModelName: c.ModelName, 
                                Dailyprice:c.DailyPrice
                                 ));
        return result.ToList();



    }

  
}


