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
    public partial class DeleteTorneo : Form
    {
        public DeleteTorneo()
        {
            InitializeComponent();

            LoadAllTornei();
        }

        private void LoadAllTornei()
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewTornei_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //solito controllo
            //eliminare torneo
            //reload AllTornei
        }
    }
}
