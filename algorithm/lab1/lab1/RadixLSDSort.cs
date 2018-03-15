using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class RadixLSDSort<T> : Sort<T>
    {
        public override bool sort(bool ascending)
        {
            if (!(list[0].val.GetType() == typeof(sbyte) ||
                list[0].val.GetType() == typeof(byte) ||
                list[0].val.GetType() == typeof(char) ||
                list[0].val.GetType() == typeof(short) ||
                list[0].val.GetType() == typeof(ushort) ||
                list[0].val.GetType() == typeof(int) ||
                list[0].val.GetType() == typeof(uint) ||
                list[0].val.GetType() == typeof(long) ||
                list[0].val.GetType() == typeof(ulong) ||
                list[0].val.GetType() == typeof(float) ||
                list[0].val.GetType() == typeof(double)))
            {
                return false;
            }

            long[] arr = new long[list.Count];
            int n = 0;
            double d;
            int _POW = (int)Math.Pow(10, 8);

            foreach (Record<T> r in list)
            {
                double.TryParse(r.val.ToString(), out d);
                arr[n] = (long)(Math.Ceiling(d * _POW));
                ++n;
            }

            radix(arr);

            if (!ascending)
                list.Reverse();

            sortCount++;
            return true;
        }

        private void radix(long[] arr)
        {
            int i, j;
            Record<T>[] records = new Record<T>[arr.Length];
            for (int k = 0; k < arr.Length; k++)
            {
                records[k] = list[k];
            }
            long[] tmp = new long[arr.Length];
            Record<T>[] tmpRec = new Record<T>[arr.Length];

            for (int shift = 63; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < arr.Length; ++i)
                {
                    bool move = (arr[i] << shift) >= 0;
                    comparisonCount++;
                    if (shift == 0 ? !move : move)
                    {
                        arr[i - j] = arr[i];
                        records[i - j] = records[i];
                    }
                    else
                    {
                        tmpRec[j] = records[i];
                        tmp[j++] = arr[i];
                        swapCount++;
                    }
                }
                Array.Copy(tmp, 0, arr, arr.Length - j, j);
                Array.Copy(tmpRec, 0, records, records.Length - j, j);
            }
            for (int k = 0; k < list.Count; k++)
            {
                list[k] = records[k];
            }
        }
    }
}
