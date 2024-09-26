
using System.Drawing;

namespace RentACar.Models.Dtos;

public class CarDetailDto
{

    public int id { get; set; }
    public string? fuelname { get; set; }
    public string? transmissionname { get; set; }
    public string? colorname { get; set; }
    public string carstate { get; set; }
    public int? kilometer { get; set; }
    public short? modelyear { get; set; }
    public string? plate { get; set; }
    public string? brandname { get; set; }
    public string? modelname { get; set; }
    public double? dailyprice { get; set; }


    public override string ToString()
    {
        return $" ıd: {id}, color: {colorname}," +
            $" yakıt: {fuelname}, vites: {transmissionname}," +
            $" araba durumu : {carstate}, kilometer : {kilometer}," +
            $" model yılı:{modelyear}, plaka:{plate}," +
            $" marka adı:{brandname}, model adı:{modelname}," +
            $" günlük ücret:{dailyprice}";
    }


    public CarDetailDto() { 
    
    }

    public CarDetailDto(int Id, string? ColorName, string? FuelName, string? TransmissionName, string CarState, int? KiloMeter, short? ModelYear, string? Plate, string? BrandName, string? ModelName,double? Dailyprice)
    {
        id = Id;
        colorname = ColorName;
        fuelname = FuelName;
        transmissionname = TransmissionName;
        carstate = CarState;
        kilometer = KiloMeter;
        modelyear = ModelYear;
        plate = Plate;
        brandname = BrandName;
        modelname = ModelName;
        dailyprice = Dailyprice;
    }
    
}