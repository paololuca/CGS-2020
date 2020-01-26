namespace WindowsFormsApplication1
{
    partial class AddTorneo
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
            this.labelNomeTorneo = new System.Windows.Forms.Label();
            this.textBoxNomeTorneo = new System.Windows.Forms.TextBox();
            this.labelDataTorneo = new System.Windows.Forms.Label();
            this.dateTimePickerDataInizioTorneo = new System.Windows.Forms.DateTimePicker();
            this.groupBoxDiscipline = new System.Windows.Forms.GroupBox();
            this.checkBoxSpadaDueMani = new System.Windows.Forms.CheckBox();
            this.checkBoxSpadaBrocchiero = new System.Windows.Forms.CheckBox();
            this.checkBoxSpadaRotella = new System.Windows.Forms.CheckBox();
            this.checkBoxSpagaPugnale = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLuogo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDataFineTorneo = new System.Windows.Forms.DateTimePicker();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.checkBoxSpadaSola = new System.Windows.Forms.CheckBox();
            this.groupBoxDiscipline.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNomeTorneo
            // 
            this.labelNomeTorneo.AutoSize = true;
            this.labelNomeTorneo.Location = new System.Drawing.Point(16, 11);
            this.labelNomeTorneo.Name = "labelNomeTorneo";
            this.labelNomeTorneo.Size = new System.Drawing.Size(72, 13);
            this.labelNomeTorneo.TabIndex = 0;
            this.labelNomeTorneo.Text = "Nome Torneo";
            // 
            // textBoxNomeTorneo
            // 
            this.textBoxNomeTorneo.Location = new System.Drawing.Point(19, 27);
            this.textBoxNomeTorneo.Name = "textBoxNomeTorneo";
            this.textBoxNomeTorneo.Size = new System.Drawing.Size(213, 20);
            this.textBoxNomeTorneo.TabIndex = 1;
            // 
            // labelDataTorneo
            // 
            this.labelDataTorneo.AutoSize = true;
            this.labelDataTorneo.Location = new System.Drawing.Point(16, 99);
            this.labelDataTorneo.Name = "labelDataTorneo";
            this.labelDataTorneo.Size = new System.Drawing.Size(93, 13);
            this.labelDataTorneo.TabIndex = 2;
            this.labelDataTorneo.Text = "Data inizio Torneo";
            // 
            // dateTimePickerDataInizioTorneo
            // 
            this.dateTimePickerDataInizioTorneo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataInizioTorneo.Location = new System.Drawing.Point(19, 118);
            this.dateTimePickerDataInizioTorneo.Name = "dateTimePickerDataInizioTorneo";
            this.dateTimePickerDataInizioTorneo.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerDataInizioTorneo.TabIndex = 3;
            // 
            // groupBoxDiscipline
            // 
            this.groupBoxDiscipline.Controls.Add(this.checkBoxSpadaSola);
            this.groupBoxDiscipline.Controls.Add(this.checkBoxSpadaDueMani);
            this.groupBoxDiscipline.Controls.Add(this.checkBoxSpadaBrocchiero);
            this.groupBoxDiscipline.Controls.Add(this.checkBoxSpadaRotella);
            this.groupBoxDiscipline.Controls.Add(this.checkBoxSpagaPugnale);
            this.groupBoxDiscipline.Location = new System.Drawing.Point(16, 154);
            this.groupBoxDiscipline.Name = "groupBoxDiscipline";
            this.groupBoxDiscipline.Size = new System.Drawing.Size(421, 100);
            this.groupBoxDiscipline.TabIndex = 4;
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
            this.checkBoxSpadaBrocchiero.Location = new System.Drawing.Point(249, 19);
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
            this.checkBoxSpagaPugnale.Location = new System.Drawing.Point(128, 19);
            this.checkBoxSpagaPugnale.Name = "checkBoxSpagaPugnale";
            this.checkBoxSpagaPugnale.Size = new System.Drawing.Size(108, 17);
            this.checkBoxSpagaPugnale.TabIndex = 0;
            this.checkBoxSpagaPugnale.Text = "Spada e Pugnale";
            this.checkBoxSpagaPugnale.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(19, 261);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Salva";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(361, 261);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Chiudi";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Luogo";
            // 
            // textBoxLuogo
            // 
            this.textBoxLuogo.Location = new System.Drawing.Point(19, 70);
            this.textBoxLuogo.Name = "textBoxLuogo";
            this.textBoxLuogo.Size = new System.Drawing.Size(213, 20);
            this.textBoxLuogo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data fine Torneo";
            // 
            // dateTimePickerDataFineTorneo
            // 
            this.dateTimePickerDataFineTorneo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataFineTorneo.Location = new System.Drawing.Point(195, 118);
            this.dateTimePickerDataFineTorneo.Name = "dateTimePickerDataFineTorneo";
            this.dateTimePickerDataFineTorneo.Size = new System.Drawing.Size(156, 20);
            this.dateTimePickerDataFineTorneo.TabIndex = 10;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Location = new System.Drawing.Point(268, 16);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(169, 80);
            this.groupBoxGender.TabIndex = 11;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Categoria";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(7, 44);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(71, 17);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Femminile";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.Location = new System.Drawing.Point(7, 20);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(67, 17);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Maschile";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpadaSola
            // 
            this.checkBoxSpadaSola.AutoSize = true;
            this.checkBoxSpadaSola.Location = new System.Drawing.Point(7, 19);
            this.checkBoxSpadaSola.Name = "checkBoxSpadaSola";
            this.checkBoxSpadaSola.Size = new System.Drawing.Size(81, 17);
            this.checkBoxSpadaSola.TabIndex = 4;
            this.checkBoxSpadaSola.Text = "Spada Sola";
            this.checkBoxSpadaSola.UseVisualStyleBackColor = true;
            // 
            // AddTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 296);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.dateTimePickerDataFineTorneo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLuogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxDiscipline);
            this.Controls.Add(this.dateTimePickerDataInizioTorneo);
            this.Controls.Add(this.labelDataTorneo);
            this.Controls.Add(this.textBoxNomeTorneo);
            this.Controls.Add(this.labelNomeTorneo);
            this.Name = "AddTorneo";
            this.Text = "Nuovo Torneo";
            this.groupBoxDiscipline.ResumeLayout(false);
            this.groupBoxDiscipline.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeTorneo;
        private System.Windows.Forms.TextBox textBoxNomeTorneo;
        private System.Windows.Forms.Label labelDataTorneo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInizioTorneo;
        private System.Windows.Forms.GroupBox groupBoxDiscipline;
        private System.Windows.Forms.CheckBox checkBoxSpadaDueMani;
        private System.Windows.Forms.CheckBox checkBoxSpadaBrocchiero;
        private System.Windows.Forms.CheckBox checkBoxSpadaRotella;
        private System.Windows.Forms.CheckBox checkBoxSpagaPugnale;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLuogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFineTorneo;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.CheckBox checkBoxSpadaSola;
    }
}