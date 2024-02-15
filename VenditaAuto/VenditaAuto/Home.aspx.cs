using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VenditaAuto
{
    public partial class Home : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InserisciAuto();
                InserimentoOptional();
            }

        }
        protected void InserisciAuto()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Auto"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            string IDAuto = Request.QueryString["IDAuto"];

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * From Automobili";
                SqlDataReader reader = cmd.ExecuteReader();
                ListaAuto.Items.Add(new ListItem("Seleziona un'auto"));

                while (reader.Read())
                {
                    string AutoLista = reader["Marca"].ToString() + " " + reader["Modello"].ToString() + " Cilindrata " + reader["Cilindrata"].ToString() + " Elettrica " + reader["Elettrica"].ToString() + " Prezzo " + reader["Prezzo"].ToString();
                    ListItem li = new ListItem(AutoLista);
                    ListaAuto.Items.Add(li);
                }

            }
            catch
            {
                Response.Write("Errore");
            }
            finally
            {
                conn.Close();
            }

        }
        protected void InserimentoOptional()
        {
            string Optional = ConfigurationManager.ConnectionStrings["Auto"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(Optional);
           
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * From Optional";
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string OptionalLista = reader["Nome"].ToString() + " Euro " + reader["Prezzo"].ToString();
                    ListItem li = new ListItem(OptionalLista);
                    ListaOptional.Items.Add(li);


                }

            }
            catch
            {
                Response.Write("Errore");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}