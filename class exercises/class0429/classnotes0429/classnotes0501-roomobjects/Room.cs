using System;
using System.Collections.Generic;
using System.Text;

namespace classnotes0501_roomobjects
{
    public class Room
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area
        {
            get { return Length * Width; }
        }

        public Room(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public int GetArea()
        {
            return Length * Width;
        }

        public int GetPerimeter()
        {
            return 2 * (Length + Width);
        }

        public int GetVolumne()
        {
            return Length * Width * Height;
        }

    }
}
