﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3.Inheritence
{
   public class Animal
    {
        public Animal(int age,string name,double weight)
        {
            Age=age;
            Name = name;
            Weight = weight;

        }
        public int Age { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
    }
}
