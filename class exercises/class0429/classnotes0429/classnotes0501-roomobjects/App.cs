using System;
using System.Collections.Generic;
using System.Text;

namespace classnotes0501_roomobjects
{
    public static class App
    {
        public static void Run()
        {
            Console.WriteLine("Enter a length and width of room: ");
            Console.Write("Length: ");

            var length = int.Parse(Console.ReadLine());

            Console.Write("Width: ");

            var width = int.Parse(Console.ReadLine());

            Console.Write("Height: ");

            var height = int.Parse(Console.ReadLine());

            var room = new Room(length, width, height);

            Console.WriteLine($"Room area: {room.GetArea()}");
            Console.WriteLine($"Room perimeter: {room.GetPerimeter()}");
            Console.WriteLine($"Room volume: {room.GetVolumne()}");
            Console.WriteLine($"Room area (property): {room.Area}");


            Console.ReadLine();
        }
    }
}
