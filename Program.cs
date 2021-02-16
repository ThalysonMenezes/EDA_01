using System;
using System.Diagnostics;

namespace EDA_ATV_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = new int[1000];
            int[] v2 = new int[5000];

            Stopwatch stopwatch = new Stopwatch();
            var watch = System.Diagnostics.Stopwatch.StartNew();

            Bloco bloco = new Bloco();

            stopwatch.Start();

            bloco.PreencherVetor1(v1); //Método 1
            watch.Stop();
            Console.WriteLine("\nTempo de preenchimento do vetor 1: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");

            watch.Restart();

            bloco.PreencherVetor2(v2); //Método 2
            watch.Stop();
            Console.WriteLine("\nTempo de preenchimento do vetor 2: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");

            watch.Restart();

            bloco.ExibirVetor1(v1); //Método 3
            watch.Stop();
            Console.WriteLine("\nTempo de exibição do vetor 1: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");

            watch.Restart();

            bloco.ExibirVetor2(v2); //Método 4
            watch.Stop();
            Console.WriteLine("\nTempo de exibição do vetor 2: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");

            watch.Restart();

            bool encontrado1 = bloco.BuscaSequencialVetor1(v1, 45); //Método 5
            if(!encontrado1) Console.WriteLine("\nValor não encontrado!\n");
            watch.Stop();
            Console.WriteLine("\nTempo de busca sequencial do vetor 1: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");

            watch.Restart();

            bool encontrado2 = bloco.BuscaSequencialVetor2(v2, 200); //Método 6
            if(!encontrado2) Console.WriteLine("\nValor não encontrado!\n");
            watch.Stop();
            Console.WriteLine("\nTempo de busca sequencial do vetor 2: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");
            
            watch.Restart();

            bloco.OrdenacaobubbleSort(v1); //Método 7
            watch.Stop();
            Console.WriteLine("\nTempo de ordenação pelo BubbleSort do vetor 1: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");

            watch.Restart();

            bloco.OrdenacaoquickSort(v2); //Método 8
            watch.Stop();
            Console.WriteLine("\nTempo de ordenação pelo QuickSort do vetor 2: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");

            watch.Restart();

            bloco.SubstituirValorVetor1(v1, 998, 1); //Método 9
            watch.Stop();
            Console.WriteLine("\nTempo de substituição de valor do vetor 1: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");

            watch.Restart();

            bloco.SubstituirValorVetor2(v2, 4000, 999); //Método 10
            watch.Stop();
            Console.WriteLine("\nTempo de substituição de valor do vetor 2: {0}\n", watch.Elapsed);
            Console.WriteLine("-----------------------------------");
            
            watch.Restart();

            bloco.TrocarValoresV1V2(v1,v2);
            watch.Stop();
            Console.WriteLine("\nTempo de troca de valores do v1 e v2: {0}\n", watch.Elapsed); 
            Console.WriteLine("-----------------------------------");      

            watch.Restart();
            // Fim do código
            //.
            //.
            //.
            //.
            //.
            stopwatch.Stop();
            Console.WriteLine("\n\nO Tempo de execução: {0}\n", stopwatch.Elapsed);

        }
    }
}
