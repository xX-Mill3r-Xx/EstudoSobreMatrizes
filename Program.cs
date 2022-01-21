using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoSobreMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /* Em Programação, "Matriz" é o nome dado a arranjos bidimensionais;*/
            /* Arranjo é uma estrutura de dados:
             #1 - Homogenea (dados sempre do mesmo tipo);
             #2 - Ordenada (Elementos acessados por meio de posições);
             #3 - Alocada de uma só vez, em um bloco contiguo de memoria;
            
             Vantagens: 
             - Acesso imediato aos elementos pela sua posição;
            
             Desvantagens:
             - Tamanho Fixo;
             - Dificuldade para se realizar inserções e deleções;*/
            #endregion

            #region Exemplos
            //Maneira para declarar uma Matriz;
            //double[,] matriz = new double[3, 3];
            /*O comando acima, instancia uma matriz do tipo double com 3 linha e 3 colunas*/

            //Para imprimir o tamanho de uma matriz;
            //Console.WriteLine(matriz.Length);

            //Imprimir a quantidade de linhas;
            //Console.WriteLine(matriz.Rank);
            #endregion

            #region Exercicio 1
            //Console.Write("Entre com o valor do numero N: ");
            //int n = int.Parse(Console.ReadLine());

            //int[,] mat = new int[n, n];

            //for(int i = 0; i < n; i++)
            //{
            //    string[] vet = Console.ReadLine().Split(' ');
            //    for (int j = 0; j < n; j++)
            //    {
            //        mat[i, j] = int.Parse(vet[j]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Main Diagonal:");

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"{mat[i,i]} ");
            //}
            //Console.WriteLine();

            //int count = 0;
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < n; j++)
            //    {
            //        if(mat[i,j] < 0)
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Negative Numbers: {count}");
            #endregion

            #region Exercicio 2
            Console.Write("Entre com o numero de linhas e o numero de colunas: ");
            string[] Linha = Console.ReadLine().Split(' ');
            int M = int.Parse(Linha[0]);
            int N = int.Parse(Linha[1]);

            int[,] matriz = new int[M, N];
            Console.WriteLine();
            Console.WriteLine($"Digite os numeros da matriz de {M} Linhas x {N} Colunas:");
            for(int i = 0; i< M; i++)
            {
                string[] valor = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(valor[j]);
                }
            }
            Console.WriteLine();
            Console.Write("Entre com o valor de X: ");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for(int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if(matriz[i,j] == X)
                    {
                        Console.WriteLine($"Posição: {i}, {j}:");
                        if (j > 0)
                        {
                            Console.WriteLine($"Esquerda {matriz[i,j-1]}:");
                        }
                        if(i > 0)
                        {
                            Console.WriteLine($"Acima {matriz[i - 1, j]}");
                        }
                        if(j < N - 1)
                        {
                            Console.WriteLine($"Direita {matriz[i, j + 1]}");
                        }
                        if(i < M - 1)
                        {
                            Console.WriteLine($"Abaixo {matriz[i + 1, j]}");
                        }
                    }
                    

                }
            }

            #endregion

            Console.ReadKey();
            
        }
    }
}
