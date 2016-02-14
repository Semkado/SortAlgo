using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgo.Algorithmen
{
    public class MergeSort
    {
        void sort(int[] arr)
        {
            int[] helper = new int[arr.Length];
            mergesort(arr, helper, 0, arr.Length - 1);
        }

        void mergesort(int[] arr, int[] helper, int low, int high)
        {
            if (low < high)
            {
                int middle = (high + low) / 2;
                mergesort(arr, helper, low, middle);
                mergesort(arr, helper, middle + 1, high);
                merge(arr, helper, low, middle, high);
            }
        }

        void merge(int[] arr, int[] helper, int low, int middle, int high)
        {
            for (int x = low; x <= high; x++)
            {
                helper[x] = arr[x];
            }

            int left = low;
            int curr = low;
            int right = middle + 1;

            while (left <= middle && right <= high)
            {
                if (helper[right] > helper[left])
                    arr[curr++] = helper[left++];
                else
                    arr[curr++] = helper[right++];
            }

            while (left <= middle)
                arr[curr++] = helper[left++];
        }

    }
}
