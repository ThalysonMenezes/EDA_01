using System;
using System.Diagnostics;

namespace EDA_ATV_01
{
    public class Bloco
    {
        Random random = new Random();
        public void PreencherVetor1(int[] v1){
            for (int i = 0; i < v1.Length; i++) v1[i] = random.Next(1, 1000);
            Console.WriteLine("\nÍndices do vetor1 preenchidos randomicamente!\n");           
        }
        public void PreencherVetor2(int[] v2){
            for (int i = 0; i < v2.Length; i++) v2[i] = random.Next(1, 5000);
            Console.WriteLine("\nÍndices do vetor2 preenchidos randomicamente!\n");           
        }

        public void ExibirVetor1(int[] v1){
            for (int i = 0; i < v1.Length; i++) Console.WriteLine("Índice do vetor1[{0}]: {1}", i, v1[i]);
        }
        public void ExibirVetor2(int[] v2){
            for (int i = 0; i < v2.Length; i++) Console.WriteLine("Índice do vetor2[{0}]: {1}", i, v2[i]);
        }

        public bool BuscaSequencialVetor1(int[] v1, int x){
            bool encontrado = false;

            for (int i = 0; i < v1.Length; i++) {
                if(x.Equals(v1[i])) {
                Console.WriteLine("\nValor {0} encontrado no índice {1} do vetor1!", x, i);
                encontrado = true;
                break; 
                }                  
            } 
            return encontrado;
        }
        public bool BuscaSequencialVetor2(int[] v2, int x){
            bool encontrado = false;

            for (int i = 0; i < v2.Length; i++) {
                if(x.Equals(v2[i])) {
                Console.WriteLine("\nValor {0} encontrado no índice {1} do vetor2!", x, i);
                encontrado = true;
                break; 
                }                  
            } 
            return encontrado;
        }

        public void OrdenacaobubbleSort(int[] vetor) {
            int trocas = 0;
            for (int i = 0; i < vetor.Length - 1; i++)
            {           
                for (int j = 0; j < vetor.Length - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        trocas = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = trocas;
                    }
                }
            }
            if(vetor.Length.Equals(1000)) Console.WriteLine("\nVetor1 Ordenado pelo BubbleSort!");
            else                          Console.WriteLine("\nVetor2 Ordenado pelo BubbleSort!");
        }

        public int[] OrdenacaoquickSort(int[] vetor){
            int inicio = 0;
            int fim = vetor.Length - 1;
            quickSort(vetor, inicio, fim);
            if(vetor.Length.Equals(1000)) Console.WriteLine("\nVetor1 Ordenado pelo QuickSort!");
            else                          Console.WriteLine("\nVetor2 Ordenado pelo QuickSort!");
            return vetor;
        }
        private static void quickSort(int[] vetor, int inicio, int fim){
            if (inicio < fim){
                int p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;
                while (i <= f){
                    if (vetor[i] <= p){
                        i++;
                    }
                    else if (p < vetor[f]){
                        f--;
                    }
                    else{
                        int troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }
                vetor[inicio] = vetor[f];
                vetor[f] = p;
                quickSort(vetor, inicio, f - 1);
                quickSort(vetor, f + 1, fim);
            }
        }

        public void SubstituirValorVetor1(int[] v1, int indice, int x){
            if(indice > 999 || indice < 0) Console.WriteLine("\nValor {0} de índice não correspondente ao vetor!", indice);
            else{
                int aux = v1[indice];
                v1[indice] = x;
                Console.WriteLine("\nValor {0} do vetor v1[{1}] substituído por {2}", aux, indice, x);
            }
        }
        public void SubstituirValorVetor2(int[] v2, int indice, int x){
            if(indice > 4999 || indice < 0) Console.WriteLine("\nValor {0} de índice não correspondente ao vetor!", indice);
            else{
                int aux = v2[indice];
                v2[indice] = x;
                Console.WriteLine("\nValor {0} do vetor v1[{1}] substituído por {2}", aux, indice, x);
            }
        }

        public void TrocarValoresV1V2(int[] v1, int[] v2){
            int[] aux = new int[1000];

            Console.WriteLine("\nEste método substitui os primeiros 1000 valores de v1 por v2 e vice-versa!\n");

            for (int i = 0; i < v1.Length; i++){
                aux[i] = v1[i];
            }
            for (int i = 0; i < v1.Length; i++){
                v1[i] = v2[i];
            }
            for (int i = 0; i < v1.Length; i++){
                v2[i] = aux[i];
            }
        }

    }
}