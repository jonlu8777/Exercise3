using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._3
{
  
    internal class Horse : Animal
    {
        //public string Name { get; set; };
        //public decimal Weight  { get; set; };
        //public decimal Age { get; set; };

        public string EatsCarrots { get; set; }
        //public static decimal age { get; private set; }
        //public static decimal weight { get; private set; }
        //public static string name { get; private set; }

        public Horse(string name, decimal weight, decimal age, string eatscarrots) : base(name, weight, age)
        {
            this.EatsCarrots = eatscarrots;
        
        }

           public override void DoSound()
        {
            Console.WriteLine("Sound like a horse!");
        }
        public override string Stats()
        {
            return Extensions.makeStringofProperties(this);
        }
    }
}
