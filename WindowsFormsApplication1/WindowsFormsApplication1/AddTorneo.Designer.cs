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
            this.dateTimePickerDataTorneo = new System.Windows.Forms.DateTimePicker();
            this.groupBoxDiscipline = new System.Windows.Forms.GroupBox();
            this.checkBoxSpagaPugnale = new System.Windows.Forms.CheckBox();
            this.checkBoxSpadaRotella = new System.Windows.Forms.CheckBox();
            this.checkBoxSpadaBrocchiero = new System.Windows.Forms.CheckBox();
            this.checkBoxSpadaDueMani = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxDiscipline.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNomeTorneo
            // 
            this.labelNomeTorneo.AutoSize = true;
            this.labelNomeTorneo.Location = new System.Drawing.Point(16, 32);
            this.labelNomeTorneo.Name = "labelNomeTorneo";
            this.labelNomeTorneo.Size = new System.Drawing.Size(72, 13);
            this.labelNomeTorneo.TabIndex = 0;
            this.labelNomeTorneo.Text = "Nome Torneo";
            // 
            // textBoxNomeTorneo
            // 
            this.textBoxNomeTorneo.Location = new System.Drawing.Point(19, 48);
            this.textBoxNomeTorneo.Name = "textBoxNomeTorneo";
            this.textBoxNomeTorneo.Size = new System.Drawing.Size(213, 20);
            this.textBoxNomeTorneo.TabIndex = 1;
            // 
            // labelDataTorneo
            // 
            this.labelDataTorneo.AutoSize = true;
            this.labelDataTorneo.Location = new System.Drawing.Point(16, 78);
            this.labelDataTorneo.Name = "labelDataTorneo";
            this.labelDataTorneo.Size = new System.Drawing.Size(67, 13);
            this.labelDataTorneo.TabIndex = 2;
            this.labelDataTorneo.Text = "Data Torneo";
            // 
            // dateTimePickerDataTorneo
            // 
            this.dateTimePickerDataTorneo.Location = new System.Drawing.Point(19, 95);
            this.dateTimePickerDataTorneo.Name = "dateTimePickerDataTorneo";
            this.dateTimePickerDataTorneo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDataTorneo.TabIndex = 3;
            // 
            // groupBoxDiscipline
            // 
            this.groupBoxDiscipline.Controls.Add(this.checkBoxSpadaDueMani);
            this.groupBoxDiscipline.Controls.Add(this.checkBoxSpadaBrocchiero);
            this.groupBoxDiscipline.Controls.Add(this.checkBoxSpadaRotella);
            this.groupBoxDiscipline.Controls.Add(this.checkBoxSpagaPugnale);
            this.groupBoxDiscipline.Location = new System.Drawing.Point(16, 129);
            this.groupBoxDiscipline.Name = "groupBoxDiscipline";
            this.groupBoxDiscipline.Size = new System.Drawing.Size(421, 100);
            this.groupBoxDiscipline.TabIndex = 4;
            this.groupBoxDiscipline.TabStop = false;
            this.groupBoxDiscipline.Text = "Discipline";
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
            // AddTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 296);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxDiscipline);
            this.Controls.Add(this.dateTimePickerDataTorneo);
            this.Controls.Add(this.labelDataTorneo);
            this.Controls.Add(this.textBoxNomeTorneo);
            this.Controls.Add(this.labelNomeTorneo);
            this.Name = "AddTorneo";
            this.Text = "Nuovo Torneo";
            this.groupBoxDiscipline.ResumeLayout(false);
            this.groupBoxDiscipline.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeTorneo;
        private System.Windows.Forms.TextBox textBoxNomeTorneo;
        private System.Windows.Forms.Label labelDataTorneo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataTorneo;
        private System.Windows.Forms.GroupBox groupBoxDiscipline;
        private System.Windows.Forms.CheckBox checkBoxSpadaDueMani;
        private System.Windows.Forms.CheckBox checkBoxSpadaBrocchiero;
        private System.Windows.Forms.CheckBox checkBoxSpadaRotella;
        private System.Windows.Forms.CheckBox checkBoxSpagaPugnale;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
    }
}