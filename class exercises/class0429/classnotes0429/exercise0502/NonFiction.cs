using System;
using System.Collections.Generic;
using System.Text;

namespace exercise0502
{
    public class NonFiction : BookBase
    {
        public string NonFictionType { get; set; }

        public override string GetGenre()
        {
            return "nonfiction";
        }
    }
}
