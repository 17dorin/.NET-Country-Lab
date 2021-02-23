using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesDotNet.Models
{
    public class Country
    {
        public string name { get; set; }
        public string language { get; set; }
        public string greeting { get; set; }
        public string description { get; set; }
        public List<string> colors { get; set; }
    }
}
