// See https://aka.ms/new-console-template for more information
using Expressoes_lambda.Entities;
using System.Security.Cryptography;

List<Product> list = new List<Product>();

list.Add(new Product("Notebook", 1700));
list.Add(new Product("Panela", 700));
list.Add(new Product("Book", 10));
list.Add(new Product("Tablet", 1100));

//list.Sort(); //só vai funcionar porque foi implementada a classe IComparable******************************

//Expressão Lambda Arrow Function. Opção que não precisa instanciar a classe Producr com IComparable
//Comparison<Product> prod = (p1, p2) => p1.name.ToUpper().CompareTo(p2.name.ToUpper());

//TAMBEM FUNCIONA SÓ PASSANDO A ARROW FUNCTION DIRETO COMO CALLBACK
list.Sort((p1, p2) => p1.name.ToUpper().CompareTo(p2.name.ToUpper()));

foreach(Product p in list) {
    Console.WriteLine(p.ToString());
}