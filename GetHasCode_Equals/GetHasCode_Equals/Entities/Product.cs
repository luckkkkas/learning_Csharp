using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHasCode_Equals.Entities {
    internal class Product {
        public int Price { get; set; }
        public string Name { get; set; }

        public Product(string name, int price) {
            Name = name;
            Price = price;
        }

        public override bool Equals(object? obj) {
            if (!(obj is Product)) {
                return false;
            }
            Product other = obj as Product;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }

        public override int GetHashCode() {
            return Name.GetHashCode() + Price.GetHashCode();
        }
    }
}
