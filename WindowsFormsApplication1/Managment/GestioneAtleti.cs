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
    public partial class EliminaAtleti : Form
    {
        public EliminaAtleti()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadListAtleti();
        }


        private void LoadListAtleti()
        {
            List<Atleta> atletiPresenti = Helper.GetAllAnagraficaAtletiWithRanking();

            dataGridView1.DataSource = atletiPresenti.ToArray();

            dataGridView1.Columns["FullName"].Visible = false;
            dataGridView1.Columns["IdAtleta"].Visible = false;
            dataGridView1.Columns["IdAsd"].Visible = false;

            dataGridView1.Columns["Asd"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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

            lblNumber.Text = atletiPresenti.Count.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            DataGridView dgv = sender as DataGridView;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (e.ColumnIndex >= 0 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here

                if (MessageBox.Show("Eliminare l'anagrafica di " + row.Cells["Cognome"].Value + " " + row.Cells["Nome"].Value + " ?",
                                    "Attenzione",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int idAtleta = (int)row.Cells["IdAtleta"].Value;

                    Helper.EliminaAtleta(idAtleta);
                    Helper.EliminaAtletaDaGironi(idAtleta);
                    Helper.EliminaAtletaDaTorneo(idAtleta);
                    Helper.EliminaAtletaDaRanking(idAtleta);

                    LoadListAtleti();
                }
            }
        }
    }
}
