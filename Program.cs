using System;

namespace test1
{
    class Class1
    {
        [STAThread]
        public static void Main(string[] args)
        {
            double a, b, c;
            bool szerkesztheto = false;
            Console.Write("Kérlek, add meg a háromszög oldalainak hosszát!\na: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
            c = Convert.ToDouble(Console.ReadLine());

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                szerkesztheto = true;
            }
            else szerkesztheto = false;

            if (szerkesztheto == true)
            {
                Console.WriteLine("A háromszög szerkeszthető");
            }
            else Console.WriteLine("A háromszög nem szerkeszthető");
        }
    }
}
