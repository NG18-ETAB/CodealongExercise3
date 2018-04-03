using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
   public class Bird : Animal
    {
        public Bird(int age, string name, double weight, string plummage) : base(age, name,weight)
        {
            Plummage = Plummage;
        }
        public string Plummage { get; set; }
    }

}
