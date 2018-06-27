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
    public partial class frmDayGUI : Form
    {
        Day aDay;
        string aDayCode;
        string aDayName;

        public frmDayGUI()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            txtCode.Text = "";
            txtName.Text = "";
            txtCode.Focus();
        }


        private void frmDayGUI_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            aDayCode = txtCode.Text;
            aDayName = txtName.Text;
            if (aDayCode.Length == 0 || aDayName.Length == 0)
            {
                MessageBox.Show("Please enter all data.", "Data Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                aDay = new Day(aDayCode, aDayName);
                MessageBox.Show("Day is added.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                txtCode.Focus();
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
