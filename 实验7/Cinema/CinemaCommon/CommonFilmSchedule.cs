using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCommon
{
    public class CommonFilmSchedule
    {
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public int VideoHallId { get; set; }
        public string FilmBeginTime { get; set; }
        public string FilmEndTime { get; set; }
        public int FilmBeginId { get; set; }
        public int FilmEndId { get; set; }
        public string ReleaseDates { get; set; }
        public int TicketPrice { get; set; }
        public int PreferentialPrice { get; set; }
    }
}
