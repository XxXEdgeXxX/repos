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
    public partial class HTMLCode : Form
    {
        
        
        public HTMLCode(string Title, string CSS)
        {                        
            InitializeComponent();
            MakeHTML(Title, CSS);
            
        }
        
        private string MakeHTML(string Title, string CSS)
        {
            string HTML = string.Format(
                "<!DOCTYPE html>{2}"
              + "  <HTML>{2}"
              + "    <meta charset=\"utf-8\">{2}"
              + "      <head>{2}"
              + "        \t<title>{0}</title>{2}"
              + "        \t<link rel=\"stylesheet\" type=\"text/css\" href=\"{1}.css\"{2}>"
              + "      </head>{2}"
              + "      <body></body>{2}"
              + "  </html>"
              , Title, CSS, Environment.NewLine);            
            tbCode.Text = HTML;
            return HTML;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void HTMLCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }
    }
}
