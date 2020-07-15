using System;

namespace POO1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria(200);


            contaBancaria.Agencia = "34518-3";
            contaBancaria.Conta = "3030";
            contaBancaria.Nome = "DIEGO LUNARDELLI BOSCHETTI";
            contaBancaria.Senha = "senha123";

            contaBancaria.ImprimirSaldos();

            

        }
    }
}
