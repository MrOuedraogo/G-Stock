using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Etat : Form
    {
        OleDbConnection chaine_cnx = new OleDbConnection();
        OleDbDataAdapter cnx_dataAdapter;
        OleDbCommandBuilder cnx_commandBuilder;

        DataTable vue_produits = new DataTable();
        Connexion cnx = new Connexion();
        public Etat()
        {
            InitializeComponent();
        }

        private void Etat_Load(object sender, EventArgs e)
        {
           
            if(cnx.OuvrirBD()==1)
            {
                chaine_cnx = cnx.cnx_bd;
                vue_produits.Reset();

                cnx_dataAdapter = new OleDbDataAdapter("Select * From Produits", chaine_cnx);
                cnx_commandBuilder = new OleDbCommandBuilder(cnx_dataAdapter);
                cnx_dataAdapter.Fill(vue_produits);

                ProduitsBindingSource.DataSource = vue_produits;
            
            this.reportViewer1.RefreshReport();
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
