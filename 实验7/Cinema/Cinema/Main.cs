using System;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pic_SellTicket_Click(object sender, EventArgs e)
        {
            SellTicket sellTicket = new SellTicket(this);
            sellTicket.Show();
            this.Hide();
            this.Main_Load(sender, e);
        }

        bool isLogin = false;
        private void pic_Managment_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (DialogResult.Yes == login.ShowDialog())
            {
                isLogin = true;
            }
            if (isLogin)
            {
                this.Height = 250;
                btn_VideoHall.Enabled = true;
                btn_FilmMsg.Enabled = true;
                btn_FilmShedule.Enabled = true;
            }
        }

        private void btn_VideoHall_Click(object sender, EventArgs e)
        {
            ManageVideoHall videoHall = new ManageVideoHall(this);
            videoHall.Show();
            this.Hide();
        }

        private void btn_FilmMsg_Click(object sender, EventArgs e)
        {
            ManageFilmMsg filmMsg = new ManageFilmMsg(this);
            filmMsg.Show();
            this.Hide();
        }

        private void btn_FilmShedule_Click(object sender, EventArgs e)
        {
            ManageFilmSchedule filmShedule = new ManageFilmSchedule(this);
            filmShedule.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Height = 130;
            btn_VideoHall.Enabled = false;
            btn_FilmMsg.Enabled = false;
            btn_FilmShedule.Enabled = false;
        }
    }
}
