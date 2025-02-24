using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_heranca_polimorfismo.Entities {
    public class Product {
        public string name { get; set; }
        public double price { get; set; }

        public Product(string name, double price) {
            this.name = name;
            this.price = price;
        }

        public virtual string PriceTag() {
            return $"{name}, ${price}";
        }
    }
}
