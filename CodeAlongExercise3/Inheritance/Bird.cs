using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    class Bird : Animal
{

    public string Plumage { get; set; }

    public Bird(int age, string name, double weight, string plumage) : base(age, name, weight)
    {
        Plumage = plumage;
    }
}
}

