using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktinis_duom_bazes
{
    public partial class Form3 : Form
    {

        private string workerEmail;
        private static string connString = "Server=localhost;Port=3306;Database=it_shop_repair;Uid=root;Pwd=19Nado73*";

        public Form3(string email)
        {
            InitializeComponent();
            workerEmail = email;
            LoadWorkerData();
            LoadProducts();
            LoadClientNames();
            LoadProductNames();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void LoadWorkerData()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = @"
            SELECT 
                d.Vardas, 
                d.Pavarde, 
                d.Elektroninis_pastas, 
                d.Telefono_numeris, 
                d.Slaptazodis, 
                p.Pareigos_pavadinimas AS PareigosPavadinimas
            FROM 
                Darbuotojai d
                JOIN Pareigos p ON d.PareigosID = p.PareigosID
            WHERE 
                d.Elektroninis_pastas = @Email";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", workerEmail);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        vardas_box.Text = reader["Vardas"].ToString();
                        pavarde_box.Text = reader["Pavarde"].ToString();
                        email_box.Text = reader["Elektroninis_pastas"].ToString();
                        telefononr_box.Text = reader["Telefono_numeris"].ToString();
                        slaptazodis_box.Text = reader["Slaptazodis"].ToString();
                        job_position_box.Text = reader["PareigosPavadinimas"].ToString();
                    }
                }
            }
        }

        private void LoadProducts()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT ProduktoID, Pavadinimas FROM Produktas";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string productInfo = reader["ProduktoID"].ToString() + " - " + reader["Pavadinimas"].ToString();
                        produkto_list.Items.Add(productInfo);
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

        private void job_position_box_TextChanged(object sender, EventArgs e)
        {

        }



        private void produkto_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (produkto_list.SelectedItem != null)
            {
                string selectedProduct = produkto_list.SelectedItem.ToString();
                int productId = int.Parse(selectedProduct.Split(' ')[0]);

                LoadProductDetails(productId);
            }
        }

        private void LoadProductDetails(int productId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT Pavadinimas, Kaina, Kiekis FROM Produktas WHERE ProduktoID = @ProductId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductId", productId);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        produkto_pavadinimas_box.Text = reader["Pavadinimas"].ToString();
                        produkto_kaina_box.Text = reader["Kaina"].ToString();
                        produkto_kiekis_box.Text = reader["Kiekis"].ToString();
                    }
                }
            }
        }
        

        private void keikis_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_uzsakyma_button_Click(object sender, EventArgs e)
        {
            if (vardas_pavarde_pasirinkimas_box.SelectedIndex == -1 || selected_prod_box.SelectedIndex == -1 || string.IsNullOrEmpty(kiekis_box.Text))
            {
                MessageBox.Show("Please select a client, product and enter quantity.");
                return;
            }

            string clientName = vardas_pavarde_pasirinkimas_box.Text.Split(' ')[0];
            string clientLastName = vardas_pavarde_pasirinkimas_box.Text.Split(' ')[1];
            var selectedProduct = (KeyValuePair<int, string>)selected_prod_box.SelectedItem;
            int quantity;

            if (!int.TryParse(kiekis_box.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            int clientId = GetClientId(clientName, clientLastName);
            int productId = selectedProduct.Key;

            if (clientId > 0 && productId > 0)
            {
                CreateOrder(clientId, productId, quantity);
                MessageBox.Show("Order created successfully!");
            }
            else
            {
                MessageBox.Show("Invalid client or product. Please check your data and try again.");
            }
        }

        private int GetClientId(string name, string lastName)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT KlientoID FROM Klientas WHERE Vardas = @Name AND Pavarde = @LastName";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@LastName", lastName);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        private void CreateOrder(int clientId, int productId, int quantity)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Insert into Uzsakymas
                    string query = "INSERT INTO Uzsakymas (KlientoID, DarbuotojoID, Uzsakymo_data, Busena) VALUES (@ClientId, @WorkerId, @Date, @Status)";
                    MySqlCommand cmd = new MySqlCommand(query, conn, transaction);
                    cmd.Parameters.AddWithValue("@ClientId", clientId);
                    cmd.Parameters.AddWithValue("@WorkerId", GetWorkerId());
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Status", "Vykdomas");

                    cmd.ExecuteNonQuery();
                    int orderId = (int)cmd.LastInsertedId;

                    // Insert into UzsakymasInfo
                    string orderInfoQuery = "INSERT INTO UzsakymasInfo (UzsakymoID, ProduktoID, Kiekis, Kaina) VALUES (@OrderId, @ProductId, @Quantity, @Price)";
                    MySqlCommand orderInfoCmd = new MySqlCommand(orderInfoQuery, conn, transaction);
                    orderInfoCmd.Parameters.AddWithValue("@OrderId", orderId);
                    orderInfoCmd.Parameters.AddWithValue("@ProductId", productId);
                    orderInfoCmd.Parameters.AddWithValue("@Quantity", quantity);
                    orderInfoCmd.Parameters.AddWithValue("@Price", GetProductPrice(productId));

                    orderInfoCmd.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error creating order: " + ex.Message);
                }
            }
        }

        private int GetWorkerId()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT DarbuotojoID FROM Darbuotojai WHERE Elektroninis_pastas = @Email";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", workerEmail);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        private decimal GetProductPrice(int productId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT Kaina FROM Produktas WHERE ProduktoID = @ProductId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductId", productId);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToDecimal(result) : 0;
            }
        }

        private void cacel_uzsakyma_button_Click(object sender, EventArgs e)
        {
            vardas_pavarde_pasirinkimas_box.SelectedIndex = -1;
            selected_prod_box.SelectedIndex = -1;
            kiekis_box.Clear();
        }

        private void atsijungimas_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void produkto_pavadinimas_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void produkto_kaina_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void produkto_kiekis_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void vardas_pavarde_pasirinkimas_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadClientNames()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT Vardas, Pavarde FROM Klientas";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string fullName = reader["Vardas"].ToString() + " " + reader["Pavarde"].ToString();
                        vardas_pavarde_pasirinkimas_box.Items.Add(fullName);
                    }
                }
            }

            // Set AutoComplete properties
            vardas_pavarde_pasirinkimas_box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            vardas_pavarde_pasirinkimas_box.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadProductNames()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT ProduktoID, Pavadinimas FROM Produktas";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int productId = reader.GetInt32("ProduktoID");
                        string productName = reader.GetString("Pavadinimas");
                        selected_prod_box.Items.Add(new KeyValuePair<int, string>(productId, productName));
                    }
                }
            }

            // Set display and value members for the ComboBox
            selected_prod_box.DisplayMember = "Value";
            selected_prod_box.ValueMember = "Key";
        }

        private void selected_prod_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
