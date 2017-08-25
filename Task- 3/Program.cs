using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];
            Console.WriteLine("Enter the numbres for each array press enter after every input: ");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("This is the array you inputed: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("\nSorted Array");

            SortQuick(numbers, 0, size - 1);

            //sorted array 
            for (int i = 0; i < size; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.ReadLine();
        }

        public static void SortQuick(int[] numbers, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = numbers[(left + right) / 2];

            while (i <= j)
            {
                while (numbers[i].CompareTo(pivot)<0)
                {
                    i++;
                }

                while (numbers[j].CompareTo(pivot) >0)
                {
                    j--;
                }

                if (i <= j)
                {
                    //swap
                    int tmp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = tmp;

                    i++;
                    j--;
                }
            }

            //recursive calls 
            if (left <j)
            {
                SortQuick(numbers, left, j);
            }
            if (i < right)
            {
                SortQuick(numbers, i, right);
            }
            //throw new NotImplementedException();
        }
    }
}
