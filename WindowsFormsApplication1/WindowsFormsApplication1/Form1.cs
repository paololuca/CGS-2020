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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadForm();

            PdfManager pdf = new PdfManager();

            pdf.TestPdfCreation();
        }

        private void loadForm()
        {
            //AddAnagraphicUser a;

            //a = new AddAnagraphicUser();
            //a.Show();

            ModifyAnagrafic m = new ModifyAnagrafic();
            m.Show();
        }
    }
}
