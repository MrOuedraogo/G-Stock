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
    public partial class Authentification : Form
    {
        OleDbConnection chaine_cnx = new OleDbConnection();
        OleDbDataAdapter cnx_dataAdapter;
        OleDbCommandBuilder cnx_commandBuilder;

        DataTable vue_users = new DataTable();
        Connexion cnx = new Connexion();
        public Authentification()
        {
            InitializeComponent();
        }

        private void Authentification_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            string xlogin = txt_login.Text;
            string xpassword = txt_password.Text;
            if(cnx.OuvrirBD()==1)
            {
                chaine_cnx = cnx.cnx_bd;
                vue_users.Reset();

                cnx_dataAdapter = new OleDbDataAdapter("Select * From Users where login like '"+xlogin+"' and password like '"+xpassword+"'", chaine_cnx);
                cnx_commandBuilder = new OleDbCommandBuilder(cnx_dataAdapter);
                cnx_dataAdapter.Fill(vue_users);
                if (vue_users.Rows.Count > 0)
                {
                    this.Visible = false;
                    Menu menu = new Menu();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrecte", "Connexion Impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    viderChamp();
                }
            }
            else
            {
                MessageBox.Show("Impossible d'ouvrir la base de donnée", "Acces refusé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        public void viderChamp()
        {
            txt_login.Text = "";
            txt_password.Text= "";
            txt_login.Focus();
        }

        private void btn_connexion_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btn_connexion_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                  btn_connexion_Click(sender, e);
            }
        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
