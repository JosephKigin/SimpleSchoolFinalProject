using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SimpleSchool
{
    public partial class frmFindDay : Form
    {
        Day aDay;
        ArrayList days = new ArrayList();


        public frmFindDay()
        {
            InitializeComponent();
            PopulateListBox();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int i = lstCode.SelectedIndex;
            aDay = (Day)days[i];
            txtName.Text = aDay.GetDayName();
        }

        private void CreateDays()
        {
            days.Add(new Day("M", "Monday"));
            days.Add(new Day("T", "Tuesday"));
            days.Add(new Day("W", "Wednesday"));
            days.Add(new Day("R", "Thursday"));
            days.Add(new Day("F", "Friday"));
            days.Add(new Day("S", "Saturday"));
        }

        private void PopulateListBox()
        {
            CreateDays();
            for (int i = 0; i < days.Count; ++i)
            {
                aDay = (Day)days[i];
                lstCode.Items.Add(aDay.GetDayCode());
            }
            lstCode.SelectedIndex = 0;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            int i = lstCode.SelectedIndex;
            aDay = (Day)days[i];
            aDay.SetDayName(txtName.Text);
            MessageBox.Show("Day is updated.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtName.Text = "";
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
