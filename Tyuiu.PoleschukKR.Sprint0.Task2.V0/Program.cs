using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PoleschukKR.Sprint0.Task2.V0.Lib;
namespace Tyuiu.PoleschukKR.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вызов класса DataService и метода GetMessage
            // Из библиотеки Tyuiu.PoleschukKR.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Кирилл"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
