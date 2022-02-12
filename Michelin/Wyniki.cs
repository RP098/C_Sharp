using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michelin_Garda_2021
{
    class Wyniki
    {
      
        public long contests_id { get; set; }
        public long competition__id { get; set; }
        public long participan_competitor_id { get; set; }
        public long club_id { get; set; }
        public string competition_name { get; set; }
        public string participan_competitor_name { get; set; }
        public string contests_name { get; set; }

        public string club_name { get; set; }
        public string result { get; set; }
        public string place { get; set; } 
        public string comments { get; set; }
        public int inside { get; set; }
        public long result_id { get; set; }

    }
}
