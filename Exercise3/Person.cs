using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise3
{ 
    internal class Person
    {
    private int age;
    private string fName;
    private string lName;
    private double height;
    private double weight;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
               else throw new ArgumentException("Age must be over 0");
            }
        }
        public string FName
        {
            get { return fName; }
            set
            {
                if(value.Length >=2 && value.Length <= 10)
                { fName = value; }
                else throw new ArgumentException("FName too short or too long");
            }
        }
        public string LName 
        {
            get { return lName; }
            set {
                if (value.Length >= 3 && value.Length <= 15)
                 { lName = value;
                 }
                else throw new ArgumentException("LName too short or too long");
            } }
        public double Height { get { return height; } set { height = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
        public Person(int age, string fName, string lName, double height, double weight)
        {
            this.age = age;
            this.fName = fName;
            this.lName = lName;
            this.height = height;
            this.weight = weight;

        }
       

        public override string ToString()
        {
            return $"{Age}, {FName}, {LName}, {Height}, {Weight}";
        }

    }
}
