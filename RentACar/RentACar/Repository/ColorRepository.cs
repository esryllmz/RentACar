
//Bütün Repository classlarda GetById, GetAll,
//Update, Delete, Add metodları olmalıdır

using RentACar.Models;

namespace RentACar.Repository;

public class ColorRepository
{
    public List<Color> colors = new List<Color>
    {
        new Color(1,"Gri"),
        new Color(2,"Siyah"),
        new Color(3,"Beyaz")

    };


    public List<Color> GetAll()
    {
        return colors;
    }

    public Color? GetById(int id)
    {
        Color? color = colors.SingleOrDefault(x => x.Id == id);
        return color;


    }

    public Color Add(Color created)
    {
        colors.Add(created);
        return created;
    }

    public Color? Delete(int id)
    {
        Color? deletedColor = GetById(id);

        if (deletedColor is null)
        {
            return null;
        }
        colors.Remove(deletedColor);
        return deletedColor;
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
