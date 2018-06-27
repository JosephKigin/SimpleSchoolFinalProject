using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSchool
{
    class CourseTest
    {
        public CourseTest()
        {
            string output = "";
            Course[] course ={ new Course("Programming 2", "SD254")};

            for (int i = 0; i < course.Length; ++i)
                output += course[i] + "\r\n";

            frmResultsDisplay theForm = new frmResultsDisplay(output, "Course PD Test");

            theForm.ShowDialog();
        }
    }
}
