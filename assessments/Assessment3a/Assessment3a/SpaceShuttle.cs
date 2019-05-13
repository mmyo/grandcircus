using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment3a
{
    public class SpaceShuttle
    {
        public int Fuel { get; set; }

        public List<Crew> Team { get; set; }

        public SpaceShuttle()
        {
            Fuel = 0;
            Team = new List<Crew>()
            {
                new Crew("John", "Captain"),
                new Crew("Diddy", "Chimp"),
                new Crew("Hannah", "Navigator")
            };           
        }

        public bool Launch()
        {
            if (Fuel > 5 && Team.Count == 3)
            {
                return true;
            }
            return false;
        }

    }
}
