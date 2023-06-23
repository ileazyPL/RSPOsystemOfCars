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
    public partial class AddReg : Form
    {
        public AddReg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddReg_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rSPOusersDataSet2.region". При необходимости она может быть перемещена или удалена.
            this.regionTableAdapter1.Fill(this.rSPOusersDataSet2.region);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rSPOusersDataSet1.region". При необходимости она может быть перемещена или удалена.
            this.regionTableAdapter.Fill(this.rSPOusersDataSet1.region);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rSPOusersDataSet.Color". При необходимости она может быть перемещена или удалена.
            this.colorTableAdapter.Fill(this.rSPOusersDataSet.Color);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rSPOusersDataSet.Avto". При необходимости она может быть перемещена или удалена.
            this.avtoTableAdapter.Fill(this.rSPOusersDataSet.Avto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(DB.ConnStr))
            {
                connection.Open();

                int id_avto = (int)comboBox1.SelectedValue;
                int id_color = (int)comboBox2.SelectedValue;
                int id_region = (int)comboBox3.SelectedValue;
                string SqlText = $"INSERT INTO REGISTRATION(fio, id_avto, id_color, nomer, id_region, passport) " +
                    $"VALUES ('{textBox1.Text}', '{id_avto}', '{id_color}','{textBox2.Text}','{id_region}','{textBox3.Text}');";
                SqlCommand sqlCommand = new SqlCommand(SqlText, connection);
                sqlCommand.ExecuteNonQuery();
            }
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.regionTableAdapter.FillBy(this.rSPOusersDataSet1.region);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
