using Exercicio_Linq.Entities;
using System.IO;
using System.Linq;

Console.Write("Path of archive: ");
string path = Console.ReadLine();

List<Product> list = new List<Product>();

try {
    using (StreamReader sr = File.OpenText(path)) {
        while (!sr.EndOfStream) {
            string line = sr.ReadLine();
            string[] separator = line.Split(',');
            list.Add(new Product(separator[0], double.Parse(separator[1])));
        }
    }
} catch (IOException error) {
    Console.WriteLine(error.Message);
}

//Average
double average = list.Average(p => p.price);
Console.WriteLine("Average Price:" + average.ToString("F2"));

list.Sort();
//OU
list.Sort((p1, p2) => p1.name.ToUpper().CompareTo(p2.name.ToUpper()));

list.Reverse();
foreach (var item in list) {
    if(item.price < average) Console.WriteLine(item);
}


//apresentar a lista em ordem alfabética de forma decrescente