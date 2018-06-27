using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleSchool
{
    class Student
    {
        //DATA
        private static int autoStudentId = 10000;
        private int studentId;
        private string firstName,
                       lastName,
                       middleInitial;

        ArrayList enrollments;

        //Constructor
        public Student(string fn, string ln, string mi)
        {
            SetStudentId(++autoStudentId);
            SetFirstName(fn);
            SetLastName(ln);
            SetMiddleInitial(mi);
            enrollments = new ArrayList();
        }

        //Accessor
        public int GetStudentId() { return studentId; }

        public string GetFirstName() { return firstName; }

        public string GetLastName() { return lastName; }

        public string GetMiddleInitial() { return middleInitial; }

        //Mutator
        public void SetStudentId(int id) { studentId = id; }

        public void SetFirstName(string fn) { firstName = fn; }

        public void SetLastName(string ln) { lastName = ln; }

        public void SetMiddleInitial(string mi) { middleInitial = mi; }

        //ASSOCIATION WITH ENROLLMENT
        public void AddEnrollment(Enrollment anEnrollment) { enrollments.Add(anEnrollment); }

        public void AddStudentToEnrollment(Enrollment anEnrollment)
        {
            AddEnrollment(anEnrollment);
            anEnrollment.SetStudent(this);
        }

        public override string ToString() { return "STUDENT: " + lastName + ", " + firstName + " " + middleInitial + " ID: " + studentId; }
    }
}
