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
    public partial class ModifyAnagrafic : Form
    {
        int IdAtleta = 0;
        int IdAsd = 0;

        public ModifyAnagrafic()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String nome = textBoxName.Text;
            String cognome = textBoxSurname.Text;
            
            if((nome == "") && (cognome == ""))
            {
                MessageBox.Show("Inserire almeno un NOME o un COGNOME per la ricerca", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Search(nome, cognome);
            }
        }

        private void Search(String nome, String cognome)
        {
            List<Atleta> atleti = Helper.GetAtletiFromNameAndSurname(nome, cognome);

            if (atleti != null)
            {

                dataGridView1.DataSource = atleti.ToArray();
                dataGridView1.Columns["IdAtleta"].Visible = false;
                dataGridView1.Columns["IdAsd"].Visible = false;
                //dataGridView1.Columns["Asd"].Visible = false;
                dataGridView1.Columns["Ranking"].Visible = false;
                dataGridView1.Columns["FullNAme"].Visible = false;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;


                FullFillAssociationComboBox((int)dataGridView1.Rows[0].Cells["IdAtleta"].Value,
                                            (int)dataGridView1.Rows[0].Cells["IdAsd"].Value);

                textBoxNewName.Text = (String)dataGridView1.Rows[0].Cells["Nome"].Value;
                textBoxNewSurname.Text = (String)dataGridView1.Rows[0].Cells["Cognome"].Value;

                radioButtonFemale.Checked = ((String)dataGridView1.Rows[0].Cells["Sesso"].Value).Remove(1) == "F" ? true : false;
                radioButtonMale.Checked = ((String)dataGridView1.Rows[0].Cells["Sesso"].Value).Remove(1) == "M" ? true : false;

                EnableModificationControl();
                buttonSave.Enabled = true;
            }
        }

        private void EnableModificationControl()
        {
            textBoxNewSurname.Enabled = true;
            textBoxNewName.Enabled = true;
            groupBoxGender.Enabled = true;
            comboBoxNewAssociation.Enabled = true;
        }

        private void FullFillAssociationComboBox(Int32 idAtleta, Int32 idAsd)
        {
            List<Asd> allAsd = Helper.GetAllAsd();
            comboBoxNewAssociation.DataSource = allAsd.ToArray();
            comboBoxNewAssociation.ValueMember = "Id";
            this.comboBoxNewAssociation.DisplayMember = "NomeAsd";
            comboBoxNewAssociation.SelectedIndex = allAsd.IndexOf(allAsd.First(x => x.Id == IdAsd));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //recupero 
            //  IdAtleta
            //  IdASD
            //dalla riga selezionata
            var senderGrid = (DataGridView)sender;

            DataGridView dgv = sender as DataGridView;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            IdAtleta = (int)row.Cells["IdAtleta"].Value;
            IdAsd = (int)row.Cells["IdAsd"].Value;

            textBoxNewName.Text = (String)row.Cells["Nome"].Value;
            textBoxNewSurname.Text = (String)row.Cells["Cognome"].Value;

            radioButtonFemale.Checked = ((String)row.Cells["Sesso"].Value).Remove(1) == "F" ? true : false;
            radioButtonMale.Checked = ((String)row.Cells["Sesso"].Value).Remove(1) == "M" ? true : false;


            FullFillAssociationComboBox(IdAtleta, IdAsd);
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String newName = textBoxNewName.Text;
            String newSurname = textBoxNewSurname.Text;
            String sesso = radioButtonMale.Checked ? "M" : "F";

            IdAsd = (int)comboBoxNewAssociation.SelectedValue;

            Atleta a = new Atleta()
            {
                IdAsd = IdAsd,
                IdAtleta = IdAtleta,
                Nome = newName,
                Cognome = newSurname,
                Sesso = sesso
            };

            if (Helper.UpdateAngraficDataByAtleta(a))
            {
                MessageBox.Show("Anagrafica aggiornata correttamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Search(textBoxName.Text, textBoxSurname.Text);
            }
            else
                MessageBox.Show("Anagrafica non aggiornata", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
