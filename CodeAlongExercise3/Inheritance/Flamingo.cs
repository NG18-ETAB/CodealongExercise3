using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    public class Flamingo : Bird
    {
        public Flamingo(string name, double weight, int age, string plummage, bool isPink) : base(name, weight, age, plummage)
        {
            IsPink = isPink;
        }

        public bool IsPink { get; set; }
    }
}
