using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orm1.Models
{
    public class Export
    {
        public string Reporter { get; set; }
        public string Partner { get; set; }
        public string Year { get; set; }
        public string Flow { get; set; }
        public string ProductGroup { get; set; }
        public float ExportUsdThou { get; set; }
        public float ExportProductSharePerc { get; set; }
        public float Rca { get; set; }
        public float WorldGrowth { get; set; }
        public float CountryGrowth { get; set; }
    }
}
