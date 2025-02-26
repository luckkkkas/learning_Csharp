// See https://aka.ms/new-console-template for more information
using Generics.Entities;

Console.WriteLine("Hello, World!");

PrintService<int> printService = new PrintService<int>();

Console.Write("How many values? ");
int value = int.Parse(Console.ReadLine());

for (int i = 0; i < value; i++) {
    int x = int.Parse(Console.ReadLine());
    printService.AddValue(x);
}

printService.Print();
Console.WriteLine($"First Number:jh {printService.First()}");
