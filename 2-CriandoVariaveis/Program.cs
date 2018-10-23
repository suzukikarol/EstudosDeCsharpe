using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando variáveis!");

            int idade;
            idade = 32;

            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            //soma simples de dois numeros inteiros
            idade = 10 + 5;
            Console.WriteLine(idade);

            //a equação seguirá a sequência de operações conforme conhecemos (*/+-)
            idade = 10 + 5 * 2;
            Console.WriteLine(idade);
            
            //neste caso a operação inicial será a que se encontra dentro dos ()  antes da *
            idade = (10 + 5) * 2;

            int divisao = 5 / 2;
            Console.WriteLine(divisao);
            //neste caso o resultado esperado é 2, pois foi declarado var int, então ele ignora todos os valores após a vírgula
            
            //importante frizar que quando fizemos divisão ñ exata, mas usamos 2 nos inteiros ,o c# ñ truncará o resultado.
            //se ao invés disso, só colocasse como var double, o resultado seria o mesmo
            //para mudar o resultado disso é preciso colocar o seguinte, declarar como double e colocar o no desta forma
            // 5.0/2 , ai o resultado seria 2.5

            //concatenação de string de saída com a variável utiliada no programa "idade"
            Console.WriteLine("Sua idade é : "+ idade+ " anos!!!");

            Console.WriteLine("Execução finalizada,tecle enter para finalizar!!!");
            Console.ReadLine();
        }
    }
}