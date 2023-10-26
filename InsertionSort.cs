using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortOperation
{
    internal class InsertionSort
    {
        public static void Sort(Student[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                Student studentToInsert = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j].Age > studentToInsert.Age)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = studentToInsert;
            }
        }


    }
}
