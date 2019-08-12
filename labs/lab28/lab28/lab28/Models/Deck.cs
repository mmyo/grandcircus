using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab28.Models
{
    public class Deck
    {

        public string Deck_Id { get; set; }

        public bool Shuffled { get; set; }
        public int Remaining { get; set; }

        public List<Card> Cards { get; set; }

    }
}
