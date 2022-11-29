using System;
using System.Collections.Generic;

#nullable disable

namespace Tmp_lab1_app2_StoreDB
{
    public partial class Test
    {
        public Test()
        {
            Scores = new HashSet<Score>();
        }

        public string Testid { get; set; }

        public virtual ICollection<Score> Scores { get; set; }
    }
}
