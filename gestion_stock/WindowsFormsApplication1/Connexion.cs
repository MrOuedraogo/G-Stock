using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
   class Connexion
   {
       public OleDbConnection cnx_bd;

       public Connexion()
       {
           cnx_bd = new OleDbConnection();
       }
       public int OuvrirBD()
       {
           if (cnx_bd.State == ConnectionState.Closed)
           {
               cnx_bd.ConnectionString = @"Provider=Microsoft.jet.OLEDB.4.0;Data Source=" + Application.StartupPath.ToString() + "\\bdgestion.mdb";
               cnx_bd.Open();
           }
           if (cnx_bd.State == ConnectionState.Open)
               return 1;
           else
               return 0;

       }
       

       //Methode permettant de fermer une base de donnee
       public void FermerBD()
       {
           if(cnx_bd.State==ConnectionState.Open)
           {
               cnx_bd.Close();
               cnx_bd.Dispose();
           }
       }
   }

}
