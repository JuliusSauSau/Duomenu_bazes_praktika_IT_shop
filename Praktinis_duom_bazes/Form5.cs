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
    public partial class Form5 : Form
    {
        private static string connString = "Server=localhost;Port=3306;Database=it_shop_repair;Uid=root;Pwd=19Nado73*";

        public Form5()
        {
            InitializeComponent();
            LoadPositions();
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

        private void delete_pareiga_box_Click(object sender, EventArgs e)
        {
            if (pareigu_list.SelectedItem != null)
            {
                string selectedPosition = pareigu_list.SelectedItem.ToString();
                int positionId = int.Parse(selectedPosition.Split('-')[0].Trim());

                DeletePosition(positionId);
                LoadPositions();
                ClearPositionDetails();
            }
        }



        private void new_pareigos_pav_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void new_pareiga_botton_Click(object sender, EventArgs e)
        {
            string newPositionName = new_pareigos_pav_box.Text;
            if (!string.IsNullOrEmpty(newPositionName))
            {
                AddNewPosition(newPositionName);
                LoadPositions();
                new_pareigos_pav_box.Clear();
            }
        }



        private void Get_back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void LoadPositions()
        {
            pareigu_list.Items.Clear();

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

        private void DeletePosition(int positionId)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "DELETE FROM Pareigos WHERE PareigosID = @PositionId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PositionId", positionId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void AddNewPosition(string positionName)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "INSERT INTO Pareigos (Pareigos_pavadinimas) VALUES (@PositionName)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PositionName", positionName);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void ClearPositionDetails()
        {
            pareigosid_box.Clear();
            pareigos_pav_box.Clear();
        }
    }
}
