using TrabalhandoComClasses.Entities;
using TrabalhandoComClasses.Entities.Enums;

namespace MyApp {
    internal class Program {
        static void Main(string[] args) {
            //    float depInicial = 0;
            //    Console.WriteLine("Entre com número da conta:");
            //    int nConta = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Nome:");
            //    string nome = Console.ReadLine();
            //    Console.WriteLine("Vai haver depósito inicial[s/n]?");
            //    string depInicialSN = Console.ReadLine();

            //    if (depInicialSN.ToLower() == "s") {
            //        Console.WriteLine("Informe o valor inicial");
            //        depInicial = float.Parse(Console.ReadLine());
            //    }
            //    Conta conta1 = new Conta(nConta, nome, depInicial);


            //    Console.WriteLine($"Conta {conta1.Nconta}, titular {conta1.nome}, saldo {conta1.Saldo}");

            //    Console.WriteLine("entre um valor para depósito:");
            //        float dep = float.Parse(Console.ReadLine());
            //    conta1.depositar(dep);
            //    Console.WriteLine($"Conta {conta1.Nconta}, titular {conta1.nome}, saldo {conta1.Saldo}");

            //    Console.WriteLine("entre um valor para sacar:");
            //        float saq = float.Parse(Console.ReadLine());
            //    conta1.sacar(saq);
            //    Console.WriteLine($"Conta {conta1.Nconta}, titular {conta1.nome}, saldo {conta1.Saldo}");

            Order order = new() {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            OrderStatus od = Enum.Parse<OrderStatus>("Delivered"); // atribuindo um valor de um enum a uma variável;
            Console.WriteLine(od);
            Console.WriteLine(order);

        }
    }
}