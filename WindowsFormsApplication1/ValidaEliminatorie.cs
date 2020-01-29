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
    public partial class ValidaEliminatorie : Form
    {

        Int32 idTorneo = 0;
        Int32 idDisciplina = 0;
        Int32 atletiAmmessiEliminatorie;

        public ValidaEliminatorie(Int32 idTorneo, Int32 idDisciplina,Int32 atletiAmmessiEliminatorie)
        {

            this.idTorneo = idTorneo;
            this.idDisciplina = idDisciplina;
            this.atletiAmmessiEliminatorie = atletiAmmessiEliminatorie;

            InitializeComponent();

            buttonConferma.DialogResult = DialogResult.OK;
            buttonAnnulla.DialogResult = DialogResult.Abort;

            CaricaAtletiPostGironi();
        }

        private void CaricaAtletiPostGironi()
        {
            List<GironiConclusi> gironiConclusi = Helper.GetClassificaGironi(idTorneo, idDisciplina);

            for (int i = 0; i < atletiAmmessiEliminatorie; i++)
                gironiConclusi[i].Qualificato = true;

            labelStatus.Text = " Selezionati "+ atletiAmmessiEliminatorie + " Atleti per la fase successiva";

            dataGridView1.DataSource = gironiConclusi.ToArray();

            dataGridView1.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dataGridView1_DataBindingComplete);

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView d = (DataGridView)sender;

            d.Columns["IdTorneo"].Visible = false;
            d.Columns["IdDisciplina"].Visible = false;
            d.Columns["IdGirone"].Visible = false;
            d.Columns["IdAtleta"].Visible = false;
            d.Columns["Posizionamento"].Visible = false;

            d.Columns["Vittorie"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            d.Columns["Vittorie"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            d.Columns["Sconfitte"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            d.Columns["Sconfitte"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            d.Columns["PuntiFatti"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            d.Columns["PuntiFatti"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            d.Columns["PuntiSubiti"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            d.Columns["PuntiSubiti"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void buttonConferma_Click(object sender, EventArgs e)
        {

            if (CountSelectedRowInDataGrid() != atletiAmmessiEliminatorie)
            {
                MessageBox.Show("Il numero di atleti selezionati non è "+ atletiAmmessiEliminatorie + ": controllare la lista", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<AtletaEliminatorie> listaQualificati = new List<AtletaEliminatorie>();
                int posizione = 1;
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if(((bool)r.Cells[0].Value == true ) && posizione <= atletiAmmessiEliminatorie)
                    {
                        listaQualificati.Add(new AtletaEliminatorie()
                        {
                            IdAtleta = (int)r.Cells[4].Value,
                            IdTorneo = (int)r.Cells[1].Value,
                            idDisciplina = (int)r.Cells[2].Value,
                            Posizione = posizione
                        }
                            );
                        posizione++;
                    }
                }

                Helper.DeleteAllSedicesimi(idTorneo, idDisciplina);
                Helper.DeleteAllOttavi(idTorneo, idDisciplina);
                Helper.DeleteAllQuarti(idTorneo, idDisciplina);
                Helper.DeleteAllSemifinali(idTorneo, idDisciplina);
                Helper.DeleteAllFinali(idTorneo, idDisciplina);
                //Helper.RestartAfterGironi();

                if (atletiAmmessiEliminatorie == 32)
                    Helper.InsertSedicesimi(listaQualificati);
                else if (atletiAmmessiEliminatorie == 16)
                    Helper.InsertOttavi(listaQualificati);
                else if (atletiAmmessiEliminatorie == 8)
                    Helper.InsertQuarti(listaQualificati);
                else if (atletiAmmessiEliminatorie == 4)
                    Helper.InsertSemifinali(SetCampoForSemifinali(listaQualificati));

                Helper.ConcludiGironi(idTorneo, idDisciplina);

                //va fatta la lista di output per la generazione degli incontri
                //in realtà qui salvo semplicemente i dati sui Qualificati 'atletiAmmessiEliminatorie'
                //poi la form1 li carica e genera gli incontri diretti

                this.Close();
            }
        }

        private List<AtletaEliminatorie> SetCampoForSemifinali(List<AtletaEliminatorie> listaQualificati)
        {
            listaQualificati[0].Campo = 1;
            listaQualificati[3].Campo = 1;
            listaQualificati[1].Campo = 2;
            listaQualificati[2].Campo = 2;

            return listaQualificati;
        }

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex > -1)
            {
                DataGridView dgv = sender as DataGridView;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[0].Value = !(bool)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                    int numeroAtletiSelezionati = CountSelectedRowInDataGrid();

                    labelStatus.Text = " Selezionati " + numeroAtletiSelezionati + " Atleti per la fase successiva";
                }
            }
        }

        private int CountSelectedRowInDataGrid()
        {
            int i = 0;

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                i += (bool)r.Cells[0].Value == true ? 1 : 0;
            }

            return i;
        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            PdfManager pdf = new PdfManager();
            pdf.StampaRisultatiGironi(
                dataGridView1, 
                Helper.GetTorneoById(this.idTorneo).TournamentName,
                Helper.GetDisciplinaById(this.idDisciplina));
        }
    }
}
