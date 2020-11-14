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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                    
            Size s = new Size(100,50);
            Point point = new Point(100, 100);//Dinamik buton oluşturma
            Button button = new Button();
            button.BackColor = Color.Red;
            button.Text = "button";
            button.Size = s;
            button.Location = point;
            this.Controls.Add(button);
            button.Click += new EventHandler(this.button_click);
            
        }
        private void button_click(object sender,EventArgs e)
        {
            MessageBox.Show("Test");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
