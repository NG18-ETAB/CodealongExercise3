using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    class Horse : Animal
    {
        public Horse(int age, string name, double weitght, double speed):
            base(age , name , weitght)
        {
           Speed = speed;
        }

        public double Speed { get; set; }
    }
}
