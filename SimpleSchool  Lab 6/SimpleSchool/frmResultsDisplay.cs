using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSchool
{
    public partial class frmResultsDisplay : Form
    {
        public frmResultsDisplay(string content, string title)
        {
            InitializeComponent();

            Text = title;
            txtDisplay.Text = content;
            txtDisplay.SelectionStart = 0;
            txtDisplay.SelectionLength = 0;
        }

        private void txtDisplay_TextChanged()
        {
            InitializeComponent();
        }

        private void frmResultsDisplay_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
