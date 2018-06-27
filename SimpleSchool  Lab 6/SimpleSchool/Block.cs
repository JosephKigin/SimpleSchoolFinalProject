using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimpleSchool
{
    class Block
    {
        /*******
         * DATA
         * *****/
        private int blockId;
        private DateTime startTime,
                         endTime;
        ArrayList timeSlots;

        /************
         * PROCESSING
         * **********/

        //Constructor

        public Block(int id, DateTime st, DateTime et)
        {
            SetBlockId(id);
            SetStartTime(st);
            SetEndTime(et);
            timeSlots = new ArrayList();
        }
        
        //Accessors
        public int GetBlockId() { return blockId; }

        public DateTime GetStartTime() { return startTime; }
  
        public DateTime GetEndTime() { return endTime; }

        public ArrayList GetTimeSlot() { return timeSlots; }

        
        //Mutators
        public void SetBlockId(int id) { blockId = id; }

        public void SetStartTime(DateTime st) { startTime = st; }

        public void SetEndTime(DateTime et) { endTime = et; }

        public void AddTimeSlot(TimeSlot aTimeSlot) { timeSlots.Add(aTimeSlot); }

        //To String
        public override string ToString() { return " BLOCK: " + blockId + " " + startTime.ToString("t") + 
                                            " - " + endTime.ToString("t"); }
    }
}
