using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factorial
{
    public partial class factorial : Form
    {
        public factorial()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            listBoxRecursive.Items.Clear();
            listBoxIterative.Items.Clear();
            
            for (int i = 0; i < 21; i++)
            {
                Parallel.Invoke(() => recursive(i), () => iterative(i));
                listBoxRecursive.Items.Add(i + "! = " + recursive(i));
                listBoxIterative.Items.Add(i + "! = " + iterative(i));
            }
        }

        private long recursive(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * recursive(n - 1);
        }

        private long iterative(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            long f = 1;
            for (int j = 1; j < n + 1; j++)
            {
                f *= j;
            }
            return f;
        }
    }
}
