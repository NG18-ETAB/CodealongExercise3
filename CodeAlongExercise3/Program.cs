using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlongExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //PersonHandler ph = new PersonHandler();
            //Person person = ph.CreatePerson(30, "John",
            //    "Hellman", 120, 195);

            //Console.WriteLine(ph.PrintPerson(person));
            //ph.SetWeight(person, 10);
            //ph.SetHeight(person, 2000);
            //ph.SetFName(person, "Billy-Bob");
            //Console.ReadLine();
            //Console.WriteLine(ph.PrintPerson(person));

            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog(2,"Fido",90,false));
            animals.Add(new Flamingo(200, "Youngling", 3000, "Broken", true));
            animals.Add(new Dog(12, "Dido", 9, false));
            animals.Add(new Horse(9, "Blinky", 12, 9001));
            animals.Add(new Dog(5, "Bob", 5, true));

            foreach (Animal a in animals)
            {
                Console.WriteLine(a.Stats());
                //if(a is Dog)
                //{

                //}
                if(a.GetType().Name == "Dog")
                {
                    Console.WriteLine((a as Dog).Speak());
                }
            }
            Console.Read();

        }
    }
}
