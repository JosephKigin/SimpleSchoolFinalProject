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
    public partial class frmBlockGUI : Form
    {
        public frmBlockGUI()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sID = txtID.Text;
            string sStart = dtpStart.Text;
            string sEnd = dtpEnd.Text;
            if (sID.Length == 0 || sStart.Length == 0 || sEnd.Length == 0)
            {
                MessageBox.Show("Please ender all data.", "Data Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Block aBlock = new Block(Convert.ToInt32(sID),
                    dtpStart.Value, dtpEnd.Value);
                MessageBox.Show("Block is added", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                txtID.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtID.Text = "";
            dtpStart.Value = new DateTime(1800, 1, 1, 0, 0, 0);
            dtpEnd.Value = new DateTime(1800, 1, 1, 0, 0, 0);
            txtID.Focus();
        }
 
    }
}
