using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    public class Dog : Animal
    {
        public Dog(int age, string name, double weight, bool isGoodBoy) : base(age,name,weight)
        {
            IsGoodBoy = isGoodBoy;
        }

        public bool IsGoodBoy { get; set; }
    }
}
