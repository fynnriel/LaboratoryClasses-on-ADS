using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    class BogoSort<T> : Sort<T>
    {
        public override bool sort(bool ascending)
        {
            int count = 3;
            if (list.Count >= count)
            {
                MessageBox.Show($"Don't run it on {count + 1} or more count of values");
                list.RemoveRange(count, list.Count - count - 1);
            }
            while (!checkArray())
            {
                shuffle();
            }
            if (!ascending)
                list.Reverse();
            sortCount++;
            return true;
        }
        private void shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                swap(i, random.Next(list.Count));
            }
        }
        private bool checkArray()
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (compare(list[i], list[i - 1]) < 0)
                    return false;
            }
            return true;
        }
    }
}
