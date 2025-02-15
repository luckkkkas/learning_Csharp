// See https://aka.ms/new-console-template for more information
using Employee.Entities;
using System.Globalization;

Console.WriteLine("Hello, World!");

Console.WriteLine("Numero de trabalhadores:");
int employees = int.Parse(Console.ReadLine());
List<Employe> todos = new List<Employe>();

for (int i = 0; i < employees; i++) {
    Console.WriteLine($"***************Dados do trabalhador {i}************************");
    Console.Write("Terceirizado?");
    char outsource = char.Parse(Console.ReadLine());

    Console.Write("Nome:");
    string name = Console.ReadLine();

    Console.Write("Hours:");
    int Hours = int.Parse(Console.ReadLine());

    Console.Write("value per hour:");
    double valuephour = int.Parse(Console.ReadLine());

    if(outsource == 's') {
        Console.Write("Despesas Adicionais");
        double adicionalCharge = double.Parse(Console.ReadLine());
        OutsourceEmployee outEmployee = new OutsourceEmployee(name, Hours, valuephour, adicionalCharge);
        todos.Add(outEmployee);
    } else {
        Employe employee = new(name, Hours, valuephour);
        todos.Add(employee);
    }
}

for (int i = 0; i < todos.Count; i++) {
    Console.WriteLine($"{todos[i].Name} - {todos[i].Payment()}");
}