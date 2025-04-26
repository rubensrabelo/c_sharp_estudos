using System.Diagnostics.Contracts;
using Course.Entity.enums;

namespace Course.Entity {
    class Worker {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Departament Departament{ get; set; }

        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

        public Worker() {} 

        public Worker(String name, WorkerLevel level, double baseSalary, Departament departament) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract) {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract) {
            Contracts.Remove(contract);
        }

        public double Income(int month, int year) {
            double valueTotal = BaseSalary;

            foreach(HourContract contract in Contracts) {
                if(contract.Date.Year == year && contract.Date.Month == month) 
                    valueTotal += contract.TotalValue();
            }
            
            return valueTotal;
        }
    }
}