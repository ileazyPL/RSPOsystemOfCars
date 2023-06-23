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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RSPOsystemOfCars
{
    public partial class Region : Form
    {
        public Region()
        {
            InitializeComponent();
            Filltable();
        }
        void Filltable()
        {
            dataGridView1.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(DB.ConnStr))
            {
                connection.Open();


                string SqlText = $"SELECT * FROM region";
                SqlDataAdapter da = new SqlDataAdapter(SqlText, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["id"].ToString();
                    string region = dt.Rows[i]["name_region"].ToString();
                    dataGridView1.Rows.Add(region, id);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addname addname = new Addname();
            if(addname.ShowDialog() == DialogResult.OK)
            {
                string a = addname.textBox1.Text;
                if(a == "")
                {
                    MessageBox.Show("Ошибка ввода");
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(DB.ConnStr))
                    {
                        connection.Open();

                        string SqlText = $"INSERT INTO REGION(name_region) " +
                            $"VALUES ('{a}');";
                        SqlCommand sqlCommand = new SqlCommand(SqlText, connection);
                        sqlCommand.ExecuteNonQuery();
                    }
                    Filltable();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addname addname = new Addname();
            if (addname.ShowDialog() == DialogResult.OK)
            {
                string a = addname.textBox1.Text;
                if (a == "")
                {
                    MessageBox.Show("Ошибка ввода");
                }
                else
                {
                    string id = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    using (SqlConnection connection = new SqlConnection(DB.ConnStr))
                    {
                        connection.Open();

                        string SqlText = "UPDATE REGION Set name_region = @name_region WHERE ID = @ID";
                        SqlCommand sqlCommand = new SqlCommand(SqlText, connection);
                        sqlCommand.Parameters.AddWithValue("@name_region", a);
                        sqlCommand.Parameters.AddWithValue("@ID", id);
                        sqlCommand.ExecuteNonQuery();
                    }
                    Filltable();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не указаана строка для удаления");
                return;
            }
            else
            {
                string id = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                using (SqlConnection connection = new SqlConnection(DB.ConnStr))
                {
                    connection.Open();

                    string SqlText = $"DELETE FROM REGION WHERE ID = {id}";
                    SqlCommand sqlCommand = new SqlCommand(SqlText, connection);
                    sqlCommand.ExecuteNonQuery();
                }
                Filltable();
            }
        }
    }
}
