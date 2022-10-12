using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolmRakendust_Tsybirev
{
    public partial class Reg : Form
    {
        TextBox login, pass, mail, vanus, sugu;
        public Reg()
        {
            this.Text = "Menu App";
            this.Size = new Size(600, 500);
            this.BackColor = Color.Gray;
            Label text = new Label { Text = "Registreerimine", Location = new Point(200, 30), AutoSize = true, };
             login = new TextBox { Location = new Point(200, 90), Height = 50, Width = 150, };
            Label logintxt = new Label { Text = "Uus Login:", Location = new Point(20, 90), AutoSize = true, };
             pass = new TextBox { Location = new Point(200, 130), Height = 50, Width = 150, };
            Label passtxt = new Label { Text = "Uus parool:", Location = new Point(20, 130), AutoSize = true, };
             mail = new TextBox { Location = new Point(200, 170), Height = 50, Width = 150, };
            Label mailtxt = new Label { Text = "Email:", Location = new Point(20, 170), AutoSize = true, };
             vanus = new TextBox { Location = new Point(200, 200), Height = 50, Width = 150, };
            Label vanusltxt = new Label { Text = "Vanus:", Location = new Point(20, 200), AutoSize = true, };
             sugu = new TextBox { Location = new Point(200, 230), Height = 50, Width = 150, };
            Label sugutxt = new Label { Text = "Sugu:", Location = new Point(20, 230), AutoSize = true, };



            Button save = new Button { Text = "Salvesta", Location = new Point(200, 350),Width = 150, Height = 35, };

            save.Click += Save_Click;


            this.Controls.Add(text);
            this.Controls.Add(login);
            this.Controls.Add(pass);
            this.Controls.Add(logintxt);
            this.Controls.Add(passtxt);
            this.Controls.Add(mail);
            this.Controls.Add(mailtxt);
            this.Controls.Add(vanus);
            this.Controls.Add(vanusltxt);
            this.Controls.Add(sugu);
            this.Controls.Add(sugutxt);
            this.Controls.Add(save);
        }
        public int  I;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane.TTHK\source\repos\KolmRakendust_Tsybirev\KolmRakendust_Tsybirev\Databas.mdf";
        private void Save_Click(object? sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            I = 0;
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT people(login,pass,mail,vanus,sugu) VALUES ('" + login.Text + "','" + pass.Text + "', '" + mail.Text + "', '" + vanus.Text + "','" + sugu.Text + "');";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            I = Convert.ToInt32(dt.Rows.Count.ToString());
            this.Hide();
            Login mp = new Login();
            mp.Show();

        }

    }
 
    
}
