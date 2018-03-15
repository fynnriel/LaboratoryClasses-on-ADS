using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        private List<string[]> list;
        List<Record<double>> recordsDouble;
        List<Record<int>> recordsInt;
        List<Record<string>> recordsStr;
        int size = 1000;
        private bool arrayOfRecords = true;

        public Form1()
        {
            InitializeComponent();
            radGnomeSort.Select();
            recordsInt = new List<Record<int>>();
            recordsDouble = new List<Record<double>>();
            recordsStr = new List<Record<string>>();
            list = new List<string[]>();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

            Stopwatch stopwatch = new Stopwatch();
            int avrCompCount = 0;
            int avrSwapCount = 0;
            bool ascending = radAscendingSort.Checked;

            Type type = typeof(int);

            if (!radNumbersArray.Checked && arrayOfRecords)
            {
                recordsInt.Clear();
                recordsDouble.Clear();
                recordsStr.Clear();
                if (cmbColumnNumber.SelectedItem == null)
                    return;
                string num = cmbColumnNumber.SelectedItem.ToString();
                int column = int.Parse(num);

                if (int.TryParse(list[0][column], out int resInt))
                {
                    type = typeof(int);
                    foreach (string[] s in list)
                    {
                        recordsInt.Add(new Record<int>(s, column, int.Parse(s[column])));
                    }
                }
                else if (double.TryParse(list[0][column], out double resDouble))
                {
                    type = typeof(double);
                    foreach (string[] s in list)
                    {
                        recordsDouble.Add(new Record<double>(s, column, double.Parse(s[column])));
                    }
                }
                else
                {
                    type = typeof(string);
                    foreach (string[] s in list)
                    {
                        recordsStr.Add(new Record<string>(s, column, s[column]));
                    }
                }
            }
            else
            {
                if (recordsInt.Count == 0)
                    return;
            }

            Sort<int> sortInt;
            Sort<double> sortDouble;
            Sort<string> sortStr;

            if (type == typeof(int))
            {
                if (radGnomeSort.Checked)
                {
                    sortInt = new GnomeSort<int>();
                }
                else if (radMergeSort.Checked)
                {
                    sortInt = new MergeSort<int>();
                }
                else if (radBitByBitAscendSort.Checked)
                {
                    sortInt = new RadixMSDSort<int>();
                }
                else if (radBitByBitDescendSort.Checked)
                {
                    sortInt = new RadixLSDSort<int>();
                }
                else
                {
                    sortInt = new BogoSort<int>();
                }
                sortInt.addRecord(recordsInt);
                stopwatch.Start();
                sortInt.sort(ascending);
                stopwatch.Stop();
                avrCompCount = sortInt.averageComparisonCount;
                avrSwapCount = sortInt.averageSwapCount;
            }
            if (type == typeof(double))
            {
                if (radGnomeSort.Checked)
                {
                    sortDouble = new GnomeSort<double>();
                }
                else if (radMergeSort.Checked)
                {
                    sortDouble = new MergeSort<double>();
                }
                else if (radBitByBitAscendSort.Checked)
                {
                    sortDouble = new RadixMSDSort<double>();
                }
                else if (radBitByBitDescendSort.Checked)
                {
                    sortDouble = new RadixLSDSort<double>();
                }
                else
                {
                    sortDouble = new BogoSort<double>();
                }
                sortDouble.addRecord(recordsDouble);
                stopwatch.Start();
                sortDouble.sort(ascending);
                stopwatch.Stop();
                avrCompCount = sortDouble.averageComparisonCount;
                avrSwapCount = sortDouble.averageSwapCount;
            }
            if (type == typeof(string))
            {
                if (radGnomeSort.Checked)
                {
                    sortStr = new GnomeSort<string>();
                }
                else if (radMergeSort.Checked)
                {
                    sortStr = new MergeSort<string>();
                }
                else if (radBitByBitAscendSort.Checked)
                {
                    sortStr = new RadixMSDSort<string>();
                }
                else if (radBitByBitDescendSort.Checked)
                {
                    sortStr = new RadixLSDSort<string>();
                }
                else
                {
                    sortStr = new BogoSort<string>();
                }
                sortStr.addRecord(recordsStr);
                stopwatch.Start();
                sortStr.sort(ascending);
                stopwatch.Stop();
                avrCompCount = sortStr.averageComparisonCount;
                avrSwapCount = sortStr.averageSwapCount;
            }

            tbxOutputValues.Text = "";

            StringBuilder stb = new StringBuilder();
            if (radNumbersArray.Checked)
            {
                int c = 0;
                if (type == typeof(int))
                {
                    foreach (Record<int> r in recordsInt)
                    {
                        stb.Append(r.val.ToString());
                        stb.Append("\t\t");
                        if (++c == 5)
                        {
                            stb.Append('\n');
                            c = 0;
                        }
                    }
                }
                if (type == typeof(double))
                {
                    foreach (Record<double> r in recordsDouble)
                    {
                        stb.Append(r.val.ToString());
                        stb.Append("\t\t");
                        if (++c == 5)
                        {
                            stb.Append('\n');
                            c = 0;
                        }
                    }
                }
                if (type == typeof(string))
                {
                    foreach (Record<string> r in recordsStr)
                    {
                        stb.Append(r.val.ToString());
                        stb.Append("\t\t");
                        if (++c == 5)
                        {
                            stb.Append('\n');
                            c = 0;
                        }
                    }
                }
            }
            else
            {
                if (type == typeof(int))
                {
                    foreach (Record<int> r in recordsInt)
                    {
                        foreach (string i in r.columns)
                        {
                            stb.Append($"{i}\t | ");
                        }
                        stb.Append('\n');
                    }
                }
                if (type == typeof(double))
                {
                    foreach (Record<double> r in recordsDouble)
                    {
                        foreach (string i in r.columns)
                        {
                            stb.Append($"{i}\t | ");
                        }
                        stb.Append('\n');
                    }
                }
                if (type == typeof(string))
                {
                    foreach (Record<string> r in recordsStr)
                    {
                        foreach (string i in r.columns)
                        {
                            stb.Append($"{i}\t | ");
                        }
                        stb.Append('\n');
                    }
                }
            }

            tbxOutputValues.Text = stb.ToString();

            StringBuilder stat = new StringBuilder();
            stat.Append("Время сортировки:\n");
            stat.Append((double)stopwatch.ElapsedMilliseconds / 1000);
            stat.Append(" c");
            stat.Append('\n');
            stat.Append("Среднее число сравнений:\n");
            stat.Append(avrCompCount);
            stat.Append('\n');
            stat.Append("Среднее число перестановок:\n");
            stat.Append(avrSwapCount);

            tbxSortStat.Text = stat.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            recordsInt.Clear();
            tbxInputValues.Text = "";
        }

        private void test()
        {
            recordsInt.Clear();
            tbxInputValues.Text = "";
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                recordsInt.Add(new Record<int>(i, random.Next(size) - size / 2));
            }
            lblSortedValuesCount.Text = "Количество сортируемых значений: " + recordsInt.Count;
            StringBuilder stb = new StringBuilder();
            int c = 0;
            foreach (Record<int> r in recordsInt)
            {
                stb.Append(r.val.ToString());
                stb.Append("\t\t");
                if (++c == 5)
                {
                    stb.Append('\n');
                    c = 0;
                }
            }
            tbxInputValues.Text = stb.ToString();
        }

        private void menuFileTest10_Click(object sender, EventArgs e)
        {
            /*
            if (!File.Exists("rec.csv"))
                using (File.Create("rec.csv")) ;

            using (StreamWriter writer = new StreamWriter("rec.csv", false))
            {
                Random random = new Random();
                for (int i = 0; i < 1000; i++)
                {
                    writer.WriteLine($"{i};{(random.NextDouble() - random.NextDouble()) * Math.Pow(10, random.Next(4))};name{i};{random.Next(1000)}");
                }
            }*/

            if (radRecordsArray.Checked)
                return;
            size = 10;
            test();

        }

        private void menuFileTest100_Click(object sender, EventArgs e)
        {
            if (radRecordsArray.Checked)
                return;
            size = 100;
            test();
        }

        private void menuFileTest1000_Click(object sender, EventArgs e)
        {
            if (radRecordsArray.Checked)
                return;
            size = 1000;
            test();
        }

        private void menuFileTest10000_Click(object sender, EventArgs e)
        {
            if (radRecordsArray.Checked)
                return;
            size = 10_000;
            test();
        }

        private void menuFileTest100000_Click(object sender, EventArgs e)
        {
            if (radRecordsArray.Checked)
                return;
            size = 100_000;
            test();
        }

        private void menuFileLoadData_Click(object sender, EventArgs e)
        {
            if (!radRecordsArray.Checked)
                return;
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(dialog.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        list.Add(reader.ReadLine().Split(';'));
                    }
                }
            }

            cmbColumnNumber.Items.Clear();

            for (int i = 0; i < list[0].Length; i++)
            {
                cmbColumnNumber.Items.Add(i);
            }
            tbxInputValues.Clear();
            StringBuilder str = new StringBuilder();
            foreach (string[] s in list)
            {
                foreach (string i in s)
                {
                    str.Append($"{i}\t | ");
                }
                str.Append('\n');
            }
            tbxInputValues.Text = str.ToString();
        }

        private void radRecordsArray_CheckedChanged(object sender, EventArgs e)
        {
            cmbColumnNumber.Enabled = true;
            arrayOfRecords = true;
            list.Clear();
            tbxInputValues.Clear();
            recordsInt.Clear();
            recordsDouble.Clear();
            recordsStr.Clear();
        }

        private void radNumbersArray_CheckedChanged(object sender, EventArgs e)
        {
            cmbColumnNumber.Enabled = false;
            arrayOfRecords = false;
            list.Clear();
            tbxInputValues.Clear();
            recordsInt.Clear();
            recordsDouble.Clear();
            recordsStr.Clear();
        }
    }
}
