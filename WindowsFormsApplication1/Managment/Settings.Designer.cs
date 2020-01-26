namespace WindowsFormsApplication1
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.groupBoxTest = new System.Windows.Forms.GroupBox();
            this.rbtTest = new System.Windows.Forms.RadioButton();
            this.rbtFemminile = new System.Windows.Forms.RadioButton();
            this.rbtMaschile = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxCreazione = new System.Windows.Forms.GroupBox();
            this.chbCreazione = new System.Windows.Forms.CheckBox();
            this.groupBoxDebug = new System.Windows.Forms.GroupBox();
            this.chbDebug = new System.Windows.Forms.CheckBox();
            this.groupBoxTest.SuspendLayout();
            this.groupBoxCreazione.SuspendLayout();
            this.groupBoxDebug.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTest
            // 
            this.groupBoxTest.Controls.Add(this.rbtTest);
            this.groupBoxTest.Controls.Add(this.rbtFemminile);
            this.groupBoxTest.Controls.Add(this.rbtMaschile);
            this.groupBoxTest.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTest.Name = "groupBoxTest";
            this.groupBoxTest.Size = new System.Drawing.Size(464, 69);
            this.groupBoxTest.TabIndex = 0;
            this.groupBoxTest.TabStop = false;
            this.groupBoxTest.Text = "Data Base";
            // 
            // rbtTest
            // 
            this.rbtTest.AutoSize = true;
            this.rbtTest.Location = new System.Drawing.Point(192, 31);
            this.rbtTest.Name = "rbtTest";
            this.rbtTest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtTest.Size = new System.Drawing.Size(64, 17);
            this.rbtTest.TabIndex = 2;
            this.rbtTest.TabStop = true;
            this.rbtTest.Text = "DB Test";
            this.rbtTest.UseVisualStyleBackColor = true;
            this.rbtTest.CheckedChanged += new System.EventHandler(this.rbtTest_CheckedChanged);
            // 
            // rbtFemminile
            // 
            this.rbtFemminile.AutoSize = true;
            this.rbtFemminile.Location = new System.Drawing.Point(97, 31);
            this.rbtFemminile.Name = "rbtFemminile";
            this.rbtFemminile.Size = new System.Drawing.Size(89, 17);
            this.rbtFemminile.TabIndex = 1;
            this.rbtFemminile.Text = "DB Femminile";
            this.rbtFemminile.UseVisualStyleBackColor = true;
            this.rbtFemminile.CheckedChanged += new System.EventHandler(this.rbtTestTrue_CheckedChanged);
            // 
            // rbtMaschile
            // 
            this.rbtMaschile.AutoSize = true;
            this.rbtMaschile.Location = new System.Drawing.Point(6, 31);
            this.rbtMaschile.Name = "rbtMaschile";
            this.rbtMaschile.Size = new System.Drawing.Size(85, 17);
            this.rbtMaschile.TabIndex = 0;
            this.rbtMaschile.Text = "DB Maschile";
            this.rbtMaschile.UseVisualStyleBackColor = true;
            this.rbtMaschile.CheckedChanged += new System.EventHandler(this.rbtTestFalse_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(402, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Salva";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(20, 294);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Chiudi";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBoxCreazione
            // 
            this.groupBoxCreazione.Controls.Add(this.chbCreazione);
            this.groupBoxCreazione.Location = new System.Drawing.Point(13, 88);
            this.groupBoxCreazione.Name = "groupBoxCreazione";
            this.groupBoxCreazione.Size = new System.Drawing.Size(464, 51);
            this.groupBoxCreazione.TabIndex = 3;
            this.groupBoxCreazione.TabStop = false;
            this.groupBoxCreazione.Text = "Creazione Gironi";
            // 
            // chbCreazione
            // 
            this.chbCreazione.AutoSize = true;
            this.chbCreazione.Location = new System.Drawing.Point(7, 20);
            this.chbCreazione.Name = "chbCreazione";
            this.chbCreazione.Size = new System.Drawing.Size(78, 17);
            this.chbCreazione.TabIndex = 0;
            this.chbCreazione.Text = "Crea Gironi";
            this.chbCreazione.UseVisualStyleBackColor = true;
            // 
            // groupBoxDebug
            // 
            this.groupBoxDebug.Controls.Add(this.chbDebug);
            this.groupBoxDebug.Location = new System.Drawing.Point(13, 202);
            this.groupBoxDebug.Name = "groupBoxDebug";
            this.groupBoxDebug.Size = new System.Drawing.Size(464, 51);
            this.groupBoxDebug.TabIndex = 5;
            this.groupBoxDebug.TabStop = false;
            this.groupBoxDebug.Text = "Output di Debug";
            // 
            // chbDebug
            // 
            this.chbDebug.AutoSize = true;
            this.chbDebug.Location = new System.Drawing.Point(7, 20);
            this.chbDebug.Name = "chbDebug";
            this.chbDebug.Size = new System.Drawing.Size(58, 17);
            this.chbDebug.TabIndex = 0;
            this.chbDebug.Text = "Debug";
            this.chbDebug.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 329);
            this.Controls.Add(this.groupBoxDebug);
            this.Controls.Add(this.groupBoxCreazione);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBoxTest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.groupBoxTest.ResumeLayout(false);
            this.groupBoxTest.PerformLayout();
            this.groupBoxCreazione.ResumeLayout(false);
            this.groupBoxCreazione.PerformLayout();
            this.groupBoxDebug.ResumeLayout(false);
            this.groupBoxDebug.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTest;
        private System.Windows.Forms.RadioButton rbtFemminile;
        private System.Windows.Forms.RadioButton rbtMaschile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rbtTest;
        private System.Windows.Forms.GroupBox groupBoxCreazione;
        private System.Windows.Forms.CheckBox chbCreazione;
        private System.Windows.Forms.GroupBox groupBoxDebug;
        private System.Windows.Forms.CheckBox chbDebug;
    }
}