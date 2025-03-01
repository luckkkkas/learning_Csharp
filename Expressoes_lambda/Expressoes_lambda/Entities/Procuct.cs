
namespace Expressoes_lambda.Entities {
    class Product{//: IComparable<Product> {

        public string name{ get; set; }
        public int price{ get; set; }

        public Product(string name, int price) {
            this.name = name;
            this.price = price;
        }

        public override string ToString() {
            return $"{name}-{price}";
        }

        //public int CompareTo(Product other) {
        //    return  name.ToUpper().CompareTo(other.name.ToUpper());
        //}
    }
}
