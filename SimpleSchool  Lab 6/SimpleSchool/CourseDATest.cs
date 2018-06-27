/********************
 *  FILE:           SimpleSchool
 *  PROGRAMMER:     Joe Kigin
 *  DATE:           5/18/15
 *  LAB:            6
 * 
 *  DESCRIPTION:    CourseDATest Class
 * ********************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleSchool
{
    class CourseDATest
    {
        public CourseDATest()
        {
            ArrayList theCourses;
            Course foundCourse;
            string output = "";

            //Initialize with starting contents
            Course.Initialize();

            //Create and add two database courses
            Course dbCourse1 = new Course("DB211", "Database Design");
            Course dbCourse2 = new Course("DB311", "Database Implementation");
            dbCourse1.AddNew();
            dbCourse2.AddNew();

            //Display modified contents
            theCourses = Course.GetAll();
            for (int i = 0; i < theCourses.Count; ++i) { output += " " + theCourses[i] + "\r\n"; }

            output += "\r\n";

            //Search for course
            foundCourse = Course.Find("SD254");
            if (foundCourse == null) { output += " SD245 Not Found" + "\r\n"; }
            else { output += " Found" + foundCourse.ToString() + "\r\n"; }

            //Search for another course
            foundCourse = Course.Find("DB200");
            if (foundCourse == null) { output += " DB200 Not Found" + "\r\n"; }
            else { output += " Found" + foundCourse.ToString() + "\r\n"; }

            //Delete a course
            output += "\r\n" + "After deleting BD211: " + "\r\n";
            dbCourse1.Delete();
            for (int i = 0; i < theCourses.Count; ++i) { output += " " + theCourses[i] + "\r\n"; }
            output += "\r\n";

            //Update a course
            foundCourse = Course.Find("SD234");
            if (foundCourse != null) { foundCourse.SetCourseName("C# Programming 1"); }
            foundCourse = Course.Find("SD254");
            if (foundCourse != null) { foundCourse.SetCourseName("C# Programming 2"); }

            output += "After updating: " + "\r\n";
            for (int i = 0; i < theCourses.Count; ++i) { output += " " + theCourses[i] + "\r\n"; }

            frmResultsDisplay theForm = new frmResultsDisplay(output, "Course PD Test");
            theForm.ShowDialog();
        }
    }
}
