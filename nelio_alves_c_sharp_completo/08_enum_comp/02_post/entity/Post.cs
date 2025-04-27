using System.Text;

namespace Example.Entity {
    class Post {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(DateTime moment, String title, string content, int likes) {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment) {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment) {
            Comments.Remove(comment);
        }

        public override string ToString() {
            StringBuilder output = new StringBuilder();
            output.AppendLine(Title);
            output.Append(Likes);
            output.Append(" Likes - ");
            output.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            output.AppendLine(Content);
            output.AppendLine("Comments:");
            foreach (Comment c in Comments)
            {
                output.AppendLine(c.Text);
            }
            return output.ToString();
        }
    }
}