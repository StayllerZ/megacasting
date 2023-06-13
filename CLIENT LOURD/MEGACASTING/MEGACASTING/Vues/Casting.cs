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
using MEGACASTINGLIB;

namespace MEGACASTING.Vues
{
    public partial class Casting : Form
    {
        public Casting()
        {
            InitializeComponent();
            RemplirComboBox();
            RemplirDatagrid();
        }



        private void RemplirComboBox()
        {
            SqlConnection connection = new SqlConnection("Server=10.192.86.4;Database=Commandes;User Id=sa;Password=root;");

            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandText = @"SELECT * FROM Experience"
            };

            connection.Open();

            SqlDataReader query = command.ExecuteReader();

            List<ComboBoxClientDB> ComboBoxList = new List<ComboBoxClientDB>();

            while (query.Read())
            {
                int identifier = query.GetInt32("identifiant");
                ComboBoxClientDB commandMessage = new ComboBoxClientDB()
                {
                    Id = identifier,
                    Name = query.GetString("libelle"),
                };
                ComboBoxList.Add(commandMessage);
            }

            connection.Close();

            foreach (ComboBoxClientDB ComboItem in ComboBoxList)
            {
                comboBoxContract.Items.Add(ComboItem);
            }


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
            string Description = textBox9.Text;
            int IdClient = Int32.Parse(textBox10.Text);
            int IdMetier = Int32.Parse(textBox11.Text);
            int IdContrat = Int32.Parse(textBox12.Text);
            int id_experience = ((ComboBoxClientDB)this.comboBoxContract.SelectedItem).Id;



            SqlConnection connection = new SqlConnection("Server=10.192.86.4;Database=Commandes;User Id=sa;Password=root;");

            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandText = @"insert into OFFRE (libelle, description, date_debut_casting, date_fin_casting, reference, localisation, age_minimum, age_maximum, IdentifiantTypeContrat, IdentifiantClient, IdentifiantMetier, id_experience) values( @libelle, @description, @date_debut_casting, @date_fin_casting, @reference, @localisation, @age_minimum, @age_maximum, @IdentifiantTypeContrat, @IdentifiantClient, @IdentifiantMetier, @Id_experience);";

            command.Parameters.AddWithValue("@libelle", Libelle);
            command.Parameters.AddWithValue("@description", Description);
            command.Parameters.AddWithValue("@date_debut_casting", DateDebutCasting);
            command.Parameters.AddWithValue("@date_fin_casting", DateTimeFinCasting);
            command.Parameters.AddWithValue("@reference", Reference);
            command.Parameters.AddWithValue("@localisation", City);
            command.Parameters.AddWithValue("@age_minimum", AgeMini);
            command.Parameters.AddWithValue("@age_maximum", AgeMax);
            command.Parameters.AddWithValue("@IdentifiantTypeContrat", IdContrat);
            command.Parameters.AddWithValue("@IdentifiantClient", IdClient);
            command.Parameters.AddWithValue("@IdentifiantMetier", IdMetier);
            command.Parameters.AddWithValue("@Id_experience", id_experience);

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
            string Description = textBox9.Text;
            int IdClient = Int32.Parse(textBox10.Text);
            int IdMetier = Int32.Parse(textBox11.Text);
            int IdContrat = Int32.Parse(textBox12.Text);
            string ActualDate = DateTime.Now.ToString();
            int id_experience = ((ComboBoxClientDB)this.comboBoxContract.SelectedItem).Id;

            SqlConnection connection = new SqlConnection("Server=10.192.86.4;Database=Commandes;User Id=sa;Password=root;");

            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandText = @"UPDATE OFFRE SET libelle = @libelle, description = @description, date_debut_casting = @date_debut_casting, date_fin_casting = @date_fin_casting, reference = @reference, localisation = @localisation, age_minimum = @age_minimum, age_maximum = @age_maximum, IdentifiantTypeContrat = @IdentifiantTypeContrat, IdentifiantClient = @IdentifiantClient, IdentifiantMetier = @IdentifiantMetier, id_experience = @Id_experience WHERE Identifiant = @Identifiant;";

            command.Parameters.AddWithValue("@libelle", Libelle);
            command.Parameters.AddWithValue("@description", Description);
            command.Parameters.AddWithValue("@date_debut_casting", DateDebutCasting);
            command.Parameters.AddWithValue("@date_fin_casting", DateTimeFinCasting);
            command.Parameters.AddWithValue("@reference", Reference);
            command.Parameters.AddWithValue("@localisation", City);
            command.Parameters.AddWithValue("@age_minimum", AgeMini);
            command.Parameters.AddWithValue("@age_maximum", AgeMax);
            command.Parameters.AddWithValue("@IdentifiantTypeContrat", IdContrat);
            command.Parameters.AddWithValue("@IdentifiantClient", IdClient);
            command.Parameters.AddWithValue("@IdentifiantMetier", IdMetier);
            command.Parameters.AddWithValue("@Identifiant", ID);
            command.Parameters.AddWithValue("@Id_experience", id_experience);


            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

