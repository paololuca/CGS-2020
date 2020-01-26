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
    public partial class DeleteTorneo : Form
    {
        public DeleteTorneo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadAllTornei();
        }

        private void LoadAllTornei()
        {
            dataGridViewTornei.DataSource = Helper.GetAllTornei().ToArray();

            dataGridViewTornei.Columns["TournamentId"].Visible = false;
            dataGridViewTornei.Columns["TournamentName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (dataGridViewTornei.ColumnCount <= 5)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dataGridViewTornei.Columns.Add(btn);
                btn.HeaderText = "Elimina";
                btn.Text = "Elimina";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewTornei_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            DataGridView dgv = sender as DataGridView;
            DataGridViewRow row = dataGridViewTornei.Rows[e.RowIndex];

            if (e.ColumnIndex >= 0 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Eliminare il Torneo " + row.Cells["TournamentName"].Value + " ? (verranno cancellate anche tutte le iscrizioni al torneo stesso)",
                                    "Attenzione",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Int32 idTorneo = (int)row.Cells["tournamentId"].Value;

                    if(Helper.EliminaTorneo(idTorneo))
                    {
                        if (Helper.EliminaAtletiVsTorneoVsDiscipline(idTorneo))
                        {
                            if (Helper.EliminaTorneoVsDiscipline(idTorneo))
                            {
                                MessageBox.Show("Torneo ELIMINATO correttamente", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadAllTornei();
                            }
                            else
                                MessageBox.Show("Errore durante la cancellazione delle Discipline del Torneo", "Eroore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Errore durante la cancellazione degli Atleti associati al Torneo", "Eroore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Errore durante la cancellazione del Torneo", "Eroore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
