using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortOperation
{
    internal class SelectionSort
    {
        public static void Sort(Student[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j].Age < arr[smallest].Age)
                    {
                        smallest = j;
                    }
                }

                if (smallest != i)
                {
                    Student temp = arr[i];
                    arr[i] = arr[smallest];
                    arr[smallest] = temp;
                }
            }
        }
    }
}

