using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.associazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiASDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaASDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaASDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaTorneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoTorneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaTorneiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaTorneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminatorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carivaOttaviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caricaQuartiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caricaSemifinaliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caricaFinaliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gironiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esportaPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esportaGironiIncontriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bracketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atletiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associazioniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atltetiEdAssociazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atletiInTorneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.risultatiTorneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemaRatingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esportaTorneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.labelLog = new System.Windows.Forms.Label();
            this.buttonNextFase = new System.Windows.Forms.Button();
            this.cancellaEliminatorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(12, 586);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1050, 100);
            this.textBox1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(12, 52);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(209, 508);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "weapon-swords-crossed-512.png");
            this.imageList1.Images.SetKeyName(1, "group.ico");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.associazioniToolStripMenuItem,
            this.torneoToolStripMenuItem,
            this.eliminatorieToolStripMenuItem,
            this.gironiToolStripMenuItem,
            this.reportisticaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.hemaRatingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creaToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator2,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "Gare";
            // 
            // creaToolStripMenuItem
            // 
            this.creaToolStripMenuItem.Name = "creaToolStripMenuItem";
            this.creaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.creaToolStripMenuItem.Text = "Crea Gironi";
            this.creaToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.loadToolStripMenuItem.Text = "Carica Gironi";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPersonToolStripMenuItem,
            this.modifyPersonToolStripMenuItem,
            this.deletePersonToolStripMenuItem,
            this.toolStripSeparator1});
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.modificaToolStripMenuItem.Text = "Atleti";
            // 
            // addPersonToolStripMenuItem
            // 
            this.addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            this.addPersonToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addPersonToolStripMenuItem.Text = "Aggiungi Atleta";
            this.addPersonToolStripMenuItem.Click += new System.EventHandler(this.addPersonToolStripMenuItem_Click);
            // 
            // modifyPersonToolStripMenuItem
            // 
            this.modifyPersonToolStripMenuItem.Name = "modifyPersonToolStripMenuItem";
            this.modifyPersonToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.modifyPersonToolStripMenuItem.Text = "Modifica Atleta";
            this.modifyPersonToolStripMenuItem.Click += new System.EventHandler(this.modifyPersonToolStripMenuItem_Click);
            // 
            // deletePersonToolStripMenuItem
            // 
            this.deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
            this.deletePersonToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deletePersonToolStripMenuItem.Text = "Elimina Atleta";
            this.deletePersonToolStripMenuItem.Click += new System.EventHandler(this.deletePersonToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // associazioniToolStripMenuItem
            // 
            this.associazioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiASDToolStripMenuItem,
            this.modificaASDToolStripMenuItem,
            this.eliminaASDToolStripMenuItem});
            this.associazioniToolStripMenuItem.Name = "associazioniToolStripMenuItem";
            this.associazioniToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.associazioniToolStripMenuItem.Text = "Associazioni";
            // 
            // aggiungiASDToolStripMenuItem
            // 
            this.aggiungiASDToolStripMenuItem.Name = "aggiungiASDToolStripMenuItem";
            this.aggiungiASDToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aggiungiASDToolStripMenuItem.Text = "Aggiungi ASD";
            this.aggiungiASDToolStripMenuItem.Click += new System.EventHandler(this.aggiungiASDToolStripMenuItem_Click);
            // 
            // modificaASDToolStripMenuItem
            // 
            this.modificaASDToolStripMenuItem.Name = "modificaASDToolStripMenuItem";
            this.modificaASDToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.modificaASDToolStripMenuItem.Text = "Modifica ASD";
            this.modificaASDToolStripMenuItem.Click += new System.EventHandler(this.modificaASDToolStripMenuItem_Click);
            // 
            // eliminaASDToolStripMenuItem
            // 
            this.eliminaASDToolStripMenuItem.Name = "eliminaASDToolStripMenuItem";
            this.eliminaASDToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.eliminaASDToolStripMenuItem.Text = "Elimina ASD";
            this.eliminaASDToolStripMenuItem.Click += new System.EventHandler(this.eliminaASDToolStripMenuItem_Click);
            // 
            // torneoToolStripMenuItem
            // 
            this.torneoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizzaTorneoToolStripMenuItem,
            this.nuovoTorneoToolStripMenuItem,
            this.modificaTorneiToolStripMenuItem,
            this.eliminaTorneoToolStripMenuItem});
            this.torneoToolStripMenuItem.Name = "torneoToolStripMenuItem";
            this.torneoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.torneoToolStripMenuItem.Text = "Torneo";
            // 
            // visualizzaTorneoToolStripMenuItem
            // 
            this.visualizzaTorneoToolStripMenuItem.Name = "visualizzaTorneoToolStripMenuItem";
            this.visualizzaTorneoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.visualizzaTorneoToolStripMenuItem.Text = "Visualizza Iscritti";
            this.visualizzaTorneoToolStripMenuItem.Click += new System.EventHandler(this.visualizzaIscrittiToolStripMenuItem_Click);
            // 
            // nuovoTorneoToolStripMenuItem
            // 
            this.nuovoTorneoToolStripMenuItem.Name = "nuovoTorneoToolStripMenuItem";
            this.nuovoTorneoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.nuovoTorneoToolStripMenuItem.Text = "Nuovo Torneo";
            this.nuovoTorneoToolStripMenuItem.Click += new System.EventHandler(this.nuovoTorneoToolStripMenuItem_Click);
            // 
            // modificaTorneiToolStripMenuItem
            // 
            this.modificaTorneiToolStripMenuItem.Name = "modificaTorneiToolStripMenuItem";
            this.modificaTorneiToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.modificaTorneiToolStripMenuItem.Text = "Modifica Tornei";
            this.modificaTorneiToolStripMenuItem.Click += new System.EventHandler(this.modificaTorneiToolStripMenuItem_Click);
            // 
            // eliminaTorneoToolStripMenuItem
            // 
            this.eliminaTorneoToolStripMenuItem.Name = "eliminaTorneoToolStripMenuItem";
            this.eliminaTorneoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.eliminaTorneoToolStripMenuItem.Text = "Elimina Torneo";
            this.eliminaTorneoToolStripMenuItem.Click += new System.EventHandler(this.eliminaTorneoToolStripMenuItem_Click);
            // 
            // eliminatorieToolStripMenuItem
            // 
            this.eliminatorieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carivaOttaviToolStripMenuItem,
            this.caricaQuartiToolStripMenuItem,
            this.caricaSemifinaliToolStripMenuItem,
            this.caricaFinaliToolStripMenuItem,
            this.toolStripSeparator4,
            this.cancellaEliminatorieToolStripMenuItem});
            this.eliminatorieToolStripMenuItem.Enabled = false;
            this.eliminatorieToolStripMenuItem.Name = "eliminatorieToolStripMenuItem";
            this.eliminatorieToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.eliminatorieToolStripMenuItem.Text = "Eliminatorie";
            // 
            // carivaOttaviToolStripMenuItem
            // 
            this.carivaOttaviToolStripMenuItem.Name = "carivaOttaviToolStripMenuItem";
            this.carivaOttaviToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.carivaOttaviToolStripMenuItem.Text = "Cariva Ottavi";
            this.carivaOttaviToolStripMenuItem.Click += new System.EventHandler(this.carivaOttaviToolStripMenuItem_Click);
            // 
            // caricaQuartiToolStripMenuItem
            // 
            this.caricaQuartiToolStripMenuItem.Name = "caricaQuartiToolStripMenuItem";
            this.caricaQuartiToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.caricaQuartiToolStripMenuItem.Text = "Carica Quarti";
            this.caricaQuartiToolStripMenuItem.Click += new System.EventHandler(this.caricaQuartiToolStripMenuItem_Click);
            // 
            // caricaSemifinaliToolStripMenuItem
            // 
            this.caricaSemifinaliToolStripMenuItem.Name = "caricaSemifinaliToolStripMenuItem";
            this.caricaSemifinaliToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.caricaSemifinaliToolStripMenuItem.Text = "Carica Semifinali";
            this.caricaSemifinaliToolStripMenuItem.Click += new System.EventHandler(this.caricaSemifinaliToolStripMenuItem_Click);
            // 
            // caricaFinaliToolStripMenuItem
            // 
            this.caricaFinaliToolStripMenuItem.Name = "caricaFinaliToolStripMenuItem";
            this.caricaFinaliToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.caricaFinaliToolStripMenuItem.Text = "Carica Finali";
            this.caricaFinaliToolStripMenuItem.Click += new System.EventHandler(this.caricaFinaliToolStripMenuItem_Click);
            // 
            // gironiToolStripMenuItem
            // 
            this.gironiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esportaPDFToolStripMenuItem,
            this.esportaGironiIncontriToolStripMenuItem,
            this.bracketToolStripMenuItem});
            this.gironiToolStripMenuItem.Name = "gironiToolStripMenuItem";
            this.gironiToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.gironiToolStripMenuItem.Text = "Export";
            // 
            // esportaPDFToolStripMenuItem
            // 
            this.esportaPDFToolStripMenuItem.Enabled = false;
            this.esportaPDFToolStripMenuItem.Name = "esportaPDFToolStripMenuItem";
            this.esportaPDFToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.esportaPDFToolStripMenuItem.Text = "Esporta Gironi";
            this.esportaPDFToolStripMenuItem.Click += new System.EventHandler(this.exportPDFToolStripMenuItem_Click);
            // 
            // esportaGironiIncontriToolStripMenuItem
            // 
            this.esportaGironiIncontriToolStripMenuItem.Enabled = false;
            this.esportaGironiIncontriToolStripMenuItem.Name = "esportaGironiIncontriToolStripMenuItem";
            this.esportaGironiIncontriToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.esportaGironiIncontriToolStripMenuItem.Text = "Esporta Gironi & Incontri";
            this.esportaGironiIncontriToolStripMenuItem.Click += new System.EventHandler(this.exportGironiIncontriToolStripMenuItem_Click);
            // 
            // bracketToolStripMenuItem
            // 
            this.bracketToolStripMenuItem.Enabled = false;
            this.bracketToolStripMenuItem.Name = "bracketToolStripMenuItem";
            this.bracketToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.bracketToolStripMenuItem.Text = "Bracket";
            this.bracketToolStripMenuItem.Click += new System.EventHandler(this.bracketToolStripMenuItem_Click);
            // 
            // reportisticaToolStripMenuItem
            // 
            this.reportisticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atletiToolStripMenuItem,
            this.associazioniToolStripMenuItem1,
            this.atltetiEdAssociazioniToolStripMenuItem,
            this.atletiInTorneoToolStripMenuItem,
            this.risultatiTorneoToolStripMenuItem});
            this.reportisticaToolStripMenuItem.Name = "reportisticaToolStripMenuItem";
            this.reportisticaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.reportisticaToolStripMenuItem.Text = "Reportistica";
            // 
            // atletiToolStripMenuItem
            // 
            this.atletiToolStripMenuItem.Name = "atletiToolStripMenuItem";
            this.atletiToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.atletiToolStripMenuItem.Text = "Atleti";
            this.atletiToolStripMenuItem.Click += new System.EventHandler(this.atletiToolStripMenuItem_Click);
            // 
            // associazioniToolStripMenuItem1
            // 
            this.associazioniToolStripMenuItem1.Name = "associazioniToolStripMenuItem1";
            this.associazioniToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.associazioniToolStripMenuItem1.Text = "Associazioni";
            this.associazioniToolStripMenuItem1.Click += new System.EventHandler(this.associazioniToolStripMenuItem1_Click);
            // 
            // atltetiEdAssociazioniToolStripMenuItem
            // 
            this.atltetiEdAssociazioniToolStripMenuItem.Name = "atltetiEdAssociazioniToolStripMenuItem";
            this.atltetiEdAssociazioniToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.atltetiEdAssociazioniToolStripMenuItem.Text = "Atlteti ed associazioni";
            this.atltetiEdAssociazioniToolStripMenuItem.Click += new System.EventHandler(this.atltetiEdAssociazioniToolStripMenuItem_Click);
            // 
            // atletiInTorneoToolStripMenuItem
            // 
            this.atletiInTorneoToolStripMenuItem.Name = "atletiInTorneoToolStripMenuItem";
            this.atletiInTorneoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.atletiInTorneoToolStripMenuItem.Text = "Atleti in Torneo";
            this.atletiInTorneoToolStripMenuItem.Click += new System.EventHandler(this.atletiInTorneoToolStripMenuItem_Click);
            // 
            // risultatiTorneoToolStripMenuItem
            // 
            this.risultatiTorneoToolStripMenuItem.Name = "risultatiTorneoToolStripMenuItem";
            this.risultatiTorneoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.risultatiTorneoToolStripMenuItem.Text = "Risultati Torneo";
            this.risultatiTorneoToolStripMenuItem.Click += new System.EventHandler(this.risultatiTorneoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // hemaRatingsToolStripMenuItem
            // 
            this.hemaRatingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esportaTorneoToolStripMenuItem});
            this.hemaRatingsToolStripMenuItem.Name = "hemaRatingsToolStripMenuItem";
            this.hemaRatingsToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.hemaRatingsToolStripMenuItem.Text = "Hema Ratings";
            // 
            // esportaTorneoToolStripMenuItem
            // 
            this.esportaTorneoToolStripMenuItem.Name = "esportaTorneoToolStripMenuItem";
            this.esportaTorneoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.esportaTorneoToolStripMenuItem.Text = "Esporta Torneo";
            this.esportaTorneoToolStripMenuItem.Click += new System.EventHandler(this.esportaTorneoToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(227, 52);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 508);
            this.tabControl1.TabIndex = 4;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(13, 567);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(25, 13);
            this.labelLog.TabIndex = 5;
            this.labelLog.Text = "Log";
            // 
            // buttonNextFase
            // 
            this.buttonNextFase.Location = new System.Drawing.Point(930, 692);
            this.buttonNextFase.Name = "buttonNextFase";
            this.buttonNextFase.Size = new System.Drawing.Size(131, 23);
            this.buttonNextFase.TabIndex = 6;
            this.buttonNextFase.Text = "Fase Successiva";
            this.buttonNextFase.UseVisualStyleBackColor = true;
            this.buttonNextFase.Click += new System.EventHandler(this.buttonNextFase_Click);
            // 
            // cancellaEliminatorieToolStripMenuItem
            // 
            this.cancellaEliminatorieToolStripMenuItem.Name = "cancellaEliminatorieToolStripMenuItem";
            this.cancellaEliminatorieToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cancellaEliminatorieToolStripMenuItem.Text = "Cancella Eliminatorie";
            this.cancellaEliminatorieToolStripMenuItem.Click += new System.EventHandler(this.cancellaEliminatorieToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(182, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 742);
            this.Controls.Add(this.buttonNextFase);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa CGS SAAM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView treeView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem modificaToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem addPersonToolStripMenuItem;
        private ToolStripMenuItem deletePersonToolStripMenuItem;
        private ToolStripMenuItem modifyPersonToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private TabControl tabControl1;
        private ImageList imageList1;
        private ToolStripMenuItem gironiToolStripMenuItem;
        private ToolStripMenuItem torneoToolStripMenuItem;
        private ToolStripMenuItem visualizzaTorneoToolStripMenuItem;
        private ToolStripMenuItem esportaPDFToolStripMenuItem;
        private ToolStripMenuItem creaToolStripMenuItem;
        private Label labelLog;
        private ToolStripMenuItem nuovoTorneoToolStripMenuItem;
        private ToolStripMenuItem modificaTorneiToolStripMenuItem;
        private ToolStripMenuItem eliminaTorneoToolStripMenuItem;
        private ToolStripMenuItem associazioniToolStripMenuItem;
        private ToolStripMenuItem aggiungiASDToolStripMenuItem;
        private ToolStripMenuItem modificaASDToolStripMenuItem;
        private ToolStripMenuItem eliminaASDToolStripMenuItem;
        private ToolStripMenuItem esportaGironiIncontriToolStripMenuItem;
        private Button buttonNextFase;
        private ToolStripMenuItem eliminatorieToolStripMenuItem;
        private ToolStripMenuItem carivaOttaviToolStripMenuItem;
        private ToolStripMenuItem caricaQuartiToolStripMenuItem;
        private ToolStripMenuItem caricaSemifinaliToolStripMenuItem;
        private ToolStripMenuItem caricaFinaliToolStripMenuItem;
        private ToolStripMenuItem bracketToolStripMenuItem;
        private ToolStripMenuItem reportisticaToolStripMenuItem;
        private ToolStripMenuItem atletiToolStripMenuItem;
        private ToolStripMenuItem associazioniToolStripMenuItem1;
        private ToolStripMenuItem atltetiEdAssociazioniToolStripMenuItem;
        private ToolStripMenuItem atletiInTorneoToolStripMenuItem;
        private ToolStripMenuItem risultatiTorneoToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem hemaRatingsToolStripMenuItem;
        private ToolStripMenuItem esportaTorneoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem cancellaEliminatorieToolStripMenuItem;
    }
}

