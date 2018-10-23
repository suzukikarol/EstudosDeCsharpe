using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3, criando variáveis ponto flutuantes");

            //declarando variável double que pode receber valores quebrados
            double salario;
            salario = 1200.70;
            //concatenação para exibir resultado mais claro
            Console.WriteLine("O salário é de : " + salario);

            double idade;
            idade = 15.0 / 2;
            Console.WriteLine(idade);

            //5 inteiro por 3 inteiro
            idade = 5 / 3;
            Console.WriteLine(idade);

            //5 com dizima dividido por 3 dará outro resultado
            idade = 5.0 / 3;
            Console.WriteLine(idade);
            Console.WriteLine("A execução acabou, tecle enter para finalizar!");
            Console.ReadLine();
        }
    }
}
