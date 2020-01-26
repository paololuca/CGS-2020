namespace WindowsFormsApplication1
{
    partial class ManageTournament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageTournament));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonLoadIscritti = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNumberOfAtleti = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnAddAtleta = new System.Windows.Forms.Button();
            this.comboBoxAtletaToAdd = new System.Windows.Forms.ComboBox();
            this.buttonPrintList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(309, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 97);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 61);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Femminile";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Maschile";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(807, 493);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(110, 23);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Chiudi";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonLoadIscritti
            // 
            this.buttonLoadIscritti.Location = new System.Drawing.Point(624, 84);
            this.buttonLoadIscritti.Name = "buttonLoadIscritti";
            this.buttonLoadIscritti.Size = new System.Drawing.Size(110, 23);
            this.buttonLoadIscritti.TabIndex = 11;
            this.buttonLoadIscritti.Text = "Visualizza Iscritti";
            this.buttonLoadIscritti.UseVisualStyleBackColor = true;
            this.buttonLoadIscritti.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Disciplina";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(21, 86);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(259, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Torneo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 376);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblNumberOfAtleti
            // 
            this.lblNumberOfAtleti.AutoSize = true;
            this.lblNumberOfAtleti.Location = new System.Drawing.Point(21, 532);
            this.lblNumberOfAtleti.Name = "lblNumberOfAtleti";
            this.lblNumberOfAtleti.Size = new System.Drawing.Size(112, 13);
            this.lblNumberOfAtleti.TabIndex = 15;
            this.lblNumberOfAtleti.Text = "Numero Partecipanti : ";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(140, 532);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 16;
            // 
            // btnAddAtleta
            // 
            this.btnAddAtleta.Enabled = false;
            this.btnAddAtleta.Location = new System.Drawing.Point(624, 140);
            this.btnAddAtleta.Name = "btnAddAtleta";
            this.btnAddAtleta.Size = new System.Drawing.Size(110, 23);
            this.btnAddAtleta.TabIndex = 17;
            this.btnAddAtleta.Text = "Aggiungi";
            this.btnAddAtleta.UseVisualStyleBackColor = true;
            this.btnAddAtleta.Click += new System.EventHandler(this.btnAddAtleta_Click);
            // 
            // comboBoxAtletaToAdd
            // 
            this.comboBoxAtletaToAdd.FormattingEnabled = true;
            this.comboBoxAtletaToAdd.Location = new System.Drawing.Point(624, 182);
            this.comboBoxAtletaToAdd.Name = "comboBoxAtletaToAdd";
            this.comboBoxAtletaToAdd.Size = new System.Drawing.Size(293, 21);
            this.comboBoxAtletaToAdd.TabIndex = 18;
            // 
            // buttonPrintList
            // 
            this.buttonPrintList.Location = new System.Drawing.Point(624, 492);
            this.buttonPrintList.Name = "buttonPrintList";
            this.buttonPrintList.Size = new System.Drawing.Size(75, 23);
            this.buttonPrintList.TabIndex = 19;
            this.buttonPrintList.Text = "Stampa Elenco";
            this.buttonPrintList.UseVisualStyleBackColor = true;
            this.buttonPrintList.Click += new System.EventHandler(this.buttonPrintList_Click);
            // 
            // ManageTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 557);
            this.Controls.Add(this.buttonPrintList);
            this.Controls.Add(this.comboBoxAtletaToAdd);
            this.Controls.Add(this.btnAddAtleta);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblNumberOfAtleti);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonLoadIscritti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageTournament";
            this.Text = "Gestione Tornei";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonLoadIscritti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNumberOfAtleti;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnAddAtleta;
        private System.Windows.Forms.ComboBox comboBoxAtletaToAdd;
        private System.Windows.Forms.Button buttonPrintList;
    }
}