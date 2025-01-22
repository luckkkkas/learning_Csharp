using System;
using System.Runtime.InteropServices;
using helloWorld;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string frase = Console.ReadLine();

            // string[] fruta = frase.Split(',');
            // for (int i = 0; i < fruta.Length; i++) {
            ///   Console.WriteLine(fruta[i]); 

            // }

            //Console.WriteLine("entre com seu nome completo:");
            //string nome = Console.ReadLine();
            //Console.WriteLine("quantos quartos tem a sua casa?");
            //int quartos = int.Parse(Console.ReadLine());
            //Console.WriteLine("preço de um produto?");
            //int preco = int.Parse(Console.ReadLine());

            //Console.WriteLine("nome, idade, altura? (mesma linha)");
            //string nomes = Console.ReadLine();


            //string[] numbre = nomes.Split(' ');

            //Console.WriteLine(nomes);
            //Console.WriteLine(quartos);
            //Console.WriteLine(preco);

            //for (int i = 0; i < nomes.Length; i++) {
            //    Console.WriteLine(numbre[i]);
            //}

            Retangulo retangulo = new Retangulo();
            Console.WriteLine("entre a largura e altura do triangulo:");
            string dadosRecebidos = Console.ReadLine();
            retangulo.Altura = float.Parse(dadosRecebidos.Split(' ')[0]);
            retangulo.Largura = float.Parse(dadosRecebidos.Split(' ')[1]);

            Console.WriteLine($"Area {retangulo.Area()}");
            Console.WriteLine($"Perímetro {retangulo.Perimetro()}");
            Console.WriteLine($"Hipotenusa {retangulo.Hipotenusa()}");
        }
         
    }
}