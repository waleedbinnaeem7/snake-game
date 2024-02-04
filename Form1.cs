using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x , y;

        int height = 255;
        int width = 378;
        string operand; 
        int game_over = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            switch (operand)
            {
                case "L":
                    x = x - 5;
                    
                    break;
                case "R":
                    x = x + 5;

                    break;
                case "U":
                    y = y - 5;
                    

                    break;
                case "D":
                    y = y + 5;

                    break;


                default:
                    break;
            }
        

            pictureBox1.Location = new Point(x , y);
           
            label1.Text = x.ToString();
            label4.Text = y.ToString();
            if (x < 0 || x > width || y < 0 || y > height)
            {
                timer1.Stop();
                MessageBox.Show("Game over :(");
                pictureBox1.Location = new Point(0, 0);
                game_over = 1;

            }
                
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Left")
            {
              
                operand = "L";
            }
            else if (e.KeyCode.ToString () == "Right")
            {
              
                operand = "R";
            }
            else if (e.KeyCode.ToString() == "Down")
            {
            
                operand = "D";
            }
            else if (e.KeyCode.ToString() == "Up")
            {
              
                operand = "U";
            }

            if (game_over == 1)
            {
                Form1 r = new Form1();
                r.Show();
            }  
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
