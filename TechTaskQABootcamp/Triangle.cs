using System.Reflection.Metadata.Ecma335;

namespace TechTaskQABootcamp
{
    public class Triangle
    {
        public TrianglePoint A, B, C;
        public double AB, BC, AC;
        public double P;

        public Triangle(TrianglePoint a, TrianglePoint b, TrianglePoint c)
        {
            A = a;
            B = b;
            C = c;

            AB = Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2));
            BC = Math.Sqrt(Math.Pow(B.x - C.x, 2) + Math.Pow(B.y - C.y, 2));
            AC = Math.Sqrt(Math.Pow(A.x - C.x, 2) + Math.Pow(A.y - C.y, 2));

            P = AB + BC + AC;
        }

        public void WriteLengths()
        {
            Console.WriteLine($"\nLength of AB is '{AB}'");
            Console.WriteLine($"Length of BC is '{BC}'");
            Console.WriteLine($"Length of AC is '{AC}'");
        }

        public void WriteRoundedLengths()
        {
            Console.WriteLine($"\nLength of AB is '{Math.Round(AB)}'");
            Console.WriteLine($"Length of BC is '{Math.Round(BC)}'");
            Console.WriteLine($"Length of AC is '{Math.Round(AC)}'");
        }

        public void IsEquilateral()
        {
            if (AB == BC && BC == AC)
            {
                Console.WriteLine("Triangle IS 'Equilateral'");
            }
            else
            {
                Console.WriteLine("Triangle IS NOT 'Equilateral'");
            }
        }

        public void IsIsosceles()
        {
            if (AB == BC || BC == AC || AB == AC)
            {
                Console.WriteLine("Triangle IS 'Isosceles'");
            }
            else
            {
                Console.WriteLine("Triangle IS NOT 'Isosceles'");
            }
        }

        public void IsRight(double delta)
        {
            if ((BC * BC - (AB * AB + AC * AC) <= delta && BC * BC - (AB * AB + AC * AC) >= -delta) ||
                (AB * AB - (BC * BC + AC * AC) <= delta && AB * AB - (BC * BC + AC * AC) >= -delta) ||
                (AC * AC - (AB * AB + BC * BC) <= delta && AC * AC - (AB * AB + BC * BC) >= -delta))
            {
                Console.WriteLine("Triangle IS 'Right'");
            }
            else
            {
                Console.WriteLine("Triangle IS NOT 'Right'");
            }
        }

    }
}
