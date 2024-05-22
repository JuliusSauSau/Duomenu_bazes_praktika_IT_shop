using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktinis_duom_bazes
{
    public partial class Form1 : Form
    {
        private static string connString = "Server=localhost;Port=3306;Database=it_shop_repair;Uid=root;Pwd=19Nado73*";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void Pri_ema_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pri_slap_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prisijungti_button_Click(object sender, EventArgs e)
        {
            string email = Pri_ema.Text;
            string password = Pri_slap.Text;

            if (ValidateLogin(email, password, out string role))
            {
                if (role == "Client")
                {
                    // Open Form2 for clients
                    Form2 form2 = new Form2(email);
                    form2.Show();
                    this.Hide();
                }
                else if (role == "Worker")
                {
                    // Open Form3 for workers
                    Form3 form3 = new Form3(email);
                    form3.Show();
                    this.Hide();
                }
                else if (role == "Admin")
                {
                    // Open Form4 for admins
                    Form4 form4 = new Form4(email);
                    form4.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Login failed. Please check your email and password.");
            }
        }



        private void Reg_var_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reg_pav_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reg_ema_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reg_adr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reg_telnr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reg_slap_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registruotis_button_Click(object sender, EventArgs e)
        {
            string name = Reg_var.Text;
            string lastName = Reg_pav.Text;
            string email = Reg_ema.Text;
            string address = Reg_adr.Text;
            string phone = Reg_telnr.Text;
            string password = Reg_slap.Text;

            if (RegisterClient(name, lastName, email, address, phone, password))
            {
                MessageBox.Show("Registration successful! You can now log in.");
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }



        private bool ValidateLogin(string email, string password, out string role)
        {
            role = null;

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                // Check for Client
                string query = "SELECT * FROM Klientas WHERE Elektroninis_pastas = @Email AND Slaptazodis = @Password";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    role = "Client";
                    return true;
                }
                reader.Close();

                // Check for Worker/Admin
                query = "SELECT * FROM Darbuotojai WHERE Elektroninis_pastas = @Email AND Slaptazodis = @Password";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    int pareigosId = reader.GetInt32("PareigosID");

                    // Assuming PareigosID 1 is for Admins
                    if (pareigosId == 1)
                    {
                        role = "Admin";
                    }
                    else
                    {
                        role = "Worker";
                    }
                    return true;
                }
            }

            return false;
        }

        private bool RegisterClient(string name, string lastName, string email, string address, string phone, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "INSERT INTO Klientas (Vardas, Pavarde, Elektroninis_pastas, Adresas, Telefono_numeris, Slaptazodis) " +
                               "VALUES (@Name, @LastName, @Email, @Address, @Phone, @Password)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
