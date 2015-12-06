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
            this.Id = id;
            this.strId = strId;
        }

        public int Id { get; set; }

        private string strId;
        public string StrId
        {
            set { strId = value; }
            get
            {
                if (this.Id == 0)
                {
                    return strId;
                }
                return Id.ToString();
            }

        }
    }
}
