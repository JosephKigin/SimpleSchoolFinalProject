namespace SimpleSchool
{
    partial class frmSimpleSchool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pDClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockPDTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayPDTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomPDTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cousePDTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentPDTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gUIClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDayGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseClassesTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollmentTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorClassesTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorOfficeTest1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorOfficeTest2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseDATestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(101, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 90);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Simple School";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDClassesToolStripMenuItem,
            this.gUIClassesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.testsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pDClassesToolStripMenuItem
            // 
            this.pDClassesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blockPDTestToolStripMenuItem,
            this.dayPDTestToolStripMenuItem,
            this.roomPDTestToolStripMenuItem,
            this.cousePDTestToolStripMenuItem,
            this.studentPDTestToolStripMenuItem});
            this.pDClassesToolStripMenuItem.Name = "pDClassesToolStripMenuItem";
            this.pDClassesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.pDClassesToolStripMenuItem.Text = "&PD Classes";
            // 
            // blockPDTestToolStripMenuItem
            // 
            this.blockPDTestToolStripMenuItem.Name = "blockPDTestToolStripMenuItem";
            this.blockPDTestToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.blockPDTestToolStripMenuItem.Text = "Block PD Test";
            this.blockPDTestToolStripMenuItem.Click += new System.EventHandler(this.blockPDTestToolStripMenuItem_Click);
            // 
            // dayPDTestToolStripMenuItem
            // 
            this.dayPDTestToolStripMenuItem.Name = "dayPDTestToolStripMenuItem";
            this.dayPDTestToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.dayPDTestToolStripMenuItem.Text = "Day PD Test";
            this.dayPDTestToolStripMenuItem.Click += new System.EventHandler(this.dayPDTestToolStripMenuItem_Click);
            // 
            // roomPDTestToolStripMenuItem
            // 
            this.roomPDTestToolStripMenuItem.Name = "roomPDTestToolStripMenuItem";
            this.roomPDTestToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.roomPDTestToolStripMenuItem.Text = "Room PD Test";
            this.roomPDTestToolStripMenuItem.Click += new System.EventHandler(this.roomPDTestToolStripMenuItem_Click);
            // 
            // cousePDTestToolStripMenuItem
            // 
            this.cousePDTestToolStripMenuItem.Name = "cousePDTestToolStripMenuItem";
            this.cousePDTestToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.cousePDTestToolStripMenuItem.Text = "Couse PD Test";
            this.cousePDTestToolStripMenuItem.Click += new System.EventHandler(this.cousePDTestToolStripMenuItem_Click);
            // 
            // studentPDTestToolStripMenuItem
            // 
            this.studentPDTestToolStripMenuItem.Name = "studentPDTestToolStripMenuItem";
            this.studentPDTestToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.studentPDTestToolStripMenuItem.Text = "Student PD Test";
            this.studentPDTestToolStripMenuItem.Click += new System.EventHandler(this.studentPDTestToolStripMenuItem_Click);
            // 
            // gUIClassesToolStripMenuItem
            // 
            this.gUIClassesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blockGUIToolStripMenuItem,
            this.dayGUIToolStripMenuItem,
            this.findDayGUIToolStripMenuItem});
            this.gUIClassesToolStripMenuItem.Name = "gUIClassesToolStripMenuItem";
            this.gUIClassesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.gUIClassesToolStripMenuItem.Text = "&GUI Classes";
            // 
            // blockGUIToolStripMenuItem
            // 
            this.blockGUIToolStripMenuItem.Name = "blockGUIToolStripMenuItem";
            this.blockGUIToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.blockGUIToolStripMenuItem.Text = "Block GUI";
            this.blockGUIToolStripMenuItem.Click += new System.EventHandler(this.blockGUIToolStripMenuItem_Click);
            // 
            // dayGUIToolStripMenuItem
            // 
            this.dayGUIToolStripMenuItem.Name = "dayGUIToolStripMenuItem";
            this.dayGUIToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.dayGUIToolStripMenuItem.Text = "Day GUI";
            this.dayGUIToolStripMenuItem.Click += new System.EventHandler(this.dayGUIToolStripMenuItem_Click);
            // 
            // findDayGUIToolStripMenuItem
            // 
            this.findDayGUIToolStripMenuItem.Name = "findDayGUIToolStripMenuItem";
            this.findDayGUIToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.findDayGUIToolStripMenuItem.Text = "Find-Day GUI";
            this.findDayGUIToolStripMenuItem.Click += new System.EventHandler(this.findDayGUIToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courseDATestToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.toolStripMenuItem1.Text = "&DA Classes";
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courseClassesTestToolStripMenuItem,
            this.enrollmentTestToolStripMenuItem,
            this.instructorClassesTestToolStripMenuItem,
            this.instructorOfficeTest1ToolStripMenuItem,
            this.instructorOfficeTest2ToolStripMenuItem});
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.testsToolStripMenuItem.Text = "&Tests";
            // 
            // courseClassesTestToolStripMenuItem
            // 
            this.courseClassesTestToolStripMenuItem.Name = "courseClassesTestToolStripMenuItem";
            this.courseClassesTestToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.courseClassesTestToolStripMenuItem.Text = "Course Classes Test";
            this.courseClassesTestToolStripMenuItem.Click += new System.EventHandler(this.courseClassesTestToolStripMenuItem_Click);
            // 
            // enrollmentTestToolStripMenuItem
            // 
            this.enrollmentTestToolStripMenuItem.Name = "enrollmentTestToolStripMenuItem";
            this.enrollmentTestToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.enrollmentTestToolStripMenuItem.Text = "Enrollment Test";
            this.enrollmentTestToolStripMenuItem.Click += new System.EventHandler(this.enrollmentTestToolStripMenuItem_Click);
            // 
            // instructorClassesTestToolStripMenuItem
            // 
            this.instructorClassesTestToolStripMenuItem.Name = "instructorClassesTestToolStripMenuItem";
            this.instructorClassesTestToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.instructorClassesTestToolStripMenuItem.Text = "Instructor Classes Test";
            this.instructorClassesTestToolStripMenuItem.Click += new System.EventHandler(this.instructorClassesTestToolStripMenuItem_Click);
            // 
            // instructorOfficeTest1ToolStripMenuItem
            // 
            this.instructorOfficeTest1ToolStripMenuItem.Name = "instructorOfficeTest1ToolStripMenuItem";
            this.instructorOfficeTest1ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.instructorOfficeTest1ToolStripMenuItem.Text = "Instructor Office Test1";
            this.instructorOfficeTest1ToolStripMenuItem.Click += new System.EventHandler(this.instructorOfficeTest1ToolStripMenuItem_Click);
            // 
            // instructorOfficeTest2ToolStripMenuItem
            // 
            this.instructorOfficeTest2ToolStripMenuItem.Name = "instructorOfficeTest2ToolStripMenuItem";
            this.instructorOfficeTest2ToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.instructorOfficeTest2ToolStripMenuItem.Text = "Instructor Office Test2";
            this.instructorOfficeTest2ToolStripMenuItem.Click += new System.EventHandler(this.instructorOfficeTest2ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // courseDATestToolStripMenuItem
            // 
            this.courseDATestToolStripMenuItem.Name = "courseDATestToolStripMenuItem";
            this.courseDATestToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.courseDATestToolStripMenuItem.Text = "Course DA Test";
            this.courseDATestToolStripMenuItem.Click += new System.EventHandler(this.courseDATestToolStripMenuItem_Click);
            // 
            // frmSimpleSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 357);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSimpleSchool";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSimpleSchool_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pDClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gUIClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockPDTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayPDTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomPDTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cousePDTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentPDTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorOfficeTest1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorOfficeTest2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseClassesTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollmentTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorClassesTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockGUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayGUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findDayGUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseDATestToolStripMenuItem;
    }
}

