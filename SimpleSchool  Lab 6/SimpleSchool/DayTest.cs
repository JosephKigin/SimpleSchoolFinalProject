using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSchool
{
    class DayTest
    {
        public DayTest()
        {
            string output = "";

            //Days Monday-Saturday
            Day [] day = {new Day("M", "Monday"),
                         new Day("T", "Tuesday"),
                         new Day("W", "Wednesday"),
                         new Day("R", "Thursday"),
                         new Day("F", "Friday"),
                         new Day("S", "Saturday")};

            //Output format
            for (int i = 0; i < day.Length; ++i)
            {
                output += " " + day[i] + "\r\n";
            }
            frmResultsDisplay theForm =
                                  new frmResultsDisplay(output, "Day PD Test");
            theForm.ShowDialog();                            
        }
    }
}
