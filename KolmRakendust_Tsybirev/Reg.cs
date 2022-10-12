using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolmRakendust_Tsybirev
{
    public partial class Reg : Form
    {
        public Reg()
        {
            this.Text = "Menu App";
            this.Size = new Size(600, 500);
            this.BackColor = Color.Gray;
            Label text = new Label { Text = "Registreerimine", Location = new Point(200, 30), AutoSize = true, };
            TextBox login = new TextBox { Location = new Point(200, 90), Height = 50, Width = 150, };
            Label logintxt = new Label { Text = "Uus Login:", Location = new Point(20, 90), AutoSize = true, };
            TextBox pass = new TextBox { Location = new Point(200, 130), Height = 50, Width = 150, };
            Label passtxt = new Label { Text = "Uus parool:", Location = new Point(20, 130), AutoSize = true, };
            TextBox mail = new TextBox { Location = new Point(200, 170), Height = 50, Width = 150, };
            Label mailtxt = new Label { Text = "Email:", Location = new Point(20, 170), AutoSize = true, };
            TextBox vanus = new TextBox { Location = new Point(200, 200), Height = 50, Width = 150, };
            Label vanusltxt = new Label { Text = "Vanus:", Location = new Point(20, 200), AutoSize = true, };
            TextBox sugu = new TextBox { Location = new Point(200, 230), Height = 50, Width = 150, };
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
        private void Save_Click(object? sender, EventArgs e)
        {

        }
 
    }
}
