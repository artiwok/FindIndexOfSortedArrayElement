using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIndexOfSortedArrayElement
{
    class Program
    {
        static void Main(string[] args)
        {
            FindIndexOfSortedArrayElement();
        }

        static int FindIndexOfSortedArrayElement()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter the array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array elements' values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            // Array sort

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            // Retrieving the necessary element's index in the sorted array

            Console.Write("Choose the element's value: ");

            int value = int.Parse(Console.ReadLine());

            Console.WriteLine();

            // Linear search:

            //Console.Write("The index of the chosen element's value in the sorted array is: ");

            //int res = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == value)
            //    {
            //        res = i;                
            //        break;
            //    }
            //}

            //Console.Write(res);

            // Binary search:

            int low = 0; 
            int high = arr.Length - 1; 

            while (low <= high)
            {                
                int middle = low + (high - low) / 2;
                
                if (value < arr[middle])
                {
                    high = middle - 1;
                }
                else if (value > arr[middle])
                {
                    low = middle + 1;
                }
                else
                {
                    Console.Write($"The index of the chosen element's value in the sorted array is: {middle}");
                    Console.WriteLine("\n");
                    return middle;
                }               
            }

            Console.WriteLine("There is no such array element index!\n");

            return -1;
        }                   
    }
}
