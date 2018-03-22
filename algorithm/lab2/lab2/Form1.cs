using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        //test
        private string TEST_FILE_NAME = "origin";
        private int TEST_FILE_SIZE = 100;

        //variables
        private string path;

        public Form1()
        {
            InitializeComponent();
        }

        private void menuFileLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dialog.FileName))
                {
                    path = dialog.FileName;
                    printToTextBox(true);
                }
            }
        }

        private void printToTextBox(bool input)
        {
            if (path == null || !File.Exists(path))
                return;

            StringBuilder str = new StringBuilder();

            using (StreamReader stream = new StreamReader(path, Encoding.UTF8))
            {
                int counter = 0;

                while (!stream.EndOfStream)
                {
                    int[] arr = new int[5];
                    counter = 0;
                    for (int i = 0; i < 5 && !stream.EndOfStream; i++)
                    {
                        arr[i] = int.Parse(stream.ReadLine());
                        counter++;
                    }
                    if (counter == 5)
                        str.Append(String.Format("{0,20} {1,20} {2,20} {3,20} {4,20}", arr[0], arr[1], arr[2], arr[3], arr[4]));
                    else if (counter == 4)
                        str.Append(String.Format("{0,20} {1,20} {2,20} {3,20}", arr[0], arr[1], arr[2], arr[3]));
                    else if (counter == 3)
                        str.Append(String.Format("{0,20} {1,20} {2,20}", arr[0], arr[1], arr[2]));
                    else if (counter == 2)
                        str.Append(String.Format("{0,20} {1,20}", arr[0], arr[1]));
                    else if (counter == 1)
                        str.Append(String.Format("{0,20}", arr[0]));
                    str.Append('\n');
                }
            }

            if (input)
                rtbInputValues.Text = str.ToString();
            else
                rtbOutputValues.Text = str.ToString();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (!File.Exists(path))
                MessageBox.Show("Wrong path or file!");
            if (radSimpleMerge.Checked)
            {
                SimpleMergeSort sort = new SimpleMergeSort();
                sort.sort(path);
                stopwatch.Stop();
            }
            else if (radNaturalMerge.Checked)
            {
                NaturalMergeSort sort = new NaturalMergeSort();
                sort.sort(path);
                stopwatch.Stop();
            }
            else if (radDoubleMerge.Checked)
            {
                MultiMergeSort sort = new MultiMergeSort();
                sort.sort(path);
                stopwatch.Stop();
            }
            rtbInfo.Text = String.Format($"{stopwatch.ElapsedMilliseconds} ms");
            printToTextBox(false);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();
            /*
            if (radGenerate100.Checked)
            {
                sort.generateTestFile("test100", 20);
            }
            else if (radGenerate1000.Checked)
            {
                sort.generateTestFile("test1000", 1000);
            }
            else if (radGenerate10000.Checked)
            {
                sort.generateTestFile("test10000", 10000);
            }
            else if (radGenerate100000.Checked)
            {
                sort.generateTestFile("test100000", 100000);
            }
            */
            for (int i = 10_000; i <= 50_000; i+=5000)
            {
                sort.generateTestFile("test" + i, i);
            }
        }
    }
}
