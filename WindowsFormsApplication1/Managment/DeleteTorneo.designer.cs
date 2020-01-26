namespace WindowsFormsApplication1
{
    partial class DeleteTorneo
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridViewTornei = new System.Windows.Forms.DataGridView();
            this.labeltornei = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTornei)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(572, 226);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Chiudi";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridViewTornei
            // 
            this.dataGridViewTornei.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTornei.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewTornei.Name = "dataGridViewTornei";
            this.dataGridViewTornei.Size = new System.Drawing.Size(635, 150);
            this.dataGridViewTornei.TabIndex = 1;
            this.dataGridViewTornei.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTornei_CellClick);
            // 
            // labeltornei
            // 
            this.labeltornei.AutoSize = true;
            this.labeltornei.Location = new System.Drawing.Point(13, 13);
            this.labeltornei.Name = "labeltornei";
            this.labeltornei.Size = new System.Drawing.Size(37, 13);
            this.labeltornei.TabIndex = 2;
            this.labeltornei.Text = "Tornei";
            // 
            // DeleteTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 261);
            this.Controls.Add(this.labeltornei);
            this.Controls.Add(this.dataGridViewTornei);
            this.Controls.Add(this.buttonClose);
            this.Name = "DeleteTorneo";
            this.Text = "Elimina Torneo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTornei)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridViewTornei;
        private System.Windows.Forms.Label labeltornei;
    }
}