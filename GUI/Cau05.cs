using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DO_AN
{
    public partial class Cau05 : Form
    {
        public Cau05()
        {
            InitializeComponent();
        }

        private void Cau05_Load(object sender, EventArgs e)
        {
            LoadAreas();
        }

        private void LoadAreas()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-F61L4C7\SQLEXPRESS;Initial Catalog=QLBH;User ID=sa;Password=sa"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT name FROM areas", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cbArea.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtNew_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-F61L4C7\SQLEXPRESS;Initial Catalog=QLBH;User ID=sa;Password=sa"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO customer (id, name, id_area) VALUES (@Id, @Name, (SELECT id FROM areas WHERE name = @Area))", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", txtId.Text);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Area", cbArea.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Inserted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-F61L4C7\SQLEXPRESS;Initial Catalog=QLBH;User ID=sa;Password=sa"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM customer WHERE id = @Id AND name = @Name", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", txtId.Text);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Deleted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-F61L4C7\SQLEXPRESS;Initial Catalog=QLBH;User ID=sa;Password=sa"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE customer SET name = @NewName, id_area = (SELECT id FROM areas WHERE name = @NewArea) WHERE id = @Id AND name = @OldName", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", txtId.Text);
                        cmd.Parameters.AddWithValue("@OldName", txtName.Text);
                        cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                        cmd.Parameters.AddWithValue("@NewArea", cbArea.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            dgvCustomer.Rows.Clear();
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-F61L4C7\SQLEXPRESS;Initial Catalog=QLBH;User ID=sa;Password=sa"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT c.id, c.name, a.name FROM customer c JOIN areas a ON c.id_area = a.id", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    dgvCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}