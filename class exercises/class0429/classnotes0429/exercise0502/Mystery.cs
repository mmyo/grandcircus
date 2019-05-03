using System;
using System.Collections.Generic;
using System.Text;

namespace exercise0502
{
    class Mystery : BookBase
    {
        public string MysteryType { get; set; }

        public override string GetGenre()
        {
            return "mystery";
        }
    }
}
