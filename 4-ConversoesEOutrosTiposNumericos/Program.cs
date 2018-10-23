using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4!");

            double salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            ///pode deixar assim pois assim ele entende que esta correto.
            //é preciso deixar isso pra manter conssistencia do código
            //gracas a rigidez que temos

            Console.WriteLine(salarioEmInteiro);
            //aqui ele vai acabar com valores double pois esta definido como int
            //32 bits

            long idadeDaTerra; // suporta numeros de tamanhos grandes , 64 bits
            idadeDaTerra = 1300000000;
            Console.WriteLine("a idade da terra é de :" + idadeDaTerra);

            short quantidadeProdutos; //somente valores menores de até 1600 16 bits
            quantidadeProdutos = 15;
            Console.WriteLine("Quantidade de produtos: " + quantidadeProdutos);

            //float em numero decimal nao tem suporte
            float altura = 1.80f;
            Console.WriteLine("Altura é de : " + altura);
            //coloca o f pra falar que n é erro de digitação, usando float com menor precisão.
            //pode declarar a variável assim tbm       



            Console.ReadLine();
        }
    }
}
