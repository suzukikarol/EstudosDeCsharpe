using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //new ContaCorrente();
            //construindo um novo objeto

            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Gabriela";
            conta.agencia = 863;
            conta.numero = 896523;
            conta.saldo = 100.59;

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "JAck Black";
            conta2.agencia = 863;
            conta2.numero = 896523;
            conta2.saldo = 100.59;

            Console.WriteLine("Titular: "+conta.titular);
            Console.WriteLine("Agência: "+conta.agencia);
            Console.WriteLine("Número: " + conta.numero);
            Console.WriteLine("Saldo: " + conta.saldo);
            Console.WriteLine();
            Console.WriteLine("Titular: " + conta2.titular);
            Console.WriteLine("Agência: " + conta2.agencia);
            Console.WriteLine("Número: " + conta2.numero);
            Console.WriteLine("Saldo: " + conta2.saldo);

            Console.ReadLine();
        }
    }
}
