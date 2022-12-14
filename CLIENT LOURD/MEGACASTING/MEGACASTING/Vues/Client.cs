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
    public partial class Client : Form
    {


        private void RemplirComboBox()
        {
            SqlConnection connection = new SqlConnection("Server= localhost; Database= MegaCastingDB; Integrated Security=True;");

            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandText = @"SELECT ID_PACK, LIBELLE_PACK
                                FROM PACK_CASTING"
            };

            connection.Open();

            SqlDataReader query = command.ExecuteReader();

            List<ComboBoxClientDB> ComboBoxList = new List<ComboBoxClientDB>();

            while (query.Read())
            {
                int identifier = query.GetInt32("ID_PACK");
                ComboBoxClientDB commandMessage = new ComboBoxClientDB()
                {
                    Id = identifier,
                    Name = query.GetString("LIBELLE_PACK"),
                };
                ComboBoxList.Add(commandMessage);
            }

            connection.Close();

            foreach (ComboBoxClientDB ComboItem in ComboBoxList)
            {
                comboBoxContract.Items.Add(ComboItem);
            }





        }

        private void RemplirDatagrid()
        {
            SqlConnection connection = new SqlConnection("Server= localhost; Database= MegaCastingDB; Integrated Security=True;");

            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandText = @"SELECT *
                                FROM CLIENT"
            };

            connection.Open();

            SqlDataReader query = command.ExecuteReader();

            List<ClientDB> ClientList = new List<ClientDB>();

            while (query.Read())
            {
                int identifier = query.GetInt32("ID_CLIENT");
                ClientDB commandMessage = new ClientDB()
                {
                    Id = identifier,
                    Name = query.GetString("NOM_CLI"),
                    Mail = query.GetString("MAIL_CLI"),
                    Tel = query.GetDecimal("TEL_CLI"),
                    Login = query.GetString("LOGIN_CLI"),
                    Password = query.GetString("PASSWORD_CLI"),
                    Url = query.GetString("URL_CLI"),
                    Siret = query.GetString("SIRET_CLI"),
                    City = query.GetString("VILLE_CLI"),
                    Id_packCasting = query.GetInt32("ID_PACK"),
                    Nbr_rest_offre = query.GetInt32("NB_REST_OFF_CLI")
                };
                ClientList.Add(commandMessage);
            }

            connection.Close();

            foreach (ClientDB client in ClientList)
            {
                dataGridViewClient.Rows.Add(client.Id,
                                            client.Name,
                                            client.Mail,
                                            client.Tel,
                                            client.Login,
                                            client.Password,
                                            client.Url,
                                            client.Siret,
                                            client.City,
                                            client.Id_packCasting,
                                            client.Nbr_rest_offre);
            }
        }





        public Client()
        {
            InitializeComponent();
            RemplirDatagrid();
            RemplirComboBox();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string nom = textBoxName.Text;
            string tel = textBoxTel.Text;
            string mail = textBoxMail.Text;
            int id = Int32.Parse(textBoxID.Text);
            string password = textBoxPassword.Text;
            string url = textBoxUrl.Text;
            string siret = textBoxSiret.Text;
            string city = textBoxCity.Text;
            string login = textBoxLogin.Text;
            // string id_pack = textBoxContrat.Text;
            string nb_rest_off = textBoxRestant.Text;
            int id_packCast = ((ComboBoxClientDB)this.comboBoxContract.SelectedItem).Id;
            

            SqlConnection connection = new SqlConnection("Server= localhost; Database= MegaCastingDB; Integrated Security=True;");

            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandText = @"INSERT INTO PARTENAIRES_DIFFUSION(NOM, MAIL_PART, TEL_PART)
                                    VALUES( @nom, @mail, @tel);";

            command.CommandText = @"insert into CLIENT (NOM_CLI, TEL_CLI, MAIL_CLI, PASSWORD_CLI, URL_CLI, SIRET_CLI, LOGIN_CLI, VILLE_CLI, ID_PACK, NB_REST_OFF_CLI) values (@name, @tel, @mail, @password, @url, @siret, @login, @city, @id_pack, @nb_rest_off);";

            command.Parameters.AddWithValue("@name", nom);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@tel", tel);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@url", url);
            command.Parameters.AddWithValue("@siret", siret);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@city", city);
            command.Parameters.AddWithValue("@id_pack", id_packCast);
            command.Parameters.AddWithValue("@nb_rest_off", nb_rest_off);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

            dataGridViewClient.Rows.Clear();

            RemplirDatagrid();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            string nom = textBoxName.Text;
            string tel = textBoxTel.Text;
            string mail = textBoxMail.Text;
            string password = textBoxPassword.Text;
            string url = textBoxUrl.Text;
            string siret = textBoxSiret.Text;
            string city = textBoxCity.Text;
            string login = textBoxLogin.Text;
            // string id_pack = textBoxContrat.Text;
            string nb_rest_off = textBoxRestant.Text;
            int id = Int32.Parse(textBoxID.Text);
            int id_packCast = ((ComboBoxClientDB)this.comboBoxContract.SelectedItem).Id;

            SqlConnection connection = new SqlConnection("Server= localhost; Database= MegaCastingDB; Integrated Security=True;");

            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandText = @"UPDATE CLIENT SET NOM_CLI = @nom, MAIL_CLI = @mail, TEL_CLI = @tel, PASSWORD_CLI = @password, URL_CLI = @url, SIRET_CLI = @siret, LOGIN_CLI = @login, VILLE_CLI = @city, ID_PACK = @id_pack, NB_REST_OFF_CLI = @nb_rest_off WHERE ID_CLIENT = @id;";

            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@tel", tel);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@url", url);
            command.Parameters.AddWithValue("@siret", siret);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@city", city);
            command.Parameters.AddWithValue("@id_pack", id_packCast);
            command.Parameters.AddWithValue("@nb_rest_off", nb_rest_off);
            command.Parameters.AddWithValue("@id", id);

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

            command.CommandText = @"DELETE FROM CLIENT WHERE ID_CLIENT = @id;";

            command.Parameters.AddWithValue("@id", id);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

            dataGridViewClient.Rows.Clear();

            RemplirDatagrid();
        }

        private void dataGridViewPartenaire_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridViewClient.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewClient.Rows[selectedrowindex];

            string id = Convert.ToString(selectedRow.Cells["Identifiant"].Value);
            string nom = Convert.ToString(selectedRow.Cells["Nom"].Value);
            string code = Convert.ToString(selectedRow.Cells["Mail"].Value);
            string tel = Convert.ToString(selectedRow.Cells["Telephone"].Value);
            string login = Convert.ToString(selectedRow.Cells["Login"].Value);
            string password = Convert.ToString(selectedRow.Cells["Password"].Value);
            string url = Convert.ToString(selectedRow.Cells["Url"].Value);
            string siret = Convert.ToString(selectedRow.Cells["Siret"].Value);
            string city = Convert.ToString(selectedRow.Cells["City"].Value);
            string contrat = Convert.ToString(selectedRow.Cells["Contrat"].Value);
            Int32 contratInt = Convert.ToInt32(contrat);
            string restant = Convert.ToString(selectedRow.Cells["Restant"].Value);
            textBoxID.Text = id;
            textBoxName.Text = nom;
            textBoxMail.Text = code;
            textBoxTel.Text = tel;
            textBoxLogin.Text = login;
            textBoxPassword.Text = password;
            textBoxUrl.Text = url;
            textBoxCity.Text = city;
            // textBoxContrat.Text = contrat;
            textBoxRestant.Text = restant;
            textBoxSiret.Text = siret;
            comboBoxContract.SelectedIndex = contratInt- 1;
        }

    }
}
