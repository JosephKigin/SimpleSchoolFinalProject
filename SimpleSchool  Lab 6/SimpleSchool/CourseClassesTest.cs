using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleSchool
{
    class CourseClassesTest
    {
        public CourseClassesTest()
        {
            Course crs = new Course("SD254", "Programming II");
            Instructor ins1 = new Instructor("Knows", "Alot");
            Instructor ins2 = new Instructor("Talks", "Toofast");

            _Class cls = new _Class(crs);
            cls.AddClassToInstructor(ins1);

            cls = new _Class(crs);
            cls.AddClassToInstructor(ins1);

            ArrayList classes = crs.GetClasses();
            string output = " Course " + crs.GetCourseCode() + " has " + classes.Count + " classes." + "\r\n";

            output += "\r\n Classes for course " + crs.GetCourseCode() + ":\r\n";

            for (int i = 0; i < classes.Count; ++i)
            {
                string cl = classes[i].ToString();
                output += "\t" + cl + "\r\n";
            }
            output += "\r\n The course for class " + ((_Class)classes[0]).GetClassID() + ":\r\n";
            output += " " + ((_Class)classes[0]).GetCourse() + ":\r\n";

            frmResultsDisplay theForm = new frmResultsDisplay(output, "Course Classes Test");
            theForm.ShowDialog();
        }
    }
}
