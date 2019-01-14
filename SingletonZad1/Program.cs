using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonZad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Roman rozpoczyna pracę");
            var roman = RomanEmplyee.Start();
            Console.WriteLine($"Pracownik jest w pracy: {RomanEmplyee.IsWorking()}");
            Console.WriteLine("Roman kończy pracę");
            RomanEmplyee.Stop();
            Console.WriteLine($"Pracownik jest w pracy: {RomanEmplyee.IsWorking()}");

            //Bonus
            Console.WriteLine("Roman nie pracuje");
            //Console.WriteLine($"Pracownik pracuje już {RomanEmplyee.WorkingTime()}");

            Console.ReadKey();
        }
    }
}
