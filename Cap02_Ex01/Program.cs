using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex01
{
    internal class Program
    {
        static void Main(string[] args) // Assinatura do método principal de um programa, que atua como o ponto de entrada do aplicativo.
        {
            string NOME; // Variável chamada 'NOME', que pode armazenar textos.

            Console.Write("Entre seu nome:");
            NOME = Console.ReadLine(); // O usuário irá digitar algum 'NOME'.
            Console.WriteLine("Ola, " + NOME); // Quando ele digitar algum nome vai exibir "Ola, NOME".

            Console.WriteLine(); // Pula uma linha.
            Console.Write("Tecle <Enter> para encerrar... ");
            Console.ReadLine(); // O programa vai esperar o usuário digitar algo e depois pressionar o <Enter>.
        }
    }
}