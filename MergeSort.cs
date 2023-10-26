using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortOperation
{
    internal class MergeSort
    {

        public static void Sort(Student[] arr)
        {
            int n = arr.Length;
            if (n < 2)
                return;

            int mid = n / 2;
            Student[] left = new Student[mid];
            Student[] right = new Student[n - mid];

            for (int i = 0; i < mid; i++)
                left[i] = arr[i];
            for (int i = mid; i < n; i++)
                right[i - mid] = arr[i];

            Sort(left);
            Sort(right);
            Merge(arr, left, right);
        }

        private static void Merge(Student[] arr, Student[] left, Student[] right)
        {
          
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i].Age <= right[j].Age)
                {
                    arr[k++] = left[i++];
                }
                else
                {
                    arr[k++] = right[j++];
                }
            }

            while (i < left.Length)
            {
                arr[k++] = left[i++];
            }

            while (j < right.Length)
            {
                arr[k++] = right[j++];
            }
        }
    }
}
    
