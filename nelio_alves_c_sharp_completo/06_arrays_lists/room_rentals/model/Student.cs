namespace Exercise {
    class Student {
        public string Name { get; set; }
        public string Email { get; set; }

        public Student() {
            Name = "";
            Email = "";
        }

        public Student(string name, string email) {
            Name = name;
            Email = email;
        }

        public override string ToString() {
            return $"Name: {Name}, Email: {Email}";
        }
    }
}