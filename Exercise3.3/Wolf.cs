using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._3
{
    internal class Wolf:Animal
    {
        public bool HuntsInPack { get; set; }
        public Wolf(bool huntsInPack, string name, decimal weight, decimal age):base(name, weight, age)
        {
            this.HuntsInPack = huntsInPack;

        }



        public override void DoSound()
        {
            Console.WriteLine("Wooooollf!");
        }
        public override string Stats()
        {
            return Extensions.makeStringofProperties(this);
        }
    }
}
