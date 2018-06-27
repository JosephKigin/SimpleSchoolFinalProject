using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleSchool
{
    class InstructorClassesTest
    {
        public InstructorClassesTest()
        {
            //NEW INSTRUCTOR NAMED instructor AND A NEW COURSE NAMED crs
            Instructor instructor = new Instructor("Wayne", "Masters");
            Course crs = new Course("SD234", "Programming I");

            for(int i = 0; i < 3; i++)
            {
                _Class cls = new _Class(crs);
                cls.AddClassToInstructor(instructor);
            }

            ArrayList classes = instructor.GetClasses();

            string output = "Instructor " + instructor.GetInstructorId() + " has " + classes.Count + " classes." + "\r\n";

            output += "\r\n Classes for instructor " + instructor.GetInstructorId() + ":\r\n";

            for (int i = 0; i < classes.Count; ++i)
            {
                string cl = classes[i].ToString();
                output += "\t" + cl + "\r\n";
            }

            output += "\r\n  The instructor for class " + ((_Class)classes[0]).GetClassID() + ":\r\n";
            output += " " + ((_Class)classes[0]).GetInstructor().ToString() + "\r\n";
            output += "\r\n  Class info & instructor for class " + ((_Class)classes[0]).GetClassID() + ":\r\n";
            output += " " + ((_Class)classes[0]).GetCourse() + " " + ((_Class)classes[0]).ToString() + "\r\n";

            frmResultsDisplay theForm = new frmResultsDisplay(output, "Instructor Classes Test");
            theForm.ShowDialog();
        }

    }
}
