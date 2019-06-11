using System;
using System.Collections.Generic;

namespace WhatToWear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("What's the event? ");
            var eventType = Enum.Parse(typeof(EventEnum), Console.ReadLine());

            Console.WriteLine(eventType);

            //casual "something comfy" semi-formal "a polo" formal "a suit"
            //< 54 degrees "a coat", 54-70 "a jacket", > 70 "no jacket" 

            Console.ReadLine();

        }
      
    }
}
