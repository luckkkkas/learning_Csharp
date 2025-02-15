
namespace Employee.Entities {
    internal class OutsourceEmployee: Employe {
        public double AditionalCharge { get; set; }
        public OutsourceEmployee(string name, int hours, double valuePerHour,double adicionalCharge) : base(name, hours, valuePerHour) {
            AditionalCharge = adicionalCharge;
        }

       public override double Payment() {
            return base.Payment() + (AditionalCharge * 1.1);
       } 
    }
}
