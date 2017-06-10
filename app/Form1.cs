using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {

        public int speed_left = 4;
        public int speed_top = 4;
        public int point = 0;

        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            deska.Top = playground.Bottom - (playground.Bottom / 10);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            deska.Left = Cursor.Position.X - (deska.Width / 2);

            pilka.Left += speed_left;
            pilka.Top += speed_top;

            if (pilka.Bottom >= deska.Top && pilka.Bottom <= deska.Bottom && pilka.Left >= deska.Left && pilka.Right <= deska.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                point += 1;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) { this.Close()}
        }
    }
}
