
namespace Delegate.Entities {
    internal class product {
        public string name { get; set; }
        public double Price { get; set; }

        public product(string name, double price) {
            this.name = name;
            Price = price;
        }

        public override string ToString() {
            return $"{name}-{Price}";
        }
    }
}
