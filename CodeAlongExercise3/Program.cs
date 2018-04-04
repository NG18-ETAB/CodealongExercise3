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
            //Console.Read();

            var a = new List<Animal>
            {
                new Horse(12,"horse", 100, 30),
                new Bird(2,"burrd", 1, "a nice plummage")
            };

            foreach (var item in a)
            {
                Console.WriteLine(item.Stats());
            }
        }
    }
}
