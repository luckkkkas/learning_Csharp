// See https://aka.ms/new-console-template for more information
using ExercicioContratos.Entities;
using System.Linq.Expressions;
using System.Collections.Generic;
using System;


Console.WriteLine("Digite o Departamento: ");
string departament = Console.ReadLine();
Departament departamento = new(departament);

Console.WriteLine("Worker date:");
string date = Console.ReadLine();

Console.WriteLine("Name:");
string name = Console.ReadLine();

Console.WriteLine("Level");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

Console.WriteLine("base salary");
double salary = double.Parse(Console.ReadLine());

Worker worker = new(name, level, salary, departamento);

Console.WriteLine("quantos contratos possuis?");
int ncontracts = int.Parse(Console.ReadLine());

for (int i = 0; i < ncontracts; i++) {

    Console.WriteLine($"data do {i + 1} contrato(DD/MM/YYY)/;");
    DateTime datee = DateTime.Parse(Console.ReadLine());

    Console.WriteLine($"Valor Hora");
    double vhour = double.Parse(Console.ReadLine());

    Console.WriteLine($"Horas");
    int hours = int.Parse(Console.ReadLine());

    hourContract hourContract = new hourContract(datee, vhour, hours);
    worker.AddContract(hourContract);
}

Console.WriteLine("entre o mês e ano que deseja verificar;(MM/YYYY)");
string month = Console.ReadLine();

string[] monthYear = month.Split("/");

Console.WriteLine(worker.Income(int.Parse(monthYear[1]), int.Parse(monthYear[0])));