using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    public class Dog : Animal
    {
        public Dog(string name, double weight, int age, bool isGoodBoy) : base(name, weight, age)
        {
            IsGoodBoy = isGoodBoy;
        }

        public bool IsGoodBoy { get; set; }

        public override string Stats()
        {
            return base.Stats() + $", is a good: {IsGoodBoy}";
        }
    }
}
