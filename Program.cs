using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAnimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("30kg","2.0","Kitty");
            cat.PrintInfo();
            Console.ReadLine();
        }
    }
}
