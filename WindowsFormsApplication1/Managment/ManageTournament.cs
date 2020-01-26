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
    public partial class ManageTournament : Form
    {
        private String Categoria = "M";
        public ManageTournament()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            List<Torneo> tornei = Helper.GetTorneiAttivi();
            this.comboBox1.DataSource = tornei.ToArray();
            this.comboBox1.ValueMember = "TournamentId";
            this.comboBox1.DisplayMember = "TournamentName";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedItem = 0;

            //La inizializzo a 0
            List<Disciplina> discipline = Helper.GetDisciplineByIdTorneo(0);
            this.comboBox2.DataSource = discipline.ToArray();
            this.comboBox2.ValueMember = "IdDisciplina";
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.SelectedItem = 0;

            buttonLoadIscritti.DialogResult = DialogResult.OK;
            buttonClose.DialogResult = DialogResult.Abort;

            buttonPrintList.Enabled = false;
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

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Int32 idTorneo = (int)comboBox1.SelectedValue;
            Int32 idDisciplina = (int)comboBox2.SelectedValue;

            if ((idTorneo > 0) && (idDisciplina > 0))
            {
                LoadPartecipantFromTournament(idTorneo, idDisciplina, Categoria);
                LoadPartecipantOffTournament(idTorneo, idDisciplina, Categoria);
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

        private void LoadPartecipantFromTournament(Int32 idTorneo, Int32 idDisciplina, string categoria)
        {
            List<Atleta> atleti = Helper.GetAtletiIscrittiTorneoVsDisciplina(idTorneo, idDisciplina, categoria);
            

            if ((atleti != null) && (atleti.Count > 0))
            {
                atleti = atleti.OrderByDescending(x => x.Ranking).ThenBy(x => x.Asd).ThenBy(x => x.Cognome).ToList();

                dataGridView1.DataSource = atleti.ToArray();
                dataGridView1.Visible = true;

                InitializegridView();

                lblCount.Text = atleti.Count.ToString();

                btnAddAtleta.Enabled = true;
                buttonPrintList.Enabled = true;

            }
            else
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("Nessun Atelta trovato per il Torneo e la Disciplina Selezionati", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadPartecipantOffTournament(Int32 idTorneo, Int32 idDisciplina, string categoria)
        {
            List<Atleta> atletiOffTournament = Helper.GetAtletiOffTournament(idTorneo, idDisciplina, categoria);
            comboBoxAtletaToAdd.DataSource = atletiOffTournament.OrderBy(x => x.Cognome).ToArray();
            this.comboBoxAtletaToAdd.ValueMember = "IdAtleta";
            this.comboBoxAtletaToAdd.DisplayMember = "FullName";// + " " + "Nome";
            this.comboBoxAtletaToAdd.SelectedItem = 0;
        }

        private void InitializegridView()
        {
            dataGridView1.ReadOnly = true;

            dataGridView1.Columns["IdAtleta"].Visible = false;
            dataGridView1.Columns["IdAsd"].Visible = false;
            dataGridView1.Columns["Sesso"].Visible = false;
            dataGridView1.Columns["FullName"].Visible = false;

            dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;

            if (dataGridView1.ColumnCount <= 8)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btn);
                btn.HeaderText = "Elimina";
                btn.Text = "Elimina";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
            }

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            DataGridView dgv = sender as DataGridView;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (e.ColumnIndex >= 0 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Eliminare dal Torneo " + row.Cells["Cognome"].Value + " " + row.Cells["Nome"].Value + " ?",
                                "Attenzione",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    Int32 idTorneo = (int)comboBox1.SelectedValue;
                    Int32 idDisciplina = (int)comboBox2.SelectedValue;

                    if (Helper.EliminaPartecipanteDaTorneo(idTorneo, idDisciplina, (int)row.Cells["IdAtleta"].Value, Categoria))
                    {
                        LoadPartecipantFromTournament(idTorneo, idDisciplina, Categoria);
                        LoadPartecipantOffTournament(idTorneo, idDisciplina, Categoria);
                        MessageBox.Show("Atleta rimosso correttamente.", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        MessageBox.Show("Atleta NON rimosso.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
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

        private void btnAddAtleta_Click(object sender, EventArgs e)
        {
            Int32 idTorneo = (int)comboBox1.SelectedValue;
            Int32 idDisciplina = (int)comboBox2.SelectedValue;
            Int32 idAtleta = (int)comboBoxAtletaToAdd.SelectedValue;

            if(idAtleta >0 )
            {
                if(Helper.InsertAtletaOnTournament(idTorneo, idDisciplina, idAtleta, Categoria))
                {
                    LoadPartecipantFromTournament(idTorneo, idDisciplina, Categoria);
                    LoadPartecipantOffTournament(idTorneo, idDisciplina, Categoria);
                    MessageBox.Show("Atleta inserito correttamente.", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Atleta NON inserito nel torneo.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Selezionare un Atleta da inserire nel Torneo '" + comboBox1.Text + "' per la disciplina '" + comboBox2.Text + "'",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonPrintList_Click(object sender, EventArgs e)
        {
            PdfManager pdf = new PdfManager();

            Int32 idTorneo = (int)comboBox1.SelectedValue;
            Int32 idDisciplina = (int)comboBox2.SelectedValue;

            pdf.StampaAtletiTorneo(Helper.GetAtletiTorneoVsDisciplina(idTorneo, idDisciplina, Categoria), comboBox1.Text, comboBox2.Text);
        }
    }
}
