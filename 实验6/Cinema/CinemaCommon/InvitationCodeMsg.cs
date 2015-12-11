using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaCommon
{
    public class InvitationCodeMsg
    {
        private int filmId;

        public int FilmId
        {
            get { return filmId; }
            set { filmId = value; }
        }
        private string deadline;

        public string Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }
        private int codeState;

        public int CodeState
        {
            get { return codeState; }
            set { codeState = value; }
        }
        private string invitationCode;

        public string InvitationCode
        {
            get { return invitationCode; }
            set { invitationCode = value; }
        }
    }
}
