using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
