
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

 namespace SeriesApp
{


    class Series
    {
        public string SeriesName { get; set; }
        public int ProductionYear { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public string Director { get; set; }
        public string Platform { get; set; }
    }

    class ComedySeries
{
    public string SeriesName { get; set; }
    public string Genre { get; set; }
    public string Director { get; set; }
}


}