
using Delegate.Entities;
using System.Linq;
class Program {
    // delegate int BinaryOptions(int n1, int n2);
    delegate void BinaryOptions(int n1, int n2);
    static void Main() {
        int a = 1;
        int b = 3;

        //BinaryOptions op = CalculationService.sum; //precisa colocar o STATIC na função para funcionar//////////
        //int result = op.Invoke(a, b);
        //Console.WriteLine(result);

        BinaryOptions op = CalculationService.ExibeMax;
        op += CalculationService.Soma;

        op.Invoke(a, b);
        //ou 
        op(a, b);


       List<product> list = new List<product>();

        list.Add(new product("Notebook", 1600));
        list.Add(new product("Note", 1500));
        list.Add(new product("Book", 400));
        list.Add(new product("avião", 10600));

        list.RemoveAll(p => p.Price <= 1500); // remoção com função lambda
        
        list.RemoveAll(productTest); //FUNCIONA DA MESMA FORMA QUE A EXPRESSÃO ACIMA precisa de um retorno booleeano

        foreach (product p in list) {
            Console.WriteLine(p.name);
        }
        Console.WriteLine("--------------------------------------------------------");

        // Action<product> act = Aumentar10;
        // Action<product> act = ((p) => { p.Price += p.Price * 0.10; });
        // list.ForEach(act);

        list.ForEach((p) => { p.Price += p.Price * 0.10; });
        foreach (var item in list) {
            Console.WriteLine(item);
        }

        List<string> result = list.Select(p => p.name.ToUpper()).ToList();

        foreach (string name in result) {
            Console.WriteLine(name);
        }
    }

    public static bool productTest(product p) {
        return p.Price <= 1500;
    }

    //public static void Aumentar10(product p) {
    //    p.Price += p.Price * 0.1;
    // }

    static string nameUpper(product p) {
        return p.name.ToUpper();
    }
}
