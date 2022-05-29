using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int[] A = { 2, 8, 6, 4, 3 };
            Console.WriteLine("UnSort Array :");
            PrintArray(A);
            int[] rs = BubbleSort.Library.BubbleSort.Sort(A);
            Console.WriteLine("\n\nSorted Array :");
            PrintArray(rs);
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
        }

    }
}
