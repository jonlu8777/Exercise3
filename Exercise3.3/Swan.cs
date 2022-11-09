using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise3._3
{
    internal class Swan : Bird
    {
        public bool IsSwan { get; set; }
        public Swan(bool isSwan, decimal wingSpan, string name, decimal weight, decimal age) : base(wingSpan, name, weight, age)
        {
            this.IsSwan = isSwan;

        }
          public override void DoSound()
        {
            Console.WriteLine("chirpSwan!");
        }
        public override string Stats()
        {
            return Extensions.makeStringofProperties(this);
        }
    } 
    
}

