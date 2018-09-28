using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenHTMLCode
{
    public partial class Form1 : Form
    {
        Form form;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void tbTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (tbTitle.Text == "Title?")
            {
                tbTitle.Text = "";
            }
        }

        private void tbTitle_Leave(object sender, EventArgs e)
        {
            if (tbTitle.Text == "")
            {
                tbTitle.Text = "Title?";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text != "Title?" && tbTitle.Text != "" && tbCSS.Text != "CSS naam?" && tbCSS.Text != "")
            {
                form = this;
                HTMLCode NewForm = new HTMLCode(tbTitle.Text, tbCSS.Text);
                this.Hide();
                if (NewForm.ShowDialog() == DialogResult.Abort)
                {
                    this.Show();
                }
                
            }
        }

        private void tbCSS_MouseDown(object sender, MouseEventArgs e)
        {
            if (tbCSS.Text == "CSS name?")
            {
                tbCSS.Clear();
            }

        }

        private void tbCSS_Leave(object sender, EventArgs e)
        {
            if (tbCSS.Text == "")
            {
                tbCSS.Text = "CSS name?";
            }

        }
    }
}
