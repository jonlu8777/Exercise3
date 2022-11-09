using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise3._3
{
    internal class Flamingo:Bird
    {
        public bool IsFlamingo
        {
            get; 
            set;   
        }
        public Flamingo(bool isFlamingo, decimal wingSpan, string name, decimal weight, decimal age) : base(wingSpan, name, weight, age)
        {
            this.IsFlamingo = isFlamingo;
        }
            public override void DoSound()
        {
            Console.WriteLine("chirpFlamingo!");
        }
        public override string Stats()
        {
            return Extensions.makeStringofProperties(this);
        }

    }



    
}
