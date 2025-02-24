
namespace Exercicio_heranca_polimorfismo.Entities {
    internal class UsedProducts: Product {
        public DateTime ManufactureDate { get; set; }

        public UsedProducts(string name, double price, DateTime ManufactureDate) : base(name, price) {

        }

        public override string PriceTag() {
            return $"{name} (used), ${price} (Manufacture date){ManufactureDate}";
        }
    }
}
