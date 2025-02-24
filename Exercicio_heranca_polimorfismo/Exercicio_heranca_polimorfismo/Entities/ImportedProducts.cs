namespace Exercicio_heranca_polimorfismo.Entities {
    internal class ImportedProducts : Product {
        public double customsFee { get; set; }
        
        public ImportedProducts(string name, double price, double customsFee) : base(name, price) {
            this.customsFee = customsFee;
        }
        public override string PriceTag() {
            return $"{name}, ${price} (customs fee: ${customsFee})";
        }
        public double TotalPrice() {
            return (customsFee + price);
        }
    }
}
