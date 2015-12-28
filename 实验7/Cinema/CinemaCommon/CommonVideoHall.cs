using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCommon
{
    public class CommonVideoHall
    {
        public CommonVideoHall() { }
        public CommonVideoHall(int id, string strId)
        {
            this.VideoHallId = id;
            this.strId = strId;
        }

        public int VideoHallId { get; set; }

        private string strId;
        public string StrId
        {
            set { strId = value; }
            get
            {
                if (this.VideoHallId == 0)
                {
                    return strId;
                }
                return VideoHallId.ToString();
            }
        }
        public int Seatings { get; set; }
        public int RowSeatNum { get; set; }
        public int ColumnSeatNum { get; set; }

    }
}
