using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
        }

        private void rechercheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recherche rech = new Recherche();
            rech.Show();
        }

        private void sortieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sortie form_sortie = new Sortie();
            form_sortie.Show();
        }

        private void etatProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Etat form_etat = new Etat();
            form_etat.Show();
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aide aide = new Aide();
            aide.Show();
        }

        private void reportingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = "";
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aProposDeNousToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
