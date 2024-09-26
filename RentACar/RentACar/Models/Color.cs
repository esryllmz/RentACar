
using System.Xml.Linq;

namespace RentACar.Models;


public  class Color:Entity<int>
{


    public Color(int id, string? name)
    {
        Id = id;
        Name = name;
    }

   
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}, Name: {Name}";
    }
}


