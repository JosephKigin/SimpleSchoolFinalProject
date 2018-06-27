using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSchool
{
    class Room
    {
        /*********
         * DATA
         * *******/
        public const string OFFICE = "Office",
                            CLASSROOM = "Classroom";

        private static int autoRoomId = 0;
        private int roomId,
                    roomNumber;
        private string building,
                       roomType;
        Instructor theInstructor;

        

        /************
         * PROCESSING
         * **********/


        //Constructors
        public Room()
        {

        }
        
        public Room(string bd, int rn, string rt)
        {
            SetRoomId(++autoRoomId);
            SetBuilding(bd);
            SetRoomNumber(rn);
            SetRoomType(rt);
        }

        //Accessor
        public int GetRoomId() { return roomId; }

        public string GetBuilding() { return building; }

        public int GetRoomNumber() { return roomNumber; }

        public string GetRoomType() { return roomType; }

        //Mutator
        public void SetRoomId(int id) { roomId = id; }

        public void SetBuilding(string bd) { building = bd; }

        public void SetRoomNumber(int rn) { roomNumber = rn; }

        public void SetRoomType(string rt) { roomType = rt; }

        //ACCESSING INSTRUCTOR
        public Instructor GetInstructorRoom() { return theInstructor; }

        public void SetInstructorRoom(Instructor ir) { theInstructor = ir; }

        public override string ToString()
        {
            return building + " " + roomNumber + " " + roomType + " " + roomId;
        }
    }
}
