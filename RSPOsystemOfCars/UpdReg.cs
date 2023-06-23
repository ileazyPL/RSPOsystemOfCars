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
    public partial class UpdReg : Form
    {
        public string id = "";
        public UpdReg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(DB.ConnStr))
            {
                connection.Open();

                string fio = textBox1.Text;
                int id_avto = (int)comboBox1.SelectedValue;
                int id_color = (int)comboBox2.SelectedValue;
                string nomer = textBox2.Text;
                int id_region = (int)comboBox3.SelectedValue;
                string passport = textBox3.Text;
                string SqlText = $"UPDATE REGISTRATION Set fio = @fio, id_avto = @id_avto, id_color = @id_color, nomer = @nomer, id_region = @id_region, passport = @passport WHERE ID = @ID";
                SqlCommand command = new SqlCommand(SqlText, connection);
                command.Parameters.AddWithValue("@fio", textBox1.Text);
                command.Parameters.AddWithValue("@id_avto", comboBox1.SelectedValue);
                command.Parameters.AddWithValue("@id_color", comboBox2.SelectedValue);
                command.Parameters.AddWithValue("@nomer", textBox2.Text);
                command.Parameters.AddWithValue("@id_region", comboBox3.SelectedValue);
                command.Parameters.AddWithValue("@passport", textBox3.Text);
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
            }
            Close();
        }

        private void UpdReg_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rSPOusersDataSet3.region". При необходимости она может быть перемещена или удалена.
            this.regionTableAdapter.Fill(this.rSPOusersDataSet3.region);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rSPOusersDataSet.Color". При необходимости она может быть перемещена или удалена.
            this.colorTableAdapter.Fill(this.rSPOusersDataSet.Color);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rSPOusersDataSet.Avto". При необходимости она может быть перемещена или удалена.
            this.avtoTableAdapter.Fill(this.rSPOusersDataSet.Avto);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
