using Exercicio_heranca_polimorfismo.Entities;

Console.Write("numero de produtos: ");
int nProdutps = int.Parse(Console.ReadLine());

List<Product> products = new List<Product>();

for (int i = 0; i < nProdutps; i++) {
    Console.WriteLine($"######{i+1} product ###########");
    Console.Write("usado comum ou importado? (U/I/C)");
    string type = Console.ReadLine();
    Console.Write("name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());
    if (type.ToLower() == "i") {
        Console.Write("importação: ");
        double customs = double.Parse(Console.ReadLine());
        ImportedProducts imported = new(name, price, customs);
       products.Add(imported);
    }
    if (type.ToLower() == "u") {
        DateTime manufacture = new DateTime(14/07/2001);
        UsedProducts Usadao = new(name, price, manufacture);
        products.Add(Usadao);
    } else if(type.ToLower() == "c"){
        Product product = new(name, price);
        products.Add(product);
    }

    foreach (Product product in products) {
        Console.WriteLine(product.PriceTag());
    }
}
