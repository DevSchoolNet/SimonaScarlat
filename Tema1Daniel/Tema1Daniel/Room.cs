using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tema1Daniel
{
    public enum CardinalPoints
    {
        N,
        S,
        E,
        V
        
    }
    public class Room
    {
        private int roomId;
        private int width;
        private int height;
        public CardinalPoints orientation;

        public Room()
        {

        }

        public Room(int roomId, int width, int height, CardinalPoints orientation)
        {
            
            this.roomId = roomId;
            this.width = width;
            this.height = height;
            this.orientation = orientation;
        }

        public int RoomId { get; set; }
        public int Width { get; set; }

        public int Height { get; set; }
        public CardinalPoints Orientation { get; set; }
        public double RoomAria => Width * Height;
      

    }
}
