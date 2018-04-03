using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    public class Swan:Bird
    {
        public Swan(int age, string name, double weight,bool hasMate) :base(age, name, weight)
        {
            HasMate = hasMate;
        }

        public bool HasMate { get; set; }

    }


}