            dataGridViewClient.Rows.Clear();

            RemplirDatagrid();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBoxID.Text);

            string actualDate = DateTime.Now.ToString();

            SqlConnection connection = new SqlConnection("Server=10.192.86.4;Database=Commandes;User Id=sa;Password=root;");

            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandText = @"DELETE FROM Offre where identifiant = @id;";

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
            Int32 experienceInt = Convert.ToInt32(selectedRow.Cells["Experience"].Value);
            textBoxID.Text = id;
            textBox1.Text = Libelle;
            textBox2.Text = Debut;
            textBox3.Text = Fin;
            textBox4.Text = Refference;
            textBox5.Text = Ville;
            textBox6.Text = AgeMin;
            textBox7.Text = AgeMax;
            textBox9.Text = Desc;
            textBox10.Text = Client;
            textBox11.Text = Metier;
            textBox12.Text = Contrat;
            comboBoxContract.SelectedIndex = experienceInt - 1;
        }

        private void RemplirDatagrid()
        {
            SqlConnection connection = new SqlConnection("Server=10.192.86.4;Database=Commandes;User Id=sa;Password=root;");

            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandText = @"SELECT * FROM Offre"
            };

            connection.Open();

            SqlDataReader query = command.ExecuteReader();

            List<CastingDB> Castinglist = new List<CastingDB>();

            while (query.Read())
            {
                    int identifier = query.GetInt32("identifiant");
                        CastingDB commandMessage = new CastingDB()
                        {
                            ID = identifier,
                            Libelle = query.GetString("libelle"),
                            //DateDiffusion = query.GetDateTime("date_diffusion"),
                            DateDebutCasting = query.GetDateTime("date_debut_casting"),
                            DateTimeFinCasting = query.GetDateTime("date_fin_casting"),
                            Reference = query.GetString("reference"),
                            City = query.GetString("localisation"),
                            AgeMini = query.GetInt32("age_minimum"),
                            AgeMax = query.GetInt32("age_maximum"),
                            Description = query.GetString("description"),
                            IdClient = query.GetInt32("IdentifiantClient"),
                            IdMetier = query.GetInt32("IdentifiantMetier"),
                            IdContrat = query.GetInt32("IdentifiantTypeContrat"),
                            Id_experience = query.GetInt32("id_experience"),

                        };
                        Castinglist.Add(commandMessage);            
            }

            connection.Close();

            foreach (CastingDB casting in Castinglist)
            {
                //dataGridViewClient.DefaultCellStyle.NullValue = "Aucune modification";
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
                                            casting.IdContrat,
                                            casting.Id_experience
                                            );
            }
        }
        private void RechercheByLibelle()
        {
            string libelleFind = textBox1.Text;
            System.Data.SqlClient.SqlConnection connection = new SqlConnection("Server=10.192.86.4;Database=Commandes;User Id=sa;Password=root;");

            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandText = @"SELECT *
                                FROM OFFRE WHERE libelle = @libelle"
            };
            command.Parameters.AddWithValue("@libelle", libelleFind);

            connection.Open();

            SqlDataReader query = command.ExecuteReader();

            List<CastingDB> Castinglist = new List<CastingDB>();

            while (query.Read())
            {
                int identifier = query.GetInt32("identifiant");
                CastingDB commandMessage = new CastingDB()
                {
                     ID = identifier,
                    Libelle = query.GetString("libelle"),
                    DateDebutCasting = query.GetDateTime("date_debut_casting"),
                    DateTimeFinCasting = query.GetDateTime("date_fin_casting"),
                    Reference = query.GetString("reference"),
                    City = query.GetString("localisation"),
                    AgeMini = query.GetInt32("age_minimum"),
                    AgeMax = query.GetInt32("age_maximum"),
                    Description = query.GetString("description"),
                    IdClient = query.GetInt32("IdentifiantClient"),
                    IdMetier = query.GetInt32("IdentifiantMetier"),
                    IdContrat = query.GetInt32("IdentifiantTypeContrat")
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewClient.Rows.Clear();
            RechercheByLibelle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewClient.Rows.Clear();
            RemplirDatagrid();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

}
