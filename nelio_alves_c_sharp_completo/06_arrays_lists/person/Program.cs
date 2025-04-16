using System;
using System.Globalization;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            Person[] people = new Person[3];

            for(int i = 0; i < people.Length; i++) {
                Console.WriteLine("Enter the person's name: ");
                string name = Console.ReadLine() ?? throw new ArgumentNullException();

                Console.WriteLine("Enter the person's height: ");
                double height = double.Parse(Console.ReadLine() ?? throw new ArgumentNullException(), CultureInfo.InvariantCulture);

                Person person = new Person(name, height);

                people[i] = person;
            }

            double sum_heith = 0.0;

            foreach(Person person in people) {
                sum_heith += person.Height;
            }

            double average_heith = sum_heith / people.Length;

            Console.WriteLine("AVERAGE HEIGHT= " + average_heith.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}