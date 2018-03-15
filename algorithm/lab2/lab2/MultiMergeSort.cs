using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class MultiMergeSort : Sort
    {
        public override void sort(string path)
        {
            if (!File.Exists(path))
            {
                return;
            }

            int n = 10;

            if (n < 2)
                n = 2;

            List<string> fileNames = new List<string>(n);
            StreamWriter wrf;
            StreamReader rdf;
            List<StreamWriter> writers = new List<StreamWriter>(n);
            List<StreamReader> readers = new List<StreamReader>(n);


            bool flag = false;
            bool end = false;

            while (!end)
            {
                writers.Clear();
                readers.Clear();
                fileNames.Clear();

                for (int i = 0; i < n; i++)
                {
                    fileNames.Add($"f{i}");
                    File.Create(fileNames[i]).Close();
                    writers.Add(new StreamWriter(fileNames[i], false, Encoding.UTF8));
                }

                end = true;
                flag = true;
                int id = 0;

                using (rdf = new StreamReader(path, Encoding.UTF8))
                {
                    int prev = int.MinValue;

                    while (!rdf.EndOfStream)
                    {
                        int val = int.Parse(rdf.ReadLine());
                        if (val < prev)
                        {
                            if (id < n - 1)
                                id++;
                            else
                                id = 0;
                            end = false;
                        }
                        writers[id].WriteLine(val);
                        prev = val;
                    }
                }
                foreach (StreamWriter sw in writers)
                {
                    sw.Flush();
                    sw.Dispose();
                    sw.Close();
                }
                if (end)
                {
                    break;
                }


                for (int i = 0; i < n; i++)
                {
                    readers.Add(new StreamReader(fileNames[i], Encoding.UTF8));
                }
                //---------------Merge files----------------

                using (wrf = new StreamWriter(path, false, Encoding.UTF8))
                {
                    int[] vals = new int[n];
                    bool[] endOfIteration = new bool[n];
                    int[] prevs = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        if (!readers[i].EndOfStream)
                        {
                            vals[i] = int.Parse(readers[i].ReadLine());
                            endOfIteration[i] = false;
                            prevs[i] = int.MinValue;
                        }
                    }

                    while (!isEoF(readers.ToArray()))
                    {
                        for (int i = 0; i < n; i++)
                        {
                            prevs[i] = int.MinValue;

                            if (!readers[i].EndOfStream)
                            {
                                endOfIteration[i] = false;
                            }
                            else
                            {
                                endOfIteration[i] = true;
                            }
                        }

                        while (greaterThanPrev(vals, prevs) && !isAllWrited(endOfIteration))
                        {
                            int index = getIndexMin(vals, endOfIteration);
                            wrf.WriteLine(vals[index]);
                            if (!readers[index].EndOfStream)
                            {
                                prevs[index] = vals[index];
                                vals[index] = int.Parse(readers[index].ReadLine());
                                if (prevs[index] > vals[index])
                                {
                                    endOfIteration[index] = true;
                                }
                            }
                            else
                            {
                                endOfIteration[index] = true;
                            }
                        }

                    }
                }

                foreach (StreamReader sr in readers)
                {
                    sr.Dispose();
                    sr.Close();
                }
            }
            foreach (String name in fileNames)
                File.Delete(name);
        }

        private bool isAllWrited(bool[] endOfIteration)
        {
            foreach (bool b in endOfIteration)
                if (!b)
                    return false;
            return true;
        }

        private int getIndexMin(int[] vals, bool[] endOfIteration)
        {
            int min = int.MaxValue;
            int index = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                if (!endOfIteration[i] && vals[i] < min)
                {
                    min = vals[i];
                    index = i;
                }
            }
            return index;
        }

        private bool greaterThanPrev(int[] vals, int[] prevs)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] >= prevs[i])
                    return true;
            }
            return false;
        }

        private bool isEoF(StreamReader[] arr)
        {
            foreach (StreamReader sr in arr)
            {
                if (!sr.EndOfStream)
                    return false;
            }
            return true;
        }
    }
}
