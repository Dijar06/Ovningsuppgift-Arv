using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange bredd:");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Ange höjd:");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Välj 1 om du vill räkna på en rätvinklig triangel");
            Console.WriteLine("Välj 2 om du vill ränka på en rektangel");
            int val = int.Parse(Console.ReadLine());

            double area = 0;
            double circumferance = 0;
            Shape shape = null;

            if (val == 1)
            {
                shape = new Triangle(width, height);
            }

            else if (val == 2)
            {
                shape = new Rectangle(width, height);
            }

            area = shape.Area();
            circumferance = shape.Circumferance();

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Omkrets: " + circumferance);
        }
    }
}