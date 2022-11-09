using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3._3
{
    internal abstract class Animal
    {
        
       
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public decimal Age { get; set; }
        
        internal Animal(string name, decimal weight, decimal age)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
        }

        public abstract void DoSound();
        public abstract string Stats();
   

           



    }
}
