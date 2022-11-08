﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercise3
{
    internal class PersonHandler 
    {
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person(age, fname, lname, height, weight);
            return person;
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public void SetFName(Person pers, string fname)
        {
            pers.FName = fname;
        }
        public void SetLName(Person pers, string lname)
        {
            pers.LName = lname;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public string MakeToFullString(Person p)
        {
            return $"Personhandler: Age:{p.Age}, Name:{p.FName}, {p.LName}, Height:{p.Height}, Weight:{p.Weight}";

        }

    }
}
