
//Bütün Repository classlarda GetById, GetAll,
//Update, Delete, Add metodları olmalıdır


using RentACar.Models;

namespace RentACar.Repository;

public class TransmissionRepository
{


    List<Transmission> transmissions = new List<Transmission>
    {
        new Transmission(1,"Manuel"),
        new Transmission(2,"Otomatik"),
    };

    public List<Transmission> GetAll()
    {
        return transmissions;
    }

    public Transmission? GetById(int id)
    {
        Transmission? transmission = transmissions.SingleOrDefault(x => x.Id == id);
        return transmission;


    }

    public Transmission Add(Transmission created)
    {
        transmissions.Add(created);
        return created;
    }

    public Transmission? Delete(int id)
    {
        Transmission? deletedTransmission = GetById(id);

        if (deletedTransmission is null)
        {
            return null;
        }
        transmissions.Remove(deletedTransmission);
        return deletedTransmission;
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
