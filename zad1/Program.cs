using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Введи имя кота");
            string name = Console.ReadLine();
            Console.WriteLine("Введи вес кота");
            string ves = Console.ReadLine();
            Cat cat = new Cat(name,ves);
            if(cat.Check())
                cat.Meow();
            Console.ReadKey();
        }
    }
}
