using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSchool
{
    class StudentTest
    {
        public StudentTest()
        {
            string output = "";
            Student[] student = {new Student("Joe", "Kigin", "P.")};

            for (int i = 0; i < student.Length; ++i)
                output += " " + student[i] + "\r\n";

            frmResultsDisplay theForm = new frmResultsDisplay(output, "Student PD Test");

            theForm.ShowDialog();
        }
    }
}
