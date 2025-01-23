using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComClasses {
    internal class Conta {

        public float Saldo { get; private set; }
        public string nome { get; private set; }
        public int Nconta { get; private set; }
        
        public Conta(int nconta, string nome, float depInicial) {
            this.Saldo = depInicial;
            this.nome = nome;
            this.Nconta = nconta;
        }

        public float sacar(float saque) {
            int taxa = 5;
            this.Saldo -= (saque + taxa);
            return this.Saldo;
        }

        public float depositar(float dep) {
            return this.Saldo += dep;
        }
    }
}
