using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorMessages
{
    public partial class Form1 : Form
    {
        string[] errors;
        int ErrorAmount = 0;
        int i = 0;
        Random X = new Random();
        public Form1()
        {
            InitializeComponent();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ErrorAmount = 0;
            errors = System.IO.File.ReadAllLines(@"error.txt");
            while (i < 10000)
            {
                int Q = X.Next(0, errors.Length - 1);
                lbErrors.Items.Add(errors[Q]);
                ErrorAmount++;
                lbErrors.SetSelected(ErrorAmount-1,true);
                lblErrorAmount.Text = Convert.ToString(ErrorAmount);
                i++;
                lblErrorAmount.Refresh();
            }
        }
    }
}
