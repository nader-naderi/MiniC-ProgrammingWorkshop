using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_Game
{
    public partial class Pong : Form
    {
        public Pong()
        {
            InitializeComponent();


            // runs once at start of the game! 

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    PictureBox newBlock = new PictureBox();
                    newBlock.Size = new Size(50, 20);
                    newBlock.Location = new Point(i * newBlock.Size.Width, j * newBlock.Size.Height);
                    newBlock.BackColor = Color.Blue;
                    newBlock.BorderStyle = BorderStyle.Fixed3D;

                    Controls.Add(newBlock);

                    blocks.Add(newBlock);
                }
            }
        }

        private List<PictureBox> blocks = new List<PictureBox>();

        private int speed = 3;
        private int verticalDir = +1;
        private int horizontalDir = +1;

        private int paddleSpeed = 5;
        private bool left;
        private bool right;

        private void horzT_Tick(object sender, EventArgs e)
        {
            if (ball.Left < 0)
                horizontalDir = 1;
            else if(ball.Left > (Width - ball.Width))
                horizontalDir = -1;

            ball.Left += (horizontalDir * speed);
        }

        private void vert_Tick(object sender, EventArgs e)
        {
            if (ball.Top < 0)
            {
                verticalDir = +1;
            }
            else if (ball.Bounds.IntersectsWith(paddle.Bounds))
            {
                verticalDir = -1;
            }
            else if (ball.Top > (Height - ball.Height - paddle.Height))
            {
                if (ball.Left < paddle.Left || ((ball.Left + ball.Width) > (paddle.Left + paddle.Width)))
                {
                    MessageBox.Show("Game Over !");
                    horzT.Enabled = vert.Enabled = false;
                }
            }

            ball.Top += (verticalDir * speed);
        }

        private void inputT_Tick(object sender, EventArgs e)
        {
            if (right && paddle.Left < (Width - paddle.Width))
            {
                paddle.Left += paddleSpeed;
            }
            if (left && paddle.Left > 0)
            {
                paddle.Left -= paddleSpeed;
            }
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                right = false;
            else if (e.KeyCode == Keys.Left)
                left = false;
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            left = (e.KeyCode == Keys.Left);
            right = (e.KeyCode == Keys.Right);
        }

        private void collisionT_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < blocks.Count; i++)
            {
                if (ball.Bounds.IntersectsWith(blocks[i].Bounds))
                {
                    Controls.Remove(blocks[i]);
                    blocks.RemoveAt(i);
                }
            }
        }
    }
}
