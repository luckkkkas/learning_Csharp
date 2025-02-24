
namespace Classes_abstratas.Entities {
    internal class Circle: Shape {
        public double radius { get; set; }
        public Circle(string color, double radius) : base(color) {
            this.radius = radius;
        }

        public override double area() {
            return (3.14 * Math.Pow(radius, 2));
        }
    }
}
