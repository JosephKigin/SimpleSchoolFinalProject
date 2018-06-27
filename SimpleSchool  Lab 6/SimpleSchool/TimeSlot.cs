using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSchool
{
    class TimeSlot
    {
        //DATA
        int tsID;
        Block theBlock;
        Day theDay;

        //Constructor
        public TimeSlot(int ID, Block aBlock, Day aDay)
        {
            SetTimeSlotID(ID);
            SetTheBlock(aBlock);
            SetTheDay(aDay);
        }

        //Accessor
        public int GetTimeSlotID() { return tsID; }

        //Mutator
        public void SetTimeSlotID(int timeSlotID) { timeSlotID = tsID; }

        //The block association
        public Block GetTheBlock() { return theBlock; }

        public void SetTheBlock(Block block) { block = theBlock; }

        //The day association
        public Day GetTheDay() { return theDay; }

        public void SetTheDay(Day day) { day = theDay; }

        //Adding TimeSlot to a block and a day

        public void AddTimeSlotToBlock(Block aBlock)
        {
            theBlock = aBlock;
            theBlock.AddTimeSlot(this);
        }

        public void AddTimeSlotToDay(Day aDay)
        {
            theDay = aDay;
            theDay.AddTimeSlot(this);
        }

        //To string
        public override string ToString()
        {
            return " The time slot of " + tsID + " is " + theBlock + " on " + theDay;
        }
    }
}