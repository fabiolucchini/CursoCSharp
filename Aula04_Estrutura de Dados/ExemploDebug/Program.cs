using System;

namespace ExemploDEbug
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7,4, 5, -1,2, 1, 0, 3 };
            int [] arrayOrdenado =Ordenar(array);
            for (int i = 0; i < arrayOrdenado.Length; i++)
                Console.WriteLine($"Posicao: {i + 1}, Valor:{arrayOrdenado[i]}");
        }

        static int [] Ordenar ( int [] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j< arr.Length-1; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
