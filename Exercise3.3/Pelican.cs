using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._3
{
    internal class Pelican : Bird
    {
        public bool IsPelican { get; set; }

        public Pelican(bool isPelican,decimal wingSpan, string name, decimal weight, decimal age) : base(wingSpan, name, weight, age)
        {
            this.IsPelican = isPelican;
        }
        public override void DoSound()
        {
            Console.WriteLine("chirpPelican!");
        }
        public override string Stats()
        {
            return Extensions.makeStringofProperties(this);
        }
    }

}
