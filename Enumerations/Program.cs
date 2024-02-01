var temp = new Temperature(TemperatureUnit.Celcius, 10);

Console.WriteLine(temp.Unit);
Console.ReadKey();
enum TemperatureUnit
{
    Celcius,
    Fahrenheit,
    Kelvin
}


class Temperature
{
    public TemperatureUnit Unit { get; set; }

    public decimal Value { get; set; }

    public Temperature(TemperatureUnit unit, decimal value)
    {
        Unit = unit;
        Value = value;
    }

}


