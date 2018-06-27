/********************
 *  FILE:           SimpleSchool
 *  PROGRAMMER:     Joe Kigin
 *  DATE:           5/18/15
 *  LAB:            6
 * 
 *  DESCRIPTION:    Course Class
 * ********************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleSchool
{
    class Course
    {
        //DATA
        private string courseName,
                       courseCode;

        ArrayList classes;

        //Constructor
        public Course() { }

        public Course(string cn, string cc)
        {
            SetCourseName(cn);
            SetCourseCode(cc);
            classes = new ArrayList();
        }
        
        //Accessors
        public string GetCourseName() { return courseName; }

        public string GetCourseCode() { return courseCode; }

        //Mutators
        public void SetCourseName(string cn) { courseName = cn; }

        public void SetCourseCode(string cc) { courseCode = cc; }

        //ASSOCIATION WITH CLASS
        public void AddClass(_Class aClass) { classes.Add(aClass); }

        public ArrayList GetClasses() { return classes; }

        //CourseDA association
        public void AddNew() { CourseDA.AddNew(this); }

        public void Delete() { CourseDA.Delete(this); }

        public static Course Find(string aCourseCode) { return CourseDA.Find(aCourseCode); }

        public static ArrayList GetAll() { return CourseDA.GetAll(); }

        public static void Initialize() { CourseDA.Initialize(); }

        public static void Terminate() { CourseDA.Terminate(); }

        public void Update() { CourseDA.Update(this); }

        public override string ToString() { return "COURSE: " + courseName + ", " + courseCode; }
    }
}
