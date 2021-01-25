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

    public partial class Form1 : Form
    {

        OleDbConnection chaine_cnx = new OleDbConnection();
        OleDbDataAdapter cnx_dataAdapter;
        OleDbCommandBuilder cnx_commandBuilder;

        DataTable vue_produits = new DataTable();
        Connexion cnx = new Connexion();

        List<ListViewItem> list_prod = new List<ListViewItem>();

        public Form1()
        {
            InitializeComponent();
            chargerListe();
            desactiver();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnenregister_Click(object sender, EventArgs e)

        {
            desactiver();
            
            if(MessageBox.Show("Voulez vous ajoutez effectuer un enregistrement","Demande de confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {

           genererRef();

                     cnx_dataAdapter = new OleDbDataAdapter("Select * From Produits", chaine_cnx);
                     cnx_commandBuilder = new OleDbCommandBuilder(cnx_dataAdapter);
                     cnx_dataAdapter.Fill(vue_produits);

                     DataRow drNewProd = vue_produits.NewRow();

                     drNewProd["Reference"] = txtreference.Text.Trim();
                     drNewProd["Libelle"] = txtproduits.Text.Trim();
                     drNewProd["Origine"] = txtorigine.Text.Trim();
                     drNewProd["Dateexpiration"] = dtpperemption.Text.Trim();
                     drNewProd["Prix"] = txtprix.Text.Trim();
                     drNewProd["Categorie"] = cmbcategorie.Text.Trim();
                     drNewProd["Quantite"] = txtstock.Text.Trim();
                     drNewProd["Lot"] = txtlot.Text.Trim();

                     vue_produits.Rows.Add(drNewProd);
                     cnx_dataAdapter.Update(vue_produits);
                     MessageBox.Show("Enregistrement effectuée avec succès", "Enregistrement Reuissie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     cnx.FermerBD();
                     ListViewItem itm = new ListViewItem(txtreference.Text);
/*                     lsvproduit.Items.Add(itm).SubItems.Add(txtlot.Text);
                    itm.SubItems.Add(txtproduits.Text);
                    itm.SubItems.Add(txtstock.Text);
                    itm.SubItems.Add(txtprix.Text);
                    itm.SubItems.Add(dtpperemption.Text);
                    itm.SubItems.Add(cmbcategorie.Text);
                    itm.SubItems.Add(txtorigine.Text);
                    itm.SubItems.Add(txtlot.Text);
                     
                     lsvproduit.Update();*/
                     txtreference.Text = "";
                     txtproduits.Text = "";
                     txtorigine.Text = "";
                     txtprix.Text = "";
                     txtstock.Text = "";
                     txtlot.Text = "";

                     chargerListe();
                 }
            viderChamps();
                
            }


        

        public void chargerListe()
        {
            if(cnx.OuvrirBD()==1)
            {
                chaine_cnx = cnx.cnx_bd;
                vue_produits.Reset();
                cnx_dataAdapter = new OleDbDataAdapter("Select * From Produits", chaine_cnx);
                cnx_commandBuilder = new OleDbCommandBuilder(cnx_dataAdapter);
                cnx_dataAdapter.Fill(vue_produits);
                int TotalEng = vue_produits.Rows.Count;
                lsvproduit.BeginUpdate();
                list_prod.Clear();
                for(int i=0;i<TotalEng;i++)
                {
                    ListViewItem listItem = new ListViewItem(vue_produits.Rows[i].ItemArray[0].ToString());
                    for(int j=1;j<vue_produits.Columns.Count;j++)
                    {
                        listItem.SubItems.Add(vue_produits.Rows[i].ItemArray[j].ToString().Trim());
                    }
                    list_prod.Add(listItem);
                }
                lsvproduit.Items.Clear();
                lsvproduit.Items.AddRange(list_prod.ToArray());
                lsvproduit.EndUpdate();
                
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Merci d'avoir utilisé GSTock".Substring(3, 7));
            Close();
        }

        private void btnnouveau_Click(object sender, EventArgs e)
        {
            activer();
            

            chargerListe();
        }

        private void lsvproduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvproduit.SelectedItems.Count>0)
            {
                ListViewItem lsvItemSelected = lsvproduit.SelectedItems[0] as ListViewItem;
                lsvItemSelected.BackColor = Color.LightBlue;
                txtreference.Text = lsvItemSelected.SubItems[0].Text.Trim();
                txtproduits.Text = lsvItemSelected.SubItems[1].Text.Trim();
                txtstock.Text = lsvItemSelected.SubItems[2].Text.Trim();
                txtprix.Text = lsvItemSelected.SubItems[3].Text.Trim();
                dtpperemption.Text = lsvItemSelected.SubItems[4].Text.Trim();
                cmbcategorie.Text = lsvItemSelected.SubItems[5].Text.Trim();   
                txtorigine.Text = lsvItemSelected.SubItems[6].Text.Trim();
                txtlot.Text = lsvItemSelected.SubItems[7].Text.Trim();
            }
            desactiverListe();
        }

        private void cmbcategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            

            btnmodifier.BackColor=Color.Red;
            btnmodifier.ForeColor=Color.White;

            string xRef = txtreference.Text.Trim();
            if(cnx.OuvrirBD()==1)
            {
                chaine_cnx = cnx.cnx_bd;
                vue_produits.Reset();
                cnx_dataAdapter = new OleDbDataAdapter("Select * From Produits where Reference like '" + xRef + "'", chaine_cnx);
                cnx_commandBuilder = new OleDbCommandBuilder(cnx_dataAdapter);
                cnx_dataAdapter.Fill(vue_produits);
                if(vue_produits.Rows.Count>0)
                {
                    if (MessageBox.Show("Voulez vous vraiement effectuée", "Demande de confirmation de Modification",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        vue_produits.Rows[0]["Reference"]=txtreference.Text.Trim();
                         vue_produits.Rows[0]["Libelle"]=txtproduits.Text.Trim();
                         vue_produits.Rows[0]["Origine"]=txtorigine.Text.Trim();
                         vue_produits.Rows[0]["Dateexpiration"]=dtpperemption.Text.Trim() ;
                         vue_produits.Rows[0]["Prix"]=txtprix.Text.Trim();
                         vue_produits.Rows[0]["Quantite"]=txtstock.Text.Trim();
                         vue_produits.Rows[0]["Categorie"]=cmbcategorie.Text.Trim();
                         vue_produits.Rows[0]["Lot"]=txtlot.Text.Trim();

                         cnx_dataAdapter.Update(vue_produits);
                         MessageBox.Show("Modification effectuée avec succès.", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            btnmodifier.BackColor = Button.DefaultBackColor;
            btnmodifier.ForeColor = Color.Black;
            chargerListe();
            viderChamps();
            desactiver();
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
              if (MessageBox.Show("Voulez vous vraiment supprimez?", "Demande de confirmation de Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                         if (cnx.OuvrirBD() == 1)
                              {
                                chaine_cnx = cnx.cnx_bd;
                             if(lsvproduit.SelectedItems.Count>0)
                             {
                                 foreach(ListViewItem itemCourant in lsvproduit.SelectedItems)
                                 {
                                     string xProd = itemCourant.SubItems[0].Text.Trim();
                                      vue_produits.Reset();
                                        cnx_dataAdapter = new OleDbDataAdapter("Select * From Produits where Reference like '" + xProd + "'", chaine_cnx);
                                        cnx_commandBuilder = new OleDbCommandBuilder(cnx_dataAdapter);
                                        cnx_dataAdapter.Fill(vue_produits);
                                      if (vue_produits.Rows.Count > 0)
                                      {
                                           vue_produits.Rows[0].Delete();

                                      }
                                        cnx_dataAdapter.Update(vue_produits);

                                 }
                             }
                               chargerListe();
                               MessageBox.Show("Suppression effectuée avec succès.", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cnx.FermerBD();
                        viderChamps();
                     
                              }
                    }
              desactiver();
              viderChamps();
        }
                          

            /*string xRef = txtreference.Text.Trim();
            if (cnx.OuvrirBD() == 1)
            {
                chaine_cnx = cnx.cnx_bd;
                vue_produits.Reset();
                cnx_dataAdapter = new OleDbDataAdapter("Select * From Produits where Reference like '" + xRef + "'", chaine_cnx);
                cnx_commandBuilder = new OleDbCommandBuilder(cnx_dataAdapter);
                cnx_dataAdapter.Fill(vue_produits);
                if (vue_produits.Rows.Count > 0)
                {
                    if (MessageBox.Show("Voulez vous vraiment supprimez?", "Demande de confirmation de Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        vue_produits.Rows[0].Delete();
                        cnx_dataAdapter.Update(vue_produits);
                        MessageBox.Show("Suppression effectuée avec succès.", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cnx.FermerBD();

                        txtreference.Text = "";
                        txtproduits.Text = "";
                        txtorigine.Text = "";
                        txtprix.Text = "";
                        txtstock.Text = "";
                        txtlot.Text = "";
                    }
                }
            }
           */

        private void btnannuler_Click(object sender, EventArgs e)
        {
            desactiver();
            viderChamps();
        }

        private void dtpperemption_ValueChanged(object sender, EventArgs e)
        {

        }
        public void viderChamps()
        {
            txtreference.Clear();
            txtproduits.Clear();
            txtorigine.Clear();
            txtprix.Clear();
            txtstock.Clear();
            txtlot.Clear();
        }
        public void genererRef()
        {
                  if(cnx.OuvrirBD()==1)
                 {
                     chaine_cnx = cnx.cnx_bd;

                     vue_produits.Reset();
                     //Reinitialisation du data set
                     cnx_dataAdapter = new OleDbDataAdapter("Select * From Produits Order by Reference DESC", chaine_cnx);
                     cnx_commandBuilder = new OleDbCommandBuilder(cnx_dataAdapter);
                     cnx_dataAdapter.Fill(vue_produits);
                     int xNew_Code = 1;
                     if(vue_produits.Rows.Count>0)
                     {
                         string der_enreg = vue_produits.Rows[0]["Reference"].ToString().Trim();
                         xNew_Code = int.Parse(der_enreg.Trim()) + 1;


                     }
                     txtreference.Text = "0000".Substring(0, 4 - xNew_Code.ToString().Length) + xNew_Code.ToString();
                 }

        }
        private void desactiver()
        {
            txtproduits.Enabled = false;
            txtorigine.Enabled = false;
            txtprix.Enabled = false;
            txtstock.Enabled = false;
            txtlot.Enabled = false;
            dtpperemption.Enabled = false;
            txtproduits.Enabled = false;
            cmbcategorie.Enabled = false;
            
            btnsupprimer.Enabled = false;
             btnmodifier.Enabled = false;
             btnenregister.Enabled = false;
             btnnouveau.Enabled = true;
             btnannuler.Enabled = false;
             btnquitter.Enabled = true;
        }
        private void activer()
        {
            txtproduits.Enabled = true;
            txtorigine.Enabled = true;
            txtprix.Enabled = true;
            txtstock.Enabled = true;
            txtlot.Enabled = true;
            dtpperemption.Enabled = true;
            txtproduits.Enabled = true;
            cmbcategorie.Enabled = true;

            btnsupprimer.Enabled = true;
            btnmodifier.Enabled = true;
            btnenregister.Enabled = true;
            btnnouveau.Enabled = false;
            btnannuler.Enabled = true;
            btnquitter.Enabled = false;
        }
        private void desactiverListe()
        {
            txtproduits.Enabled = true;
            txtorigine.Enabled = true;
            txtprix.Enabled = true;
            txtstock.Enabled = true;
            txtlot.Enabled = true;
            dtpperemption.Enabled = true;
            txtproduits.Enabled = true;
            cmbcategorie.Enabled = true;

            btnsupprimer.Enabled = true;
            btnmodifier.Enabled = true;
            btnenregister.Enabled = false;
            btnnouveau.Enabled = false;
            btnannuler.Enabled = true;
            btnquitter.Enabled = false;
        }

        //e.handle fait quoi au juste:)
        private void txtprix_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = false;
            }
            
            base.OnKeyPress(e);


        }

        private void txtprix_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtprix.Text = long.Parse(txtprix.Text.Trim()).ToString();
            }
            catch
            {
                txtprix.Text = "";
            }
        }

        private void txtstock_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
