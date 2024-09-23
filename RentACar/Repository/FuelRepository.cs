
//Bütün Repository classlarda GetById, GetAll,
//Update, Delete, Add metodları olmalıdır


using RentACar.Models;

namespace RentACar.Repository;

public class FuelRepository
{

    List<Fuel> fuels = new List<Fuel>
    {
        new Fuel(1,"Benzin"),
        new Fuel(2,"Dizel"),
        new Fuel(3,"Elektrik")

    };
    public Fuel? GetById(int id)
    {
        Fuel? fuel = fuels.SingleOrDefault(x => x.Id == id);
        return fuel;


    }

    public Fuel Add(Fuel created)
    {
        fuels.Add(created);
        return created;
    }

    public Fuel? Delete(int id)
    {
        Fuel? deletedFuel = GetById(id);

        if (deletedFuel is null)
        {
            return null;
        }
        fuels.Remove(deletedFuel);
        return deletedFuel;
    }

    //public void Update(int id)
    //{

    //    Car? updatedCar = GetById(id);

    //    if (updatedCar is null)
    //    {
    //        return;
    //    }

    //    return updatedCar;

    //}
}
