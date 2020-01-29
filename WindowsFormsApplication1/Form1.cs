using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        int faseSuccessiva = 32;    //inizialmente passano i primi 32

        bool debug = ConfigurationManager.AppSettings["Debug"].ToString() == "true";

        CreaGironiDaDisciplina creaGironi = null;

        CaricaGironiDaDisciplina caricaGironi = null;
        CaricaGironiDaDisciplina caricaSedicesimi = null;
        CaricaGironiDaDisciplina caricaOttavi = null;
        CaricaGironiDaDisciplina caricaQuarti = null;
        CaricaGironiDaDisciplina caricaSemifinali = null;
        CaricaGironiDaDisciplina caricaFinali = null;
        CaricaGironiDaDisciplina risultatiTorneo = null;

        //Lista degli atleti
        private List<Atleta> partecipantiTorneo = null;
        private int numeroAtletiTorneoDisciplina = 0;
        private int atletiAmmessiEliminatorie = 0;
        //Sono i gironi
        //la struttura è una lista che contiene liste di persone, appunto i partecipanti al girone
        List<List<Atleta>> gironi = new List<List<Atleta>>();
        //Lista degli scontri per girone
        List<List<Incontro>> gironiIncontri = null;

        private int numeroGironi = 0;

        internal System.Windows.Forms.StatusBar statusBar;
        private TreeNode previousSelectedNode;
        private String nomeTorneo;

        public static Form1 Form1Instance;

        public Form1()
        {
            if (Helper.TestConnectionString())
            {

                //Everyone eveywhere in the app should know me as Form1.Form1Instance
                Form1Instance = this;

                //Carica i dati
                InitializeComponent();
                //Inizializzo la barra di stato
                InitializeStatusBar();

                //se ho già creato tutti i gironi non li faccio più creare
                creaToolStripMenuItem.Enabled = ConfigurationManager.AppSettings["Creazione"].ToString() == "true";

                buttonNextFase.Enabled = false;

                this.FormClosing += new FormClosingEventHandler(form1_FormClosed);
            }
            else
            {
                if (MessageBox.Show("Si è verificato un errore durante la connessione al DB \r\nContattare un amministratore",
                                "ERRORE Applicazione",
                                MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    ///TODO disabilitare tutti i comandi ed abilitare solo 
                    ///--la possibilità di riprovare la connessione
                    ///--uscire dal programma
                    ///--menù '?'
                    ///se la connesssione funziona allora abilitare tutto e partire, altrimenti nisba e riprovare
                    ///
                    this.Close();
                }
            }

        }

        private void InitializeTreeView()
        {
            foreach (TreeNode t in treeView1.Nodes)
                treeView1.Nodes.Remove(t);

            treeView1.BeginUpdate();
            if (treeView1.Nodes.Count > 0)
                treeView1.Nodes[0].Remove();
            treeView1.Nodes.Add("Torneo");
            treeView1.EndUpdate();
        }

        #region action

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (previousSelectedNode != null)
            {
                previousSelectedNode.BackColor = treeView1.BackColor;
                previousSelectedNode.ForeColor = treeView1.ForeColor;
            }

            tabControl1.SelectTab(e.Node.Index);

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sicuro di voler uscire?",
                                "Chiusura Applicazione",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                Application.Exit();
            }
        }


        #endregion

        #region statusBar

        private void InitializeStatusBar()
        {
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            //this.statusBar.Location = new System.Drawing.Point(0, 138);
            this.statusBar.Name = "statusBar";
            this.statusBar.ShowPanels = true;
            //this.statusBar.Size = new System.Drawing.Size(292, 24);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 1;
            // 
            // StatusBarExample
            // 
            //this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            //this.ClientSize = new System.Drawing.Size(292, 162);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                      this.statusBar});
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            //this.Name = "StatusBarExample";
            //this.Text = "StatusBar Example";
            this.Load += new System.EventHandler(this.StatusBarExample_Load);
            this.ResumeLayout(false);

        }


        private void StatusBarExample_Load(object sender, System.EventArgs e)
        {
            if (Helper.TestConnectionString())
            {
                StatusBarPanel pnlStatus = new StatusBarPanel();
                pnlStatus.Text = "Ready";
                //pnlStatus.Icon = new Icon(Application.StartupPath + "\\online.ico");
                pnlStatus.AutoSize = StatusBarPanelAutoSize.Contents;
                string dbType = Helper.GetDbType();

                StatusBarPanel pnlConnection = new StatusBarPanel();
                pnlConnection.Text = "Connected to " + "DB " + dbType + " [Ver: " + Helper.GetDbVersion() + "] ";
                pnlConnection.AutoSize = StatusBarPanelAutoSize.Spring;

                StatusBarPanel pnlTournamentInfo = new StatusBarPanel();
                pnlTournamentInfo.Text = "";
                pnlTournamentInfo.AutoSize = StatusBarPanelAutoSize.Spring;

                statusBar.Panels.Add(pnlStatus);
                statusBar.Panels.Add(pnlConnection);
                statusBar.Panels.Add(pnlTournamentInfo);
            }
        }

        

        #endregion



        /// <summary>
        /// Costruisce il tab dello specifico del girone
        /// </summary>
        /// <param name="title">Titolo del TAB</param>
        /// <param name="g">lista dei giroi (lista di persone)</param>
        /// <param name="l">Lista degli incontri</param>
        /// <returns></returns>
        private TabPage elaboraTab(string title, List<Atleta> g, List<Incontro> l, Int32 tabIndex)
        {
            TabPage myTabPage = new TabPage(title);
            //myTabPage.Controls.Add(new Button());

            Button saveButton = new Button();

            Label label1 = new Label();
            Label label2 = new Label();
            Label hiddenId = new Label();
            // 
            // tabPage3
            // 
            myTabPage.Controls.Add(label2);
            myTabPage.Controls.Add(label1);
            myTabPage.Controls.Add(saveButton);
            myTabPage.Location = new System.Drawing.Point(4, 22);
            myTabPage.Padding = new System.Windows.Forms.Padding(3);
            myTabPage.Size = new System.Drawing.Size(735, 485);
            myTabPage.UseVisualStyleBackColor = true;
            //
            // SaveButton
            //
            saveButton.Text = "Salva girone " + tabIndex.ToString();
            saveButton.AutoSize = true;
            saveButton.Location = new Point(700, 35);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 35);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 104);
            label2.TabIndex = 1;
            label2.Text = "";

            foreach (Atleta a in g)
            {
                label2.Text += "[" + a.Asd + "] " + a.Cognome + " " + a.Nome + "\r\n";
                hiddenId.Text += a.IdAtleta + ";";
            }

            hiddenId.Text = hiddenId.Text.Substring(0, hiddenId.Text.Length - 1);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 13);
            label1.TabIndex = 0;
            label1.Text = "Atleti:";
            label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));

            DataGridView dg = new DataGridView();
            dg.Location = new System.Drawing.Point(7, 150);
            dg.Size = new System.Drawing.Size(780, 300);

            if (l != null)

            {
                dg.DataSource = l.ToArray();
                dg.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dataGridView1_DataBindingComplete);
                saveButton.Click += new System.EventHandler(this.saveGirone_Click);
                myTabPage.Controls.Add(dg);
            }

            hiddenId.Location = new System.Drawing.Point(1000, 1000);
            myTabPage.Controls.Add(hiddenId);
            return myTabPage;
        }

        private void saveGirone_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            int indexGirone = Convert.ToInt32(b.Text.Substring(12)) - 1;

            if (debug)
                textBox1.AppendText("Selezionato il tab " + indexGirone.ToString() + "\r\n");

            TabPage t = tabControl1.TabPages[indexGirone];

            DataGridView dtView = (DataGridView)t.Controls[3];

            string labelIdAtleti = ((Label)t.Controls[4]).Text;
            List<Int32> idAtleti = labelIdAtleti.Split(';').Select(Int32.Parse).ToList();

            if (debug)
                textBox1.AppendText("Numero incontri : " + dtView.RowCount.ToString() + "\r\n");

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
             * [10] DoppiaMorte 
             * 
             * */


            if (debug)
                foreach (DataGridViewRow r in dtView.Rows)
                {
                    textBox1.AppendText("Incontro : " +
                                        r.Cells[0].Value + " " + r.Cells[2].Value +
                                        " VS " +
                                        r.Cells[5].Value + " " + r.Cells[7].Value +
                                        "[ " + r.Cells[4].Value + " : " + r.Cells[9].Value + " ]" + "\r\n");

                }

            List<RisultatiIncontriGironi> risultati = new List<RisultatiIncontriGironi>();

            int numeroIncontriAdPersonam = idAtleti.Count - 1;

            foreach (Int32 atleta in idAtleti)
            {
                RisultatiIncontriGironi res = new RisultatiIncontriGironi();

                res.idAtleta = atleta;

                foreach (DataGridViewRow r in dtView.Rows)
                {
                    bool doppiaMorte = (bool)r.Cells[10].Value;

                    if (!Helper.UpdateGironiIncontri(caricaGironi.IdTorneo, caricaGironi.IdDisciplina, indexGirone + 1, (int)r.Cells[0].Value, (int)r.Cells[4].Value, (int)r.Cells[5].Value, (int)r.Cells[9].Value, doppiaMorte))
                        MessageBox.Show("Errore di salvataggio nella tabella GironiIncontri:\n\n non ti preoccupare funziona uguale, ma chiama PL", "ATTENZIONE: PL REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if ((int)r.Cells[0].Value == atleta) //se sono l'atleta a "sinistra"
                    {
                        if (doppiaMorte)
                        {
                            res.Sconfitte++;
                            res.PuntiSubiti += Math.Abs(3-(int)r.Cells[4].Value);
                        }
                        else
                        {
                            //HO VINTO con 3 o più punti
                            if (((int)r.Cells[4].Value >= 3) && (int)r.Cells[4].Value > (int)r.Cells[9].Value)
                            {
                                res.Vittorie++;
                                res.PuntiFatti += (int)r.Cells[4].Value;// > 3 ? 3 : (int)r.Cells[4].Value;
                                res.PuntiSubiti += (int)r.Cells[9].Value;
                            }

                            //HO PERSO (l'avversario ha vinto con più di tre punti
                            else if (((int)r.Cells[4].Value < (int)r.Cells[9].Value) && ((int)r.Cells[9].Value >= 3))
                            {
                                res.PuntiFatti += (int)r.Cells[4].Value;
                                res.PuntiSubiti += (int)r.Cells[9].Value;// > 3 ? 3 : (int)r.Cells[9].Value;
                                res.Sconfitte++;
                            }

                            else if (((int)r.Cells[9].Value < 3) && ((int)r.Cells[4].Value < 3))
                            {
                                if ((int)r.Cells[4].Value > (int)r.Cells[9].Value)
                                    res.Vittorie++;
                                else if ((int)r.Cells[4].Value < (int)r.Cells[9].Value)
                                    res.Sconfitte++;

                                res.PuntiFatti += (int)r.Cells[4].Value;
                                res.PuntiSubiti += (int)r.Cells[9].Value;

                            }
                        }
                    }
                    else if ((int)r.Cells[5].Value == atleta)   //se sono l'atleta a "destra"
                    {
                        if (doppiaMorte)
                        {
                            res.Sconfitte++;
                            res.PuntiSubiti += Math.Abs(3 - (int)r.Cells[9].Value);
                        }

                        else
                        {
                            //HO vinto con più di 3 punti
                            if (((int)r.Cells[9].Value > (int)r.Cells[4].Value) && ((int)r.Cells[9].Value >= 3))
                            {
                                res.Vittorie++;
                                res.PuntiFatti += (int)r.Cells[9].Value;// > 3 ? 3 : (int)r.Cells[9].Value;
                                res.PuntiSubiti += (int)r.Cells[4].Value;
                            }
                            //HO PERSO (l'avversario ha vinto con più di tre punti
                            else if (((int)r.Cells[9].Value < (int)r.Cells[4].Value) && ((int)r.Cells[4].Value >= 3))
                            {
                                res.PuntiFatti += (int)r.Cells[9].Value;
                                res.PuntiSubiti += (int)r.Cells[4].Value;// > 3 ? 3 : (int)r.Cells[4].Value;
                                res.Sconfitte++;
                            }
                            
                            else if (((int)r.Cells[4].Value < 3) && ((int)r.Cells[9].Value < 3))
                            {
                                if ((int)r.Cells[4].Value < (int)r.Cells[9].Value)
                                    res.Vittorie++;
                                else if ((int)r.Cells[4].Value > (int)r.Cells[9].Value)
                                    res.Sconfitte++;

                                res.PuntiFatti += (int)r.Cells[9].Value;
                                res.PuntiSubiti += (int)r.Cells[4].Value;
                            }
                        }
                    }
                }

                int delpaP = res.PuntiFatti - res.PuntiSubiti;
                res.NumeroIncontriDisputati = numeroIncontriAdPersonam;

                res.Differenziale = (Double)(delpaP + res.Vittorie) / res.NumeroIncontriDisputati;

                //salvare res in Gironi:
                //per ogni atleta , torneo e disciplina salvo i punti fatti, subiti, le vittorie ed il differenziale
                Helper.UpdateGironi(res, caricaGironi.IdTorneo, caricaGironi.IdDisciplina, indexGirone + 1);

                risultati.Add(res);
            }

            MessageBox.Show("Girone " + (indexGirone + 1) + " salvato correttamente", "Completato", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Binding, style and columns visibile for any datagridview in the tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView d = (DataGridView)sender;

            d.Columns["IdBlu"].Visible = false;
            d.Columns["IdRosso"].Visible = false;
            d.Columns["SatrapiaRosso"].Visible = false;
            d.Columns["Satrapiablu"].Visible = false;
            d.Columns["PuntiRosso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            d.Columns["PuntiBlu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            d.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        void creaGironi_FormClosed(object sender, FormClosingEventArgs e)
        {
            if ((sender as Form).DialogResult == DialogResult.None)
            {
                // Then assume that X has been clicked and act accordingly.
            }
            else if ((sender as Form).DialogResult == DialogResult.OK)
            {
                if (creaGironi != null)
                {
                    if ((creaGironi.IdDisciplina > 0) && (creaGironi.IdTorneo > 0))
                    {
                        textBox1.AppendText("[TORNEO] --> " + creaGironi.NomeTorneo + "\r\n");
                        textBox1.AppendText("[DISCIPLINA] --> " + creaGironi.Disciplina + "\r\n");
                        textBox1.AppendText("[CATEGORIA] --> " + (creaGironi.Categoria == "M" ? "Mascile" : "Femminile") + "\r\n");
                        //TODO solo se non ci sono già gironi attivi (e cioè in stato 0 per quel torneo e disciplina)
                        creaAtletiDaForm(creaGironi.IdTorneo, creaGironi.IdDisciplina, creaGironi.Categoria);
                    }
                }
            }
            else if ((sender as Form).DialogResult == DialogResult.Abort)
            {
                // Then assume that Cancel Button has been clicked and act accordingly.)
            }
        }
        private void creaAtletiDaForm(int idTorneo, int idDisciplina, String categoria)
        {

            //loadToolStripMenuItem.Enabled = false;      //Non permetto più di caricare i dati (in teoria va fatto meglio)

            //partecipantiTorneo = CaricaAtleti();

            // i dati in lettura vanno fatti caricando la disciplina dal DB (divisione per disciplina)
            //se sono in presenza degli assoluti, per ora, carico i dati ordinati solo per ranking e senza random dei nomi all'interno delle ASD
            //partecipantiTorneo = assoluti == false ?
            //                                    Helper.GetAtletiTorneoVsDisciplina(idTorneo, idDisciplina, categoria) :
            //                                    Helper.GetAtletiTorneoVsDisciplinaAssoluti(idTorneo, idDisciplina, categoria);

            partecipantiTorneo = Helper.GetAtletiTorneoVsDisciplinaAssoluti(idTorneo, idDisciplina, categoria);

            //TODO: da parametrizzare
            

            bool rankingEnabled = partecipantiTorneo.Sum(x => x.Ranking) != 0;


            InitializeTreeView();

            numeroGironi = Helper.GetNumeroGironiByTorneoDisciplina(idTorneo, idDisciplina, categoria);
            textBox1.AppendText("[NUMERO GIRONI] --> " + numeroGironi + "\r\n");


            if (numeroGironi > 0)
            {
                gironi = new List<List<Atleta>>();

                //Setting delle strutture dati
                for (int i = 0; i < numeroGironi; i++)
                {
                    //Per ogni girone creo la lista, vuota al momento, dei partecipanti al girone stesso
                    gironi.Add(new List<Atleta>());
                    //Preparo e setto l'albero di visualizzazione
                    treeView1.Nodes[0].Nodes.Add("Girone " + (i + 1)).ImageIndex = 1;
                }

                //Inserisco ogni partecipante del torneo dentro la struttura dati dei gironi
                //e dell'albero nella posizione corrispondente
                //(l'abero deve essere visualizzato via WEB : quando ci clicchi ti deve far vedere la lista e lo stato degli incontri al suo interno
                int count = 0;

                if (!rankingEnabled)
                {
                    foreach (Atleta a in partecipantiTorneo)    //ciclo sui gironi, e sulla lista atleti partecipanti al torneo, inserendo ogni atleta in un girone diverso, e poi rifacendo il giro
                    {
                        gironi[count].Add(a);

                        treeView1.Nodes[0].Nodes[count].Nodes.Add("[" + a.Asd + "] " + a.Cognome + " " + a.Nome);

                        if (count == numeroGironi - 1)
                            count = 0;
                        else
                            count++;
                    }
                }
                else
                {
                    //qui ci va il codice per il calcolo dei gironi con gli assoluti
                    int fasceAssoluti = 4;
                    int atletiPerfascia = partecipantiTorneo.Count / fasceAssoluti;

                    #region inizializziani 4 fasce
                    List<Atleta> primaFascia = new List<Atleta>();
                    List<Atleta> secondaFascia = new List<Atleta>();
                    List<Atleta> terzaFascia = new List<Atleta>();
                    List<Atleta> quartaFascia = new List<Atleta>();
                    #endregion 

                    //primo quarto
                    primaFascia.AddRange(partecipantiTorneo.GetRange(0, atletiPerfascia));
                    //secondo quarto     
                    secondaFascia.AddRange(partecipantiTorneo.GetRange(atletiPerfascia, atletiPerfascia));
                    //terzo quarto
                    terzaFascia.AddRange(partecipantiTorneo.GetRange(2 * atletiPerfascia, atletiPerfascia));
                    //tutti i restanti
                    quartaFascia.AddRange(partecipantiTorneo.GetRange(3 * atletiPerfascia, atletiPerfascia + (partecipantiTorneo.Count - (4 * atletiPerfascia))));

                    foreach (List<Atleta> g in gironi)
                    {
                        //inserisco il primo atleta di ogni fascia nel girone i-esimo
                        if(primaFascia.Count > 0)
                            g.Add(primaFascia.ElementAt(0));
                        if (secondaFascia.Count > 0)
                            g.Add(secondaFascia.ElementAt(0));
                        if (terzaFascia.Count > 0)
                            g.Add(terzaFascia.ElementAt(0));
                        if (quartaFascia.Count > 0)
                            g.Add(quartaFascia.ElementAt(0));

                        //elimino quell'atleta dalla lista dei papabili
                        if (primaFascia.Count > 0)
                            primaFascia.RemoveAt(0);
                        if (secondaFascia.Count > 0)
                            secondaFascia.RemoveAt(0);
                        if (terzaFascia.Count > 0)
                            terzaFascia.RemoveAt(0);
                        if (quartaFascia.Count > 0)
                            quartaFascia.RemoveAt(0);
                    }

                    //gestisco eventuali orfani : GIRONI da 5
                    //per sicurezza controllo tutte le fasce ma sarà solo la quarta ad avere degli orfani
                    //che andaranno inseriti nei gironi già popolati a partire dal primo
                    if (primaFascia.Count > 0 || secondaFascia.Count > 0 || terzaFascia.Count > 0 || quartaFascia.Count > 0)
                    {
                        foreach (List<Atleta> g in gironi)
                        {
                            if (primaFascia.Count > 0)
                            {
                                g.Add(primaFascia.ElementAt(0));
                                primaFascia.RemoveAt(0);
                            }
                            else if (secondaFascia.Count > 0)
                            {
                                g.Add(secondaFascia.ElementAt(0));
                                secondaFascia.RemoveAt(0);
                            }
                            else if (terzaFascia.Count > 0)
                            {
                                g.Add(terzaFascia.ElementAt(0));
                                terzaFascia.RemoveAt(0);
                            }
                            else if (quartaFascia.Count > 0)
                            {
                                g.Add(quartaFascia.ElementAt(0));
                                quartaFascia.RemoveAt(0);
                            }
                            else
                                break;
                        }
                    }
                }

                esportaPDFToolStripMenuItem.Enabled = true;
                esportaGironiIncontriToolStripMenuItem.Enabled = true;
                visualizzaTorneoToolStripMenuItem.Enabled = true;
                bracketToolStripMenuItem.Enabled = true;


                ///TODO
                ///per ogni girone devo creare la lsita corrispondente degli scontri
                ///- nuova struttura dati dei gironi/scontri che ogni posizione contiene una lista di incontri
                ///- tali incontri vanno salvati sul DB
                ///- tali incontri dovranno, in futuro, essere anche visualizzati via WEB
                ///
                gironiIncontri = new List<List<Incontro>>();

                //Reset tabPages
                foreach (TabPage t in tabControl1.TabPages)
                    tabControl1.TabPages.Remove(t);

                Int32 idGirone = 1;

                foreach (List<Atleta> g in gironi)
                {
                    List<Incontro> matchList = null;

                    if (g.Count == 4)
                        matchList = Helper.ElaborateT4(g);
                    else if (g.Count == 5)
                        matchList = Helper.ElaborateT5(g);
                    else if (g.Count == 6)
                        matchList = Helper.ElaborateT6(g);

                    gironiIncontri.Add(matchList);
                    string title = "Girone " + (tabControl1.TabCount + 1).ToString();
                    tabControl1.TabPages.Add(elaboraTab(title, g, matchList, (tabControl1.TabCount + 1)));

                    //TODO l'inserimento va fatto solo se già non è stato fatto, altrimenti vanno eliminati TUTTI i dati
                    Helper.InserisciGironiIncontri(idTorneo, idDisciplina, matchList, idGirone);

                    foreach (Atleta a in g)
                        Helper.InsertAtletaInGirone(creaGironi.IdTorneo, creaGironi.IdDisciplina, idGirone, a.IdAtleta);

                    idGirone++;
                }

                //Aggiorno la radice dell'albero con il numero totale dei partecipanti
                treeView1.Nodes[0].Text = "Torneo del " + DateTime.Today.ToString("dd/MM/yyyy");
                treeView1.Nodes[0].Expand();
                treeView1.SelectedNode = treeView1.Nodes[0].Nodes[0];
                treeView1.SelectedNode.BackColor = SystemColors.Highlight;
                treeView1.SelectedNode.ForeColor = Color.White;
                previousSelectedNode = treeView1.SelectedNode;

                statusBar.Panels[2].Text = "Torneo (" + partecipantiTorneo.Count + " partecipanti) - [" + numeroGironi + " GIRONI]";
            }
            else
            {
                MessageBox.Show("Si è verificato un errore durante il recupero delle informazioni sul numero dei gironi \r\nContattare un amministratore",
                                "ERRORE Applicazione",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void caricaGironi_FormClosed(object sender, FormClosingEventArgs e)
        {
            if ((sender as Form).DialogResult == DialogResult.None)
            {
                // Then assume that X has been clicked and act accordingly.
            }
            else if ((sender as Form).DialogResult == DialogResult.OK)
            {
                if (caricaGironi != null)
                {
                    if ((caricaGironi.IdDisciplina > 0) && (caricaGironi.IdTorneo > 0))
                    {
                        //TODO solo se non ci sono già gironi attivi (e cioè in stato 0 per quel torneo e disciplina)
                        textBox1.AppendText("[TORNEO] --> " + caricaGironi.NomeTorneo + "\r\n");
                        textBox1.AppendText("[DISCIPLINA] --> " + caricaGironi.Disciplina + "\r\n");
                        textBox1.AppendText("[CATEGORIA] --> " + (caricaGironi.Categoria == "M" ? "Mascile" : "Femminile") + "\r\n");

                        caricaGironiCreati(caricaGironi.IdTorneo, caricaGironi.IdDisciplina, caricaGironi.Categoria);

                        buttonNextFase.Enabled = true;
                        eliminatorieToolStripMenuItem.Enabled = true;
                    }
                }
            }
            else if ((sender as Form).DialogResult == DialogResult.Abort)
            {
                // Then assume that Cancel Button has been clicked and act accordingly.)
            }
        }
        private void caricaGironiCreati(int idTorneo, int idDisciplina, String categoria)
        {
            InitializeTreeView();

            numeroGironi = Helper.GetNumeroGironiByTorneoDisciplina(idTorneo, idDisciplina, categoria);
            textBox1.AppendText("[NUMERO GIRONI] --> " + numeroGironi + "\r\n");

            if (numeroGironi > 0)
            {
                gironi = new List<List<Atleta>>();
                //il problema è qui, carica la lista degli atletiin maniera diversa di come li salva la prima volta
                gironi = Helper.GetGironiSalvati(idTorneo, idDisciplina, categoria);

                numeroAtletiTorneoDisciplina = gironi.SelectMany(list => list).Distinct().Count();
                textBox1.AppendText("[NUMERO Atleti] --> " + numeroAtletiTorneoDisciplina + "\r\n");

                //Setting delle strutture dati
                for (int i = 0; i < numeroGironi; i++)
                {
                    //Preparo e setto l'albero di visualizzazione
                    treeView1.Nodes[0].Nodes.Add("Girone " + (i + 1)).ImageIndex = 1;
                }

                esportaPDFToolStripMenuItem.Enabled = true;
                esportaGironiIncontriToolStripMenuItem.Enabled = true;
                visualizzaTorneoToolStripMenuItem.Enabled = true;
                gironiIncontri = new List<List<Incontro>>();

                foreach (TabPage t in tabControl1.TabPages)
                    tabControl1.TabPages.Remove(t);

                Int32 idGirone = 1;

                foreach (List<Atleta> g in gironi)
                {
                    List<Incontro> l = null;

                    //TODO eliminabile visto che sono già sul DB
                    if (g.Count == 4)
                        l = Helper.ElaborateT4(g);
                    else if (g.Count == 5)
                        l = Helper.ElaborateT5(g);
                    else if (g.Count == 6)
                        l = Helper.ElaborateT6(g);

                    //da commentare se manualmente si vuole eliminare un girone per ritiro di un atleta
                    //prima però eliminare i record relativi a torneo e disciplina nella tabella
                    //GironiIncontri
                    //Helper.InserisciGironiIncontri(idTorneo, idDisciplina, l, idGirone);

                    if (l != null)
                    {
                        foreach (Incontro i in l)
                            Helper.CaricaPunteggiEsistentiGironiIncontri(idTorneo, idDisciplina, i, idGirone);

                        gironiIncontri.Add(l);
                        string title = "Girone " + (tabControl1.TabCount + 1).ToString();
                        tabControl1.TabPages.Add(elaboraTab(title, g, l, (tabControl1.TabCount + 1)));

                    }
                    idGirone++;
                }

                //Aggiorno la radice dell'albero con il numero totale dei partecipanti
                treeView1.Nodes[0].Text = "Torneo di del " + DateTime.Today.ToString("dd/MM/yyyy");
                treeView1.Nodes[0].Expand();
                treeView1.SelectedNode = treeView1.Nodes[0].Nodes[0];
                treeView1.SelectedNode.BackColor = SystemColors.Highlight;
                treeView1.SelectedNode.ForeColor = Color.White;
                previousSelectedNode = treeView1.SelectedNode;
            }
            else
            {
                MessageBox.Show("Si è verificato un errore durante il recupero delle informazioni sul numero dei gironi \r\nContattare un amministratore",
                                "ERRORE Applicazione",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        void caricaOttavi_FormClosed(object sender, FormClosingEventArgs e)
        {
            if ((sender as Form).DialogResult == DialogResult.None)
            {
                // Then assume that X has been clicked and act accordingly.
            }
            else if ((sender as Form).DialogResult == DialogResult.OK)
            {
                if (caricaOttavi != null)
                {
                    if ((caricaOttavi.IdDisciplina > 0) && (caricaOttavi.IdTorneo > 0))
                    {
                        List<AtletaEliminatorie> campo1 = new List<AtletaEliminatorie>();
                        List<AtletaEliminatorie> campo2 = new List<AtletaEliminatorie>();
                        List<AtletaEliminatorie> campo3 = new List<AtletaEliminatorie>();
                        List<AtletaEliminatorie> campo4 = new List<AtletaEliminatorie>();

                        campo1 = Helper.GetOttavi(caricaOttavi.IdTorneo, caricaOttavi.IdDisciplina, 1);
                        campo2 = Helper.GetOttavi(caricaOttavi.IdTorneo, caricaOttavi.IdDisciplina, 2);
                        campo3 = Helper.GetOttavi(caricaOttavi.IdTorneo, caricaOttavi.IdDisciplina, 3);
                        campo4 = Helper.GetOttavi(caricaOttavi.IdTorneo, caricaOttavi.IdDisciplina, 4);

                        Form ottavi = new Ottavi(campo1, campo2, campo3, campo4, caricaOttavi.IdTorneo, caricaOttavi.IdDisciplina);

                        ottavi.StartPosition = FormStartPosition.CenterScreen;

                        ottavi.Show();
                    }
                }
            }
            else if ((sender as Form).DialogResult == DialogResult.Abort)
            {
                // Then assume that Cancel Button has been clicked and act accordingly.)
            }
        }

        void caricaQuarti_FormClosed(object sender, FormClosingEventArgs e)
        {
            if ((sender as Form).DialogResult == DialogResult.None)
            {
                // Then assume that X has been clicked and act accordingly.
            }
            else if ((sender as Form).DialogResult == DialogResult.OK)
            {
                if (caricaQuarti != null)
                {
                    if ((caricaQuarti.IdDisciplina > 0) && (caricaQuarti.IdTorneo > 0))
                    {
                        List<AtletaEliminatorie> campo1 = new List<AtletaEliminatorie>();
                        List<AtletaEliminatorie> campo2 = new List<AtletaEliminatorie>();
                        List<AtletaEliminatorie> campo3 = new List<AtletaEliminatorie>();
                        List<AtletaEliminatorie> campo4 = new List<AtletaEliminatorie>();

                        campo1 = Helper.GetQuarti(caricaQuarti.IdTorneo, caricaQuarti.IdDisciplina, 1);
                        campo2 = Helper.GetQuarti(caricaQuarti.IdTorneo, caricaQuarti.IdDisciplina, 2);
                        campo3 = Helper.GetQuarti(caricaQuarti.IdTorneo, caricaQuarti.IdDisciplina, 3);
                        campo4 = Helper.GetQuarti(caricaQuarti.IdTorneo, caricaQuarti.IdDisciplina, 4);

                        Form quarti = new Quarti(campo1, campo2, campo3, campo4, caricaQuarti.IdTorneo, caricaQuarti.IdDisciplina);

                        quarti.StartPosition = FormStartPosition.CenterScreen;

                        quarti.Show();
                    }
                }
            }
            else if ((sender as Form).DialogResult == DialogResult.Abort)
            {
                // Then assume that Cancel Button has been clicked and act accordingly.)
            }
        }

        void caricaSemiFinali_FormClosed(object sender, FormClosingEventArgs e)
        {
            if ((sender as Form).DialogResult == DialogResult.None)
            {
                // Then assume that X has been clicked and act accordingly.
            }
            else if ((sender as Form).DialogResult == DialogResult.OK)
            {
                if (caricaSemifinali != null)
                {
                    if ((caricaSemifinali.IdDisciplina > 0) && (caricaSemifinali.IdTorneo > 0))
                    {
                        List<AtletaEliminatorie> campo1 = new List<AtletaEliminatorie>();
                        List<AtletaEliminatorie> campo2 = new List<AtletaEliminatorie>();

                        campo1 = Helper.GetSemifinali(caricaSemifinali.IdTorneo, caricaSemifinali.IdDisciplina, 1);
                        campo2 = Helper.GetSemifinali(caricaSemifinali.IdTorneo, caricaSemifinali.IdDisciplina, 2);

                        Form semiFinali = new Semifinali(campo1, campo2, caricaSemifinali.IdTorneo, caricaSemifinali.IdDisciplina);

                        semiFinali.StartPosition = FormStartPosition.CenterScreen;

                        semiFinali.Show();
                    }
                }
            }
            else if ((sender as Form).DialogResult == DialogResult.Abort)
            {
                // Then assume that Cancel Button has been clicked and act accordingly.)
            }
        }

        void caricaFinali_FormClosed(object sender, FormClosingEventArgs e)
        {
            if ((sender as Form).DialogResult == DialogResult.None)
            {
                // Then assume that X has been clicked and act accordingly.
            }
            else if ((sender as Form).DialogResult == DialogResult.OK)
            {
                if (caricaFinali != null)
                {
                    if ((caricaFinali.IdDisciplina > 0) && (caricaFinali.IdTorneo > 0))
                    {
                        List<AtletaEliminatorie> campo1 = new List<AtletaEliminatorie>();
                        List<AtletaEliminatorie> campo2 = new List<AtletaEliminatorie>();

                        campo1 = Helper.GetFinali(caricaFinali.IdTorneo, caricaFinali.IdDisciplina, 1);
                        campo2 = Helper.GetFinali(caricaFinali.IdTorneo, caricaFinali.IdDisciplina, 2);

                        Form finali = new Finali(campo1, campo2, caricaFinali.IdTorneo, caricaFinali.IdDisciplina);

                        finali.StartPosition = FormStartPosition.CenterScreen;

                        finali.Show();
                    }
                }
            }
            else if ((sender as Form).DialogResult == DialogResult.Abort)
            {
                // Then assume that Cancel Button has been clicked and act accordingly.)
            }
        }

        /// <summary>
        /// Lettura atleti e manipolazione per creare i gironi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caricaGironi = new CaricaGironiDaDisciplina(false);
            caricaGironi.FormClosing += new FormClosingEventHandler(caricaGironi_FormClosed);

            PwdCheck check = new PwdCheck(caricaGironi);
            check.StartPosition = FormStartPosition.CenterScreen;
            check.FormClosing += new FormClosingEventHandler(check_FormClosed);
            check.Show();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            creaGironi = new CreaGironiDaDisciplina();
            creaGironi.FormClosing += new FormClosingEventHandler(creaGironi_FormClosed);

            PwdCheck check = new PwdCheck(creaGironi);
            check.StartPosition = FormStartPosition.CenterScreen;
            check.FormClosing += new FormClosingEventHandler(check_FormClosed);
            check.Show();
        }
        private void nuovoTorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTorneo newTorneo = new AddTorneo();
            newTorneo.Show();
        }
        private void visualizzaIscrittiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTournament tournament = new ManageTournament();

            tournament.Show();
            tournament.StartPosition = FormStartPosition.CenterScreen;
            tournament.TopMost = false;
        }
        private void modificaTorneiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificaTorneo editTorneo = new ModificaTorneo();
            editTorneo.Show();
        }
        private void eliminaTorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteTorneo deleteTorneo = new DeleteTorneo();

            deleteTorneo.Show();
        }
        private void form1_FormClosed(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Sicuro di voler uscire?",
            //                    "Chiusura Applicazione",
            //                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            //{
            //    e.Cancel = false;
            //    Application.Exit();
            //}
            //else
            //    e.Cancel = true;
        }
        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAnagraphicUser newUser = new AddAnagraphicUser();
            newUser.Show();
        }
        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminaAtleti a = new EliminaAtleti();
            a.Show();
            a.StartPosition = FormStartPosition.CenterScreen;
            a.TopMost = false;
        }
        private void modifyPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyAnagrafic editUser = new ModifyAnagrafic();
            editUser.Show();
        }
        private void exportGironiIncontriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gironi.Count > 0)
            {
                String nomeT = creaGironi != null ? creaGironi.NomeTorneo : caricaGironi.NomeTorneo;
                String disciplinaT = creaGironi != null ? creaGironi.Disciplina : caricaGironi.Disciplina;

                PdfManager pdf = new PdfManager();
                pdf.StampaGironiConIncontri(gironi, nomeT, disciplinaT);
            }
        }
        private void exportPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((creaGironi != null) || (caricaGironi != null))
            {
                String nomeT = creaGironi != null ? creaGironi.NomeTorneo : caricaGironi.NomeTorneo;
                String disciplinaT = creaGironi != null ? creaGironi.Disciplina : caricaGironi.Disciplina;

                PdfManager pdf = new PdfManager();
                pdf.StampaGironi(gironi, nomeT, disciplinaT);
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new AboutBox();
            about.StartPosition = FormStartPosition.CenterScreen;
            about.Show();
        }

        private void buttonNextFase_Click(object sender, EventArgs e)
        {
            atletiAmmessiEliminatorie = numeroAtletiTorneoDisciplina >= 54 ? 32 :
                numeroAtletiTorneoDisciplina >= 24 ? 16 :
                numeroAtletiTorneoDisciplina >= 12 ? 8 : 4;

            Form validaAtleti = new ValidaEliminatorie(caricaGironi.IdTorneo, caricaGironi.IdDisciplina, atletiAmmessiEliminatorie);
            validaAtleti.StartPosition = FormStartPosition.CenterScreen;

            validaAtleti.FormClosing += new FormClosingEventHandler(creaEliminatorie_FormClosed);

            validaAtleti.Show();
        }

        void creaEliminatorie_FormClosed(object sender, FormClosingEventArgs e)
        {
            if ((sender as Form).DialogResult == DialogResult.None)
            {
                // Then assume that X has been clicked and act accordingly.
            }
            else if ((sender as Form).DialogResult == DialogResult.OK)
            {
                if (atletiAmmessiEliminatorie == 32)
                {

                    List<AtletaEliminatorie> allAtleti = Helper.GetSedicesimi(caricaGironi.IdTorneo, caricaGironi.IdDisciplina);

                    List<AtletaEliminatorie> campo1 = new List<AtletaEliminatorie>();
                    List<AtletaEliminatorie> campo2 = new List<AtletaEliminatorie>();
                    List<AtletaEliminatorie> campo3 = new List<AtletaEliminatorie>();
                    List<AtletaEliminatorie> campo4 = new List<AtletaEliminatorie>();

                    #region campo1
                    campo1.Add(allAtleti.ElementAt(0));
                    campo1.Add(allAtleti.ElementAt(31));

                    campo1.Add(allAtleti.ElementAt(15));
                    campo1.Add(allAtleti.ElementAt(16));

                    campo1.Add(allAtleti.ElementAt(11));
                    campo1.Add(allAtleti.ElementAt(20));

                    campo1.Add(allAtleti.ElementAt(7));
                    campo1.Add(allAtleti.ElementAt(24));
                    #endregion
                    #region campo2
                    campo2.Add(allAtleti.ElementAt(1));
                    campo2.Add(allAtleti.ElementAt(30));

                    campo2.Add(allAtleti.ElementAt(14));
                    campo2.Add(allAtleti.ElementAt(17));

                    campo2.Add(allAtleti.ElementAt(10));
                    campo2.Add(allAtleti.ElementAt(21));

                    campo2.Add(allAtleti.ElementAt(6));
                    campo2.Add(allAtleti.ElementAt(25));
                    #endregion
                    #region campo3
                    campo3.Add(allAtleti.ElementAt(5));
                    campo3.Add(allAtleti.ElementAt(26));

                    campo3.Add(allAtleti.ElementAt(9));
                    campo3.Add(allAtleti.ElementAt(22));

                    campo3.Add(allAtleti.ElementAt(13));
                    campo3.Add(allAtleti.ElementAt(18));

                    campo3.Add(allAtleti.ElementAt(2));
                    campo3.Add(allAtleti.ElementAt(29));
                    #endregion
                    #region campo4
                    campo4.Add(allAtleti.ElementAt(4));
                    campo4.Add(allAtleti.ElementAt(27));

                    campo4.Add(allAtleti.ElementAt(8));
                    campo4.Add(allAtleti.ElementAt(23));

                    campo4.Add(allAtleti.ElementAt(12));
                    campo4.Add(allAtleti.ElementAt(19));

                    campo4.Add(allAtleti.ElementAt(3));
                    campo4.Add(allAtleti.ElementAt(28));
                    #endregion

                    Form sedicesimi = new Sedicesimi(campo1, campo2, campo3, campo4, caricaGironi.IdTorneo, caricaGironi.IdDisciplina);
                    sedicesimi.StartPosition = FormStartPosition.CenterScreen;

                    sedicesimi.Show();
                    faseSuccessiva = 16;
                }
                else if (atletiAmmessiEliminatorie == 16)
                {
                    List<AtletaEliminatorie> allAtleti = Helper.GetOttavi(caricaGironi.IdTorneo, caricaGironi.IdDisciplina);

                    List<AtletaEliminatorie> campo1 = new List<AtletaEliminatorie>();
                    List<AtletaEliminatorie> campo2 = new List<AtletaEliminatorie>();
                    List<AtletaEliminatorie> campo3 = new List<AtletaEliminatorie>();
                    List<AtletaEliminatorie> campo4 = new List<AtletaEliminatorie>();

                    #region campo1
                    campo1.Add(allAtleti.ElementAt(0));
                    campo1.Add(allAtleti.ElementAt(15));

                    campo1.Add(allAtleti.ElementAt(7));
                    campo1.Add(allAtleti.ElementAt(8));
                    #endregion
                    #region campo2
                    campo2.Add(allAtleti.ElementAt(1));
                    campo2.Add(allAtleti.ElementAt(14));

                    campo2.Add(allAtleti.ElementAt(6));
                    campo2.Add(allAtleti.ElementAt(9));
                    #endregion
                    #region campo3
                    campo3.Add(allAtleti.ElementAt(5));
                    campo3.Add(allAtleti.ElementAt(10));

                    campo3.Add(allAtleti.ElementAt(2));
                    campo3.Add(allAtleti.ElementAt(13));
                    #endregion
                    #region campo4
                    campo4.Add(allAtleti.ElementAt(4));
                    campo4.Add(allAtleti.ElementAt(11));

                    campo4.Add(allAtleti.ElementAt(3));
                    campo4.Add(allAtleti.ElementAt(12));
                    #endregion

                    Form ottavi = new Ottavi(campo1, campo2, campo3, campo4, caricaGironi.IdTorneo, caricaGironi.IdDisciplina);
                    ottavi.StartPosition = FormStartPosition.CenterScreen;

                    ottavi.Show();
                    faseSuccessiva = 8;
                }
                else if (atletiAmmessiEliminatorie == 8)
                {
                    List<AtletaEliminatorie> allAtleti = Helper.GetQuarti(caricaGironi.IdTorneo, caricaGironi.IdDisciplina);

                    List<AtletaEliminatorie> campo1 = new List<AtletaEliminatorie>();
                    List<AtletaEliminatorie> campo2 = new List<AtletaEliminatorie>();
                    List<AtletaEliminatorie> campo3 = new List<AtletaEliminatorie>();
                    List<AtletaEliminatorie> campo4 = new List<AtletaEliminatorie>();

                    #region campo1
                    campo1.Add(allAtleti.ElementAt(0));
                    campo1.Add(allAtleti.ElementAt(7));
                    #endregion
                    #region campo2
                    campo2.Add(allAtleti.ElementAt(1));
                    campo2.Add(allAtleti.ElementAt(6));
                    #endregion
                    #region campo3
                    campo3.Add(allAtleti.ElementAt(2));
                    campo3.Add(allAtleti.ElementAt(5));
                    #endregion
                    #region campo4
                    campo4.Add(allAtleti.ElementAt(3));
                    campo4.Add(allAtleti.ElementAt(4));
                    #endregion

                    Form quarti = new Quarti(campo1, campo2, campo3, campo4, caricaGironi.IdTorneo, caricaGironi.IdDisciplina);

                    quarti.StartPosition = FormStartPosition.CenterScreen;

                    quarti.Show();
                    faseSuccessiva = 4;
                }
                else if (atletiAmmessiEliminatorie == 4)
                {
                    List<AtletaEliminatorie> allAtleti = Helper.GetSemifinali(caricaGironi.IdTorneo, caricaGironi.IdDisciplina);

                    if (allAtleti.Count == 4)
                    {
                        List<AtletaEliminatorie> campo1 = new List<AtletaEliminatorie>();
                        List<AtletaEliminatorie> campo2 = new List<AtletaEliminatorie>();
                        
                        #region campo1
                        campo1.Add(allAtleti.ElementAt(0));
                        campo1.Add(allAtleti.ElementAt(3));
                        #endregion
                        #region campo2
                        campo2.Add(allAtleti.ElementAt(1));
                        campo2.Add(allAtleti.ElementAt(2));
                        #endregion

                        Form semifinali = new Semifinali(campo1, campo2, caricaGironi.IdTorneo, caricaGironi.IdDisciplina);

                        semifinali.StartPosition = FormStartPosition.CenterScreen;

                        semifinali.Show();
                        faseSuccessiva = 2;
                    }
                }
            }
            else if ((sender as Form).DialogResult == DialogResult.Abort)
            {
                // Then assume that Cancel Button has been clicked and act accordingly.)
            }
        }

        #region carica una fase specifica
        

        private void carivaOttaviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Caricando gli OTTAVI tutti i risultati successivi verranno cancellati.\n\n Procedere?", "Attenzione",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Helper.DeleteAllQuarti(caricaGironi.IdTorneo, caricaGironi.IdDisciplina);
                Helper.DeleteAllSemifinali(caricaGironi.IdTorneo, caricaGironi.IdDisciplina);
                Helper.DeleteAllFinali(caricaGironi.IdTorneo, caricaGironi.IdDisciplina);

                caricaOttavi = new CaricaGironiDaDisciplina(false);

                caricaOttavi.FormClosing += new FormClosingEventHandler(caricaOttavi_FormClosed);

                caricaOttavi.Show();
                caricaOttavi.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {

            }
        }

        private void caricaQuartiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Caricando i QUARTI tutti i risultati successivi verranno cancellati.\n\n Procedere?", "Attenzione",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Helper.DeleteAllSemifinali(caricaGironi.IdTorneo, caricaGironi.IdDisciplina);
                Helper.DeleteAllFinali(caricaGironi.IdTorneo, caricaGironi.IdDisciplina);

                caricaQuarti = new CaricaGironiDaDisciplina(false);

                caricaQuarti.FormClosing += new FormClosingEventHandler(caricaQuarti_FormClosed);

                caricaQuarti.Show();
                caricaQuarti.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {

            }
        }

        private void caricaSemifinaliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Caricando le semifinali tutti i risultati successivi verranno cancellati.\n\n Procedere?", "Attenzione",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Helper.DeleteAllFinali(caricaGironi.IdTorneo, caricaGironi.IdDisciplina);

                caricaSemifinali = new CaricaGironiDaDisciplina(false);

                caricaSemifinali.FormClosing += new FormClosingEventHandler(caricaSemiFinali_FormClosed);

                caricaSemifinali.Show();
                caricaSemifinali.StartPosition = FormStartPosition.CenterScreen;

            }
            else
            {

            }
        }

        private void caricaFinaliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Caricando le FINALI tutti i risultati salvati per le stesse verranno cancellati.\n\n Procedere?", "Attenzione",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                caricaFinali = new CaricaGironiDaDisciplina(false);

                caricaFinali.FormClosing += new FormClosingEventHandler(caricaFinali_FormClosed);

                caricaFinali.Show();
                caricaFinali.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {

            }
        }

        #endregion

        private void bracketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BracketSedicesimi bracket = new BracketSedicesimi();
            bracket.Show();
            bracket.StartPosition = FormStartPosition.CenterScreen;
        }

        private void atletiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportAtleti report = new ReportAtleti();
            report.Show();
            report.StartPosition = FormStartPosition.CenterScreen;
        }

        private void associazioniToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportAssociazioni report = new ReportAssociazioni();
            report.Show();
            report.StartPosition = FormStartPosition.CenterScreen;
        }


        private void atltetiEdAssociazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void atletiInTorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void risultatiTorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            risultatiTorneo = new CaricaGironiDaDisciplina(false);

            risultatiTorneo.FormClosing += new FormClosingEventHandler(VisualizzaReport_FormClosed);

            risultatiTorneo.Show();
            risultatiTorneo.StartPosition = FormStartPosition.CenterScreen;
        }

        void VisualizzaReport_FormClosed(object sender, FormClosingEventArgs e)
        {
            if ((sender as Form).DialogResult == DialogResult.None)
            {
                // Then assume that X has been clicked and act accordingly.
            }
            else if ((sender as Form).DialogResult == DialogResult.OK)
            {
                if (risultatiTorneo != null)
                {
                    if ((risultatiTorneo.IdDisciplina > 0) && (risultatiTorneo.IdTorneo > 0))
                    {
                        ReportRisultatiTorneo report = new ReportRisultatiTorneo(risultatiTorneo.IdTorneo, risultatiTorneo.IdDisciplina, risultatiTorneo.Categoria);
                        report.Show();
                        report.StartPosition = FormStartPosition.CenterScreen;
                    }
                }
            }
            else if ((sender as Form).DialogResult == DialogResult.Abort)
            {
                // Then assume that Cancel Button has been clicked and act accordingly.)
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings setting = new Settings();
            setting.StartPosition = FormStartPosition.CenterScreen;
            setting.FormClosing += new FormClosingEventHandler(Setting_FormClosed);
            

            PwdCheck check = new PwdCheck(setting);
            check.StartPosition = FormStartPosition.CenterScreen;
            check.FormClosing += new FormClosingEventHandler(check_FormClosed);

            check.Show();            
        }

        private void check_FormClosed(object sender, FormClosingEventArgs e)
        {
            if ((sender as Form).DialogResult == DialogResult.None)
            {
                // Then assume that X has been clicked and act accordingly.
            }
            else if ((sender as Form).DialogResult == DialogResult.OK)
            {
                (sender as PwdCheck).FormChecked.Show();
                (sender as PwdCheck).FormChecked.StartPosition = FormStartPosition.CenterScreen;
            }
            else if ((sender as Form).DialogResult == DialogResult.Abort)
            {
                // Then assume that the password was incorrect
            }
        }

        
        void Setting_FormClosed(object sender, FormClosingEventArgs e)
        {
            var settingForm = sender as Settings;

            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;

                RefreshDataBaseSelected(settings, settingForm.DbType);
                RefreshDebugMode(settingForm, settings);
                RefreshCreationMode(settingForm, settings);

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);


                creaToolStripMenuItem.Enabled = ConfigurationManager.AppSettings["Creazione"].ToString() == "true";

                statusBar.Panels[1].Text = "Connected to " + "DB " + Helper.GetDbType() + "[Ver: " + Helper.GetDbVersion() + "] ";
            }
            catch (ConfigurationErrorsException)
            {
                textBox1.AppendText("ERROR while writing app settings config file");
            }            
                                    
            
        }

        private void RefreshDebugMode(Settings settingForm, KeyValueConfigurationCollection settings)
        {
            debug = settingForm.DegubMode;

            string debugMode = debug ? "true" : "false";

            if (settings["Debug"] == null)
                settings.Add("Debug", debugMode);
            else
                settings["Debug"].Value = debugMode;
        }

        private void RefreshCreationMode(Settings settingForm, KeyValueConfigurationCollection settings)
        {
            var creation = settingForm.CreationActive;

            string creationStatus = creation ? "true" : "false";

            if (settings["Creazione"] == null)
                settings.Add("Creazione", creationStatus);
            else
                settings["Creazione"].Value = creationStatus;
        }

        private static void RefreshDataBaseSelected(KeyValueConfigurationCollection settings, string dbType)
        {
            if (settings["DataBase"] == null)
                settings.Add("DataBase", dbType);
            else
                settings["DataBase"].Value = dbType;
        }

        private void aggiungiASDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in Progress", "Attenzione", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
        }

        private void modificaASDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in Progress", "Attenzione", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
        }

        private void eliminaASDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in Progress", "Attenzione", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
        }

        private void esportaTorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cancellaEliminatorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Stai per cancellare TUTTE le fasi ad eliminazione diretta per il torneo in atto.\n\n Procedere?", "Attenzione",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Helper.DeleteAllSedicesimi(caricaGironi.IdTorneo, caricaGironi.IdDisciplina);
                Helper.DeleteAllOttavi(caricaGironi.IdTorneo, caricaGironi.IdDisciplina);
                Helper.DeleteAllQuarti(caricaGironi.IdTorneo, caricaGironi.IdDisciplina);
                Helper.DeleteAllSemifinali(caricaGironi.IdTorneo, caricaGironi.IdDisciplina);
                Helper.DeleteAllFinali(caricaGironi.IdTorneo, caricaGironi.IdDisciplina);
            }
        }
    }
}
