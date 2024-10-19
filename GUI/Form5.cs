﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DO_AN
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
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
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO KhachHang (Id, Name) VALUES (@Id, @Name)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", int.Parse(tbId.Text));
                        cmd.Parameters.AddWithValue("@Name", tbName.Text);
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
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM KhachHang WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", int.Parse(tbId.Text));
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
                    using (SqlCommand cmd = new SqlCommand("UPDATE KhachHang SET Name = @NewName WHERE Id = @Id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", int.Parse(tbId.Text));
                        cmd.Parameters.AddWithValue("@NewName", tbName.Text);
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
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-F61L4C7\SQLEXPRESS;Initial Catalog=QLBH;User ID=sa;Password=sa"))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dgvKhachHang.Rows.Clear();
                                while (reader.Read())
                                {
                                    dgvKhachHang.Rows.Add(reader.GetInt32(0), reader.GetString(1));
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