using ExercicioContratos.Entities;
using System.Diagnostics.Contracts;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace ExercicioContratos.Entities {
    internal class Worker {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double Base_salary { get; set; }
        public Departament Departament { get; set; }
        public List<hourContract> contratos { get; set; } = new List<hourContract>();

        public Worker() { }

        public Worker(string name, WorkerLevel level, double salary_base, Departament Departament) {
            this.Name = name;
            this.Level = level;
            this.Base_salary = salary_base;
            this.contratos = contratos;
        }

        public double Income(int year, int month){
            double result = Base_salary;
            foreach (hourContract contract in contratos) {
                if (contract.Date.Year == year && contract.Date.Month == month) {
                    result += contract.totalValue();
                }
            }
            return result;
        }

        public void AddContract(hourContract contra) {
            contratos.Add(contra);
        }

        public void RemoveContract(hourContract contra) {
            contratos.Remove(contra);
        }

        //public int removeContract(int Contract, int HourContract){

        //}

    }
}
