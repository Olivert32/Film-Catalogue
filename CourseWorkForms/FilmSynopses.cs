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
    public partial class frmFilmSynopses : Form
    {
        public frmFilmSynopses()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShawshank_Click(object sender, EventArgs e)
        {
            lblFilmS.Text = "\"Chronicles the experiences of a formerly successful banker as a \n prisoner in the gloomy jailhouse of Shawshank after being found guilty\n of a crime he did not commit. The film portrays the man's unique way \n of dealing with his new, torturous life.";
        }

        private void btnGodfather_Click(object sender, EventArgs e)
        {
            lblFilmS.Text = "In late summer 1945, guests are gathered for the wedding reception \n of Don Vito Corleone's daughter Connie (Talia Shire) and Carlo Rizzi\n(Gianni Russo). Vito (Marlon Brando), the head of the Corleone Mafia family\n, is known to friends and associates as \"Godfather.\" He and Tom Hagen (Robert Duvall), the Corleone family lawyer,\n are hearing requests for favors because, according to Italian tradition,\n \"no Sicilian can refuse a request on his daughter's wedding day.\"\n One of the men who asks the Don for a favor is Amerigo Bonasera, a successful mortician\n and acquaintance of the Don, whose daughter was brutally beaten by two young men because she refused \ntheir advances; the men received minimal punishment from the presiding judge. \nThe Don is disappointed in Bonasera, who'd avoided most contact with the Don due \n to Corleone's nefarious business dealings.The Don's wife is godmother to Bonasera's shamed daughter, a relationship the Don uses\n to extract new loyalty from the undertaker.\n The Don agrees to have his men punish the young men responsible (in a non-lethal manner)\n in return for future service if necessary.";
        }

        private void btnDarkKnight_Click(object sender, EventArgs e)
        {
            lblFilmS.Text = "Set within a year after the events of Batman Begins (2005), Batman,\n Lieutenant James Gordon, and new District Attorney Harvey Dent successfully begin \nto round up the criminals that plague Gotham City, until a mysterious\n and sadistic criminal mastermind known only as \"The Joker\" appears in Gotham, creating a new wave of chaos.\n Batman's struggle against The Joker becomes deeply personal, forcing him to\n \"confront everything he believes\" and improve his technology to stop him.\n A love triangle develops between Bruce Wayne, Dent, and Rachel Dawes";
        }

        private void btnGodFather2_Click(object sender, EventArgs e)
        {
            lblFilmS.Text = "The continuing saga of the Corleone crime family tells the story of \n a young Vito Corleone growing up in Sicily and in 1910s New York; and follows\n Michael Corleone in the 1950s as he attempts to expand the family \n business into Las Vegas, Hollywood and Cuba.";
        }

        private void btnAngryMen_Click(object sender, EventArgs e)
        {
            lblFilmS.Text = "The defense and the prosecution have rested, and the jury is filing into\n the jury room to decide if a young man is guilty or innocent of murdering his\n father. What begins as an open-and-shut case of murder soon becomes a \n detective story that presents a succession of clues creating doubt, and a mini-drama of each of the jurors' \n prejudices and preconceptions about the trial, the accused, AND each other.\n Based on the play, all of the action takes p\nlace on the stage of the jury room.";
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lblFilmS.Text = "Oskar Schindler is a vain and greedy German businessman who becomes an unlikely humanitarian amid the\n barbaric German Nazi reign when he feels compelled to turn his factory into a refuge for Jews.\n Based on the true story of Oskar Schindler who managed to save about\n 1100 Jews from being gassed at the Auschwitz concentration camp, it is a testament to the good in all of us.";
        }

        private void btnLOTRReturn_Click(object sender, EventArgs e)
        {
            lblFilmS.Text = "The final confrontation between the forces of good and evil fighting for \n control of the future of Middle-earth. Frodo and Sam reach Mordor in their quest\n to destroy the One Ring, while Aragorn leads the forces of good against\n Sauron's evil army at the stone city of Minas Tirith.";
        }

        private void btnPulp_Click(object sender, EventArgs e)
        {
            lblFilmS.Text = "Jules Winnfield (Samuel L. Jackson) and Vincent Vega (John Travolta) are \n two hit men who are out to retrieve a suitcase stolen from their employer, mob boss \n Marsellus Wallace (Ving Rhames). Wallace has also asked Vincent to\n take his wife Mia (Uma Thurman) out a few days later when Wallace himself will be out of town.\n Butch Coolidge (Bruce Willis) is an aging boxer who is paid by Wallace to lose his fight.\n The lives of these seemingly unrelated \npeople are woven together comprising of a series of funny, bizarre and uncalled-for incidents.—Soumitra";
        }

        private void btnLOTRFellowship_Click(object sender, EventArgs e)
        {
            lblFilmS.Text = "An ancient Ring thought lost for centuries has been found, and through a \nstrange twist of fate has been given to a small Hobbit named Frodo. When Gandalf discovers\n the Ring is in fact the One Ring of the Dark Lord Sauron, Frodo\n must make an epic quest to the Cracks of Doom in order to destroy it. However, he does not go alone.\n He is joined by Gandalf, Legolas the elf, Gimli the Dwarf, Aragorn, Boromir, and his three Hobbit \nfriends Merry, Pippin,\n and Samwise. Through mountains, snow, darkness, forests, rivers and plains, facing evil and danger at\n every corner the Fellowship of the Ring must go. Their quest to destroy the One Ring is the only\n hope for the end of the Dark Lords reign.";
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            lblFilmS.Text = "During the American Civil War, three men set off to find $200,000.00 in buried gold coins.\n Tuco (Eli Wallach) and Blondie (Clint Eastwood) have known each other for\n some time now having used the reward on Tuco's head as a way of\n earning money. They come across a dying man, Bill Carson (Antonio Casale), who tells them of a\n treasure in gold coins. By chance, he tells Tuco the name of the cemetery and tells\n Blondie the name of the grave where the gold\n is buried. Now rivals, the two men have good reason to keep each other alive. The third man, Angel Eyes\n (Lee Van Cleef), hears of the gold stash from someone he's been hired to kill. All he knows is\n to look for for someone named Bill Carson. The three ultimately meet in a \nshowdown that takes place amid a major battle between Confederate and Union forces.";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
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
