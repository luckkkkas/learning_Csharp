
using System.Numerics;

namespace ExercicioContratos.Entities {
    internal class hourContract {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public double totalValue() {
            return this.Hours * this.ValuePerHour;
        }

        public hourContract(DateTime date, double value, int hours) {
            this.Date = date;
            this.ValuePerHour = value;
            this.Hours = hours;
        }

        public hourContract() {
        }
    }
}
