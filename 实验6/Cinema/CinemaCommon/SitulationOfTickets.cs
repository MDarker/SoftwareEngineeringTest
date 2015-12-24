using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCommon
{
    public class SitulationOfTickets
    {
        public string ReleaseDates { get; set; }
        public int videoHallId { get; set; }
        public string FilmName { get; set; }
        public string Playtime { get; set; }
        public string SeatsNumber { get; set; }
        public int SeatsState { get; set; }

    }
}
