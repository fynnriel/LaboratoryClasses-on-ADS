using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class GnomeSort<T> : Sort<T>
    {
        public override bool sort(bool ascending)
        {
            int i = 1;
            int j = 2;

            while (i < n)
            {
                if (ascending && compare(list[i - 1], list[i]) <= 0 || !ascending && compare(list[i - 1], list[i]) >= 0)
                {
                    i = j;
                    ++j;
                }
                else
                {
                    swap(i - 1, i);
                    --i;
                    if (i == 0)
                    {
                        i = j;
                        ++j;
                    }
                }
            }
            ++sortCount;
            return true;
        }
    }
}
