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

namespace RSPOsystemOfCars
{
    public partial class Color : Form
    {
        public Color()
        {
            InitializeComponent();
            Filltable();
        }
        void Filltable()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(DB.ConnStr))
            {
                connection.Open();

                string sqlText = "SELECT * FROM color";
                SqlDataAdapter da = new SqlDataAdapter(sqlText, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["id"].ToString();
                    string color = dt.Rows[i]["color"].ToString();
                    dataGridView1.Rows.Add(color, id);
                }

                // Bind the DataGridView control again
                dataGridView1.DataSource = dt;
            }
        }

        private void Color_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rSPOusersDataSet.Color". При необходимости она может быть перемещена или удалена.
            this.colorTableAdapter.Fill(this.rSPOusersDataSet.Color);

        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usersBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                    using (SqlConnection connection = new SqlConnection(DB.ConnStr))
                    {
                        connection.Open();

                        string SqlText = $"INSERT INTO COLOR(color) " +
                            $"VALUES ('{a}');";
                        SqlCommand sqlCommand = new SqlCommand(SqlText, connection);
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
                MessageBox.Show("Не указана строка для удаления");
                return;
            }
            else
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                using (SqlConnection connection = new SqlConnection(DB.ConnStr))
                {
                    connection.Open();

                    string SqlText = $"DELETE FROM COLOR WHERE color = '{id}'";
                    SqlCommand sqlCommand = new SqlCommand(SqlText, connection);
                    sqlCommand.ExecuteNonQuery();
                }
                Filltable();
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
                    string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    using (SqlConnection connection = new SqlConnection(DB.ConnStr))
                    {
                        connection.Open();

                        string SqlText = "UPDATE COLOR Set color = @color WHERE color = @ID";
                        SqlCommand sqlCommand = new SqlCommand(SqlText, connection);
                        sqlCommand.Parameters.AddWithValue("@color", a);
                        sqlCommand.Parameters.AddWithValue("@ID", id);
                        sqlCommand.ExecuteNonQuery();
                    }
                    Filltable();
                }
            }
        }
    }
}
