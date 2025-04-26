namespace Course.Entity {
    class Departament {
        public string Name { get; set; }

        public Departament() {
            Name = "";
        }

        public Departament(string name) {
            Name = name;
        }

        public override string ToString() {
            return $"Name = {Name}";
        }
    }
}