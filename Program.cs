using System;

namespace Algebra
{

    public class Formulas
    {
        public Program menu = new Program();
        public int? a = null;
        public int? b = null;
        public int? c = null;
        public int? result = null;

        public void Formula_1()
        {
                Console.WriteLine("========    ( a + b )^2 = a^2 + b^2 + 2ab    ========");

                Console.Write("Insert a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Insert b: ");
                b = Convert.ToInt32(Console.ReadLine());
                result = (a)^2 + (b)^2 + 2*(a)*(b);

                Console.Write("(a+b)^2 = {0} \n", result);
                Console.Write("or a^2 + b^2 + 2ab = {0} \n", result);
        }
        public void Formula_2()
        {
                Console.WriteLine("========    ( a + b )^2 = a^2 + b^2 + 2ab    ========");

                Console.Write("Insert a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Insert b: ");
                b = Convert.ToInt32(Console.ReadLine());
                result = (a)^2 + (b)^2 + 2*(a)*(b);

                Console.Write("(a+b)^2 = {0} \n", result);
                Console.Write("or a^2 + b^2 + 2ab = {0} \n", result);
        }

        public void Reset()
        {
            a = null;
            b = null;
            c = null;
            result = null;
        }
    }

    public class Program
    {
        public static void Menu()
        {
            Formulas formula = new Formulas();
            int? menu = null;

            Console.WriteLine("========  Algebra calculator  ========");
            Console.WriteLine("\n|------------------------------------|");
            Console.WriteLine("|1- ( a + b )^2 = a^2 + b^2 + 2ab    |");
            Console.WriteLine("|2- Numeric systems                  |");
            Console.WriteLine("|3- Real numbers                     |");
            Console.WriteLine("|4- Basic algebra                    |");
            Console.WriteLine("|5- Linear ecuations                 |");
            Console.WriteLine("|------------------------------------|\n");

            menu = Convert.ToInt32(Console.ReadLine());

            switch(menu)
            {
                case 1:
                    Console.WriteLine("( a + b )^2 = a^2 + b^2 + 2ab ");
                    Console.Clear();
                    formula.Formula_1();
                    break;
                case 2:
                    Console.WriteLine("Numeric Systems");
                    break;
                case 3:
                    Console.WriteLine("Real Numbers");
                    break;
                case 4:
                    Console.WriteLine("Basic Algebra");
                    break;
                case 5:
                    Console.WriteLine("F5");
                    break;
            }

        }


        public static void Main(string[] args)
        {
            Menu();

        }
    }
}