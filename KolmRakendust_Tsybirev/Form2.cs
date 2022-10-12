using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolmRakendust_Tsybirev
{
    public partial class Form2 : Form
    {

        TableLayoutPanel table;
        string text;
        Label label;
        Label label2;
        Label l;
        Button start;
        NumericUpDown numb;

        string[] tehed = new string[4] { "+", "-", "*", "/" };
        public Form2()
        {
            Text = "Viktoriin";
            Size = new Size(500, 400);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnStyles = { new ColumnStyle(SizeType.Percent, 25), new ColumnStyle(SizeType.Percent, 25), new ColumnStyle(SizeType.Percent, 25), new ColumnStyle(SizeType.Percent, 25) },
                RowStyles = { new RowStyle(SizeType.Percent, 25), new RowStyle(SizeType.Percent, 25), new RowStyle(SizeType.Percent, 25), new RowStyle(SizeType.Percent, 25) },
            };

            Button button = new Button { Text = "viktoriin", Location = new Point(200, 50), BackColor = Color.Blue };
            Label label = new Label { Text = "Aega jäänud", AutoSize = true, };
            label.Location = new Point(15, 15);
            Label label2 = new Label { BorderStyle = BorderStyle.FixedSingle, AutoSize = false, };
            label2.Location = new Point(90, 12);
            Button start = new Button { Text = "Alusta", Location = new Point(200, 12), };
            start.Click += Start_Click;


            string[] names = { "num", "sign", "num2", "rovno", "res" };
            string[] text = { "?", "+", "-", "*", "/", "=" };
            for (int j = 1; j < 5; j++)
            {
                for (int i = 1; i < 6; i++)
                {
                    if (i == 5)
                    {
                        numb = new NumericUpDown
                        {
                            Width = 100,
                            Name = "sum" + j,
                        };
                        table.Controls.Add(numb);
                        table.SetCellPosition(numb, new TableLayoutPanelCellPosition(i - 1, j));
                    }
                    else
                    {
                        var lblText = text[0];
                        if (names[i - 1] == "sign") lblText = text[j];
                        else if (names[i - 1] == "rovno") lblText = text.Last();
                        l = new Label
                        {
                            Text = lblText,
                            AutoSize = false,
                            Size = new Size(60, 50),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Name = names[i - 1] + j,
                        };
                        table.Controls.Add(l);
                        table.SetCellPosition(l, new TableLayoutPanelCellPosition(i - 1, j));
                    }
                }
            }


            this.Controls.Add(start);
            this.Controls.Add(label);
            this.Controls.Add(label2);
            this.Controls.Add(table);
        }
        public void Start_Click(object? sender, EventArgs e)
        {
            Label l;
            Button b = (sender as Button);
            b.Enabled = false;
            Random rnd = new Random();
            for (int j = 1; j < 5; j++)
            {
                for (int i = 0; i < 3; i += 2)
                {
                    if (j == 2)
                    {
                        int a = 1, c = 2;
                        while (a < c)
                        {
                            a = rnd.Next(1, 12);
                            c = rnd.Next(1, 12);
                        }
                        l = (Label)table.GetControlFromPosition(i, j);
                        l.Text = a.ToString();

                        l = (Label)table.GetControlFromPosition(i + 2, j);
                        l.Text = c.ToString();
                        break;
                    }
                    else if (j == 4)
                    {
                        int a, c;
                        a = rnd.Next(1, 12);
                        c = rnd.Next(1, 12);

                        l = (Label)table.GetControlFromPosition(i, j);
                        l.Text = (a * c).ToString();

                        l = (Label)table.GetControlFromPosition(i + 2, j);
                        l.Text = c.ToString();
                        break;
                    }
                    else
                    {
                        l = (Label)table.GetControlFromPosition(i, j);
                        l.Text = rnd.Next(0, 101).ToString();
                    }
                }
            }

            TimerStart();
        }

        private async void TimerStart()
        {
            int time = 30;
            while (time != 0)
            {
                l.Text = time.ToString() + " seconds";
                time -= 1;
                await Task.Delay(1000);
            }
            l.Text = "";
            this.Enabled = false;

        }


    }
}