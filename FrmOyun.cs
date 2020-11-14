using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowformapp
{
    public partial class FrmOyun : Form
    {

        static int toplam = 0;
        static int sure = 10;


        public FrmOyun()
        {
            InitializeComponent();
        }

        private void FrmOyun_Load(object sender, EventArgs e)
        {
            timer1.Start();
            tmrSure.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            Button button = new Button();
            button.Location = new Point(random.Next(this.ClientSize.Width - pnlSkor.Width - button.Width), random.Next(this.ClientSize.Height - button.Height));
            button.Size = new Size(100, 50);
            button.Text = random.Next(100).ToString();
            button.Click += Button_Click;
            this.Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toplam += int.Parse(btn.Text);
            lblSkor.Text = $"Skor:{toplam}";
            btn.Dispose();//Bellekten atar
        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {                       
                sure--;
                lblSüre.Text = sure.ToString();
                if (sure == 0)
                {
                    Dur();
                    Kaydet();
                    DialogResult dialogResult = new DialogResult();
                    dialogResult = MessageBox.Show("Yeniden Oynar Mısınız", "Çıkış", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                    tmrSure.Stop();
                    sure = 3;
                    this.Hide();
                    FrmOyun oyun = new FrmOyun();
                    oyun.ShowDialog();
                    }
                else
                {
                    Application.Exit();
                }
            }                       
        }

        void Dur()
        {
            tmrSure.Stop();
            MessageBox.Show($"Oyun Bitti {lblSkor.Text}");
        }

        void Kaydet()
        {
            FileStream fileStream = new FileStream(@"C:\odev2.txt", FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(lblSkor.Text + " " + DateTime.Now);
            fileStream.Flush();
            streamWriter.Close();
            fileStream.Close();
        }

    }
}
