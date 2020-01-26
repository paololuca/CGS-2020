namespace WindowsFormsApplication1
{
    partial class Semifinali
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Semifinali));
            this.groupCampo2 = new System.Windows.Forms.GroupBox();
            this.buttonSalvaCampo2 = new System.Windows.Forms.Button();
            this.dataGridViewCampo2 = new System.Windows.Forms.DataGridView();
            this.groupCampo1 = new System.Windows.Forms.GroupBox();
            this.buttonSalvaCampo1 = new System.Windows.Forms.Button();
            this.dataGridViewCampo1 = new System.Windows.Forms.DataGridView();
            this.buttonStampa = new System.Windows.Forms.Button();
            this.buttonNextPhase = new System.Windows.Forms.Button();
            this.groupCampo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCampo2)).BeginInit();
            this.groupCampo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCampo1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCampo2
            // 
            this.groupCampo2.Controls.Add(this.buttonSalvaCampo2);
            this.groupCampo2.Controls.Add(this.dataGridViewCampo2);
            this.groupCampo2.Location = new System.Drawing.Point(12, 172);
            this.groupCampo2.Name = "groupCampo2";
            this.groupCampo2.Size = new System.Drawing.Size(945, 156);
            this.groupCampo2.TabIndex = 15;
            this.groupCampo2.TabStop = false;
            this.groupCampo2.Text = "Campo 2";
            // 
            // buttonSalvaCampo2
            // 
            this.buttonSalvaCampo2.Location = new System.Drawing.Point(864, 127);
            this.buttonSalvaCampo2.Name = "buttonSalvaCampo2";
            this.buttonSalvaCampo2.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvaCampo2.TabIndex = 2;
            this.buttonSalvaCampo2.Text = "Salva";
            this.buttonSalvaCampo2.UseVisualStyleBackColor = true;
            this.buttonSalvaCampo2.Click += new System.EventHandler(this.buttonSalvaCampo2_Click);
            // 
            // dataGridViewCampo2
            // 
            this.dataGridViewCampo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCampo2.Location = new System.Drawing.Point(7, 13);
            this.dataGridViewCampo2.Name = "dataGridViewCampo2";
            this.dataGridViewCampo2.Size = new System.Drawing.Size(711, 137);
            this.dataGridViewCampo2.TabIndex = 1;
            // 
            // groupCampo1
            // 
            this.groupCampo1.Controls.Add(this.buttonSalvaCampo1);
            this.groupCampo1.Controls.Add(this.dataGridViewCampo1);
            this.groupCampo1.Location = new System.Drawing.Point(12, 12);
            this.groupCampo1.Name = "groupCampo1";
            this.groupCampo1.Size = new System.Drawing.Size(945, 156);
            this.groupCampo1.TabIndex = 14;
            this.groupCampo1.TabStop = false;
            this.groupCampo1.Text = "Campo 1";
            // 
            // buttonSalvaCampo1
            // 
            this.buttonSalvaCampo1.Location = new System.Drawing.Point(864, 126);
            this.buttonSalvaCampo1.Name = "buttonSalvaCampo1";
            this.buttonSalvaCampo1.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvaCampo1.TabIndex = 1;
            this.buttonSalvaCampo1.Text = "Salva";
            this.buttonSalvaCampo1.UseVisualStyleBackColor = true;
            this.buttonSalvaCampo1.Click += new System.EventHandler(this.buttonSalvaCampo1_Click);
            // 
            // dataGridViewCampo1
            // 
            this.dataGridViewCampo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCampo1.Location = new System.Drawing.Point(7, 13);
            this.dataGridViewCampo1.Name = "dataGridViewCampo1";
            this.dataGridViewCampo1.Size = new System.Drawing.Size(711, 137);
            this.dataGridViewCampo1.TabIndex = 0;
            // 
            // buttonStampa
            // 
            this.buttonStampa.Location = new System.Drawing.Point(655, 334);
            this.buttonStampa.Name = "buttonStampa";
            this.buttonStampa.Size = new System.Drawing.Size(75, 23);
            this.buttonStampa.TabIndex = 17;
            this.buttonStampa.Text = "Stampa";
            this.buttonStampa.UseVisualStyleBackColor = true;
            this.buttonStampa.Click += new System.EventHandler(this.buttonStampa_Click);
            // 
            // buttonNextPhase
            // 
            this.buttonNextPhase.Location = new System.Drawing.Point(19, 334);
            this.buttonNextPhase.Name = "buttonNextPhase";
            this.buttonNextPhase.Size = new System.Drawing.Size(121, 23);
            this.buttonNextPhase.TabIndex = 16;
            this.buttonNextPhase.Text = "Passa alle finali";
            this.buttonNextPhase.UseVisualStyleBackColor = true;
            this.buttonNextPhase.Click += new System.EventHandler(this.buttonNextPhase_Click);
            // 
            // Semifinali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 371);
            this.Controls.Add(this.buttonStampa);
            this.Controls.Add(this.buttonNextPhase);
            this.Controls.Add(this.groupCampo2);
            this.Controls.Add(this.groupCampo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Semifinali";
            this.Text = "Semifinali";
            this.groupCampo2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCampo2)).EndInit();
            this.groupCampo1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCampo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCampo2;
        private System.Windows.Forms.Button buttonSalvaCampo2;
        private System.Windows.Forms.DataGridView dataGridViewCampo2;
        private System.Windows.Forms.GroupBox groupCampo1;
        private System.Windows.Forms.Button buttonSalvaCampo1;
        private System.Windows.Forms.DataGridView dataGridViewCampo1;
        private System.Windows.Forms.Button buttonStampa;
        private System.Windows.Forms.Button buttonNextPhase;
    }
}