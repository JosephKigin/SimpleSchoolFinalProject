using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleSchool
{
    class _Class
    {
        //DATA
        private static int autoIDNum = 100;
        int classID;

        Instructor theInstructor;
        Course theCourse;
        ArrayList enrollments;

        //Constructor
        public _Class(Course aCourse) 
        {
            SetClassID(++autoIDNum);
            AddClassToCourse(aCourse);
            enrollments = new ArrayList();
        }

        public _Class(Instructor anInstructor) 
        { 
            SetClassID(++autoIDNum);
            AddClassToInstructor(anInstructor);
        }

        //Accessor
        public int GetClassID() { return classID; }

        //Mutator
        public void SetClassID(int id) { classID = id; }

        //ASSOCIATION WITH INSTRUCTOR

        public Instructor GetInstructor() { return theInstructor; }

        public void AddClassToInstructor(Instructor anInstructor) 
        { 
            theInstructor = anInstructor;
            theInstructor.AddClass(this);
        }

        //ASSOCIATION WITH COURSE
        public void AddClassToCourse(Course aCourse)
        {
            theCourse = aCourse;
            theCourse.AddClass(this);
        }

        //ASSOCIATION WITH ENROLLMENT
        public void AddEnrollment(Enrollment anEnrollment) { enrollments.Add(anEnrollment); }
        
        public void AddStudentToEnrollment(Enrollment anEnrollment)
        {
            AddEnrollment(anEnrollment);
            anEnrollment.SetClass(this);
        }


        public Course GetCourse() { return theCourse; }

        public override string ToString()
        {
            return "" + classID + " " + theInstructor + " " + theCourse;
        }

    }
}
