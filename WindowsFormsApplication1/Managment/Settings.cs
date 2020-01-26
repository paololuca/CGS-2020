using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Settings : Form
    {
        private bool modified = false;

        public string DbType
        {
            get
            {
                if (rbtFemminile.Checked)
                    return Helper.FEMMINILE;
                else if (rbtMaschile.Checked)
                    return Helper.MASCHILE;
                else
                    return Helper.TEST;
            }
        }

        public bool DegubMode
        {
            get { return chbDebug.Checked; }
        }

        public bool CreationActive
        {
            get { return chbCreazione.Checked; }
        }

        public Settings()
        {
            InitializeComponent();

            ReadConfigFile();
        }

        private void ReadConfigFile()
        {
            rbtTest.Checked = Helper.GetDbType() == Helper.TEST;
            rbtMaschile.Checked = Helper.GetDbType() == Helper.MASCHILE;
            rbtFemminile.Checked = Helper.GetDbType() == Helper.FEMMINILE;

            chbDebug.Checked = ConfigurationManager.AppSettings["Debug"].ToString() == "true";
            chbCreazione.Checked = ConfigurationManager.AppSettings["Creazione"].ToString() == "true";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (modified)
            {
                if (MessageBox.Show("Sicuro di voler uscire senza salvare?",
                                    "Chiusura Applicazione",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void rbtTestFalse_CheckedChanged(object sender, EventArgs e)
        {
            modified = true;
        }

        private void rbtTestTrue_CheckedChanged(object sender, EventArgs e)
        {
            modified = true;
        }

        private void rbtTest_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
