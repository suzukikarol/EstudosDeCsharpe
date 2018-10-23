using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 13 - For Encadeado");
            //*
            //**
            //***
            //****

            //*****

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;   //vai parar de executar o laço de repetição,
                                //somente com o for de coluna
                    
                }
                Console.WriteLine();//pula uma linha

            }

            //uma forma diferente de desenhar com asteristicos
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha ; contadorColuna++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();//pula uma linha

            }
            Console.ReadLine();
        }
    }
}
