using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace diabetes
{
    public partial class Form1 : Form
    {
        int A;
        int B;
        int C;
        Random X = new Random(0);
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            


        }

        private void Infiniminer()
        {
            while (true)
            {
                A = X.Next(0, 255);
                B = X.Next(0, 255);
                C = X.Next(0, 255);
                this.BackColor = Color.FromArgb(A, B, C);
            }


        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            A = X.Next(0, 255);
            B = X.Next(0, 255);
            C = X.Next(0, 255);
            this.BackColor = Color.FromArgb(A, B, C);


        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

        }

        private void Form1_BackColorChanged(object sender, EventArgs e)
        {
            try
            {
                A = X.Next(0, 255);
                B = X.Next(0, 255);
                C = X.Next(0, 255);
                this.BackColor = Color.FromArgb(A, B, C);
            }
            catch { }
        }
    }
}

