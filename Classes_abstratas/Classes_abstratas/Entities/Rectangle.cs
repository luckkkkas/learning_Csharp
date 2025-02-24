using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_abstratas.Entities {
    internal class Rectangle: Shape {
        public double height{ get; set; }
        public double width{ get; set; }

        public Rectangle(string color, double height, double width) : base(color) {
            this.height = height;
            this.width = width;
        }

        public override double area() {
            return (height * width);
        }
    }
}
