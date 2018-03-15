using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class NaturalMergeSort : Sort
    {
        public override void sort(string path)
        {
            string f1 = "f1";
            string f2 = "f2";


            if (!File.Exists(path))
            {
                return;
            }
            if (File.Exists(f1))
            {
                File.Delete(f1);
                File.Create(f1).Close();
            }
            else
            {
                File.Create(f1).Close();
            }
            if (File.Exists(f2))
            {
                File.Delete(f2);
                File.Create(f2).Close();
            }
            else
            {
                File.Create(f2).Close();
            }

            StreamWriter wrf;
            StreamWriter wrf1;
            StreamWriter wrf2;
            StreamReader rdf;
            StreamReader rdf1;
            StreamReader rdf2;

            bool flag = false;
            bool end = false;

            while (!end)
            {
                end = true;
                flag = true;

                using (rdf = new StreamReader(path, Encoding.UTF8))
                using (wrf1 = new StreamWriter(f1, false, Encoding.UTF8))
                using (wrf2 = new StreamWriter(f2, false, Encoding.UTF8))
                {
                    int prev = int.MinValue;

                    while (!rdf.EndOfStream)
                    {
                        int val = int.Parse(rdf.ReadLine());
                        if (val < prev)
                            flag = !flag;
                        if (flag)
                        {
                            wrf1.WriteLine(val);
                        }
                        else
                        {
                            wrf2.WriteLine(val);
                            end = false;
                        }
                        prev = val;
                    }
                }
                if (end)
                    return;

                using (wrf = new StreamWriter(path, false, Encoding.UTF8))
                using (rdf1 = new StreamReader(f1, Encoding.UTF8))
                using (rdf2 = new StreamReader(f2, Encoding.UTF8))
                {
                    int val1 = int.Parse(rdf1.ReadLine());
                    int val2 = int.Parse(rdf2.ReadLine());
                    bool file1 = false;
                    bool file2 = false;
                    int prev1 = int.MinValue;
                    int prev2 = int.MinValue;

                    while (!rdf1.EndOfStream && !rdf2.EndOfStream)
                    {
                        prev1 = int.MinValue;
                        prev2 = int.MinValue;
                        file1 = false;
                        file2 = false;

                        while (val1 >= prev1 && val2 >= prev2 && !rdf1.EndOfStream && !rdf2.EndOfStream)
                        {
                            if (val1 <= val2)
                            {
                                wrf.WriteLine(val1);
                                prev1 = val1;
                                val1 = int.Parse(rdf1.ReadLine());
                            }
                            else
                            {
                                wrf.WriteLine(val2);
                                prev2 = val2;
                                val2 = int.Parse(rdf2.ReadLine());
                            }
                        }
                        while (val1 >= prev1 && !rdf1.EndOfStream)
                        {
                            wrf.WriteLine(val1);
                            prev1 = val1;
                            val1 = int.Parse(rdf1.ReadLine());
                        }
                        while (val2 >= prev2 && !rdf2.EndOfStream)
                        {
                            wrf.WriteLine(val2);
                            prev2 = val2;
                            val2 = int.Parse(rdf2.ReadLine());
                        }
                    }
                    while (!rdf1.EndOfStream)
                    {
                        wrf.WriteLine(val1);
                        val1 = int.Parse(rdf1.ReadLine());
                    }
                    while (!rdf2.EndOfStream)
                    {
                        wrf.WriteLine(val2);
                        val2 = int.Parse(rdf2.ReadLine());
                    }
                }
            }
            File.Delete(f1);
            File.Delete(f2);
        }

        public void sortBytes(string path)
        {
            string f1 = "f1";
            string f2 = "f2";


            if (!File.Exists(path))
            {
                return;
            }
            if (File.Exists(f1))
            {
                File.Delete(f1);
                File.Create(f1).Close();
            }
            else
            {
                File.Create(f1).Close();
            }
            if (File.Exists(f2))
            {
                File.Delete(f2);
                File.Create(f2).Close();
            }
            else
            {
                File.Create(f2).Close();
            }

            FileStream originStream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            FileStream f1Stream = new FileStream(f1, FileMode.Open, FileAccess.ReadWrite);
            FileStream f2Stream = new FileStream(f2, FileMode.Open, FileAccess.ReadWrite);

            int readedBytes = 0;
            bool flag = false;
            byte[] b = new byte[BUFFER_SIZE];
            byte[] b1 = new byte[BUFFER_SIZE];
            byte[] b2 = new byte[BUFFER_SIZE];
            bool correct = false;

            using (originStream)
            using (f1Stream)
            using (f2Stream)
            {
                while (!correct)
                {
                    readedBytes = 0;
                    originStream.Position = 0;
                    f1Stream.Position = 0;
                    f2Stream.Position = 0;
                    flag = true;
                    correct = true;

                    int prevVal = int.MinValue;

                    while (readedBytes < originStream.Length)
                    {
                        originStream.Read(b, 0, BUFFER_SIZE);
                        readedBytes += BUFFER_SIZE;

                        if (prevVal > BitConverter.ToInt32(b, 0))
                        {
                            flag = !flag;
                            correct = false;
                        }

                        if (flag)
                        {
                            f1Stream.Write(b, 0, BUFFER_SIZE);
                        }
                        else
                        {
                            f2Stream.Write(b, 0, BUFFER_SIZE);
                        }
                    }

                    if (correct)
                        break;

                    // Возврат указателя потока в начало
                    originStream.Position = 0;
                    f1Stream.Position = 0;
                    f2Stream.Position = 0;

                    readedBytes = 0;

                    int prevVal1 = int.MinValue;
                    int prevVal2 = int.MinValue;
                    int val1 = 0;
                    int val2 = 0;
                    int readedF1 = 0;
                    int readedF2 = 0;
                    bool eof1 = false;
                    bool eof2 = false;

                    f1Stream.Read(b1, 0, BUFFER_SIZE);
                    readedBytes += BUFFER_SIZE;
                    f2Stream.Read(b2, 0, BUFFER_SIZE);
                    readedBytes += BUFFER_SIZE;

                    val1 = BitConverter.ToInt32(b1, 0);
                    val2 = BitConverter.ToInt32(b2, 0);

                    while (readedBytes < originStream.Length)
                    {
                        while (val1 >= prevVal1 && val2 >= prevVal2)
                        {
                            if (val1 < val2)
                            {
                                originStream.Write(b1, 0, BUFFER_SIZE);
                                prevVal1 = val1;
                                f1Stream.Read(b1, 0, BUFFER_SIZE);
                                readedBytes += BUFFER_SIZE;
                                val1 = BitConverter.ToInt32(b1, 0);
                            }
                            else
                            {
                                originStream.Write(b2, 0, BUFFER_SIZE);
                                prevVal2 = val2;
                                f2Stream.Read(b2, 0, BUFFER_SIZE);
                                readedBytes += BUFFER_SIZE;
                                val2 = BitConverter.ToInt32(b2, 0);
                            }
                            while (val1 >= prevVal1)
                            {

                            }
                        }
                    }
                }
            }
            File.Delete(f1);
            File.Delete(f2);
        }
    }
}
