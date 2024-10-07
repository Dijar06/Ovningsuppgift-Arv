using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj 1 om du vill räkna på en rätvinklig triangel");
            Console.WriteLine("Välj 2 om du vill ränka på en rektangel");
            Console.WriteLine("Välj 3 om du vill räkna på en cirkel");
            Console.WriteLine("Välj 4 om du vill ränka på en cylinder");
            Console.WriteLine("Välj 5 om du vill ränka på en sphere");
            int val = int.Parse(Console.ReadLine());

            double area = 0;
            double circumferance = 0;
            IShape shape = null;

            if (val == 1)
            {
                Console.WriteLine("Ange bredd:");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("Ange höjd:");
                double height = double.Parse(Console.ReadLine());

                shape = new Triangle(width, height);
            }

            else if (val == 2)
            {
                Console.WriteLine("Ange bredd:");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("Ange höjd:");
                double height = double.Parse(Console.ReadLine());

                shape = new Rectangle(width, height);
            }

            else if (val == 3)
            {
                Console.WriteLine("Ange radie:");
                double radie = double.Parse(Console.ReadLine());

                shape = new Circle(radie);
            }

            else if (val == 4)
            {
                Console.WriteLine("Ange radie:");
                double radie = double.Parse(Console.ReadLine());
                Console.WriteLine("Ange höjd:");
                double height = double.Parse(Console.ReadLine());

                shape = new Cylinder(radie, height);
            }

            else if (val == 5)
            {
                Console.WriteLine("Ange radie:");
                double radie = double.Parse(Console.ReadLine());

                shape = new Sphere(radie);
            }

            area = shape.Area();
            circumferance = shape.Circumferance();

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Omkrets: " + circumferance);
        }
    }
}