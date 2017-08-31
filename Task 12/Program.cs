using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class Program
    {
        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
            Console.WriteLine("Результат сортировки пузырьком: ");
            for (int i = 0; i < 10; i++)
                Console.Write("{0} ", arr[i]);
            Console.WriteLine();
        }

        static void BinTreeSort(int[] arr)
        {
            BinTree k = BinTree.FindTree(arr);
            Console.WriteLine("Результат сортировки с помощью бинарного дерева: ");
            for (int i = 0; i < 10; i++)
                Console.Write("{0} ", arr[i]);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Random a = new Random();
            int[] mas = new int[10];
            for (int i = 0; i < 10; i++)
            {
                mas[i] = a.Next(10);
                Console.Write("{0} ", mas[i]);
            }
            Console.WriteLine();
            BubbleSort(mas);
            BinTreeSort(mas);
            Console.ReadLine();
        }
    }
}
