using System;
namespace reviewExercises
{
    public class Program
    {
        public static void Main()
        {
            const string Msg1 = "Write the width and height of a triangle and i will calculate it's area:";
            const string Msg2 = "The area of the triangle it's: {0}";
            const string MsgError = "The format of the number is incorrect";
            int width, height, area;
            Console.WriteLine(Msg1);
            try
            {
                width = int.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                area = MyMethods.TriangleArea(width, height);
                Console.WriteLine(Msg2, area);
            }catch(FormatException)
            {
                Console.WriteLine(MsgError);
            }
        }
    }
}