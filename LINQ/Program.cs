using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = LoadPersonList();
            // 1 - People with more than two brothers
            var peopleMoreThenTwoBrothers = from person in people
                                            where person.NumberOfBrothers > 2
                                            select person;

            foreach (Person p in peopleMoreThenTwoBrothers)
            {
                Console.WriteLine("{0}, {1}, {2} ", p.Name, p.Age, p.NumberOfBrothers);
            }
            Console.WriteLine("########################################################");
            // 2 -  Name and Age of all persons of legal age
            var peopleLegalAge = from person in people
                                 where person.Age > 18
                                 orderby person.Age
                                 select new { person.Name, person.Age };
            foreach (var person in peopleLegalAge)
            {
                Console.WriteLine("{0}, {1} ", person.Name, person.Age);
            }
            Console.ReadKey();
        }

        static List<Person> LoadPersonList()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person
            { 
                Name = "João",
                Age = 18,
                NumberOfBrothers = 2
            });
            people.Add(new Person
            {
                Name = "Maria",
                Age = 30,
                NumberOfBrothers = 0
            });
            people.Add(new Person
            {
                Name = "José",
                Age = 50,
                NumberOfBrothers = 6
            });
            return people;
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfBrothers { get; set; }
    }
}
