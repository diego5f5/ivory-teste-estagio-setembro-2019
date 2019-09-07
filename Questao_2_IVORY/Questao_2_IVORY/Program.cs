using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Desenvolvido por: Diego Ferreira
//Teste Ivory: Questão 2

namespace Questao_2_IVORY
{
    class Program
    {

        static void Main(string[] args)
        { 
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("\n\n   Digite um nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("\n");

            int linha = 3;
            int coluna = nome.Length + 2;

            if (nome == "") // Evita de que a Matriz seja gerada sem um nome digitado.
            {
                Console.Clear();
                Console.WriteLine("\n Para que a matriz seja gerada é necessário digitar algum nome !");
                Console.ReadKey();
                Main(args);
            }
            else
            {
                string[,] minhaMatriz = (GeraMatriz(nome, linha, coluna)); // Instanciando uma variável do tipo Matriz já recebendo o retorno da função (GeraMatriz).

                MostraMatriz(minhaMatriz, linha, coluna);
                Console.ReadKey();
            }
        }



        // Função para gerar a matriz com os parâmetros desejados e retorná-la ao (Main). 
        static string[,] GeraMatriz(string nome, int linha, int coluna)
        {
            int percorreVetor = 0; 
            int contadorMatriz = 1; 
            char[] vetorNome = nome.ToCharArray(); // Instanciando um vetor de caracteres e atribuindo a string "nome" convertida para char.
            string[,] Matriz = new string[linha, coluna];

            /* Preenchimento interno da Matriz com o nome digitado e o entorno com números inteiros em ordem crescente e em sentido horário:
             * 
             * ( 1 ) - Preenche a parte superior.
             * ( 2 ) - Preenche o meio do canto direito.
             * ( 3 ) - Preenche a parte inferior.
             * ( 4 ) - Preenche o meio do canto esquerdo.
             * ( 5 ) - Preenche internamente com o nome digitado.
             * 
            */

            // ( 1 )
            for (int j = 0; j < coluna; j++) 
            {
                Matriz[0, j] = contadorMatriz.ToString();
                contadorMatriz++;
            }
            // ( 2 )
            Matriz[1, coluna - 1] = contadorMatriz.ToString();
            contadorMatriz++;
            // ( 3 )
            for (int j = coluna - 1; j >= 0; j--)
            {
                Matriz[2, j] = contadorMatriz.ToString();
                contadorMatriz++;
            }
            // ( 4 )
            Matriz[1, 0] = contadorMatriz.ToString();
            // ( 5 )
            for (int j = 1; j < (coluna - 1); j++)
            {
                Matriz[1, j] = vetorNome[percorreVetor].ToString(); // Converte cada caracter do vetorNome para uma string, para que os mesmos possam ser inseridos na matriz.
                percorreVetor++;
            }

            return (Matriz);
        }



        // Função para escrever/mostrar a matriz na tela do console.
        static void MostraMatriz(string[,] Matriz, int linha, int coluna)
        {
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write("   {0}\t", Matriz[i, j]);
                }
                Console.WriteLine("\n");
            }
        }


    }
}