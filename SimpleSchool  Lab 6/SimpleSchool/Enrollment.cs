using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSchool
{
    class Enrollment
    {
        //DATA
        private string grade;
        _Class theClass;
        Student theStudent;

        //Constructor
        public Enrollment()
        {

        }

        //Accessor
        public string GetGrade() { return grade; }

        public _Class GetClass() { return theClass; }

        public Student GetStudent() { return theStudent; }

        //Mutator
        public void SetGrade(string gr) { grade = gr;  }

        public void SetClass(_Class cl) { theClass = cl; }

        public void SetStudent(Student st) { theStudent = st; }

        //ASSOCIATION WITH CLASS
        public void AddEnrollmentToClass(_Class aClass)
        {
            SetClass(aClass);
            aClass.AddEnrollment(this);
        }

        //ASSOCIATION WITH STUDENT
        public void AddEnrollmentToStudent(Student aStudent)
        {
            SetStudent(aStudent);
            aStudent.AddEnrollment(this);
        }

        public override string ToString()
        {
            return grade + " " + theClass + " " + theStudent;
        }
    }
}
