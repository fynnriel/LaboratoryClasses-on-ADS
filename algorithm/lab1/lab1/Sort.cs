using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    //Сортировки - гномья, merge, поразрядная восходящая, поразрядная нисходящая, bogo
    class Sort<T>
    {
        protected List<Record<T>> list;
        protected int n
        {
            get
            {
                return list.Count;
            }
        }

        protected int sortCount;
        protected int swapCount;
        protected int comparisonCount;
        protected int time;

        public Record<T>[] records
        {
            get
            {
                return list.ToArray();
            }
        }
        public int averageSwapCount
        {
            get
            {
                return swapCount / sortCount;
            }
        }
        public int averageComparisonCount
        {
            get
            {
                return comparisonCount / sortCount;
            }
        }

        public Sort()
        {
            list = new List<Record<T>>();
            sortCount = 0;
            swapCount = 0;
            comparisonCount = 0;
        }

        public void addRecord(Record<T> r)
        {
            list.Add(r);
        }
        public void addRecord(List<Record<T>> r)
        {
            list = r;
        }

        public void clearList()
        {
            list.Clear();
        }

        public virtual bool sort(bool ascending)
        {
            ++sortCount;
            return true;
        }

        //-------------------------------------

        protected int compare(Record<T> r1, Record<T> r2)
        {
            ++comparisonCount;
            return Comparer<T>.Default.Compare(r1.val, r2.val);
        }
        protected void swap(int id1, int id2)
        {
            try
            {
                Record<T> r = list[id1];
                list[id1] = list[id2];
                list[id2] = r;
                ++swapCount;
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show($"Index out of range in swap id1={id1}, id2={id2}, size={list.Count}");
            }
        }
    }
}
