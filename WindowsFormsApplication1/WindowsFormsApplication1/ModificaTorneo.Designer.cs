namespace WindowsFormsApplication1
{
    partial class ModificaTorneo
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
            this.comboBoxTornei = new System.Windows.Forms.ComboBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelTournaments = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxDiscipline = new System.Windows.Forms.GroupBox();
            this.checkBoxSpadaDueMani = new System.Windows.Forms.CheckBox();
            this.checkBoxSpadaBrocchiero = new System.Windows.Forms.CheckBox();
            this.checkBoxSpadaRotella = new System.Windows.Forms.CheckBox();
            this.checkBoxSpagaPugnale = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDataTorneo = new System.Windows.Forms.DateTimePicker();
            this.labelDataTorneo = new System.Windows.Forms.Label();
            this.textBoxNomeTorneo = new System.Windows.Forms.TextBox();
            this.labelNomeTorneo = new System.Windows.Forms.Label();
            this.groupBoxDiscipline.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTornei
            // 
            this.comboBoxTornei.FormattingEnabled = true;
            this.comboBoxTornei.Location = new System.Drawing.Point(13, 29);
            this.comboBoxTornei.Name = "comboBoxTornei";
            this.comboBoxTornei.Size = new System.Drawing.Size(229, 21);
            this.comboBoxTornei.TabIndex = 0;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(261, 29);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Carica";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelTournaments
            // 
            this.labelTournaments.AutoSize = true;
            this.labelTournaments.Location = new System.Drawing.Point(10, 12);
            this.labelTournaments.Name = "labelTournaments";
            this.labelTournaments.Size = new System.Drawing.Size(37, 13);
            this.labelTournaments.TabIndex = 2;
            this.labelTournaments.Text = "Tornei";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(355, 307);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "Chiudi";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(13, 307);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Salva";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxDiscipline
            // 
            this.groupBoxDiscipline.Controls.Add(this.checkBoxSpadaDueMani);
            this.groupBoxDiscipline.Controls.Add(this.checkBoxSpadaBrocchiero);
            this.groupBoxDiscipline.Controls.Add(this.checkBoxSpadaRotella);
            this.groupBoxDiscipline.Controls.Add(this.checkBoxSpagaPugnale);
            this.groupBoxDiscipline.Location = new System.Drawing.Point(13, 178);
            this.groupBoxDiscipline.Name = "groupBoxDiscipline";
            this.groupBoxDiscipline.Size = new System.Drawing.Size(421, 100);
            this.groupBoxDiscipline.TabIndex = 11;
            this.groupBoxDiscipline.TabStop = false;
            this.groupBoxDiscipline.Text = "Discipline";
            // 
            // checkBoxSpadaDueMani
            // 
            this.checkBoxSpadaDueMani.AutoSize = true;
            this.checkBoxSpadaDueMani.Location = new System.Drawing.Point(128, 58);
            this.checkBoxSpadaDueMani.Name = "checkBoxSpadaDueMani";
            this.checkBoxSpadaDueMani.Size = new System.Drawing.Size(112, 17);
            this.checkBoxSpadaDueMani.TabIndex = 3;
            this.checkBoxSpadaDueMani.Text = "Spada a due mani";
            this.checkBoxSpadaDueMani.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpadaBrocchiero
            // 
            this.checkBoxSpadaBrocchiero.AutoSize = true;
            this.checkBoxSpadaBrocchiero.Location = new System.Drawing.Point(128, 20);
            this.checkBoxSpadaBrocchiero.Name = "checkBoxSpadaBrocchiero";
            this.checkBoxSpadaBrocchiero.Size = new System.Drawing.Size(120, 17);
            this.checkBoxSpadaBrocchiero.TabIndex = 2;
            this.checkBoxSpadaBrocchiero.Text = "Spada e Brocchiero";
            this.checkBoxSpadaBrocchiero.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpadaRotella
            // 
            this.checkBoxSpadaRotella.AutoSize = true;
            this.checkBoxSpadaRotella.Location = new System.Drawing.Point(7, 58);
            this.checkBoxSpadaRotella.Name = "checkBoxSpadaRotella";
            this.checkBoxSpadaRotella.Size = new System.Drawing.Size(102, 17);
            this.checkBoxSpadaRotella.TabIndex = 1;
            this.checkBoxSpadaRotella.Text = "Spada e Rotella";
            this.checkBoxSpadaRotella.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpagaPugnale
            // 
            this.checkBoxSpagaPugnale.AutoSize = true;
            this.checkBoxSpagaPugnale.Location = new System.Drawing.Point(7, 20);
            this.checkBoxSpagaPugnale.Name = "checkBoxSpagaPugnale";
            this.checkBoxSpagaPugnale.Size = new System.Drawing.Size(108, 17);
            this.checkBoxSpagaPugnale.TabIndex = 0;
            this.checkBoxSpagaPugnale.Text = "Spada e Pugnale";
            this.checkBoxSpagaPugnale.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDataTorneo
            // 
            this.dateTimePickerDataTorneo.Location = new System.Drawing.Point(13, 140);
            this.dateTimePickerDataTorneo.Name = "dateTimePickerDataTorneo";
            this.dateTimePickerDataTorneo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDataTorneo.TabIndex = 10;
            // 
            // labelDataTorneo
            // 
            this.labelDataTorneo.AutoSize = true;
            this.labelDataTorneo.Location = new System.Drawing.Point(10, 124);
            this.labelDataTorneo.Name = "labelDataTorneo";
            this.labelDataTorneo.Size = new System.Drawing.Size(67, 13);
            this.labelDataTorneo.TabIndex = 9;
            this.labelDataTorneo.Text = "Data Torneo";
            // 
            // textBoxNomeTorneo
            // 
            this.textBoxNomeTorneo.Location = new System.Drawing.Point(13, 94);
            this.textBoxNomeTorneo.Name = "textBoxNomeTorneo";
            this.textBoxNomeTorneo.Size = new System.Drawing.Size(213, 20);
            this.textBoxNomeTorneo.TabIndex = 8;
            // 
            // labelNomeTorneo
            // 
            this.labelNomeTorneo.AutoSize = true;
            this.labelNomeTorneo.Location = new System.Drawing.Point(10, 78);
            this.labelNomeTorneo.Name = "labelNomeTorneo";
            this.labelNomeTorneo.Size = new System.Drawing.Size(72, 13);
            this.labelNomeTorneo.TabIndex = 7;
            this.labelNomeTorneo.Text = "Nome Torneo";
            // 
            // ModificaTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 341);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxDiscipline);
            this.Controls.Add(this.dateTimePickerDataTorneo);
            this.Controls.Add(this.labelDataTorneo);
            this.Controls.Add(this.textBoxNomeTorneo);
            this.Controls.Add(this.labelNomeTorneo);
            this.Controls.Add(this.labelTournaments);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.comboBoxTornei);
            this.Name = "ModificaTorneo";
            this.Text = "Modifica Tornei";
            this.groupBoxDiscipline.ResumeLayout(false);
            this.groupBoxDiscipline.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTornei;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelTournaments;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxDiscipline;
        private System.Windows.Forms.CheckBox checkBoxSpadaDueMani;
        private System.Windows.Forms.CheckBox checkBoxSpadaBrocchiero;
        private System.Windows.Forms.CheckBox checkBoxSpadaRotella;
        private System.Windows.Forms.CheckBox checkBoxSpagaPugnale;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataTorneo;
        private System.Windows.Forms.Label labelDataTorneo;
        private System.Windows.Forms.TextBox textBoxNomeTorneo;
        private System.Windows.Forms.Label labelNomeTorneo;
    }
}