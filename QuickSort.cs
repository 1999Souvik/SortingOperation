using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortOperation
{
    internal class QuickSort
    {
        public static void Sort(Student[] arr, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(arr, low, high);
                Sort(arr, low, partitionIndex - 1);
                Sort(arr, partitionIndex + 1, high);
            }
        }

        private static int Partition(Student[] arr, int low, int high)
        {
            int pivot = arr[high].Age;
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (arr[j].Age < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);
            return i + 1;
        }

        private static void Swap(Student[] arr, int i, int j)
        {
            Student temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}
