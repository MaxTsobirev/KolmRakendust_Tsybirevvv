using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolmRakendust_Tsybirev
{
   public partial class Login : Form
   {
        TextBox login = new TextBox { Location = new Point(200, 105),Height = 90, Width = 150 };
        TextBox password = new TextBox { Location = new Point(200, 165), Height = 90, Width = 150, UseSystemPasswordChar = true };

        public Login()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "Login";
            this.Size = new Size(500, 400);
            this.BackColor = Color.Gray;
            //asd

            Label label = new Label { Location = new Point(200, 30), Height = 50, Width = 170, Text = "Login vorm", };

            Label login2 = new Label { Location = new Point(50, 110), Height = 50, Width = 150, Text = "Login:" };

            Label pass = new Label { Location = new Point(50, 170), Height = 50, Width = 150, Text = "Password:" };

            Button loginbutton = new Button { Text = "Login", Location = new Point(250, 250), Width = 150, Height = 35, };

            Button regbutton = new Button { Text = "Register", Location = new Point(80, 250), Width = 150, Height = 35, };

            this.Controls.Add(label);
            this.Controls.Add(login);
            this.Controls.Add(pass);
            this.Controls.Add(login2);
            this.Controls.Add(password);
            this.Controls.Add(loginbutton);
            this.Controls.Add(regbutton);

            loginbutton.Click += Loginbutton_Click;
            regbutton.Click += Regbutton_Click;
        }

        private void Regbutton_Click(object? sender, EventArgs e)
        {
            Reg reg = new Reg();
            reg.ShowDialog();
        }
        public int I;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane.TTHK\source\repos\KolmRakendust_Tsybirev\KolmRakendust_Tsybirev\Databas.mdf";

        private async void Loginbutton_Click(object? sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            I = 0;
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tab where login = '" + login.Text + "'and parool= '" + password.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            I = Convert.ToInt32(dt.Rows.Count.ToString());
            if (I == 0)
            {
                MessageBox.Show("Seda kasutajanime või parooli pole olemas");
            }
            else
            {
                this.Hide();
                StartForm mp = new StartForm();
                mp.Show();
            }
            connection.Close();


        }
        
     }
}
