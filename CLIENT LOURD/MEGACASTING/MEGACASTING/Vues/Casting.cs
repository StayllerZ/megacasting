using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEGACASTING.Class;

namespace MEGACASTING.Vues
{
    public partial class Casting : Form
    {
        public Casting()
        {
            InitializeComponent();
            RemplirDatagrid();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string Libelle = textBox1.Text;
            DateTime DateDebutCasting = DateTime.Parse(textBox2.Text);
            DateTime DateTimeFinCasting = DateTime.Parse(textBox3.Text);
            int ID = Int32.Parse(textBoxID.Text);
            string Reference = textBox4.Text;
            string City = textBox5.Text;
            decimal AgeMini = Decimal.Parse(textBox6.Text);
            decimal AgeMax = Decimal.Parse(textBox7.Text);
            DateTime DateDiffusion = DateTime.Parse(textBox8.Text);
            string Description = textBox9.Text;
            int IdClient = Int32.Parse(textBox10.Text);
            int IdMetier = Int32.Parse(textBox11.Text);
            int IdContrat = Int32.Parse(textBox12.Text);



            SqlConnection connection = new SqlConnection("Server= localhost; Database= MegaCastingDB; Integrated Security=True;");

            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandText = @"insert into OFFRE (LIBELLE_OFF, DESC_OFF, DATE_DEB_CAST, DATE_FIN_CAST, REFERENCE_OFFRE, LOCALISATION_OFF, AGEMIN, AGEMAX, DATE_OFFRE, ID_CONTRAT, ID_CLIENT, ID_MET) values( @LIBELLE_OFF, @DESC_OFF, @DATE_DEB_CAST, @DATE_FIN_CAST, @REFERENCE_OFFRE, @LOCALISATION_OFF, @AGEMIN, @AGEMAX, @DATE_OFFRE, @ID_CONTRAT, @ID_CLIENT, @ID_MET);";

   

            command.Parameters.AddWithValue("@LIBELLE_OFF", Libelle);
            command.Parameters.AddWithValue("@DESC_OFF", Description);
            command.Parameters.AddWithValue("@DATE_DEB_CAST", DateDebutCasting);
            command.Parameters.AddWithValue("@DATE_FIN_CAST", DateTimeFinCasting);
            command.Parameters.AddWithValue("@REFERENCE_OFFRE", Reference);
            command.Parameters.AddWithValue("@LOCALISATION_OFF", City);
            command.Parameters.AddWithValue("@AGEMIN", AgeMini);
            command.Parameters.AddWithValue("@AGEMAX", AgeMax);
            command.Parameters.AddWithValue("@DATE_OFFRE", DateDiffusion);
            command.Parameters.AddWithValue("@ID_CONTRAT", IdContrat);
            command.Parameters.AddWithValue("@ID_CLIENT", IdClient);
            command.Parameters.AddWithValue("@ID_MET", IdMetier);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

            dataGridViewClient.Rows.Clear();

            RemplirDatagrid();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            string Libelle = textBox1.Text;
            DateTime DateDebutCasting = DateTime.Parse(textBox2.Text);
            DateTime DateTimeFinCasting = DateTime.Parse(textBox3.Text);
            int ID = Int32.Parse(textBoxID.Text);
            string Reference = textBox4.Text;
            string City = textBox5.Text;
            decimal AgeMini = Decimal.Parse(textBox6.Text);
            decimal AgeMax = Decimal.Parse(textBox7.Text);
            DateTime DateDiffusion = DateTime.Parse(textBox8.Text);
            string Description = textBox9.Text;
            int IdClient = Int32.Parse(textBox10.Text);
            int IdMetier = Int32.Parse(textBox11.Text);
            int IdContrat = Int32.Parse(textBox12.Text);

            SqlConnection connection = new SqlConnection("Server= localhost; Database= MegaCastingDB; Integrated Security=True;");

            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandText = @"UPDATE OFFRE SET LIBELLE_OFF = @LIBELLE_OFF, DESC_OFF = @DESC_OFF, DATE_DEB_CAST = @DATE_DEB_CAST, DATE_FIN_CAST = @DATE_FIN_CAST, REFERENCE_OFFRE = @REFERENCE_OFFRE, LOCALISATION_OFF = @LOCALISATION_OFF, AGEMIN = @AGEMIN, AGEMAX = @AGEMAX, DATE_OFFRE = @DATE_OFFRE, ID_CONTRAT = @ID_CONTRAT, ID_CLIENT = @ID_CLIENT,ID_MET = @ID_MET  WHERE ID_OFFRE = @ID;";

            command.Parameters.AddWithValue("@LIBELLE_OFF", Libelle);
            command.Parameters.AddWithValue("@DESC_OFF", Description);
            command.Parameters.AddWithValue("@DATE_DEB_CAST", DateDebutCasting);
            command.Parameters.AddWithValue("@DATE_FIN_CAST", DateTimeFinCasting);
            command.Parameters.AddWithValue("@REFERENCE_OFFRE", Reference);
            command.Parameters.AddWithValue("@LOCALISATION_OFF", City);
            command.Parameters.AddWithValue("@AGEMIN", AgeMini);
            command.Parameters.AddWithValue("@AGEMAX", AgeMax);
            command.Parameters.AddWithValue("@DATE_OFFRE", DateDiffusion);
            command.Parameters.AddWithValue("@ID_CONTRAT", IdContrat);
            command.Parameters.AddWithValue("@ID_CLIENT", IdClient);
            command.Parameters.AddWithValue("@ID_MET", IdMetier);
            command.Parameters.AddWithValue("@ID", ID);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

            dataGridViewClient.Rows.Clear();

            RemplirDatagrid();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBoxID.Text);

