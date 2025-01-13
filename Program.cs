using System;
namespace reviewExercises
{
    public class Program
    {
        public static void Main()
        {
            const string Msg1 = "Write a price and a discounted price and i will tell you how many was the discount used:";
            const string Msg2 = "The discount was: {0}%";
            const string MsgError = "The format of the number is incorrect";
            double price, discountedPrice, discount;
            Console.WriteLine(Msg1);
            try
            {
                price = double.Parse(Console.ReadLine());
                discountedPrice = double.Parse(Console.ReadLine());
                discount = MyMethods.ShowDiscount(price, discountedPrice);
                Console.WriteLine(Msg2, discount);
            }catch(FormatException)
            {
                Console.WriteLine(MsgError);
            }
        }
    }
}