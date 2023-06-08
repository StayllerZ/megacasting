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
            SqlConnection connection = new SqlConnection("Server=10.192.86.4;Database=Commandes;User Id=sa;Password=root;");

            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandText = @"SELECT * FROM PackCasting"
            };

            connection.Open();

            SqlDataReader query = command.ExecuteReader();

            List<ComboBoxClientDB> ComboBoxList = new List<ComboBoxClientDB>();

            while (query.Read())
            {
                int identifier = query.GetInt32("Identifiant");
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

        private void RemplirDatagrid()
        {
            SqlConnection connection = new SqlConnection("Server=10.192.86.4;Database=Commandes;User Id=sa;Password=root;");

            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandText = @"SELECT * FROM Client"
            };

            connection.Open();

            SqlDataReader query = command.ExecuteReader();

            List<ClientDB> ClientList = new List<ClientDB>();

            while (query.Read())
            {
                int identifier = query.GetInt32("Identifiant");
                ClientDB commandMessage = new ClientDB()
                {
                    Id = identifier,
                    Name = query.GetString("nom"),
                    Mail = query.GetString("mail"),
                    Tel = query.GetString("telephone"),
                    Login = query.GetString("login"),
                    Password = query.GetString("password"),
                    Url = query.GetString("url"),
                    Siret = query.GetString("siret"),
                    City = query.GetString("ville"),
                    Id_packCasting = query.GetInt32("IdentifiantPackCasting"),
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
                                            client.Id_packCasting);
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
            int id_packCast = ((ComboBoxClientDB)this.comboBoxContract.SelectedItem).Id;
            

            SqlConnection connection = new SqlConnection("Server=10.192.86.4;Database=Commandes;User Id=sa;Password=root;");

            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandText = @"INSERT INTO PARTENAIRES_DIFFUSION(NOM, MAIL_PART, TEL_PART)
                                    VALUES( @nom, @mail, @tel);";

            command.CommandText = @"INSERT INTO Client ( NOM, MAIL, PASSWORD, URL, SIRET, LOGIN, VILLE, TELEPHONE, IDENTIFIANTPACKCASTING) 
                        VALUES (@name, @mail, @password, @url, @siret, @login, @city, @telephone, @identifiant_pack_casting);";

            command.Parameters.AddWithValue("@name", nom);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@telephone", tel);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@url", url);
            command.Parameters.AddWithValue("@siret", siret);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@city", city);
            command.Parameters.AddWithValue("@identifiant_pack_casting", id_packCast);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

            dataGridViewClient.Rows.Clear();

            RemplirDatagrid();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            string nom = textBoxName.Text;
            string mail = textBoxMail.Text;
            string telephone = textBoxTel.Text;
            string password = textBoxPassword.Text;
            string url = textBoxUrl.Text;
            string siret = textBoxSiret.Text;
            string login = textBoxLogin.Text;
            string ville = textBoxCity.Text;
            int identifiant_pack_casting = ((ComboBoxClientDB)this.comboBoxContract.SelectedItem).Id;
            int identifiant = Int32.Parse(textBoxID.Text);

            SqlConnection connection = new SqlConnection("Server=10.192.86.4;Database=Commandes;User Id=sa;Password=root;");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = @"UPDATE Client SET NOM = @nom, MAIL = @mail, TELEPHONE = @telephone, PASSWORD = @password, URL = @url, SIRET = @siret, LOGIN = @login, VILLE = @ville, IDENTIFIANTPACKCASTING = @identifiant_pack_casting WHERE IDENTIFIANT = @identifiant;";
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@telephone", telephone);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@url", url);
            command.Parameters.AddWithValue("@siret", siret);
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@ville", ville);
            command.Parameters.AddWithValue("@identifiant_pack_casting", identifiant_pack_casting);
            command.Parameters.AddWithValue("@identifiant", identifiant);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            dataGridViewClient.Rows.Clear();
            RemplirDatagrid();
        }


        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBoxID.Text);

            SqlConnection connection = new SqlConnection("Server=10.192.86.4;Database=Commandes;User Id=sa;Password=root;");

            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandText = @"DELETE FROM Client WHERE identifiant = @id;";

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
            textBoxID.Text = id;
            textBoxName.Text = nom;
            textBoxMail.Text = code;
            textBoxTel.Text = tel;
            textBoxLogin.Text = login;
            textBoxPassword.Text = password;
            textBoxUrl.Text = url;
            textBoxCity.Text = city;
            // textBoxContrat.Text = contrat;
            textBoxSiret.Text = siret;
            comboBoxContract.SelectedIndex = contratInt- 1;
        }

    }
}
