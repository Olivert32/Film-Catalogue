using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CourseWorkForms
{
   
    public partial class frmFilmTrivia : Form
    {
        public frmFilmTrivia()
        {
            InitializeComponent();
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if (txtUserAnswer.Text == "Godfather")
            {
                lblQuestion.Text = "congratulations!";
                Application.Exit();
            }
            else
            {
                lblQuestion.Text= "incorrect, try again";
            }
        }

        private void txtUserAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {
        
        }

        private void frmFilmTrivia_Load(object sender, EventArgs e)
        {

        }

        private void btnReveal_Click(object sender, EventArgs e)
        {
            lblQuestion.Text = "Released in 1972, starring Marlon Brando and Al Pacino which film am I? ";
        }
    }
}
