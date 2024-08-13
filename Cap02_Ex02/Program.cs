using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex02
{
    internal class Program
    {
        static void Main(string[] args) // Assinatura do método principal de um programa, que atua como o ponto de entrada do aplicativo.
        {
            int A, B, R; // Define três variáveis ​​inteiras em uma única linha.

            Console.Write("Entre o 1O. valor: ");
            A = int.Parse(Console.ReadLine()); // Usuário vai inserir uma linha de texto, vai pressionar o Enter, depois vai converte essa linha de texto em um numero inteiro e por final vai armazenar esse valor na variável 'A'.

            Console.Write("Entre o 2O. valor: ");
            B = int.Parse(Console.ReadLine()); // Usuário vai inserir uma linha de texto, vai pressionar o Enter, depois vai converte essa linha de texto em um numero inteiro e por final vai armazenar esse valor na variável 'B'.

            R = A + B; // Irá fazer uma conta de mais.

            Console.WriteLine(); // Pula uma linha.
            Console.WriteLine("Resultado = " + R);

            Console.WriteLine(); // Pula uma linha.
            Console.Write("Tecla <Enter> para continuar...");
            Console.ReadLine(); // O programa vai esperar o usuário digitar algo e depois pressionar o <Enter>.
        }
    }
}