using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - calcula poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            //while parece com if, porem ele executa como loop enqnt a condição for satisfeita.
            while (contadorMes <= 12){
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após "+contadorMes+" mês você terá R$ " + valorInvestido);

                // contadorMes = contadorMes + 1;//soma de um em um
                // contadorMes += 1; //pega a varialvel da esq e conta mais um
                contadorMes++;
            }


            

            Console.ReadLine();
        }
    }
}
