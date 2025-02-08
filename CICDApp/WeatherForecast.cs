namespace CICDApp
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}

// write a simple a+b function for an output of 3

public class SimpleMath
{
    public int Add(int a, int b)
    {
         a = 1;
         b = 2;
        int result = a + b;
        Console.WriteLine(result);
        return result;

    }


}
