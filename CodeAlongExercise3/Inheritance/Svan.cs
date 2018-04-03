using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    public class Svan : Bird
    {
        public Svan(int age, string name, double weight, string plummage,bool hasMate) : base(age, name, weight, plummage)
        {
            HasMate = hasMate;
        }
        public bool HasMate { get; set; }
    }
}
