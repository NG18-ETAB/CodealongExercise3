using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    class Swan : Bird
    {
        public Swan(int age, string name, double weight, string plumage, bool hasMate) : base(age, name, weight, plumage)
        {
            HasMate = hasMate;
        }
        public bool HasMate { get; set; }
    }
}
