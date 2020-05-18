using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project__Pong_
{
    public partial class Form1 : Form
    {
        public int speed_Left = 2;
        public int speed_Top = 2;
        public int p1point = 0;
        public int p2point = 0;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            paddle1.Top = playarea.Top + 30;
            paddle2.Top = playarea.Bottom - 30;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            paddle2.Left = Cursor.Position.X - (paddle2.Width / 2);

            ball.Left += speed_Left;
            ball.Top += speed_Top;

            if (ball.Bottom >= paddle2.Top && ball.Bottom <= paddle2.Bottom && ball.Left >= paddle2.Left && ball.Right <= paddle2.Right)
            {
                p2point += 1;
                p2score.Text = p2point.ToString();

                speed_Top += 1;
                speed_Left += 1;
                speed_Top = -speed_Top;
            }

            if (ball.Top >= paddle1.Top && ball.Top <= paddle1.Bottom && ball.Left >= paddle1.Left && ball.Right <= paddle1.Right)
            {
                p1point += 1;
                p1score.Text = p1point.ToString();

                speed_Top -= 1;
                speed_Left -= 1;
                speed_Top = -speed_Top;
            }

            if (ball.Left <= playarea.Left)
            {
                speed_Left = -speed_Left;
            }
            if (ball.Right >= playarea.Right)
            {
                speed_Left = -speed_Left;
            }
            if (ball.Bottom >= playarea.Bottom)
            {
                timer.Enabled = false;
            }
            if (ball.Top <= playarea.Top)
            {
                timer.Enabled = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                paddle1.Left -= 60;
            }
            if (e.KeyCode == Keys.D)
            {
                paddle1.Left += 60;
            }


            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