            SqlConnection connection = new SqlConnection("Server= localhost; Database= MegaCastingDB; Integrated Security=True;");

            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandText = @"DELETE FROM OFFRE WHERE ID_OFFRE = @id;";

            command.Parameters.AddWithValue("@id", id);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

            dataGridViewClient.Rows.Clear();

            RemplirDatagrid();
        }

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridViewClient.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewClient.Rows[selectedrowindex];

            string id = Convert.ToString(selectedRow.Cells["Identifiant"].Value);
            string Libelle = Convert.ToString(selectedRow.Cells["Libelle"].Value);
            string Debut = Convert.ToString(selectedRow.Cells["Debut"].Value);
            string Fin = Convert.ToString(selectedRow.Cells["Fin"].Value);
            string Refference = Convert.ToString(selectedRow.Cells["Reference"].Value);
            string Ville = Convert.ToString(selectedRow.Cells["Ville"].Value);
            string AgeMin = Convert.ToString(selectedRow.Cells["AgeMin"].Value);
            string AgeMax = Convert.ToString(selectedRow.Cells["AgeMax"].Value);
            string Date = Convert.ToString(selectedRow.Cells["Date"].Value);
            string Desc = Convert.ToString(selectedRow.Cells["Desc"].Value);
            string Client = Convert.ToString(selectedRow.Cells["Client"].Value);
            string Metier = Convert.ToString(selectedRow.Cells["Metier"].Value);
            string Contrat = Convert.ToString(selectedRow.Cells["Contrat"].Value);
            textBoxID.Text = id;
            textBox1.Text = Libelle;
            textBox2.Text = Debut;
            textBox3.Text = Fin;
            textBox4.Text = Refference;
            textBox5.Text = Ville;
            textBox6.Text = AgeMin;
            textBox7.Text = AgeMax;
            textBox8.Text = Date;
            textBox9.Text = Desc;
            textBox10.Text = Client;
            textBox11.Text = Metier;
            textBox12.Text = Contrat;
        }











        private void RemplirDatagrid()
        {
            SqlConnection connection = new SqlConnection("Server= localhost; Database= MegaCastingDB; Integrated Security=True;");

            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandText = @"SELECT *
                                FROM OFFRE"
            };

            connection.Open();

            SqlDataReader query = command.ExecuteReader();

            List<CastingDB> Castinglist = new List<CastingDB>();

            while (query.Read())
            {
                int identifier = query.GetInt32("ID_OFFRE");
                CastingDB commandMessage = new CastingDB()
                {
                    ID = identifier,
                    Libelle = query.GetString("LIBELLE_OFF"),
                    DateDiffusion = query.GetDateTime("DATE_OFFRE"),
                    DateDebutCasting = query.GetDateTime("DATE_DEB_CAST"),
                    DateTimeFinCasting = query.GetDateTime("DATE_FIN_CAST"),
                    Reference = query.GetString("REFERENCE_OFFRE"),
                    City = query.GetString("LOCALISATION_OFF"),
                    AgeMini = (int)query.GetDecimal("AGEMIN"),
                    AgeMax = (int)query.GetDecimal("AGEMAX"),
                    Description = query.GetString("DESC_OFF"),
                    IdClient = query.GetInt32("ID_CLIENT"),
                    IdMetier = query.GetInt32("ID_MET"),
                    IdContrat = query.GetInt32("ID_CONTRAT")
                };
                Castinglist.Add(commandMessage);
            }

            connection.Close();

            foreach (CastingDB casting in Castinglist)
            {
                dataGridViewClient.Rows.Add(casting.ID,
                                            casting.Libelle,
                                            casting.DateDebutCasting,
                                            casting.DateTimeFinCasting,
                                            casting.Reference,
                                            casting.City,
                                            casting.AgeMini,
                                            casting.AgeMax,
                                            casting.DateDiffusion,
                                            casting.Description,
                                            casting.IdClient,
                                            casting.IdMetier,
                                            casting.IdContrat
                                            );
            }
        }

    }
}
