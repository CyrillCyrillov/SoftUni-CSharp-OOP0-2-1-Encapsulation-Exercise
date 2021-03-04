using System;

namespace Task01_Class_Box_Data
{
    public class Program
    {
        static void Main(string[] args)
        {
            // length, width and height

            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box curentBox = new Box(length, width, height);
                
                Console.WriteLine($"Surface Area - {curentBox.SurfaceArea():f2}");

                Console.WriteLine($"Lateral Surface Area - {curentBox.LateralSurfaceArea():f2}");

                Console.WriteLine($"Volume - {curentBox.Volume():f2}");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }

            //Console.WriteLine("Hello World!");
        }
    }
}
