using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCommon
{
    public class CommonSchedule
    {
        public CommonSchedule() { }
        public CommonSchedule(int id, string time)
        {
            this.Id = id;
            this.Time = time;
        }
        public int Id { get; set; }
        public string Time { get; set; }
    }
}
