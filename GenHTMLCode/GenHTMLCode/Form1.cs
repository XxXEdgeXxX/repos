using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GenHTMLCode
{
    public partial class Form1 : Form
    {
        public Standaard Basic = new Standaard();
        XmlSerializer serializer = new XmlSerializer(typeof(Standaard));
        public Form1()
        {
            InitializeComponent();
            if (File.Exists(@"Default.xml"))
            {

                FileStream ReadFileStream = new FileStream(@"Default.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Basic = (Standaard)serializer.Deserialize(ReadFileStream);
                if (Basic.Title != null && Basic.CSS != null)
                {
                    tbTitle.Text = Basic.Title;
                    tbCSS.Text = Basic.CSS;
                }


                ReadFileStream.Close();
            }



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
                if (tbCSS.Text.Contains(".css"))
                {
                    tbCSS.Text.Replace(".css", "");
                }

                if (cbDefault.Checked)
                {
                    Basic.ChangeVars(tbTitle.Text, tbCSS.Text);
                    StreamWriter writer = new StreamWriter(@"Default.xml");
                    serializer.Serialize(writer, Basic);
                }





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
