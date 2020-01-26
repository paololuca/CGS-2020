using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class SplashForm : Form
    {
        private Panel panel1;
        private System.ComponentModel.IContainer components;
        private Label label1;
        public Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Thread thread;

        //Delegate for cross thread call to close
        private delegate void CloseDelegate();

        internal void CloseForm()
        {
            this.Close();
        }

        //The type of form to be displayed as the splash screen.
        private static SplashForm splashForm;

        private Mutex mutex = new Mutex();
        
        public SplashForm()
        {
            InitializeComponent();
        }

        public void ShowSplashScreen()
        {
            // Make sure it is only launched once.
            if (splashForm != null)
                return;

            thread = new Thread(new ThreadStart(this.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void ShowForm()
        {            
            splashForm = new SplashForm();
            splashForm.FormBorderStyle = FormBorderStyle.None;
            splashForm.StartPosition = FormStartPosition.CenterScreen;
            //splashForm.Size = new Size(679, 569);
            //splashForm.InitializeComponent();
            Application.Run(splashForm);
        }

        private void CloseFormInternal()
        {
            splashForm.Close();
        }

        public void SyncedClose()
        {
            mutex.WaitOne();
            this.Close();
            if((thread != null) && (thread.ThreadState == ThreadState.Running || thread.ThreadState == ThreadState.Background))
                thread.Abort();
            mutex.ReleaseMutex();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 390);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loading components....";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(-30, -30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 416);
            this.label1.TabIndex = 0;
            this.label1.UseWaitCursor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(1, 386);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(624, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.UseWaitCursor = true;
            this.progressBar1.Value = 1000;
            // 
            // SplashForm
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(625, 409);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashForm";
            this.UseWaitCursor = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
