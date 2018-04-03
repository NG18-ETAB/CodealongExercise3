using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    class Flamingo : Bird
    {
        public Flamingo(int age, string name, double weight, string plumage, bool isPink) : base(age, name, weight, plumage)
        {
            IsPink = isPink;
        }

        public bool IsPink { get; set; }
    }
}
