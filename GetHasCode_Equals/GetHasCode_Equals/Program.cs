// See https://aka.ms/new-console-template for more information
using GetHasCode_Equals.Entities;
Product productA = new Product("louça", 1740);
Product productb = new Product("jara", 30);
Product productc = new Product("jara", 30);
Product productd = new Product("jara", 31);


Console.WriteLine(productc.Equals(productA));
Console.WriteLine(productc.Equals(productb));
Console.WriteLine(productc.Equals(productd));
Console.WriteLine(productA.GetHashCode());
Console.WriteLine(productb.GetHashCode());
Console.WriteLine(productc.GetHashCode());
Console.WriteLine(productd.GetHashCode());

HashSet<Product> names = new HashSet<Product> {
    productA,
    productb,
    productc,
    productd,
};

names.Add(productd);
names.Add(new Product("Geladeira", 1440));

Product prod = new("Geladeira", 1440);

Console.WriteLine(names.Contains(prod));