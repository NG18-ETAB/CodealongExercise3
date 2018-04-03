using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    public  class Flamingo:Bird
    {
        public Flamingo(int age, string name, double weight,string plummage,bool isPink) : base(age, name, weight,plummage)
        {
            IsPink = isPink;
         
        }

        public bool IsPink { get; set; }
    }
}
