using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSchool
{
    class InstructorOfficeTest1
    {
        public InstructorOfficeTest1()
        {
            Instructor theInstructor = new Instructor("Bill", "Hayes");
            Room anOffice = new Room("Main", 201, Room.OFFICE);
            theInstructor.SetInstOffice(anOffice);

            string output = " The instructor is " + theInstructor + ".\r\n";

            Room theOffice = theInstructor.GetInstOffice();
            output += " The office is " + theOffice + ".\r\n";

            output += " Again, the office is " + theInstructor + ".\r\n";

            frmResultsDisplay theForm = new frmResultsDisplay(output, "Instuctor Office Test1");
            theForm.ShowDialog();
        }
    }
}
