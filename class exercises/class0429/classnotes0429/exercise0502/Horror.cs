using System;
using System.Collections.Generic;
using System.Text;

namespace exercise0502
{
    public class Horror : BookBase
    {
        public string Scary { get; set; }

        public override string GetGenre()
        {
            return "horror";
        }
    }
}
