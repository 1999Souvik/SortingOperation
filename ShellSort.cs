using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortOperation
{
    internal class ShellSort
    {
        public static void Sort(Student[] arr)
        {
            int n = arr.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    Student temp = arr[i];
                    int j = i;

                    while (j >= gap && arr[j - gap].Age > temp.Age)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }

                    arr[j] = temp;
                }

                gap /= 2;
            }
        }
    }
}
       




       


