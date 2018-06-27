using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleSchool
{
    class EnrollmentTest
    {
        public EnrollmentTest()
        {
            ArrayList enrollments = new ArrayList();
            string output;

            Student[] std = 
                {
                    new Student("Heez", "Student", "A"),
                    new Student("I'm", "Winner", "A"),
                    new Student("Sheez","Walker","A"),
                    new Student("They", "Runners", "R"),
                    new Student("Will", "Goh", "E")
                };
            Course crs1 = new Course("SD234", "Programming I");
            Course crs2 = new Course("SD254", "Programming II");

            _Class[] cls = 
            {
                new _Class(crs1),
                new _Class(crs2),
                new _Class(crs1),
                new _Class(crs2),
                new _Class(crs1)
            };

            for (int i = 0; i < 5; ++i)
            {
                Enrollment enr = new Enrollment();

                enr.SetClass(cls[i]);
                cls[i].AddEnrollment(enr);
                enr.SetStudent(std[i]);
                std[i].AddEnrollment(enr);
                enrollments.Add(enr);
            }

            ArrayList results = new ArrayList();
            foreach (Enrollment e in enrollments)
            {
                output = " " + e.GetClass().GetCourse() + "\r\n";
                output += "\t" + e + "\r\n";
                results.Add(output);
            }

            results.Sort();

            output = " ENROLLMENT\r\n";
            foreach (string str in results) output += str;

            frmResultsDisplay theForm = new frmResultsDisplay(output, "Enrollment Test");

            theForm.ShowDialog();

        }
    }
}

