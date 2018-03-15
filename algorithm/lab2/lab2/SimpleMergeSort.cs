using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    class SimpleMergeSort : Sort
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

            int size = 1; //Размер серии
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
                    while (!rdf.EndOfStream)
                    {
                        for (int i = 0; i < size && !rdf.EndOfStream; i++)
                        {
                            int val = int.Parse(rdf.ReadLine());
                            if (flag)
                            {
                                wrf1.WriteLine(val);
                            }
                            else
                            {
                                wrf2.WriteLine(val);
                                end = false;
                            }
                        }
                        flag = !flag;
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

                    while (!rdf1.EndOfStream && !rdf2.EndOfStream)
                    {
                        int count1 = 0;
                        int count2 = 0;

                        flag = false;

                        while (count1 < size && count2 < size && !rdf1.EndOfStream && !rdf2.EndOfStream)
                        {
                            if (val1 <= val2)
                            {
                                wrf.WriteLine(val1);
                                val1 = int.Parse(rdf1.ReadLine());
                                count1++;
                            }
                            else
                            {
                                wrf.WriteLine(val2);
                                val2 = int.Parse(rdf2.ReadLine());
                                count2++;
                            }
                        }
                        while (count1 < size && !rdf1.EndOfStream)
                        {
                            wrf.WriteLine(val1);
                            val1 = int.Parse(rdf1.ReadLine());
                            count1++;
                        }
                        while (count2 < size && !rdf2.EndOfStream)
                        {
                            wrf.WriteLine(val2);
                            val2 = int.Parse(rdf2.ReadLine());
                            count2++;
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
                size *= 2;
            }
            File.Delete(f1);
            File.Delete(f2);
        }

        public void sortByte(string path)
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

            int size = 1; //Размер серии
            int byteReaded = 0;
            bool flag = false;
            byte[] b = new byte[BUFFER_SIZE];
            byte[] b1 = new byte[BUFFER_SIZE];
            byte[] b2 = new byte[BUFFER_SIZE];

            using (originStream)
            using (f1Stream)
            using (f2Stream)
            {
                while (size * BUFFER_SIZE < originStream.Length)
                {
                    byteReaded = 0;
                    originStream.Position = 0;
                    f1Stream.Position = 0;
                    f2Stream.Position = 0;

                    while (byteReaded < originStream.Length)
                    {
                        /* 
                         * Здесь можно было бы использовать простое считывание нужного количества байт, 
                         * но на последнем этапе, мы можем загрузить не меньше половины файла,
                         * а это слишком много в реальных условиях
                         */
                        for (int i = 0; i < size && byteReaded < originStream.Length; i++)
                        {
                            originStream.Read(b, 0, BUFFER_SIZE);
                            byteReaded += BUFFER_SIZE;
                            if (flag)
                            {
                                f1Stream.Write(b, 0, BUFFER_SIZE);
                            }
                            else
                            {
                                f2Stream.Write(b, 0, BUFFER_SIZE);
                            }
                        }
                        flag = !flag;
                    }

                    // Возврат указателя потока в начало
                    originStream.Position = 0;
                    f1Stream.Position = 0;
                    f2Stream.Position = 0;

                    byteReaded = 0;

                    while (byteReaded < originStream.Length)
                    {
                        int wrF1 = 0;
                        int wrF2 = 0;

                        f1Stream.Read(b1, 0, BUFFER_SIZE);
                        flag = false;

                        while (wrF1 < size && wrF2 < size)
                        {
                            if (flag)
                                f1Stream.Read(b1, 0, BUFFER_SIZE);
                            else
                                f2Stream.Read(b2, 0, BUFFER_SIZE);

                            int i1 = BitConverter.ToInt32(b1, 0);
                            int i2 = BitConverter.ToInt32(b2, 0);

                            if (i1 <= i2)
                            {
                                originStream.Write(b1, 0, BUFFER_SIZE);
                                ++wrF1;
                                byteReaded += BUFFER_SIZE;
                                flag = true;
                            }
                            else
                            {
                                originStream.Write(b2, 0, BUFFER_SIZE);
                                ++wrF2;
                                byteReaded += BUFFER_SIZE;
                                flag = false;
                            }
                        }

                        if (wrF2 < size)
                        {
                            originStream.Write(b2, 0, BUFFER_SIZE);
                            byteReaded += BUFFER_SIZE;
                            wrF2++;
                            for (int i = 0; i < size - wrF2; i++)
                            {
                                f2Stream.Read(b2, 0, BUFFER_SIZE);
                                originStream.Write(b2, 0, BUFFER_SIZE);
                                byteReaded += BUFFER_SIZE;
                            }
                        }
                        else if (wrF1 <= size)
                        {
                            originStream.Write(b1, 0, BUFFER_SIZE);
                            byteReaded += BUFFER_SIZE;
                            wrF1++;
                            for (int i = 0; i < size - wrF1; i++)
                            {
                                f1Stream.Read(b1, 0, BUFFER_SIZE);
                                originStream.Write(b1, 0, BUFFER_SIZE);
                                byteReaded += BUFFER_SIZE;
                            }
                        }
                    }

                    size *= 2;
                }
            }
            File.Delete(f1);
            File.Delete(f2);
        }
    }
}
