using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    public class Swan : Bird
    {
        public Swan(string name, double weight, int age, string plummage, bool hasMate) : base(name, weight, age, plummage)
        {
            HasMate = hasMate;
        }

        public bool HasMate { get; set; }
    }
}
