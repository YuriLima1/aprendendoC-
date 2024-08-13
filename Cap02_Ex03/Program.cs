using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex03
{
    class Program
    {
        static void Main(string[] args) // Assinatura do método principal de um programa, que atua como o ponto de entrada do aplicativo.
        {
            float HT, VH, PD, SB, TD, SL; // Prepara as variáveis HT, VH, PD, SB, TD e SL para armazenar números decimais em um programa.

            Console.Write("Horas trabalhadas .................: ");
            HT = float.Parse(Console.ReadLine()); // Usuário vai inserir uma linha de texto, vai pressionar o Enter, depois vai converte essa linha de texto em um numero inteiro e por final vai armazenar esse valor na variável 'HT'.
            Console.Write("Valor da hora .....................: ");
            VH = float.Parse(Console.ReadLine()); // Usuário vai inserir uma linha de texto, vai pressionar o Enter, depois vai converte essa linha de texto em um numero inteiro e por final vai armazenar esse valor na variável 'VH'.
            Console.Write("Valor do percentual do desconto .: ");
            PD = float.Parse(Console.ReadLine()); // Usuário vai inserir uma linha de texto, vai pressionar o Enter, depois vai converte essa linha de texto em um numero inteiro e por final vai armazenar esse valor na variável 'PD'.

            SB = HT * VH; // Calcula o salário bruto multiplicando as horas trabalhadas pelo valor por hora.
            TD = (PD / 100) * SB; // Calcula o valor total das deduções aplicando a porcentagem de dedução sobre o salário bruto.
            SL = SB - TD; // Calcula o salário líquido subtraindo o total de deduções do salário bruto.

            Console.WriteLine(); // Pula uma linha.
            Console.Write("Salario liquido ....................: ");
            Console.WriteLine(SL.ToString("##,##0.00")); // Exibe o valor do salário líquido no programa, formatado com separadores de milhar e duas casas decimais.

            Console.WriteLine(); // Pula uma linha.
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine(); // O programa vai esperar o usuário digitar algo e depois pressionar o <Enter>.
        }
    }
}