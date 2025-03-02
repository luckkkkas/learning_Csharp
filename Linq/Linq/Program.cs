using Course.Entities;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
// data source;
//int[] numbers = [1, 9, 0, 8, 7, 6, 5, 4, 3, 2, 11, 23, 45, 67, 89, 09, 87, 65, 443, 21, 2234, 566, 32, 575, 43, 87654, 54, 7654, 8765437, 76543, 87654];

////query expression 
//IEnumerable<int> result = numbers.Where(n => n % 2 == 0).Select(x => x * 10);
//foreach (int n in result) {
//    Console.WriteLine(n);
//}


Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

var r1 = products.Where(p => p.Category.Tier == 1 && p.Price  < 900);

var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);

var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name});

var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);

var r5 = r4.Skip(2).Take(4); // PULA OS 2 PRIMEIROS E PAGA OS PROXIMOS 4

var r6 = products.First();

var r7 = products.Where(p => p.Price > 3000).FirstOrDefault(); //RETORNA O PRIMEIRO, SE NÃOE XISTIR PEIMEIRO RETORNA NULL PARA NÃO DAR ERRO COM .FIRST()

var r8 = products.Where(p => p.Id == 3).SingleOrDefault(); //reorna uma unico elemento exemplo de busca em banco de dados, eleo ou default;

var r9 = products.Max(p => p.Price); // precisa do lambda ou iEnumerable + o capare to

var r10 = products.Min(p => p.Price); // precisa do lambda ou iEnumerable + o capare to

var r11 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);

var r12 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);

var r13 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).DefaultIfEmpty(0.0).Average(); // se form uma lista vazia atribui 0 nos valores para não dar exceção;

var r14 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y); //soma personalizada 0.0 é valor padrão;

var r16 = products.GroupBy(p => p.Category);

foreach (IGrouping<Category, Product> item in r16) {
    Console.WriteLine($"Category: {item.Key.Name}:");
    foreach (Product p in item) {
        Console.WriteLine(p);
    }
    Console.WriteLine();
}

Console.WriteLine(r12);

foreach (var item in r5) {
    Console.WriteLine(item);
}
