namespace Praktyki.zad1;

public class Car
{
    public string Model;
    public string Color;
    public double Mileage;
    public string Brand;
    public int YearOfProduction;
    public double EngineSize;

    public Car(string model, string color, double mileage, string brand, int yearOfProduction, double enginesize)
    {
        Model = model;
        Color = color;
        Brand = brand;
        YearOfProduction = yearOfProduction;
        Mileage = mileage;
        EngineSize = enginesize;
    }
}