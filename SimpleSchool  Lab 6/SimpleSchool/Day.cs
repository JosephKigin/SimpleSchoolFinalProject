using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleSchool
{
    class Day
    {
        /*******
         * DATA
         * ****/
        private string dayCode,
                       dayName;
        ArrayList timeSlots;

        /************
         * PROCESSING
         * **********/
        //Constructor
        public Day(string dc, string dn)
        {
            SetDayCode(dc);
            SetDayName(dn);
            timeSlots = new ArrayList();
        }

        //Accessor
        public string GetDayCode() { return dayCode; }

        public string GetDayName() { return dayName; }

        public ArrayList GetTimeSlots() { return timeSlots; }

        //Mutators
        public void SetDayCode(string dc) { dayCode = dc; }

        public void SetDayName(string dn) { dayName = dn; }

        public void AddTimeSlot(TimeSlot aTimeSlot) { timeSlots.Add(aTimeSlot); }

        //To String
        public override string ToString() { return dayCode + " " + dayName; }


    }
}
