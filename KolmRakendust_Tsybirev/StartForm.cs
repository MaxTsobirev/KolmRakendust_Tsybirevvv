using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolmRakendust_Tsybirev
{
    public partial class StartForm : Form
    {
        Label label;
        Button photobtn;
        Button math;
        Button game;
        Button log;
        public StartForm()
        {
            this.Text = "Menu";
            this.Size = new Size(680, 420);
            this.BackColor = Color.Gray;

            label = new Label()
            {
                Location = new Point(100,50),
                AutoSize = false,
                
            };
            photobtn = new Button()
            {
                Text = "Pilt",
                Location= new Point(100,50),
                BackColor = Color.White,
            };
            math = new Button()
            {
                Text = "viktoriin",
                Location = new Point(200, 50),
                BackColor = Color.White,
            };
            game = new Button()
            {
                Text = "Mäng",
                Location = new Point(300,50),
                BackColor= Color.White,
            };


            photobtn.Click += Photobtn_Click;
            math.Click += Math_Click;
            game.Click += Game_Click;

            this.Controls.Add(game);
            this.Controls.Add(math);
            this.Controls.Add(photobtn);
            this.Controls.Add(label);
        }



        private void Game_Click(object? sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void Math_Click(object? sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Photobtn_Click(object? sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
