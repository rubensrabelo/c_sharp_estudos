namespace Exercise {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine("How many rooms will be rented?");
            int n = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

            Student[] rooms = new Student[10];

            for(int i = 0; i < n; i++) {
                Console.WriteLine($"Rent {i+1}");

                Console.WriteLine("Name: ");
                string name = Console.ReadLine() ?? throw new ArgumentNullException();

                Console.WriteLine("Email: ");
                string email = Console.ReadLine() ?? throw new ArgumentNullException();

                Console.WriteLine("Room: ");
                int index = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());

                Student student = new Student(name, email);

                if(rooms[index] == null) rooms[index] = student;
            }

            for(int i = 0; i < rooms.Length; i++) {
                if(rooms[i] != null) {
                    Console.WriteLine($"{i}: {rooms[i]}");
                }
            }
        }
    }
}