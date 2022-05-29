using System.Linq;

namespace BubbleSort.Library
{
    public class BubbleSort
    {

        public static int[] Sort(int[] array)
        {
            int temp;
            bool isSortCompleted = true;
            for (int i = 0; i < array.Length - 1 && isSortCompleted; i++)
            {
                isSortCompleted = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        isSortCompleted = true;
                    }
                }
            }
            return array.ToArray();
        }
    }
}