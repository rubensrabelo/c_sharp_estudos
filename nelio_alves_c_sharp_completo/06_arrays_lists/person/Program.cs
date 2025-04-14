using System;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            Person[] people = new Person[5];

            for(int i = 0; i < 5; i++) {
                Console.WriteLine("Enter the person's name: ");
                string name = Console.ReadLine() ?? throw new ArgumentNullException();

                Console.WriteLine("Enter the person's height: ");
                double height = Console.ReadLine() ?? throw new ArgumentNullException();

                Person person = new Person(name, height);

                people[i] = person;
            }
        }
    }
}