using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Praktinis_duom_bazes
{
    public partial class Form2 : Form
    {

        private string clientEmail;
        private static string connString = "Server=localhost;Port=3306;Database=it_shop_repair;Uid=root;Pwd=19Nado73*";

        public Form2(string email)
        {
            InitializeComponent();
            clientEmail = email;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadClientData();
            LoadClientOrders();
        }

        private void LoadClientData()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT Vardas, Pavarde, Elektroninis_pastas, Adresas, Telefono_numeris FROM Klientas WHERE Elektroninis_pastas = @Email";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", clientEmail);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        vardas_box.Text = reader["Vardas"].ToString();
                        pavarde_box.Text = reader["Pavarde"].ToString();
                        email_box.Text = reader["Elektroninis_pastas"].ToString();
                        adresas_box.Text = reader["Adresas"].ToString();
                        telefononr_box.Text = reader["Telefono_numeris"].ToString();
                    }
                }
            }
        }

        private void LoadClientOrders()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = @"
                    SELECT u.UzsakymoID 
                    FROM Uzsakymas u
                    JOIN Klientas k ON u.KlientoID = k.KlientoID
                    WHERE k.Elektroninis_pastas = @Email";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", clientEmail);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        uzsakymu_list.Items.Add(reader["UzsakymoID"].ToString());
                    }
                }
            }
        }

        private void vardas_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void pavarde_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void adresas_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefononr_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void slaptazodis_box_TextChanged(object sender, EventArgs e)
        {

        }


        private void uzsakymu_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uzsakymu_list.SelectedItem != null)
            {
                int selectedOrderId = int.Parse(uzsakymu_list.SelectedItem.ToString());
                LoadOrderDetails(selectedOrderId);
            }
        }

        private void LoadOrderDetails(int orderId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = @"
                    SELECT u.UzsakymoID, u.KlientoID, u.DarbuotojoID, u.Uzsakymo_data, u.Busena, ui.ProduktoID, ui.Kiekis, ui.Kaina
                    FROM Uzsakymas u
                    JOIN UzsakymasInfo ui ON u.UzsakymoID = ui.UzsakymoID
                    WHERE u.UzsakymoID = @OrderId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderId", orderId);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        uzsakymoData_box.Text = reader["Uzsakymo_data"].ToString();
                        busena_box.Text = reader["Busena"].ToString();
                        produktoID_box.Text = reader["ProduktoID"].ToString();
                        kiekis_box.Text = reader["Kiekis"].ToString();
                        kaina_box.Text = reader["Kaina"].ToString();
                    }
                }
            }
        }

        private void atsijungimas_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void uzsakymoData_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void busena_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void produktoID_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
