
namespace RentACar.Models;

public class Transmission:Entity<int>
{
    public Transmission(int ıd, string? name)
    {
        Id = ıd;
        Name = name;
    }

    
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}, Name: {Name}";
    }
  
}
