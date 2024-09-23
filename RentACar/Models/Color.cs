
using System.Xml.Linq;

namespace RentACar.Models;


public  class Color
{


    public Color(int ıd, string? name)
    {
        Id = ıd;
        Name = name;
    }

    public int Id { get; set; }
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}, Name: {Name}";
    }
}


