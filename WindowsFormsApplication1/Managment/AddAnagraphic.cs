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
    public partial class AddAnagraphicUser : Form
    {
        public AddAnagraphicUser()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadAllAsd();
        }

        private void LoadAllAsd()
        {
            List<Asd> asd = Helper.GetAllAsd();

            comboBoxAssociation.DataSource = asd.OrderBy(x => x.NomeAsd).ToArray();

            this.comboBoxAssociation.ValueMember = "Id";
            this.comboBoxAssociation.DisplayMember = "NomeAsd";
            this.comboBoxAssociation.SelectedItem = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Atleta newAtleta;

            if (comboBoxAssociation.SelectedIndex < 0)
                MessageBox.Show("Selezionare un'ASD", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (textBoxSurname.Text == "")
                MessageBox.Show("Inserire il Cognome", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (textBoxName.Text == "")
                MessageBox.Show("Selezionare il Nome", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                newAtleta = new Atleta()
                {
                    IdAsd = (int)comboBoxAssociation.SelectedValue,
                    Nome = textBoxName.Text,
                    Cognome = textBoxSurname.Text,
                    Sesso = radioButtonMale.Checked ? "M" : "F"
                };
                int idInserted = Helper.InsertNewAtleta(newAtleta);

                if(idInserted > 0)
                {
                    MessageBox.Show("Atleta inserito correttamente [ID = " + idInserted + "]", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Atleta NON inserito.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
