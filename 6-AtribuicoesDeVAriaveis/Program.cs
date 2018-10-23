using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVAriaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

            //quando atribuimos um valor da 1 variavel p 2 variavel
            //a segunda variavel não ficara variando conforme mudar o valor da primeira variavel

            Console.ReadLine();
        }
    }
}
