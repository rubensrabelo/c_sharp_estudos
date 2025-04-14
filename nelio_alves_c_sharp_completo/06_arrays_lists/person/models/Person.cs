namespace Exercise {
    class Person {
        public string Name { get; set; }
        public double Height { get; set; }

        public Person(string name, string height) {
            Name = name;
            Height = height;
        }

        public override string ToString() {
            return $"Person(Name= {Name}, Height={Height})";
        }
    }
}