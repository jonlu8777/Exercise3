using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._3
{
    internal class Bird:Animal
    {
        public decimal WingSpan { get; set; }

        public Bird(decimal wingSpan, string name, decimal weight, decimal age):base(name,weight,age)
        {
            this.WingSpan = wingSpan;

        }

        public override void DoSound()
        {
            Console.WriteLine("chirp!");
        }
        public override string Stats()
        {
            return Extensions.makeStringofProperties(this);
        }
    }
}
