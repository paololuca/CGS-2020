using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ProgressBar : Form
    {
        public Int32 min = 1;
        public Int32 max = 0;
        public ProgressBar()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void InizializeProgressBar(Int32 min, Int32 max)
        {
            progressBar1.Minimum = min;
            progressBar1.Maximum = max;
        }

        public void IncrementProgressBar(int progressCount)
        {
            progressBar1.Value = progressCount;
        }

        public void SetProgressBarTitle(string title)
        {
            this.Text = title;
        }
    }
}
