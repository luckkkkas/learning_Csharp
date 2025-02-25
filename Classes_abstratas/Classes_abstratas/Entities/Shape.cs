
namespace Classes_abstratas.Entities {
    internal abstract class Shape {
        public string color { get; set; }

        protected Shape(string color) {
            this.color = color;
        }

        public abstract Double area();
    }
}
