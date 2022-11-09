using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._3
{
    internal class Hedgehog:Animal
    {
        public bool HasSpikes { get; set; }

        public Hedgehog(bool hasSpikes, string name, decimal weight, decimal age) : base(name, weight, age)
        {
            this.HasSpikes= hasSpikes;

        }



        public override void DoSound()
        {
            Console.WriteLine("Sound like hedgehog!");
        }

        public override string Stats()
        {
            return Extensions.makeStringofProperties(this);
        }
    }
}
