using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santa_claus_
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int pipespeed = 6;
        int score = 0;        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            santa.Top += gravity;
            Flake.Left -= pipespeed;
            Tree.Left -= pipespeed;
            scorelabel.Text = $"score: {score}";
            
            
                
                
            

            if (Flake.Left < -130)
            {
                Flake.Left = 1000;
                score++;
            }

            if (Tree.Left < -135)
            {
                Tree.Left = 1000;
                score++;
            }
            if (santa.Top < -25)
            {
                gameOver();
            }

            if (santa.Bounds.IntersectsWith(Flake.Bounds) || santa.Bounds.IntersectsWith(Tree.Bounds) || santa.Bounds.IntersectsWith(ground.Bounds))
            {
                gameOver();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = +10;
            }
        }
        private void gameOver()
        {
            timer1.Stop();
            scorelabel.Text = $"Game Over!";
            playAgain.Visible = true;
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
