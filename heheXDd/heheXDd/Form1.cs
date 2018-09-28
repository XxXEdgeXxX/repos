using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heheXDd
{
    public partial class Form1 : Form
    {
        Random X = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Size Q)
        {
            this.Size = Q;
            
            
            BackColor = Color.FromArgb(X.Next(0,255), X.Next(0, 255), X.Next(0, 255));
            
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Size Y = new Size();
            Y.Width = X.Next(0, 1000);
            Y.Height = X.Next(0, 1000);
            Form1 jeff = new Form1(Y);
            jeff.Show();
            e.Cancel = true;
        }
    }
}
