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
    public partial class priloshenie : Form
    {
        public priloshenie()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = (String)textBox1.Text;
            String password = (String)textBox2.Text;
            using (SqlConnection connection = new SqlConnection(DB.ConnStr))
            {
                connection.Open();


                string SqlText = $"SELECT * FROM Users Where Login = '{login}' and password = '{password}'";
                SqlDataAdapter da = new SqlDataAdapter(SqlText, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("Такого пользователя не сущесвует");
                    return;
                }
                else
                {
                    User.login = login;
                    if (Convert.ToInt32(dt.Rows[0]["type"]) == 0)
                    {
                        User.type = "admin";
                    }
                    else
                    {
                        User.type = "user";
                    }

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }

            //if (textBox1.Text.Length > 3 && textBox1.Text.Length < 16)
            //{
            //    if (textBox2.Text.Length > 3 && textBox2.Text.Length < 16)
            //    {
            //        DialogResult = DialogResult.OK;
            //        Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Некоректная длина поля - Password");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Некоректная длина поля - Login");
            //}
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для входа в аккаунт введите логин и пароль");
        }
    }
}
