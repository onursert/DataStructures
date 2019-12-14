using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacci
{
    public partial class fibonacci : Form
    {
        public fibonacci()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;

            stop = false;
            listBoxRecursive.Items.Clear();
            listBoxIterative.Items.Clear();

            var watchRecursive = System.Diagnostics.Stopwatch.StartNew();
            var watchIterative = System.Diagnostics.Stopwatch.StartNew();
            long sumWatchRecursive = 0;
            long sumWatchIterative = 0;
            for (long i = 0; i < 32767; i++)
            {
                Parallel.Invoke(() => recursive(i), () => iterative(i));

                listBoxRecursive.Items.Add(recursive(i));
                listBoxIterative.Items.Add(iterative(i));

                listBoxRecursive.SelectedIndex = listBoxRecursive.Items.Count - 1;
                listBoxIterative.SelectedIndex = listBoxIterative.Items.Count - 1;

                watchRecursive.Stop();
                labelElapsedRecursive.Text = "Elapsed Time (ms) : " + watchRecursive.ElapsedMilliseconds + " ms";
                sumWatchRecursive += watchRecursive.ElapsedMilliseconds;
                labelTotalRecursive.Text = "Total Time (ms) : " + sumWatchRecursive + " ms";
                watchRecursive = System.Diagnostics.Stopwatch.StartNew();

                watchIterative.Stop();
                labelElapsedIterative.Text = "Elapsed Time (ms) : " + watchIterative.ElapsedMilliseconds + " ms";
                sumWatchIterative += watchIterative.ElapsedMilliseconds;
                labelTotalIterative.Text = "Total Time (ms) : " + sumWatchIterative + " ms";
                watchIterative = System.Diagnostics.Stopwatch.StartNew();

                Wait(100);

                if (stop == true)
                {
                    break;
                }
            }
        }

        bool stop = false;
        private void buttonStop_Click(object sender, EventArgs e)
        {
            stop = true;

            buttonStart.Enabled = true;
        }

        private long recursive(long n)
        {
            if (n <= 1)
            {
                return n;
            }

            return (recursive(n - 1) + recursive(n - 2));
        }

        private long iterative(long n)
        {
            if (n <= 1)
            {
                return n;
            }

            long first = 0;
            long second = 1;
            long sum = 0;
            for (int i = 1; i < n; i++)
            {
                sum = first + second;
                first = second;
                second = sum;
            }
            return sum;
        }

        public void Wait(int ms)
        {
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < ms)
            {
                Application.DoEvents();
            }
        }
    }
}
