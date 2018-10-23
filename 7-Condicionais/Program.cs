using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18) //se idade do joão for maior ou igual 18
            { // executar o seguinte bloco
                Console.WriteLine("Pode entrar, pois tem mais de 18");
            }
            else //senão
            {                                           //executa isso se não for verdadeiro
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos, mas está acompanhado e pode entrar!");
                }
                else
                {
                    Console.WriteLine("Não posssui mais de 18, não pode entrar!");
                }
                
            }
            Console.ReadLine();
        }
    }
}
