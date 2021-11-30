using System;

namespace AppMultiplicaValoresMatriz
{
    /// <summary>
    /// Exercicio - Matriz
    /// Neste exemplo, usamos os recursos de preencher e multiplicar valores em uma matriz.
    /// </summary>
    class Program
    {
        public static int[,] multiplicaMatriz (int[,] matriz, int x,int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = matriz[i, j] * x;
                }
            }
            return matriz;
        }       

        public static int[,] preencherMatriz(int n,int m) 
        {
            int[,] matriz = new int[n, m];

            //Percorrer as colunas
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                
                //Percorrer as linhas
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }
            return matriz;
        }

        public static void imprimirMatriz(int[,] matriz, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Por favor, entre com os valores N e M da matriz, utilize espaço entre os valores: ");
            string[] line = Console.ReadLine().Split(" ");

            int n = int.Parse(line[0]);
            int m = int.Parse(line[1]);
            Console.WriteLine();

            Console.WriteLine("Por favor, preencha sua matriz utilizando espaço entre os valores: ");
            var mat = preencherMatriz(n, m);
            Console.WriteLine();

            Console.Write("Qual o valor que gostaria de multiplicar os elementos da sua matriz? ");
            int x = int.Parse(Console.ReadLine());

            multiplicaMatriz(mat, x, n, m);

            Console.WriteLine();
            Console.WriteLine("Os valores mutiplicados por {0} são:",x);
            imprimirMatriz(mat, n, m);

            Console.ReadLine();
        }
    }
}
