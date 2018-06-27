/********************
 *  FILE:           SimpleSchool
 *  PROGRAMMER:     Joe Kigin
 *  DATE:           5/18/15
 *  LAB:            6
 * 
 *  DESCRIPTION:    CourseDA Class
 * ********************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleSchool
{
    class CourseDA
    {
        private static ArrayList courses;
        private static Course theCourse;

        public static void AddNew(Course newCourse) { courses.Add(newCourse); }

        public static void Delete(Course aCourse) { courses.Remove(aCourse); }

        public static Course Find(string aCourseCode)
        {
            theCourse = null;
            for(int i = 0; i < courses.Count && theCourse == null; ++i)
            {
                if (((Course)courses[i]).GetCourseCode() == aCourseCode) { theCourse = (Course)courses[i]; }
            }
            return theCourse;
        }

        public static ArrayList GetAll() { return courses; }

        public static void Initialize()
        {
            courses = new ArrayList();
            courses.Add(new Course("SD114", "Introduction to Software Development"));
            courses.Add(new Course("SD234", "Programming I"));
            courses.Add(new Course("SD254", "Programming II"));
        }

        public static void Terminate() { }

        public static void Update(Course thisCourse) { }
    }
}
