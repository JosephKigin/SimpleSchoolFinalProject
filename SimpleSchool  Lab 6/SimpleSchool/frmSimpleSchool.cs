/********************
 *  FILE:           SimpleSchool
 *  PROGRAMMER:     Joe Kigin
 *  DATE:           3/30/15
 *  LAB:            1
 * 
 *  DESCRIPTION:    Shows a window with the words "Simple School in the middle. Also has a menu button called "About" giving a brief description and an exit menu button.
 * ********************/
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
    public partial class frmSimpleSchool : Form
    {
        public frmSimpleSchool()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)                //Exit menu button
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)               //About menu button
        {
            MessageBox.Show("Simple School, Version 0.1\n\nJoe Kigin", "About Simple School");
        }

        private void frmSimpleSchool_Load(object sender, EventArgs e)
        {

        }

        private void blockPDTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BlockTest theTest = new BlockTest();
            this.Show();
        }

        private void dayPDTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DayTest theTest = new DayTest();
            this.Show();
        }

        private void roomPDTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomTest theTest = new RoomTest();
            this.Show();
        }

        private void cousePDTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseTest theTest = new CourseTest();
            this.Show();
        }

        private void studentPDTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentTest theTest = new StudentTest();
            this.Show();
        }

        private void instructorOfficeTest1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorOfficeTest1 theTest = new InstructorOfficeTest1();
            this.Show();
        }

        private void instructorOfficeTest2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorOfficeTest2 theTest = new InstructorOfficeTest2();
            this.Show();
        }

        private void instructorClassesTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorClassesTest theTest = new InstructorClassesTest();
            this.Show();
        }

        private void courseClassesTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseClassesTest theTest = new CourseClassesTest();
            this.Show();
        }

        private void enrollmentTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollmentTest theTest = new EnrollmentTest();
            this.Show();
        }

        private void blockGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBlockGUI theForm = new frmBlockGUI();
            theForm.ShowDialog();
            this.Show();
        }

        private void dayGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDayGUI theForm = new frmDayGUI();
            theForm.ShowDialog();
            this.Show();
        }

        private void findDayGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFindDay theForm = new frmFindDay();
            theForm.ShowDialog();
            this.Show();
        }

        private void courseDATestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseDATest theTest = new CourseDATest();
            this.Show();
        }
    }
}