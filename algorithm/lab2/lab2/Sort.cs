using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Sort
    {
        protected const int BUFFER_SIZE = 4;

        public virtual void sort(string path)
        {
            
        }

        public void generateTestFile(string path, int n)
        {
            int[] arr = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(2_000_000) - 1_000_000;
                //arr[i] = random.Next(2_0) - 1_0;
            }
            
            using(StreamWriter stream = new StreamWriter(path, false, Encoding.UTF8))
            {
                foreach(int a in arr)
                {
                    stream.WriteLine(a);
                }
            }
        }
    }
}
