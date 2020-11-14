using System;
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
    public partial class FrmEvents : Form
    {
        int toplam = 0;
        public FrmEvents()
        {
            //Ctorlar değer atama işlemleri için daha uygundur
            InitializeComponent();
            Random random = new Random();
            btnS1.Text = random.Next(100).ToString();
            btnS2.Text= random.Next(100).ToString();
            btnS3.Text= random.Next(100).ToString();           
        }
        void Click(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;
            toplam += int.Parse(button.Text);
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Toplam: {toplam}");
        }

        private void FrmEvents_Load(object sender, EventArgs e)
        {
            //form açıldığında yapılacak olan işer
            tmr.Start();
           
        }

        private void tmr_Tick(object sender, EventArgs e)
        {

        }
    }
}
