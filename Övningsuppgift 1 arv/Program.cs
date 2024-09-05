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

            if (val == 1)
            {
                Triangle triangle = new Triangle(width, height);
                area = triangle.Area();
                circumferance = triangle.Circumferance();
            }

            else if (val == 2)
            {
                Rectangle rectangle = new Rectangle(width, height);
                area = rectangle.Area();
                circumferance = rectangle.Circumferance();
            }

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Omkrets: " + circumferance);
        }
    }
}