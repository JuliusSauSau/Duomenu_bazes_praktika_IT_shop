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
    public partial class Form6 : Form
    {
        private static string connString = "Server=localhost;Port=3306;Database=it_shop_repair;Uid=root;Pwd=19Nado73*";

        public Form6()
        {
            InitializeComponent();
            LoadWorkers();
            LoadPositions();
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

        private void darb_vardas_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void darb_pavarde_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void darb_email_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void darb_telefononr_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void darb_slaptazodis_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void darb_job_position_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_darb_changes_button_Click(object sender, EventArgs e)
        {
            if (darbuotoju_list.SelectedItem != null)
            {
                string selectedWorker = darbuotoju_list.SelectedItem.ToString();
                int workerId = int.Parse(selectedWorker.Split('-')[0].Trim());

                SaveWorkerChanges(workerId);
                LoadWorkers(); // Refresh worker list
            }
        }

        private void Pasalinti_darb_button_Click(object sender, EventArgs e)
        {
            if (darbuotoju_list.SelectedItem != null)
            {
                string selectedWorker = darbuotoju_list.SelectedItem.ToString();
                int workerId = int.Parse(selectedWorker.Split('-')[0].Trim());

                DeleteWorker(workerId);
                LoadWorkers(); // Refresh worker list
                ClearWorkerDetails();
            }
        }



        private void new_darb_vardas_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_darb_pavarde_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_darb_email_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_darb_telnr_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_darb_slap_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_darb_pozicija_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void new_darb_button_Click(object sender, EventArgs e)
        {
            AddNewWorker();
            LoadWorkers(); // Refresh worker list
            ClearNewWorkerDetails();
        }



        private void Get_back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void LoadWorkers()
        {
            darbuotoju_list.Items.Clear();

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
                        darb_vardas_box.Text = reader["Vardas"].ToString();
                        darb_pavarde_box.Text = reader["Pavarde"].ToString();
                        darb_email_box.Text = reader["Elektroninis_pastas"].ToString();
                        darb_telefononr_box.Text = reader["Telefono_numeris"].ToString();
                        darb_slaptazodis_box.Text = reader["Slaptazodis"].ToString();
                        darb_job_position_box.Text = reader["Pareigos_pavadinimas"].ToString();
                    }
                }
            }
        }

        private void SaveWorkerChanges(int workerId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = @"
                    UPDATE Darbuotojai
                    SET 
                        Vardas = @Vardas, 
                        Pavarde = @Pavarde, 
                        Elektroninis_pastas = @Email, 
                        Telefono_numeris = @Telefonas, 
                        Slaptazodis = @Slaptazodis,
                        PareigosID = (SELECT PareigosID FROM Pareigos WHERE Pareigos_pavadinimas = @PareigosPavadinimas)
                    WHERE DarbuotojoID = @WorkerId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@WorkerId", workerId);
                cmd.Parameters.AddWithValue("@Vardas", darb_vardas_box.Text);
                cmd.Parameters.AddWithValue("@Pavarde", darb_pavarde_box.Text);
                cmd.Parameters.AddWithValue("@Email", darb_email_box.Text);
                cmd.Parameters.AddWithValue("@Telefonas", darb_telefononr_box.Text);
                cmd.Parameters.AddWithValue("@Slaptazodis", darb_slaptazodis_box.Text);
                cmd.Parameters.AddWithValue("@PareigosPavadinimas", darb_job_position_box.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void DeleteWorker(int workerId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "DELETE FROM Darbuotojai WHERE DarbuotojoID = @WorkerId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@WorkerId", workerId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void AddNewWorker()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = @"
                    INSERT INTO Darbuotojai (Vardas, Pavarde, Elektroninis_pastas, Telefono_numeris, Slaptazodis, PareigosID) 
                    VALUES (@Vardas, @Pavarde, @Email, @Telefonas, @Slaptazodis, 
                    (SELECT PareigosID FROM Pareigos WHERE Pareigos_pavadinimas = @PareigosPavadinimas))";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Vardas", new_darb_vardas_box.Text);
                cmd.Parameters.AddWithValue("@Pavarde", new_darb_pavarde_box.Text);
                cmd.Parameters.AddWithValue("@Email", new_darb_email_box.Text);
                cmd.Parameters.AddWithValue("@Telefonas", new_darb_telnr_box.Text);
                cmd.Parameters.AddWithValue("@Slaptazodis", new_darb_slap_box.Text);
                cmd.Parameters.AddWithValue("@PareigosPavadinimas", new_darb_pozicija_combo_box.SelectedItem.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void LoadPositions()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT Pareigos_pavadinimas FROM Pareigos";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        new_darb_pozicija_combo_box.Items.Add(reader["Pareigos_pavadinimas"].ToString());
                    }
                }
            }
        }

        private void ClearWorkerDetails()
        {
            darb_vardas_box.Clear();
            darb_pavarde_box.Clear();
            darb_email_box.Clear();
            darb_telefononr_box.Clear();
            darb_slaptazodis_box.Clear();
            darb_job_position_box.Clear();
        }

        private void ClearNewWorkerDetails()
        {
            new_darb_vardas_box.Clear();
            new_darb_pavarde_box.Clear();
            new_darb_email_box.Clear();
            new_darb_telnr_box.Clear();
            new_darb_slap_box.Clear();
            new_darb_pozicija_combo_box.SelectedIndex = -1;
        }
    }
}
