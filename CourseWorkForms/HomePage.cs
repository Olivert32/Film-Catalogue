namespace CourseWorkForms
{

    public partial class frmHomepage : Form
    {
        public frmHomepage()
        {
            InitializeComponent();
        }


        private void btnFilmReveal_Click(object sender, EventArgs e)
        {
            frmFilmList frm = new frmFilmList();
            this.Hide();
            frm.Show();
        }

        private void btnActorList_Click(object sender, EventArgs e)
        {
            frmActorList frm = new frmActorList();
            this.Hide();
            frm.Show();
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            frmUserList frm = new frmUserList();
            this.Hide();
            frm.Show();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            frmFilmTrivia frm = new frmFilmTrivia();
            this.Hide();
            frm.Show();
        }    
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnFavouriteActors_Click(object sender, EventArgs e)
        {
            UserActorList frm = new UserActorList();
            this.Hide();
            frm.Show();
        }
    }
}