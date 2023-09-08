using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PoleschukKR.Sprint0.Task5.V0.Lib;

namespace Tyuiu.PoleschukKR.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример линейной структуры 
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Substruction (15, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));
            //Пример разветвляющей структуры находится в библиотеке классов методов Division
            Console.WriteLine("A / B = " + DataService.Division(16, 4));
            Console.ReadKey();

        }
    }
}
