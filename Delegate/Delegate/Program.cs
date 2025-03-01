
using Delegate.Entities;
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
    }
}
