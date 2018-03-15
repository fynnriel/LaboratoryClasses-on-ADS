using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class MergeSort<T> : Sort<T>
    {
        public override bool sort(bool ascending)
        {
            mergeSort(0, n-1);
            if (!ascending)
                list.Reverse();
            ++sortCount;
            return true;
        }

        private void mergeSort(int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                mergeSort(low, middle);
                mergeSort(middle + 1, high);
                merge(low, middle, high);
            }
        }

        private void merge(int low, int middle, int high)
        {

            int left = low;
            int right = middle + 1;
            Record<T>[] tmp = new Record<T>[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (compare(list[left], list[right]) < 0)
                {
                    tmp[tmpIndex] = list[left];
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = list[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = list[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = list[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                list[low + i] = tmp[i];
            }

        }
    }
}
