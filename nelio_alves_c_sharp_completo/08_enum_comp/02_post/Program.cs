using System.Globalization;
using Example.Entity;

namespace Example {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Moment (dd/MM/yyyy HH:mm:ss): ");
            string dateTime = Console.ReadLine() ?? throw new ArgumentException();

            DateTime moment = DateTime.ParseExact(
                dateTime,
                "dd/MM/yyyy HH:mm:ss",
                CultureInfo.InvariantCulture
            );

            Console.WriteLine("Title: ");
            string title = Console.ReadLine() ?? throw new ArgumentException();
            
            Console.WriteLine("Content: ");
            string content = Console.ReadLine() ?? throw new ArgumentException();

            Console.WriteLine("Likes: ");
            int likes = int.Parse(Console.ReadLine() ?? throw new ArgumentException());

            Post post = new Post(moment, title, content, likes);

            Console.WriteLine("");
            Console.WriteLine("Number of comments: ");
            int n = int.Parse(Console.ReadLine() ?? throw new ArgumentNullException());
            Console.WriteLine("");

            for(int i = 0; i < n; i++) {
                Console.WriteLine($"#{i+1} comment: ");
                Console.WriteLine("Content: ");
                content = Console.ReadLine() ?? throw new ArgumentException();

                Comment comment = new Comment(content);

                post.AddComment(comment);
            }

            Console.WriteLine("");
            Console.WriteLine(post);
        }
    }
}