using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCommon
{
    public class FilmMsgCommon
    {
        private int filmId;
        /// <summary>
        ///电影id
        /// </summary>
        public int FilmId
        {
            get { return filmId; }
            set { filmId = value; }
        }
        private string filmName;

        /// <summary>
        /// 电影名
        /// </summary>
        public string FilmName
        {
            get { return filmName; }
            set { filmName = value; }
        }
        private string director;
        /// <summary>
        /// 导演
        /// </summary>
        public string Director
        {
            get { return director; }
            set { director = value; }
        }


        private string filmType;

        /// <summary>
        /// 电影类型
        /// </summary>
        public string FilmType
        {
            get { return filmType; }
            set { filmType = value; }
        }

        private string producers;

        /// <summary>
        /// 出品方
        /// </summary>
        public string Producers
        {
            get { return producers; }
            set { producers = value; }
        }
        private string country;

        /// <summary>
        /// 国家
        /// </summary>
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        private string protagonists;

        /// <summary>
        /// 主演
        /// </summary>
        public string Protagonists
        {
            get { return protagonists; }
            set { protagonists = value; }
        }
        private string filmTimes;

        /// <summary>
        /// 电影时长
        /// </summary>
        public string FilmTimes
        {
            get { return filmTimes; }
            set { filmTimes = value; }
        }
        private int filmState;

        /// <summary>
        /// 电影上架状态
        /// </summary>
        public int FilmState
        {
            get { return filmState; }
            set { filmState = value; }
        }

    }
}
