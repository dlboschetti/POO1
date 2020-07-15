using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace POO1
{
    class ContaBancaria

    {
        private string Conta = "456321-4";
        private string Agencia = "3030";
        private string Nome = "DIEGO LUNARDELLI BOSCHETTI";
        private string Senha = "123456";
        private int Saldo;

        // Método construtor
        public ContaBancaria(int saldo)
        {
            Saldo = saldo;
        }

        public void Depositar (int valor)
        {
            Saldo = Saldo + valor;
        }

        public void Sacar(int valor)
        {
            Saldo = Saldo - valor;
        }

        public int ConsultarSaldo()
        {
            int taxa = 10;
            int valorTaxa = (Saldo * taxa) / 100;
            return Saldo - valorTaxa;
        }

        public void ImprimirSaldos()
        {
            Console.WriteLine($"Seu saldo é: {ConsultarSaldo()}");
        }
    }
}
