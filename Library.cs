using System;
namespace reviewexErcises
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
    }
}
