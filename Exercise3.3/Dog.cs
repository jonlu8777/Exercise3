using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._3
{
    internal class Dog:Animal
    {
        public bool Barking { get; set; }
        
        public Dog(bool barking, string name, decimal weight, decimal age) : base(name, weight, age)
        {

            this.Barking = barking
                ;
        }

        public override void DoSound()
        {
            Console.WriteLine("bark!");
        }

        public override string Stats()
        {
            return Extensions.makeStringofProperties(this);
        }

        public string AgeStringDog()
        {
            return $"This dog is {Age} years old";
        }
    }
}
