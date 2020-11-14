namespace windowformapp
{
    partial class FrmOyun
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlSkor = new System.Windows.Forms.Panel();
            this.lblSüre = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.pnlSkor.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlSkor
            // 
            this.pnlSkor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSkor.Controls.Add(this.lblSkor);
            this.pnlSkor.Controls.Add(this.lblSüre);
            this.pnlSkor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSkor.Location = new System.Drawing.Point(600, 0);
            this.pnlSkor.Name = "pnlSkor";
            this.pnlSkor.Size = new System.Drawing.Size(200, 450);
            this.pnlSkor.TabIndex = 0;
            // 
            // lblSüre
            // 
            this.lblSüre.AutoSize = true;
            this.lblSüre.Location = new System.Drawing.Point(62, 21);
            this.lblSüre.Name = "lblSüre";
            this.lblSüre.Size = new System.Drawing.Size(35, 13);
            this.lblSüre.TabIndex = 0;
            this.lblSüre.Text = "label1";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Location = new System.Drawing.Point(62, 62);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(35, 13);
            this.lblSkor.TabIndex = 1;
            this.lblSkor.Text = "label2";
            // 
            // tmrSure
            // 
            this.tmrSure.Interval = 1000;
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // FrmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSkor);
            this.Name = "FrmOyun";
            this.Text = "FrmOyun";
            this.Load += new System.EventHandler(this.FrmOyun_Load);
            this.pnlSkor.ResumeLayout(false);
            this.pnlSkor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlSkor;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblSüre;
        private System.Windows.Forms.Timer tmrSure;
    }
}