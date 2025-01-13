using System;
namespace reviewExercises
{
    public class Program
    {
        public static void Main()
        {
            const string Msg1 = "Write a celsius temperature and i will turn it to kelvin:";
            const string Msg2 = "The kelvin temperature it's: {0}";
            const string MsgError = "The format of the number is incorrect";
            double temperature;
            Console.WriteLine(Msg1);
            try
            {
                temperature = double.Parse(Console.ReadLine());
                temperature = MyMethods.CelsiusToKelvin(temperature);
                Console.WriteLine(Msg2, temperature);
            }catch(FormatException)
            {
                Console.WriteLine(MsgError);
            }
        }
    }
}