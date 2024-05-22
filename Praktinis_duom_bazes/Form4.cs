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
    public partial class Form4 : Form
    {
        private string adminEmail;
        private static string connString = "Server=localhost;Port=3306;Database=it_shop_repair;Uid=root;Pwd=19Nado73*";

        public Form4(string email)
        {
            InitializeComponent();
            adminEmail = email;
            LoadAdminData();
            LoadPositions();
            LoadWorkers();
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



        private void pareigu_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pareigu_list.SelectedItem != null)
            {
                string selectedPosition = pareigu_list.SelectedItem.ToString();
                string[] parts = selectedPosition.Split('-');
                int positionId = int.Parse(parts[0].Trim());
                string positionName = parts[1].Trim();

                pareigosid_box.Text = positionId.ToString();
                pareigos_pav_box.Text = positionName;
            }
        }

        private void pareigos_pav_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void pareigosid_box_TextChanged(object sender, EventArgs e)
        {

        }



        private void darbuotoju_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (darbuotoju_list.SelectedItem != null)
            {
                string selectedWorker = darbuotoju_list.SelectedItem.ToString();
                int workerId = int.Parse(selectedWorker.Split('-')[0].Trim());

                LoadWorkerDetails(workerId);
            }
        }

        private void darb_vardas_TextChanged(object sender, EventArgs e)
        {

        }

        private void darb_pavarde_TextChanged(object sender, EventArgs e)
        {

        }

        private void darb_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void darb_telnr_TextChanged(object sender, EventArgs e)
        {

        }

        private void darb_slap_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void darb_pareiga_box_TextChanged(object sender, EventArgs e)
        {

        }



        private void LoadAdminData()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT Vardas, Pavarde, Elektroninis_pastas, Telefono_numeris, Slaptazodis FROM Darbuotojai WHERE Elektroninis_pastas = @Email";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", adminEmail);

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
                    }
                }
            }
        }

        private void LoadPositions()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT PareigosID, Pareigos_pavadinimas FROM Pareigos";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string positionInfo = reader["PareigosID"].ToString() + " - " + reader["Pareigos_pavadinimas"].ToString();
                        pareigu_list.Items.Add(positionInfo);
                    }
                }
            }
        }

        private void LoadWorkers()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT DarbuotojoID, Vardas, Pavarde FROM Darbuotojai";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string workerInfo = reader["DarbuotojoID"].ToString() + " - " + reader["Vardas"].ToString() + " " + reader["Pavarde"].ToString();
                        darbuotoju_list.Items.Add(workerInfo);
                    }
                }
            }
        }

        private void LoadWorkerDetails(int workerId)
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
                        p.Pareigos_pavadinimas 
                    FROM 
                        Darbuotojai d
                        JOIN Pareigos p ON d.PareigosID = p.PareigosID
                    WHERE 
                        d.DarbuotojoID = @WorkerId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@WorkerId", workerId);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        darb_vardas.Text = reader["Vardas"].ToString();
                        darb_pavarde.Text = reader["Pavarde"].ToString();
                        darb_email.Text = reader["Elektroninis_pastas"].ToString();
                        darb_telnr.Text = reader["Telefono_numeris"].ToString();
                        darb_slap_box.Text = reader["Slaptazodis"].ToString();
                        darb_pareiga_box.Text = reader["Pareigos_pavadinimas"].ToString();
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



        private void pareiga_menu_button_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void worker_menu_button_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }
    }
}
