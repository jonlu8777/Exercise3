using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._3
{
    internal class Worm : Animal
    {
        public bool IsPoison { get; set; }

        public Worm(bool isPoison, string name, decimal weight, decimal age):base(name,weight,age)
            {
             this.IsPoison = isPoison;


            }



        public override void DoSound()
        {
            Console.WriteLine("Sound like worm!");
        }
        public override string Stats()
        {
            return Extensions.makeStringofProperties(this);
        }
    }
}
