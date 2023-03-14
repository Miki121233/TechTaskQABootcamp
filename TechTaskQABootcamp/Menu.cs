using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTaskQABootcamp
{
    public static class Menu
    {
        public static double delta;// = 0.00000000000001; //precision
        public static double pomX, pomY;
        public static TrianglePoint A, B, C;
        public static Triangle triangle;


        public static void Init()
        {

        menu:
            try
            {
                Console.WriteLine("Enter coordinate x od dot A:");
                pomX = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter coordinate y od dot A:");
                pomY = Convert.ToDouble(Console.ReadLine());
                A = new TrianglePoint(pomX, pomY);
                Console.WriteLine("Enter coordinate x od dot B:");
                pomX = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter coordinate y od dot B:");
                pomY = Convert.ToDouble(Console.ReadLine());
                B = new TrianglePoint(pomX, pomY);
                Console.WriteLine("Enter coordinate x od dot C:");
                pomX = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter coordinate y od dot C:");
                pomY = Convert.ToDouble(Console.ReadLine());
                C = new TrianglePoint(pomX, pomY); Console.WriteLine();

                triangle = new Triangle(A, B, C);
                Console.WriteLine("Set precision (delta):");
                delta = Convert.ToDouble(Console.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine("\nWrong key, coming back to choose!\n");
                goto menu;
            }
        }

        public static void Output(int outputNumber)
        {
            switch (outputNumber)
            {
                case 1:
                    {
                        triangle.WriteLengths(); Console.WriteLine();
                        triangle.IsEquilateral();
                        triangle.IsIsosceles();
                        triangle.IsRight(delta);
                        Console.WriteLine($"\nPerimeter: '{triangle.P}'\n");
                        Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");
                        for (int i = 0; i < triangle.P; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case 2:
                    {
                        triangle.WriteRoundedLengths(); Console.WriteLine();
                        triangle.IsEquilateral();
                        triangle.IsIsosceles();
                        triangle.IsRight(delta);
                        Console.WriteLine($"\nPerimeter: '{Math.Round(triangle.P)}'\n");
                        Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");
                        for (int i = 0; i < triangle.P; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                   
            }

        }

    }
}
