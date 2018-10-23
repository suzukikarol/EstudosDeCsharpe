using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000.00;

            for(int contadorMes = 1; contadorMes <= 12; contadorMes = contadorMes + 1)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Apos"+contadorMes+" mês, você terá R$"+valorInvestido);
                
            }




            Console.ReadLine();
        }
    }
}
