using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAnimal
{
    public abstract class Animal
    {
        protected string Weight { get; set; }
        protected string Height { get; set; }
        
        public Animal(string weight, string height)
        {
            this.Weight = weight;
            this.Height = height;
        }
        
        public abstract void PrintInfo();
    }
    class Cat : Animal
    {
        private string Name { get; set; }
        public Cat(string weight, string height, string name)
        : base(weight, height)
        {
            this.Name = name;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Weight : {this.Weight}  \nHeight : {this.Height}  \nName: {this.Name}");
        }
    }
}
