using System;
namespace reviewExercises
{
    public class Program
    {
        public static void Main()
        {
            const string Msg1 = "Write a kelvin temperature and i will turn it to farenheit:";
            const string Msg2 = "The farenheit temperature it's: {0}";
            const string MsgError = "The format of the number is incorrect";
            double temperature;
            Console.WriteLine(Msg1);
            try
            {
                temperature = double.Parse(Console.ReadLine());
                temperature = MyMethods.KelvinToCelsius(temperature);
                temperature = MyMethods.CelsiusToFarenheit(temperature);
                Console.WriteLine(Msg2, temperature);
            }catch(FormatException)
            {
                Console.WriteLine(MsgError);
            }
        }
    }
}