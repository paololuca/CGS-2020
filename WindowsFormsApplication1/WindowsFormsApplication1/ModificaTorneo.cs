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
    public partial class ModificaTorneo : Form
    {
        public ModificaTorneo()
        {
            InitializeComponent();

            DisableFields();
        }

        private void DisableFields()
        {
            textBoxNomeTorneo.Enabled = false;
            dateTimePickerDataTorneo.Enabled = false;
            groupBoxDiscipline.Enabled = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //controllo che sia selezionato almeno un torneo
            //load torneo
            //load discipline
            //enable all element to modify
            //set fields (le discipoline esistenti vanno disabilitate)
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //update del torneo
            //update delle discipline se modificate
        }
    }
}
