using Microsoft.Office.Interop.Excel;
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
    public partial class ReportRisultatiTorneo : Form
    {
        private int _idTorneo;
        private int _idDisciplina;
        private string _categoria;
        public ReportRisultatiTorneo(int idTorneo, int idDisciplina, string categoria)
        {
            _idTorneo = idTorneo;
            _idDisciplina = idDisciplina;
            _categoria = categoria;

            InitializeComponent();

            FullFillDatagrid();
        }

        private void FullFillDatagrid()
        {
            List<OutputRisultatiTorneo> risultatiGironi = Helper.GetExportGironiTorneo(_idTorneo, _idDisciplina, _categoria);
            if (risultatiGironi != null)
            {
                dataGridViewGironi.DataSource = risultatiGironi.ToArray();
                //lblTotal.Text = "Totale Incontri Gironi : " + risultatiGironi.Count;
            }

            List<GironiConclusi> gironiConclusi = Helper.GetClassificaGironi(_idTorneo, _idDisciplina);
            if (gironiConclusi != null)
            {
                dataGridViewPostGironi.DataSource = gironiConclusi.ToArray();
                dataGridViewPostGironi.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dataGridViewPostGironi_DataBindingComplete);
            }

            List<OutputRisultatiEliminatorieTorneo> risultatiSedicesimi = Helper.GetExportSedicesimiTorneo(_idTorneo, _idDisciplina, _categoria);
            if(risultatiSedicesimi != null)
                dataGridViewSedicesimi.DataSource = risultatiSedicesimi.ToArray();

            List<OutputRisultatiEliminatorieTorneo> risultatiOttavi = Helper.GetExportOttaviTorneo(_idTorneo, _idDisciplina, _categoria);
            if (risultatiOttavi != null)
                dataGridViewOttavi.DataSource = risultatiOttavi.ToArray();

            List<OutputRisultatiEliminatorieTorneo> risultatiQuarti = Helper.GetExportQuartiTorneo(_idTorneo, _idDisciplina, _categoria);
            if (risultatiQuarti != null)
                dataGridViewQuarti.DataSource = risultatiQuarti.ToArray();

            List<OutputRisultatiEliminatorieTorneo> risultatiSemifinali = Helper.GetExportSemifinaliTorneo(_idTorneo, _idDisciplina, _categoria);
            if (risultatiSemifinali != null)
                dataGridViewSemifinali.DataSource = risultatiSemifinali.ToArray();

            List<OutputRisultatiEliminatorieTorneo> risultatiFinali = Helper.GetExportFinaliTorneo(_idTorneo, _idDisciplina, _categoria);
            if (risultatiFinali != null)
                dataGridViewFinali.DataSource = risultatiFinali.ToArray();

        }

        private void dataGridViewPostGironi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView d = (DataGridView)sender;

            d.Columns["Qualificato"].Visible = false;
            d.Columns["IdTorneo"].Visible = false;
            d.Columns["IdDisciplina"].Visible = false;
            d.Columns["Posizionamento"].Visible = false;
            //d.Columns["PrimoSangue"].Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                excel.SheetsInNewWorkbook = 7;

                workbook = excel.Workbooks.Add();           

                worksheet = workbook.Worksheets[1];

                worksheet.Name = "Gironi";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                #region Gironi
                //Loop through gironi
                for (int j = 0; j < dataGridViewGironi.Columns.Count; j++)
                {
                    // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                    worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridViewGironi.Columns[j].HeaderText;
                    cellColumnIndex++;
                }
                cellRowIndex++;
                cellColumnIndex = 1;
                for (int i = 0; i < dataGridViewGironi.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewGironi.Columns.Count; j++)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridViewGironi.Rows[i].Cells[j].Value.ToString();
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }
                #endregion

                #region Classifica post gironi
                worksheet = workbook.Sheets[2];
                worksheet.Name = "PostGironi";
                cellRowIndex = 1;
                cellColumnIndex = 1;
                //TODO
                //Loop through Sedicesimi
                for (int j = 0; j < dataGridViewPostGironi.Columns.Count; j++)
                {
                    // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                    worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridViewPostGironi.Columns[j].HeaderText;
                    cellColumnIndex++;
                }
                cellRowIndex++;
                cellColumnIndex = 1;
                for (int i = 0; i < dataGridViewPostGironi.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewPostGironi.Columns.Count; j++)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridViewPostGironi.Rows[i].Cells[j].Value.ToString();
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }
                #endregion

                #region sedicesimi
                worksheet = workbook.Sheets[3];
                worksheet.Name = "Sedicesimi";
                cellRowIndex = 1;
                cellColumnIndex = 1;

                //Loop through Sedicesimi
                for (int j = 0; j < dataGridViewSedicesimi.Columns.Count; j++)
                {
                    // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                    worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridViewSedicesimi.Columns[j].HeaderText;
                    cellColumnIndex++;
                }
                cellRowIndex++;
                cellColumnIndex = 1;
                for (int i = 0; i < dataGridViewSedicesimi.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewSedicesimi.Columns.Count; j++)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridViewSedicesimi.Rows[i].Cells[j].Value.ToString();
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }
                #endregion

                #region ottavi
                worksheet = workbook.Sheets[4];
                worksheet.Name = "Ottavi";
                cellRowIndex = 1;
                cellColumnIndex = 1;

                //Loop through Ottavi
                for (int j = 0; j < dataGridViewOttavi.Columns.Count; j++)
                {
                    // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                    worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridViewOttavi.Columns[j].HeaderText;
                    cellColumnIndex++;
                }
                cellRowIndex++;
                cellColumnIndex = 1;
                for (int i = 0; i < dataGridViewOttavi.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewOttavi.Columns.Count; j++)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridViewOttavi.Rows[i].Cells[j].Value.ToString();
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }
                #endregion

                #region Quarti
                worksheet = workbook.Sheets[5];
                worksheet.Name = "Quarti";
                cellRowIndex = 1;
                cellColumnIndex = 1;

                //Loop through Ottavi
                for (int j = 0; j < dataGridViewQuarti.Columns.Count; j++)
                {
                    // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                    worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridViewQuarti.Columns[j].HeaderText;
                    cellColumnIndex++;
                }
                cellRowIndex++;
                cellColumnIndex = 1;
                for (int i = 0; i < dataGridViewQuarti.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewQuarti.Columns.Count; j++)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridViewQuarti.Rows[i].Cells[j].Value.ToString();
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }
                #endregion

                #region Semifinali
                worksheet = workbook.Sheets[6];
                worksheet.Name = "Semifinali";
                cellRowIndex = 1;
                cellColumnIndex = 1;

                //Loop through Semifinali
                for (int j = 0; j < dataGridViewSemifinali.Columns.Count; j++)
                {
                    // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                    worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridViewSemifinali.Columns[j].HeaderText;
                    cellColumnIndex++;
                }
                cellRowIndex++;
                cellColumnIndex = 1;
                for (int i = 0; i < dataGridViewSemifinali.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewSemifinali.Columns.Count; j++)
                    {  
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridViewSemifinali.Rows[i].Cells[j].Value.ToString();
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }
                #endregion

                #region Finali
                worksheet = workbook.Sheets[7];
                worksheet.Name = "Finali";
                cellRowIndex = 1;
                cellColumnIndex = 1;

                //Loop through Finali 
                for (int j = 0; j < dataGridViewFinali.Columns.Count; j++)
                {
                    // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                    worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridViewFinali.Columns[j].HeaderText;
                    cellColumnIndex++;
                }
                cellRowIndex++;
                cellColumnIndex = 1;
                for (int i = 0; i < dataGridViewFinali.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewFinali.Columns.Count; j++)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridViewFinali.Rows[i].Cells[j].Value.ToString();
                        
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }
                #endregion


                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";  //|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;
                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export completato con successo", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
    }
}
