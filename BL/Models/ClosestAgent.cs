using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Models
{
    public class ClosestAgent
    {
        public string Name { get; set; }
        public double Distance { get; set; }
        public double ToLat { get; set; }
        public double ToLng { get; set; }
    }
}
