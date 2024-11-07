Car car = new Car("Toyota", "Camry", 2022, "automatic");
Bicycle bicycle = new Bicycle("Haro", "Midway", 2024, "BMX");
car.CommonInfo();
bicycle.CommonInfo();

public class Vehicle
{
    public string brand {  get; set; }
    public string model { get; set; }
    public int year { get; set; }
    public Vehicle(string brand, string model, int year)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
    }
    public virtual void CommonInfo()
    {
        Console.WriteLine($"Brand: {brand}, Model: {model}, Year: {year}");
    } 
}

public class Car : Vehicle
{
    public string transmission { get; set; }
    public Car(string brand, string model, int year, string transmission)
        : base(brand, model, year)
    {
        this.transmission = transmission;
    }
    public override void CommonInfo()
    {
        base.CommonInfo();
        Console.WriteLine($"Transmission: {transmission}");
    }
}
public class Bicycle : Vehicle
{
    public string type { get; set; }
    public Bicycle(string brand, string model, int year, string type)
        : base(brand, model, year)
    {
        this.type = type;
    }
    public override void CommonInfo()
    {
        base.CommonInfo();
        Console.WriteLine($"Type: {type}");
    }
}
