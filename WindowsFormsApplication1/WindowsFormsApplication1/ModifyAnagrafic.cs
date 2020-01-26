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
        int IdATleta = 0;
        int IdAsd = 0;

        public ModifyAnagrafic()
        {
            InitializeComponent();

            
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
                //search from DB passando in input i parametri di ricerca
                //la qry deve essere modulare
                //carica gridview

                EnableModificationControl();
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
            //qry anagrafica Atleta
            //qry di tutte le asd nel DB
            //selected index della combobox associazioni con l'IdAsd in input
            //riempire
            //  nome
            //  cognome
            //  selezionare sesso
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //recupero 
            //  IdAtleta
            //  IdASD
            //dalla riga selezionata
            FullFillAssociationComboBox(IdATleta, IdAsd);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Update dell'anagrafica dell'atleta
        }
    }
}
