﻿using System;
using System.Diagnostics;

namespace EDA_ATV_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = new int[1000];/*...........................................................O(1)...........*/
            int[] v2 = new int[5000];/*...........................................................O(1)...........*/
            Stopwatch stopwatch = new Stopwatch();/*..............................................O(1)...........*/
            var watch = System.Diagnostics.Stopwatch.StartNew();/*................................O(1)...........*/

            Bloco bloco = new Bloco();/*..........................................................O(1)...........*/

            stopwatch.Start();/*..................................................................O(1)...........*/

            bloco.PreencherVetor1(v1); //Método 1.................................................O(n-1)+2O(n)...*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de preenchimento do vetor 1: {0}\n", watch.Elapsed);/*.....O(1)...........*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/

            watch.Restart();/*....................................................................O(1)...........*/

            bloco.PreencherVetor2(v2); //Método 2.................................................O(n-1)+2O(n)...*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de preenchimento do vetor 2: {0}\n", watch.Elapsed);/*.....O(1)...........*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/

            watch.Restart();/*....................................................................O(1)...........*/

            bloco.ExibirVetor1(v1); //Método 3....................................................O(n-1)+O(n)....*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de exibição do vetor 1: {0}\n", watch.Elapsed);/*..........O(1)...........*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/

            watch.Restart();/*....................................................................O(1)...........*/

            bloco.ExibirVetor2(v2); //Método 4....................................................O(n-1)+O(n)....*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de exibição do vetor 2: {0}\n", watch.Elapsed);/*..........O(1)...........*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/

            watch.Restart();/*....................................................................O(1)...........*/

            bool encontrado1 = bloco.BuscaSequencialVetor1(v1, 45); //Método 5..................O(n-1)+O(n)+4O(1)*/
            if(!encontrado1) Console.WriteLine("\nValor não encontrado!\n");/*....................O(1)...........*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de busca sequencial do vetor 1: {0}\n", watch.Elapsed);/*..O(1)...........*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/

            watch.Restart();/*....................................................................O(1)...........*/

            bool encontrado2 = bloco.BuscaSequencialVetor2(v2, 200); //Método 6..................O(n-1)+O(n)+4O(1)*/
            if(!encontrado2) Console.WriteLine("\nValor não encontrado!\n");/*....................O(1)...........*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de busca sequencial do vetor 2: {0}\n", watch.Elapsed);/*..O(1)...........*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/
            
            watch.Restart();/*....................................................................O(1)...........*/

            bloco.OrdenacaobubbleSort(v1); //Método 7.............................................O(n²)..........*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de ordenação pelo BubbleSort do vetor 1: {0}\n", watch.Elapsed);/*..O(1)..*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/

            watch.Restart();/*....................................................................O(1)...........*/

            bloco.OrdenacaoquickSort(v2); //Método 8.............................................O(nlogn)........*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de ordenação pelo QuickSort do vetor 2: {0}\n", watch.Elapsed);/*..O(1)..*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/

            watch.Restart();/*....................................................................O(1)...........*/

            bloco.SubstituirValorVetor1(v1, 998, 1); //Método 9...................................4O(1)..........*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de substituição de valor do vetor 1: {0}\n", watch.Elapsed);/*..O(1)......*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/

            watch.Restart();/*....................................................................O(1)...........*/

            bloco.SubstituirValorVetor2(v2, 4000, 999); //Método 10...............................4O(1)..........*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de substituição de valor do vetor 2: {0}\n", watch.Elapsed);/*..O(1)......*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/
            
            watch.Restart();/*....................................................................O(1)...........*/

            bloco.TrocarValoresV1V2(v1,v2);/*..........................................3O(n-1)+3O(n)+2O(1).......*/
            watch.Stop();/*.......................................................................O(1)...........*/
            Console.WriteLine("\nTempo de troca de valores do v1 e v2: {0}\n", watch.Elapsed);/*..O(1)...........*/
            Console.WriteLine("-----------------------------------");/*...........................O(1)...........*/    

            watch.Restart();/*....................................................................O(1)...........*/
            // Fim do código
            //.
            //.
            //.
            //.
            //.
            stopwatch.Stop();/*...................................................................O(1)...........*/
            Console.WriteLine("\n\nO Tempo de execução: {0}\n", stopwatch.Elapsed);/*.............O(1)...........*/



            //EQUAÇÃO ENCONTRADA:.................................O(n²)+9O(n-1)+8O(n)+O(nlogn)+75O(1)
            //TIPO:...............................................QUADRÁTICA
        }
    }
}
