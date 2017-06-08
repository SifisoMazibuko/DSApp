using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSApp.Models
{
    public class Shows
    {
        //public byte[] ShowImage { get; set; }
        public string ShowName { get; set; }
        public string ShowDescription { get; set; }
        public string Category { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Genre { get; set; }
        public TimeSpan Duration { get; set; }
        public int Channel { get; set; }
        public int AgeRestriction { get; set; }
        public string ChannelName { get; set; }
    }
}
