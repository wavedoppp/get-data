using System.ComponentModel;

namespace Module1HW1._1
//Modul 1 home work 1.3!!!
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Add your (X) ");
            int x = int.Parse(Console.ReadLine());
            var result = Math.Pow(x, 7) + (5 * x) - 1;
            Console.WriteLine(result);
            
            Console.WriteLine("Add your (Y) ");
            int y = int.Parse(Console.ReadLine());
            var result1 = Math.Pow(y, 5) % (5 * y) - 1;
            Console.WriteLine(result1);
            
            Console.WriteLine("Add your (S) ");
            int s = int.Parse(Console.ReadLine());
            var result2 = Math.Pow(s, 3) * (2 * s) - 1;
            Console.WriteLine(result2);

            Console.ReadLine();

        }
    }
}
