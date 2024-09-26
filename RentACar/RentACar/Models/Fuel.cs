

namespace RentACar.Models;

public class Fuel:Entity<int>
{


    public Fuel(int id, string? name)
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
