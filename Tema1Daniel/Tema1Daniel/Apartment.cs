using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Tema1Daniel
{
    public class Apartment
    {
        private int apartmentId;
        private int numberOfRooms;
        public string floor;
        public List<Room> listOfRooms;

        public Apartment()
        {
            this.listOfRooms = new List<Room>();
        }
        public Apartment(int apartmentId,int numberOfRooms, string floor)
        {
            this.apartmentId = apartmentId;
            this.numberOfRooms = numberOfRooms;
            this.floor = floor;
            this.listOfRooms = new List<Room>();
        }

        public int ApartmentId { get; set; }
        public int NumberOfRooms { get; set; }
        public int Floor { get; set; }
        public double ApartmentTotalAria()
        {
            var totalAria = 0.0;
            foreach(Room room in listOfRooms)
            {
                if(room != null)
                {
                    totalAria += room.RoomAria;
                }       
            }

            return Round(totalAria);
        }

        public override string ToString() => string.Format("Aria: {0} - Floor: {1} ", ApartmentTotalAria(),Floor);

        

    }
}
