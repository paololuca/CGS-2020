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
    public partial class CreaGironiDaDisciplina : Form
    {
        public CreaGironiDaDisciplina()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            List<Torneo> tornei = Helper.GetTorneiAttivi();
            this.comboBox1.DataSource = tornei.ToArray();
            this.comboBox1.ValueMember = "TournamentId";
            this.comboBox1.DisplayMember = "TournamentName";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);

            //La inizializzo a 0
            List<Disciplina> discipline = Helper.GetDisciplineByIdTorneo(0);
            this.comboBox2.DataSource = discipline.ToArray();
            this.comboBox2.ValueMember = "IdDisciplina";
            this.comboBox2.DisplayMember = "Nome";

            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Abort;
        }

        private void ComboBox1_SelectedIndexChanged(object sender,
        System.EventArgs e)
        {
            if ((int)comboBox1.SelectedValue > 0)
            {
                ComboBox comboBox = (ComboBox)sender;

                List<Disciplina> discipline = Helper.GetDisciplineByIdTorneo((int)comboBox1.SelectedValue);

                this.comboBox2.DataSource = discipline.ToArray();
                this.comboBox2.ValueMember = "IdDisciplina";
                this.comboBox2.DisplayMember = "Nome";
            }

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            IdTorneo = (int)comboBox1.SelectedValue;
            IdDisciplina = (int)comboBox2.SelectedValue;

            if ((IdTorneo > 0) && (IdDisciplina > 0))
            {
                NomeTorneo = comboBox1.Text;
                Disciplina = comboBox2.Text;
                this.Close();
            }
            else
            {
                if (MessageBox.Show("Selezionare un Torneo ed una Disciplina per la creazione dei Gironi",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                }
            }


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            IdTorneo = 0;
            IdDisciplina = 0;
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Categoria = "M";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Categoria = "F";
        }
    }
}
