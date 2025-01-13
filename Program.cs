using reviewexErcises;
using System;
namespace reviewExercises
{
    public class Program
    {
        public static void Main()
        {
            const string Msg1 = "Write a number of seconds and i will pass it to hours, minutes and seconds";
            const string MsgError = "The format of the number is incorrect";
            int seconds;
            string msg2;
            Console.WriteLine(Msg1);
            try
            {
                seconds = int.Parse(Console.ReadLine());
                msg2 = MyMethods.SecondsToTime(seconds);
                Console.WriteLine(msg2);
            }catch(FormatException)
            {
                Console.WriteLine(MsgError);
            }
        }
    }
}