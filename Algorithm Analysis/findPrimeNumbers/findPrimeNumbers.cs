using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace findPrimeNumbers
{
    public partial class findPrimeNumbers : Form
    {
        public findPrimeNumbers()
        {
            InitializeComponent();

            listBoxHardWay.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxHardWay.DrawItem += new DrawItemEventHandler(listBoxHardWay_DrawItem);

            listBoxEasyWay.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxEasyWay.DrawItem += new DrawItemEventHandler(listBoxEasyWay_DrawItem);
        }

        int inital;
        Thread thread1;
        Thread thread2;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonStart2.Enabled = false;

            inital = 0;
            stop = false;
            listBoxHardWay.Items.Clear();
            listBoxEasyWay.Items.Clear();

            //Run 2 loops at the same time.
            thread1 = new Thread(new ThreadStart(HardWay));
            thread2 = new Thread(new ThreadStart(EasyWay));

            thread1.Start();
            thread2.Start();

            //Or
            //Parallel.Invoke(() => HardWay(), () => EasyWay());
        }

        private void buttonStart2_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonStart2.Enabled = false;

            inital = 5000000;
            stop = false;
            listBoxHardWay.Items.Clear();
            listBoxEasyWay.Items.Clear();

            //Run 2 loops at the same time.
            thread1 = new Thread(new ThreadStart(HardWay));
            thread2 = new Thread(new ThreadStart(EasyWay));

            thread1.Start();
            thread2.Start();

            //Or
            //Parallel.Invoke(() => HardWay(), () => EasyWay());
        }

        bool stop = false;
        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = true;
            buttonStart2.Enabled = true;

            stop = true;
        }

        /* Type          Capacity
        *  Int16      -- (-32768 to +32767)
        *  Int32      -- (-2147483648 to +2147483647)
        *  Int64      -- (-9223372036854775808 to +9223372036854775807)
        * */

        private void HardWay()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            long sumWatch = 0;
            //We are looking for every number (i) if it's prime or not...
            for (long i = inital; i < 9223372036854775807; i++)
            {
                bool divided = false;
                //...by dividing every number in range of 2 to i-1.
                for (long j = 2; j < i; j++)
                {
                    //if j can divide i then divided will be true.
                    if (i % j == 0)
                    {
                        divided = true;
                    }
                    //if j is the last number it can get and divided is still false then i is a prime.
                    if (j == i - 1 && divided == false)
                    {
                        Invoke(new MethodInvoker(delegate ()
                        {
                            listBoxHardWay.Items.Add(i);

                            listBoxHardWay.SelectedIndex = listBoxHardWay.Items.Count - 1;

                            watch.Stop();
                            labelElapsedHard.Text = "Elapsed Time (ms) : " + watch.ElapsedMilliseconds + " ms";
                            sumWatch += watch.ElapsedMilliseconds;
                            labelTotalHard.Text = "Total Time (ms) : " + sumWatch + " ms";
                            watch = System.Diagnostics.Stopwatch.StartNew();

                            Wait(100);
                        }));
                    }
                }
                if (stop == true)
                {
                    break;
                }
            }
        }

        private void EasyWay()
        {
            File.WriteAllText("primeNumbers.txt", String.Empty);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            long sumWatch = 0;
            //We are looking for every number (i) if it's prime or not...
            for (long i = inital; i < 9223372036854775807; i++)
            {
                bool divided = false;
                //...by dividing every number in range of 2 to i^1/2.
                long sqrtN = Convert.ToInt64(Math.Round(Math.Sqrt(i)));
                for (long j = 2; j < sqrtN + 1; j++)
                {
                    //if j can divide i then divided will be true.
                    if (i % j == 0)
                    {
                        divided = true;
                    }
                    //if j is the last number it can get and divided is still false then i is a prime.
                    if (j == sqrtN && divided == false)
                    {
                        Invoke(new MethodInvoker(delegate ()
                        {
                            TextWriter tw = new StreamWriter("primeNumbers.txt", true);
                            tw.WriteLine(i);
                            tw.Close();

                            listBoxEasyWay.Items.Add(i);

                            listBoxEasyWay.SelectedIndex = listBoxEasyWay.Items.Count - 1;

                            watch.Stop();
                            labelElapsedEasy.Text = "Elapsed Milliseconds (Easy Way) : " + watch.ElapsedMilliseconds + " ms";
                            sumWatch += watch.ElapsedMilliseconds;
                            labelTotalEasy.Text = "Total Time (ms) : " + sumWatch + " ms";
                            watch = System.Diagnostics.Stopwatch.StartNew();

                            Wait(100);
                        }));
                    }
                }
                if (stop == true)
                {
                    break;
                }
            }
        }

        public void Wait(int ms)
        {
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < ms)
            {
                Application.DoEvents();
            }
        }

        private Random rnd = new Random();
        private void listBoxHardWay_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, PickBrush(), e.Bounds, StringFormat.GenericDefault);
            }
            catch
            {

            }
        }

        private void listBoxEasyWay_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, PickBrush(), e.Bounds, StringFormat.GenericDefault);
            }
            catch
            {

            }
        }

        private Brush PickBrush()
        {
            Brush result;
            Type brushesType = typeof(Brushes);
            PropertyInfo[] properties = brushesType.GetProperties();
            int random = rnd.Next(properties.Length);
            result = (Brush)properties[random].GetValue(null, null);
            return result;
        }
    }
}
