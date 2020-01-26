using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApplication1
{
    partial class CaricaGironiDaDisciplina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public int IdDisciplina { get; set; }
        public int IdTorneo { get; set; }
        public String Categoria { get; set; }
        public String NomeTorneo { get; set; }
        public String Disciplina { get; set; }

        public CaricaGironiDaDisciplina(int idTorneo)
        {
            IdTorneo = idTorneo;
        }

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
        /// 
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFemminile = new System.Windows.Forms.RadioButton();
            this.radioButtonMaschile = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Torneo";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(11, 110);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(259, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Disciplina";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(11, 262);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Carica Gironi";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(195, 262);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Annulla";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFemminile);
            this.groupBox1.Controls.Add(this.radioButtonMaschile);
            this.groupBox1.Location = new System.Drawing.Point(13, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 97);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // radioButtonFemminile
            // 
            this.radioButtonFemminile.AutoSize = true;
            this.radioButtonFemminile.Location = new System.Drawing.Point(7, 61);
            this.radioButtonFemminile.Name = "radioButtonFemminile";
            this.radioButtonFemminile.Size = new System.Drawing.Size(71, 17);
            this.radioButtonFemminile.TabIndex = 1;
            this.radioButtonFemminile.TabStop = true;
            this.radioButtonFemminile.Text = "Femminile";
            this.radioButtonFemminile.UseVisualStyleBackColor = true;
            this.radioButtonFemminile.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonMaschile
            // 
            this.radioButtonMaschile.AutoSize = true;
            this.radioButtonMaschile.Checked = true;
            this.radioButtonMaschile.Location = new System.Drawing.Point(7, 28);
            this.radioButtonMaschile.Name = "radioButtonMaschile";
            this.radioButtonMaschile.Size = new System.Drawing.Size(67, 17);
            this.radioButtonMaschile.TabIndex = 0;
            this.radioButtonMaschile.TabStop = true;
            this.radioButtonMaschile.Text = "Maschile";
            this.radioButtonMaschile.UseVisualStyleBackColor = true;
            this.radioButtonMaschile.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CaricaGironiDaDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 297);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "CaricaGironiDaDisciplina";
            this.Text = "Carica Gironi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;

        

        private ComboBox comboBox2;
        private Label label2;
        private Button buttonOk;
        private Button buttonCancel;
        private GroupBox groupBox1;
        private RadioButton radioButtonFemminile;
        private RadioButton radioButtonMaschile;
    }
}