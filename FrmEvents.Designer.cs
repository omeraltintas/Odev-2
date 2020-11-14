namespace windowformapp
{
    partial class FrmEvents
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
            this.btnS1 = new System.Windows.Forms.Button();
            this.btnS2 = new System.Windows.Forms.Button();
            this.btnS3 = new System.Windows.Forms.Button();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnS1
            // 
            this.btnS1.Location = new System.Drawing.Point(209, 55);
            this.btnS1.Name = "btnS1";
            this.btnS1.Size = new System.Drawing.Size(75, 23);
            this.btnS1.TabIndex = 0;
            this.btnS1.Text = "1.BUTON";
            this.btnS1.UseVisualStyleBackColor = true;
            this.btnS1.Click += new System.EventHandler(this.Click);
            // 
            // btnS2
            // 
            this.btnS2.Location = new System.Drawing.Point(209, 109);
            this.btnS2.Name = "btnS2";
            this.btnS2.Size = new System.Drawing.Size(75, 23);
            this.btnS2.TabIndex = 1;
            this.btnS2.Text = "2.BUTON";
            this.btnS2.UseVisualStyleBackColor = true;
            this.btnS2.Click += new System.EventHandler(this.Click);
            // 
            // btnS3
            // 
            this.btnS3.Location = new System.Drawing.Point(209, 159);
            this.btnS3.Name = "btnS3";
            this.btnS3.Size = new System.Drawing.Size(75, 23);
            this.btnS3.TabIndex = 2;
            this.btnS3.Text = "3.BUTON";
            this.btnS3.UseVisualStyleBackColor = true;
            this.btnS3.Click += new System.EventHandler(this.Click);
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(150, 200);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(210, 45);
            this.btnSonuc.TabIndex = 3;
            this.btnSonuc.Text = "Sonuç";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // FrmEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.btnS3);
            this.Controls.Add(this.btnS2);
            this.Controls.Add(this.btnS1);
            this.Name = "FrmEvents";
            this.Text = "FrmEvents";
            this.Load += new System.EventHandler(this.FrmEvents_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnS1;
        private System.Windows.Forms.Button btnS2;
        private System.Windows.Forms.Button btnS3;
        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.Timer tmr;
    }
}