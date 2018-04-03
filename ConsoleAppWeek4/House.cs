using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWeek4
{
    class House
    {
        private int roof;
        protected double rooms;
        private bool underConstruction = false;
        public string Floors;

        public int Curtains
        {
            set {

            }
            get { return Curtains; }
        }
        public bool IsUnderConstruction(string answer)
        {
            // convert string to bool 
            // call MakingRepairs()
            return underConstruction;
        }
        public void MakingRepairs(bool YesOrNo)
        {
            underConstruction = YesOrNo;
        }
        public double Rooms
        {
            private set { rooms = value; }
            get { return rooms; }
        }
        public int Roof
        {
             set { roof = value; }
            get { return roof; }
        }
        

        public House() { }

        // public House(int theRoof)
        public House(int roof)
        {
            this.roof = roof;
            // roof = theRoof;

        }
              
         public House(float roof)
        {
            this.roof = (int)roof;
        }
        public House(int roof, double rooms) : this(roof)
        {
            // this.roof = roof;
            this.rooms = rooms;
        }

        //add a third constructor that allows 2 arguments
        // call a previous constructor

        public House(int roof, double rooms, string floors):this(roof, rooms) {

            // this.Floors = floors;
            Floors = floors;
        }
        public House(float roof=1.0f, float rooms=4.5f,string floors="3 "): this((int)roof, rooms)
        {
            //this.Floors = floors;
            Floors = floors;
        }
        public override string ToString()
        {
            return "The House has"+rooms+ "rooms" +roof+ "roofs"+Floors+ "floors";
        }
    }
}
