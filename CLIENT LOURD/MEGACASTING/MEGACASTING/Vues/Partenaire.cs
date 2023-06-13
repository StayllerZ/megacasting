using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MEGACASTING.Class;
namespace MEGACASTING.Vues
{
    public partial class Partenaire : Form
    {

        private void RemplirDatagrid()
        {
            SqlConnection connection = new SqlConnection("Server=10.192.86.4;Database=Commandes;User Id=sa;Password=root;");

            SqlCommand command = new SqlCommand
            {
                Connection = connection,
                CommandText = @"SELECT *
                                FROM PartenaireDiffusion"
            };

            connection.Open();
            Console.WriteLine("réussi");

            SqlDataReader query = command.ExecuteReader();

            List<PartenaireDB> PartenaireList = new List<PartenaireDB>();

            while (query.Read())
            {
                int identifier = query.GetInt32("Identifiant");
                PartenaireDB commandMessage = new PartenaireDB()
                {
                    Id = identifier,
                    Name = query.GetString("nom"),
                    Mail = query.GetString("mail"),
                    Phone = query.GetString("telephone")
                };
                PartenaireList.Add(commandMessage);
            }

            connection.Close();

            foreach (PartenaireDB partenaire in PartenaireList)
            {
                dataGridViewPartenaire.Rows.Add(partenaire.Id,
                                                partenaire.Name,
                                                partenaire.Mail,
                                                partenaire.Phone);
            }
        }

        public Partenaire()
        {
            InitializeComponent();
            RemplirDatagrid();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            string nom = textBoxName.Text;
            string tel = textBoxTel.Text;
            string mail = textBoxMail.Text;

            SqlConnection connection = new SqlConnection("Server=10.192.86.4;Database=Commandes;User Id=sa;Password=root;");

            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandText = @"INSERT INTO PartenaireDiffusion(nom, mail, telephone)
                                    VALUES( @nom, @mail, @tel);";

            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@tel", tel);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

            dataGridViewPartenaire.Rows.Clear();

            RemplirDatagrid();
        }

        private void dataGridViewPartenaire_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridViewPartenaire.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewPartenaire.Rows[selectedrowindex];

            string nom = Convert.ToString(selectedRow.Cells["Nom"].Value);
            string code = Convert.ToString(selectedRow.Cells["Mail"].Value);
            string tel = Convert.ToString(selectedRow.Cells["Telephone"].Value);
            textBoxName.Text = nom;
            textBoxMail.Text = code;
            textBoxTel.Text = tel;
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridViewPartenaire.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewPartenaire.Rows[selectedrowindex];
            string idstr = Convert.ToString(selectedRow.Cells["Identifiant"].Value);
            int id = Int32.Parse(idstr);
            SqlConnection connection = new SqlConnection("Server=10.192.86.4;Database=Commandes;User Id=sa;Password=root;");

            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandText = @"DELETE FROM PartenaireDiffusion WHERE identifiant = @id;";

            command.Parameters.AddWithValue("@id", id);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

            dataGridViewPartenaire.Rows.Clear();

            RemplirDatagrid();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            string nom = textBoxName.Text;
            string tel = textBoxTel.Text;
            string mail = textBoxMail.Text;
            int selectedrowindex = dataGridViewPartenaire.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewPartenaire.Rows[selectedrowindex];
            string idstr = Convert.ToString(selectedRow.Cells["Identifiant"].Value);
            int id = Int32.Parse(idstr);

            SqlConnection connection = new SqlConnection("Server=10.192.86.4;Database=Commandes;User Id=sa;Password=root;");

            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandText = @"UPDATE PARTENAIREDIFFUSION SET nom = @nom, mail = @mail, telephone = @tel WHERE identifiant = @id;";

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@tel", tel);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

            dataGridViewPartenaire.Rows.Clear();

            RemplirDatagrid();
        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
