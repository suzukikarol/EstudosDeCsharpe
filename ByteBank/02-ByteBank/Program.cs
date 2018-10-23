using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaKA = new ContaCorrente();
            contaKA.titular = "KArol";
            contaKA.agencia = 7896;
            contaKA.saldo = 1500.52;
            contaKA.Sacar(100);

            Console.WriteLine(contaKA.saldo);

            contaKA.Depositar(500);

            Console.WriteLine(contaKA.saldo);

            //if (contaKA.saldo >=100)//vendo se tem saldo para saque
            //{
            // contaKA.saldo -= 100; //supor que a pessoa vá sacar 
            //          }
            Console.ReadLine();
        }      
    }
}
