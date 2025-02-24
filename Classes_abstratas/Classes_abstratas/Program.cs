using Classes_abstratas.Entities;

Console.Write("Entre com a quantidade de objetos: ");
int qntObjetos = int.Parse(Console.ReadLine());

List<Shape> list = new List<Shape>();

for (int i = 0; i < qntObjetos; i++) {
    Console.Write($"############## {i + 1} Dados #########");
    Console.Write("Retangulo ou círculo: (R/C)");
    string form = Console.ReadLine();

    if (form.ToLower() == "r") {
        Console.WriteLine("Color (Red/Blue/Black): ");
        string color = Console.ReadLine();
        Console.WriteLine("altura: ");
        double altura = double.Parse(Console.ReadLine());
        Console.WriteLine("Largura: ");
        double Largura = double.Parse(Console.ReadLine());

        Rectangle rectangle= new(color, altura, Largura);
        list.Add(rectangle);
    }

    if (form.ToLower() == "c") {
        Console.WriteLine("Color (Red/Blue/Black): ");
        string color = Console.ReadLine();
        Console.WriteLine("Raio: ");
        double radius = double.Parse(Console.ReadLine());

        Circle circle = new(color, radius);
        list.Add(circle);
    }
}

foreach (Shape element in list) {
    Console.WriteLine(element.area().ToString("F2"));
}