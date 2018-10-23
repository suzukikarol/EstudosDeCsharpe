using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            //cabe numeros de ate 16 bits
            //character
            char primeiraLetra = 'a';
            //tem que ser apas simples, pois senão c# entende que é uma string e não um char
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            //converte em char numerico agora
            Console.WriteLine(primeiraLetra);

            //nesse caso está incorreto pelo fato de ser char+char e resultado seria um int,
            primeiraLetra = (char)(primeiraLetra+1); //fazendo um cast da 1 letra com um mais um
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia";
            string cursosProgramacao = 
                @" 
                   - .NET
                   - JAVA 
                   - JavaScript";
            Console.WriteLine(cursosProgramacao);
            Console.WriteLine(titulo);


            Console.ReadLine();
        }
    }
}
