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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Формирование документов 
            //Нормальное разделение интерфесов
            //Наполнение базы данных
            //можно сделать - инспектора и начальник гаи
            //инспектра формируют документы
            //начальник гаи - создавать отечы (export office)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            priloshenie priloshenie = new priloshenie();
            DialogResult a = priloshenie.ShowDialog();
            if (a == DialogResult.OK)
            {
                Filltable();
                Text = $"GAI ({User.login}) {User.type}";
            }
            else
            {
                Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void маркиАвтоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formamarkics formamarkics = new formamarkics();
            formamarkics.ShowDialog();
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void регистрациявходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.type == "admin")
            {
                Registration registration = new Registration();
                registration.ShowDialog();
            }
            else
            {
                MessageBox.Show("#$#$#$#$#$#");
            }
        }
        private void справочникToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            O_programme o_Programme = new O_programme();
            o_Programme.ShowDialog();
        }

        void Filltable()
        {
            dataGridView1.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(DB.ConnStr))
            {
                connection.Open();


                string SqlText = $"SELECT * FROM registration,Avto,Color,region Where registration.id_avto = avto.id and registration.id_color = color.id and region.id = registration.id_region";
                SqlDataAdapter da = new SqlDataAdapter(SqlText, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string id = dt.Rows[i]["id"].ToString();
                    string fio = dt.Rows[i]["fio"].ToString();
                    string avto = dt.Rows[i]["marka"].ToString();
                    string color = dt.Rows[i]["color"].ToString();
                    string nomer = dt.Rows[i]["nomer"].ToString();
                    string region = dt.Rows[i]["name_region"].ToString();
                    string passport = dt.Rows[i]["passport"].ToString();
                    dataGridView1.Rows.Add(id, fio, avto, color, nomer, region, passport);
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void цветАвтоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color color = new Color();
            color.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddReg addReg = new AddReg();
            addReg.ShowDialog();
            Filltable();
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
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                using (SqlConnection connection = new SqlConnection(DB.ConnStr))
                {
                    connection.Open();

                    string SqlText = $"DELETE FROM REGISTRATION WHERE ID = {id}";
                    SqlCommand sqlCommand = new SqlCommand(SqlText, connection);
                    sqlCommand.ExecuteNonQuery();
                }
                Filltable();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            UpdReg updReg = new UpdReg();
            updReg.id = id;
            updReg.ShowDialog();
            Filltable();
        }

        private void регионыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Region region = new Region();
            region.ShowDialog();
        }
    }
}
