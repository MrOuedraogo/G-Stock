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
    public partial class Aide : Form
    {
        public Aide()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string str =
                "Dans le sousMenu Produit,Vous pouvez Ajouter un nouveau produit.Vous pouvez egalement supprimer un ou plusieurs produit aussi de la liste et modifier d'autre si necessaie "+Environment.NewLine+
                "Dans le sousMenu Rechercher vous pouvez rechercher un produit depuis votre base de donnée via sa reference. "+Environment.NewLine+
                "Dans le sousMenu Sortie vous pouvez faire des retraits de produit"+Environment.NewLine+
                "";
            this.lbl_principale.Text = str;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string str = "Dans le Menu Reporting vous pourrez voir tous vos produit et les differentes informations associée a chaque produit,Rechercher des produits et imprimer la liste complete. ";
            this.lbl_principale.Text = str;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string str = "Decouvrez notre entreprise dans ce menu. Nous sommes une entreprise qui oeuvre dans la promotion du numeriques en realisant des applications et en formant des jeunes dans ce domaine. Plus d'infos dans le menu.";
            this.lbl_principale.Text = str;
        }
    }
}
