using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Entities {
    internal class CalculationService {
        public static int sum(int a, int b) {
            return a + b;
        }
        public static int square(int a) {
            return a * a;
        }
        public static int max(int a, int b) {
            return (a > b) ? a : b;
        }

        public static void Soma(int a, int b) {
            Console.WriteLine(a + b);
        }
        public static void ExibeMax(int a, int b) {
            Console.WriteLine((a > b) ? a : b);
        }
    }
}
