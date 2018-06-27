using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSchool
{
    class RoomTest
    {
        public RoomTest()
        {
            string output = "";
            //Sample rooms 1-5
            Room[] room ={ new Room("Main", 101, Room.OFFICE),
                      new Room("Main", 201, Room.CLASSROOM),
                      new Room("Main", 301, Room.OFFICE),
                      new Room("Ball Pit", 101, Room.CLASSROOM),
                      new Room("Ball Pit", 105, Room.OFFICE)};

            //Output format
            for (int i = 0; i < room.Length; ++i)
                output += " " + room[i] + "\r\n";
                            

            frmResultsDisplay theForm =
                                new frmResultsDisplay(output, "Room PD Test");

            theForm.ShowDialog();

        }
    }
}
