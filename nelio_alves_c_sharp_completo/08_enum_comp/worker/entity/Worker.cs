using Course.Entity.enums;

namespace Course.Entity {
    class Worker {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Departament Departament{ get; set; }

        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

        public Worker() {
        } 

        public Worker(String name, WorkerLevel level, double baseSalary, Departament departament) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }
    }
}