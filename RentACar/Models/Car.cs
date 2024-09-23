
using Microsoft.VisualBasic.FileIO;

namespace RentACar.Models;


public class Car 
{
    internal object ColorName;
    internal object FuelName;
    internal object TransmissionName;

    public int Id { get; set; }
    internal object ColorId { get; set; }
    internal object FuelId { get; set; }
    internal object TransmissionId { get; set; }
    public string CarState { get; set; }
    public int? KiloMeter { get; set; }
    public short? ModelYear { get; set; }
    public string? Plate { get; set; }
    public string? BrandName { get; set; }
    public string? ModelName { get; set; }
    public double? DailyPrice { get; set; }




    public override string ToString()
    {
        return $" Id: {Id}, ColorId : {ColorId}," +
            $" FuelId: {FuelId}, VitesId : {TransmissionId}," +
            $" Araba Durumu : {CarState}, Kilometer : {KiloMeter}," +
            $" Model Yılı:{ModelYear}, Plaka:{Plate}," +
            $" Marka Adı:{BrandName}, Model Adı:{ModelName}," +
            $" Günlük Ücret: {DailyPrice}";
    }




    public Car(int id, int colorId, int fuelId, int transmissionId, string carState, int? kiloMeter, short? modelYear, string? plate, string? brandName, string? modelName, double? dailyPrice)
    {
        Id = id;
        ColorId = colorId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        CarState = carState;
        KiloMeter = kiloMeter;
        ModelYear = modelYear;
        Plate = plate;
        BrandName = brandName;
        ModelName = modelName;
        DailyPrice = dailyPrice;
    }


    public Car() 
    {
    }

}
