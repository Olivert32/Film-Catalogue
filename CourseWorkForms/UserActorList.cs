using CourseWorkForms;
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
    public partial class UserActorList : Form
    {
        public UserActorList()
        {
            InitializeComponent();
        }

        private void nudAge_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Actor a = new Actor();
            a.SetActorName(txtName.Text);
            a.SetActorAge(Convert.ToInt32(nudAge.Value));
            lstUserActors.Items.Add(a);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstUserActors.Items.Remove(lstUserActors.SelectedItem);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHomepage frm = new frmHomepage();
            this.Hide();
            frm.Show();
        }

        private void lstUserActors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

class Actor
{
private string ActorName;
private int ActorAge;



public string GetActorName()
{
    return ActorName;
}
public int GetActorAge()
{
    return ActorAge;
}
public void SetActorName(string newActor)
{
    if (newActor.Length > 0)
    {
        ActorName = newActor;
    }
}
public void SetActorAge(int newActorAge)
{
    if (newActorAge > 0)
    {
        ActorAge = newActorAge;
    }
}
public override string ToString()
{
    return ActorName;
}
    private void btnSave_Click(object sender, EventArgs e)
    {

      //Error: Says lstUserActors doesnt exist in current context
    }


}





    