using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleSchool
{
    class Instructor
    {
        private static int autoInstructorID = 1000;

        private int instructorId;

        private string firstName,
                       lastName;

        Room instOffice;
        ArrayList classes;

        //Constructors
        public Instructor() { }
        public Instructor(string fn, string ln)
        {
            SetInstructorId(++autoInstructorID);
            SetFirstName(fn);
            SetLastName(ln);
            SetInstOffice(null);
            classes = new ArrayList();
        }

        //Accessors
        public int GetInstructorId() { return instructorId; }


        public string GetFirstName() { return firstName; }

        public string GetLastName() { return lastName; }

        

        //Mutators
        public void SetInstructorId(int iid) { instructorId = iid; }


        public void SetFirstName(string fn) { firstName = fn; }

        public void SetLastName(string ln) { lastName = ln; }

        //ASSOCIATION WITH A ROOM
        public Room GetInstOffice() { return instOffice; }

        public void SetInstOffice(Room io) { instOffice = io; }

        //ASSOCIATION WITH CLASS

        public ArrayList GetClasses() { return classes; }

        public void AddClass(_Class aClass) { classes.Add(aClass); }

        //ToString
        public override string ToString(){ return  firstName + " " + lastName + " " + instructorId; }
    }
}
