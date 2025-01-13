using System;
namespace reviewExercises
{
    public class MyMethods
    {   
        public static string SecondsToTime(int seconds)
        {
            int minutes, hours;
            hours = seconds / 60 / 60;
            seconds = seconds - hours * 3600;
            minutes = seconds / 60;
            seconds = seconds - minutes * 60;
            string Msg1 = $"The result is {hours} hours, {minutes} minutes, {seconds} seconds";
            return Msg1;
        }

        public static int TriangleArea(int width, int height)
        {
            const int Divider = 2;
            return width * height / Divider;
        }

        public static double CelsiusToFarenheit(double temperature)
        {
            const int Multiplier = 9;
            const int Divider = 5;
            const int Plus = 32;
            return temperature * Multiplier / Divider + Plus;
        }

        public static double CelsiusToKelvin(double temperature)
        {
            const float Plus = 273.15f;
            return temperature + Plus;
        }

        public static double KelvinToCelsius(double temperature)
        {
            const float Minus = 273.15f;
            return temperature - Minus;
        }

        public static double ShowDiscount(double price, double discountedPrice)
        {
            double discount;
            discount = discountedPrice / price * 100;
            discount = 100-discount;
            return discount;
        }
    }
}