using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class RadixMSDSort<T> : Sort<T>
    {
        private int m = 20;
        private int k = 10;

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

            Rad<T>[] arr = new Rad<T>[list.Count];
            int n = 0;
            int _POW = (int)Math.Pow(10, 8);
            double d;
            long min = 0;

            foreach (Record<T> r in list)
            {
                double.TryParse(r.val.ToString(), out d);
                arr[n].s = d.ToString();
                arr[n].r = r;
                n++;
            }

            msd(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                list[i] = arr[i].r;
            }
            if (!ascending)
                list.Reverse();

            sortCount++;
            return true;
        }

        private struct Rad<T>
        {
            public Record<T> r;
            public string s;
        }

        private int R = 2 << 8;
        private void msd(Rad<T>[] arr)
        {
            Rad<T>[] aux = new Rad<T>[arr.Length];
            int lo = 0;
            int hi = arr.Length - 1;
            int at = 0;
            msdSort(arr, aux, lo, hi, at);
        }
        private int charAt(string s, int i)
        {
            if (i < s.Length) return s[i];
            else return -1;
        }
        private void msdSort(Rad<T>[] s, Rad<T>[] aux, int lo, int hi, int at)
        {
            if (hi <= lo) return;

            int[] count = new int[R + 2];

            for (int i = lo; i <= hi; ++i)
                count[charAt(s[i].s, at) + 2]++;

            for (int i = 0; i < R + 1; ++i)
                count[i + 1] += count[i];

            for (int i = lo; i <= hi; ++i)
            {
                aux[count[charAt(s[i].s, at) + 1]++] = s[i];
                swapCount++;
            }
            for (int i = lo; i <= hi; ++i)
                s[i] = aux[i - lo];

            for (int r = 0; r < R; ++r)
                msdSort(s, aux, lo + count[r], lo + count[r + 1] - 1, at + 1);
        }
    }
}
