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
    public partial class Finali : Form
    {
        int idTorneo;
        int idDisciplina;

        List<AtletaEliminatorie> campo1;
        List<AtletaEliminatorie> campo2;

        String primo;
        String secondo;
        String terzo;
        String quarto;

        public Finali(List<AtletaEliminatorie> campo1,
                            List<AtletaEliminatorie> campo2,
                            int idTorneo,
                            int idDisciplina)
        {
            this.idTorneo = idTorneo;
            this.idDisciplina = idDisciplina;

            this.campo1 = campo1;
            this.campo2 = campo2;

            InitializeComponent();

            caricaCampo1(campo1);
            caricaCampo2(campo2);
        }

        private void caricaCampo1(List<AtletaEliminatorie> campo)
        {

            List<Incontro> list = new List<Incontro>();

            list.Add(new Incontro()
            {
                IdRosso = campo[0].IdAtleta,
                CognomeRosso = campo[0].Cognome,
                NomeRosso = campo[0].Nome,
                PuntiRosso = 0,
                IdBlu = campo[1].IdAtleta,
                CognomeBlu = campo[1].Cognome,
                NomeBlu = campo[1].Nome,
                PuntiBlu = 0,
            }
            );

            dataGridViewCampo1.DataSource = list.ToArray();
            dataGridViewCampo1.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dataGridViewCampo1_DataBindingComplete);
        }

        private void dataGridViewCampo1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView d = (DataGridView)sender;

            d.Columns["IdBlu"].Visible = false;
            d.Columns["IdRosso"].Visible = false;
            d.Columns["SatrapiaRosso"].Visible = false;
            d.Columns["Satrapiablu"].Visible = false;
            //d.Columns["PrimoSangue"].Visible = false;
        }

        private void caricaCampo2(List<AtletaEliminatorie> campo)
        {

            List<Incontro> list = new List<Incontro>();

            list.Add(new Incontro()
            {
                IdRosso = campo[0].IdAtleta,
                CognomeRosso = campo[0].Cognome,
                NomeRosso = campo[0].Nome,
                PuntiRosso = 0,
                IdBlu = campo[1].IdAtleta,
                CognomeBlu = campo[1].Cognome,
                NomeBlu = campo[1].Nome,
                PuntiBlu = 0,
            }
            );

            dataGridViewCampo2.DataSource = list.ToArray();
            dataGridViewCampo2.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dataGridViewCampo2_DataBindingComplete);
        }

        private void dataGridViewCampo2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView d = (DataGridView)sender;

            d.Columns["IdBlu"].Visible = false;
            d.Columns["IdRosso"].Visible = false;
            d.Columns["SatrapiaRosso"].Visible = false;
            d.Columns["Satrapiablu"].Visible = false;
            //d.Columns["PrimoSangue"].Visible = false;
        }

        private void buttonNextPhase_Click(object sender, EventArgs e)
        {
            Torneo t = Helper.GetTorneoById(idTorneo);
            String nomeDisciplina = Helper.GetDisciplinaById(idDisciplina);

            PdfManager pdf = new PdfManager();
            pdf.FineTorneo(primo, secondo, terzo, quarto, t.TournamentName, nomeDisciplina);
        }


        /** dtgrid index columns
             * [0] IdA
             * [1] AsdA
             * [2] CognomeA
             * [3] NomeA
             * [4] PuntiA
             * [5] IdB
             * [6] AdB
             * [7] CognomeB
             * [8] NomeB
             * [9] PuntiB
             * [10] Primosangue
             * */

        private void buttonSalvaCampo1_Click(object sender, EventArgs e)
        {
            List<AtletaEliminatorie> listAtleti = new List<AtletaEliminatorie>();

            foreach (DataGridViewRow r in dataGridViewCampo1.Rows)
            {
                AtletaEliminatorie vinto = new AtletaEliminatorie();
                AtletaEliminatorie perso = new AtletaEliminatorie();

                if ((int)r.Cells[4].Value > (int)r.Cells[9].Value)
                {
                    vinto.IdAtleta = (int)r.Cells[0].Value;
                    perso.IdAtleta = (int)r.Cells[5].Value;
                    label1.Text = "1° " + r.Cells[2].Value + " " + r.Cells[3].Value + " - 2° " + r.Cells[7].Value + " " + r.Cells[8].Value;
                    primo = r.Cells[2].Value + " " + r.Cells[3].Value;
                    secondo = r.Cells[7].Value + " " + r.Cells[8].Value;
                }
                else
                {
                    vinto.IdAtleta = (int)r.Cells[5].Value;
                    perso.IdAtleta = (int)r.Cells[0].Value;
                    label1.Text = "1° " + r.Cells[7].Value + " " + r.Cells[8].Value + " - 2° " + r.Cells[2].Value + " " + r.Cells[3].Value;
                    secondo = r.Cells[2].Value + " " + r.Cells[3].Value;
                    primo = r.Cells[7].Value + " " + r.Cells[8].Value;
                }

                Helper.UpdateFinali(idTorneo, idDisciplina, 1, 1, (int)r.Cells[0].Value, (int)r.Cells[4].Value, (int)r.Cells[9].Value);
                Helper.UpdateFinali(idTorneo, idDisciplina, 1, 1, (int)r.Cells[5].Value, (int)r.Cells[9].Value, (int)r.Cells[4].Value);

            }

            MessageBox.Show("Campo 1 Salvato correttamente", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSalvaCampo2_Click(object sender, EventArgs e)
        {
            List<AtletaEliminatorie> listAtleti = new List<AtletaEliminatorie>();

            foreach (DataGridViewRow r in dataGridViewCampo2.Rows)
            {
                AtletaEliminatorie vinto = new AtletaEliminatorie();
                AtletaEliminatorie perso = new AtletaEliminatorie();

                if ((int)r.Cells[4].Value > (int)r.Cells[9].Value)
                {
                    vinto.IdAtleta = (int)r.Cells[0].Value;
                    perso.IdAtleta = (int)r.Cells[5].Value;
                    label2.Text = "3° " + r.Cells[2].Value + " " + r.Cells[3].Value + " - 4° " + r.Cells[7].Value + " " + r.Cells[8].Value;
                    terzo = r.Cells[2].Value + " " + r.Cells[3].Value;
                    quarto = r.Cells[7].Value + " " + r.Cells[8].Value;
                }
                else
                {
                    vinto.IdAtleta = (int)r.Cells[5].Value;
                    perso.IdAtleta = (int)r.Cells[0].Value;
                    label2.Text = "3° " + r.Cells[7].Value + " " + r.Cells[8].Value + " - 4° " + r.Cells[2].Value + " " + r.Cells[3].Value;
                    quarto = r.Cells[2].Value + " " + r.Cells[3].Value;
                    terzo = r.Cells[7].Value + " " + r.Cells[8].Value;
                }

                Helper.UpdateFinali(idTorneo, idDisciplina, 1, 1, (int)r.Cells[0].Value, (int)r.Cells[4].Value, (int)r.Cells[9].Value);
                Helper.UpdateFinali(idTorneo, idDisciplina, 1, 1, (int)r.Cells[5].Value, (int)r.Cells[9].Value, (int)r.Cells[4].Value);

            }

            MessageBox.Show("Campo 2 Salvato correttamente", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonStampa_Click(object sender, EventArgs e)
        {
            PdfManager pdf = new PdfManager();
            pdf.StampaFinali(campo1, campo2);
        }
    }
}
