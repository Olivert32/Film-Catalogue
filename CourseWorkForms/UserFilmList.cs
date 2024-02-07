using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkForms
{
    public partial class frmUserList : Form
    {
        public frmUserList()
        {
            InitializeComponent();
        }

        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            Film f = new Film();
            f.SetFilmName(txtUserInput.Text);
            f.SetReleaseDate(txtUserInput.Text); 
            lstUserData.Items.Add(f);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstUserData.Items.Remove(lstUserData.SelectedItem);
        }

        private void lstUserData_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        class Film
        {
            private string FilmName;
            private string ReleaseDate;


           
            public string GetFilmName()
            {
                return FilmName; 
            }
            public string GetReleaseDate() 
            {
                return ReleaseDate; 
            }
            public void SetFilmName(string newFilm)
            {
                if (newFilm.Length > 0)
                {
                    FilmName = newFilm;
                }
            }
            public void SetReleaseDate(string newReleaseDate)
            {
              if (newReleaseDate.Length > 0)
                {
                    ReleaseDate = newReleaseDate;
                }
            }
            public override string ToString()
            {
                return FilmName; 
            }

        }

        private void btnToFile_Click(object sender, EventArgs e)
        {
            string data = "";

            foreach (var filmObject in lstUserData.Items)
            {
                Film Film = filmObject as Film;

                data += Film.GetFilmName() + ":" + Film.GetReleaseDate() + "\n"; 


         
            }
           File.WriteAllText("YourFilms.txt", data);
        }

        private void txtReleaseDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHomepage frm = new frmHomepage();
            this.Hide();
            frm.Show();
        }
    }
}


