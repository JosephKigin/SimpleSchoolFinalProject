using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSchool
{
    class InstructorOfficeTest2
    {
        public InstructorOfficeTest2()
        {
            Instructor instructorOne = new Instructor("William", "Hayes");
            Room officeOne = new Room("Main", 201, Room.OFFICE);
            instructorOne.SetInstOffice(officeOne);
            officeOne.SetInstructorRoom(instructorOne);

            Instructor instructorTwo = new Instructor("Andrea", "Baker");
            Room officeTwo = new Room("Main", 202, Room.OFFICE);
            instructorTwo.SetInstOffice(officeTwo);
            officeTwo.SetInstructorRoom(instructorTwo);

            string output = " The office is " + instructorOne.GetInstOffice() + "\r\n";

            output += " The instructor is " + officeOne.GetInstructorRoom() + "\r\n";

            output += " The office is " + instructorTwo.GetInstOffice() + "\r\n";

            output += " The instructor is " + officeTwo.GetInstructorRoom() + "\r\n";

            frmResultsDisplay theForm = new frmResultsDisplay(output, "Instructor Office Test2");
            theForm.ShowDialog();

        }
    }
}
