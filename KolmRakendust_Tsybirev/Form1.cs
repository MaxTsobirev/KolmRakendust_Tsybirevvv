using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace KolmRakendust_Tsybirev
{
    public partial class Form1 : Form
    {
        
        TableLayoutPanel table;
        PictureBox pict;
        OpenFileDialog openFile = new OpenFileDialog
        {
            Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*",
            Title = "Select a Picture",
        };
        ColorDialog colorDialog = new ColorDialog{};
        //CheckBox box;

        public Form1()
        {
            this.Text = "Pilt";
            table = new TableLayoutPanel
            {

                Dock = DockStyle.Fill,
                ColumnStyles = { new ColumnStyle(SizeType.Percent, 75), new ColumnStyle(SizeType.Percent, 85) },
                RowStyles = { new RowStyle(SizeType.Percent, 90), new RowStyle(SizeType.Percent, 10) }

            };
            pict = new PictureBox {
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.Fixed3D
            };

            //box = new CheckBox { Text = "Stretch" };
            //box.CheckedChanged += CheckBox_CheckedChanged;

            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();


            Button button1 = new Button{Text = "Kinni",AutoSize = true,};
            Button button2 = new Button{Text = "Tausta määrama", AutoSize = true};
            Button button3 = new Button{Text = "Tühjenda pilt", AutoSize = true};
            Button button4 = new Button{Text = "Näita pilti", AutoSize = true};

            flowLayoutPanel.Controls.Add(button1);
            flowLayoutPanel.Controls.Add(button2);
            flowLayoutPanel.Controls.Add(button3);
            flowLayoutPanel.Controls.Add(button4);

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;

            table.Controls.Add(pict);
            table.Controls.Add(flowLayoutPanel);
            table.SetCellPosition(flowLayoutPanel, new TableLayoutPanelCellPosition(0, 0));
            table.SetColumnSpan(pict, 2);
            this.Controls.Add(table);
            
        }

        private void CheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            //if (box.Checked)
                //pict.SizeMode = PictureBoxSizeMode.StretchImage;
            //else
            //pict.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void Button4_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object? sender, EventArgs e)
        {
            pict.Image = null;
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                pict.BackColor = colorDialog.Color;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pict.Load(openFile.FileName);
            }
        }
    }
}