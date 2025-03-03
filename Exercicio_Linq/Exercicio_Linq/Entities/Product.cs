
namespace Exercicio_Linq.Entities {
    internal class Product: IComparable<Product> {
        public string name {  get; set; }
        public double price { get; set; }

        public Product(string name, double price) {
            this.name = name;
            this.price = price;
        }

        public override string ToString() {
            return name;
        }

        public int CompareTo(Product Other) {
            return name.ToUpper().CompareTo(Other.name.ToUpper());
        }
    }
}
