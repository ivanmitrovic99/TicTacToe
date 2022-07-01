using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        string x = "../pics/X.jpg";
        string o = "../pics/O.jpg";
        int turn = 1;
        int scoreX = 0;
        int scoreY = 0;
        
        string [,] array = new string[3, 3]{
                                {"1", "2","3"},
                                {"4", "5","6"},
                                {"7", "8","9"}
                            };

        
        private void checkForWinner(string[,] array)
        {
            for (int i = 0; i < 3; i++)
            {

                if (array[i,0] == array[i,1] && array[i,1] == array[i,2])
                {
                    if (array[i, 0] == "x")
                    {
                        MessageBox.Show("Player X wins");
                      
                       
                    }
                    else {
                        if (array[i, 0] == "o")
                            MessageBox.Show("Player O wins");
                       
                    }
                }



            }

            for (int i = 0; i < 3; i++)
            {

                if (array[0,i] == array[1,i] && array[0,i] == array[2,i])
                {
                    if (array[0,i] == "x")
                    {
                        MessageBox.Show("Player X wins");
                        
                    }
                    else
                    {
                        if (array[0, i] == "o")
                            MessageBox.Show("Player O wins");
                        
                    }
                }
            }
                if (array[0, 0] == array[1, 1] && array[0, 0] == array[2, 2])
                {
                    if (array[1, 1] == "x")
                    {
                        MessageBox.Show("Player X wins");
                    
                }
                    else
                    {
                        if (array[1, 1] == "o")
                            MessageBox.Show("Player O wins");
                   
                }
                }
            

            

                if (array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0])
                {
                    if (array[1, 1] == "x")
                    {
                        MessageBox.Show("Player X wins");
                   
                }
                    else
                    {
                        if (array[1, 1] == "o")
                            MessageBox.Show("Player O wins");
                  
                }
                }
        }
        public Form1()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (turn == 1 && pictureBox1.Image== null)
            {
                array[0, 0] = "x";
                turn = 0;
                pictureBox1.Image = Image.FromFile(x);
                checkForWinner(array);
            }

            else
            if(turn == 0 && pictureBox1.Image == null)
            {
                array[0, 0] = "o";
                turn = 1;
                pictureBox1.Image = Image.FromFile(o);
                checkForWinner(array);
            }

        }

       
  
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (turn == 1 && pictureBox2.Image == null)
            {
                array[0, 1] = "x";
                turn = 0;
                pictureBox2.Image = Image.FromFile(x);
                checkForWinner(array);
            }

            else
          if (turn == 0 && pictureBox2.Image == null)
            {
                array[0, 1] = "o";
                turn = 1;
                pictureBox2.Image = Image.FromFile(o);
                checkForWinner(array);
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if (turn == 1 && pictureBox3.Image == null)
            {
                array[0, 2] = "x";
                turn = 0;
                pictureBox3.Image = Image.FromFile(x);
                checkForWinner(array);
            }

            else
           if (turn == 0 && pictureBox3.Image == null)
            {
                array[0, 2] = "o";
                turn = 1;
                pictureBox3.Image = Image.FromFile(o);
                checkForWinner(array);
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            if (turn == 1 && pictureBox4.Image == null)
            {
                array[1, 0] = "x";
                turn = 0;
                pictureBox4.Image = Image.FromFile(x);
                checkForWinner(array);
            }

            else
           if (turn == 0 && pictureBox4.Image == null)
            {
                array[1, 0] = "o";
                turn = 1;
                pictureBox4.Image = Image.FromFile(o);
                checkForWinner(array);
            }

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            if (turn == 1 && pictureBox5.Image == null)
            {
                array[1, 1] = "x";
                turn = 0;
                pictureBox5.Image = Image.FromFile(x);
                checkForWinner(array);
            }

            else
            if (turn == 0 && pictureBox5.Image == null)
            {
                array[1, 1] = "o";
                turn = 1;
                pictureBox5.Image = Image.FromFile(o);
                checkForWinner(array);
            }
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            if (turn == 1 && pictureBox6.Image == null)
            {
                array[1, 2] = "x";
                turn = 0;
                pictureBox6.Image = Image.FromFile(x);
                checkForWinner(array);
            }

            else
            if (turn == 0 && pictureBox6.Image == null)
            {
                array[1, 2] = "o";
                turn = 1;
                pictureBox6.Image = Image.FromFile(o);
                checkForWinner(array);
            }


        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            if (turn == 1 && pictureBox7.Image == null)
            {
                array[2, 0] = "x";
                turn = 0;
                pictureBox7.Image = Image.FromFile(x);
                checkForWinner(array);
            }

            else
           if (turn == 0 && pictureBox7.Image == null)
            {
                array[2, 0] = "o";
                turn = 1;
                pictureBox7.Image = Image.FromFile(o);
                checkForWinner(array);
            }
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            if (turn == 1 && pictureBox8.Image == null)
            {
                array[2, 1] = "x";
                turn = 0;
                pictureBox8.Image = Image.FromFile(x);
                checkForWinner(array);
            }

            else
            if (turn == 0 && pictureBox8.Image == null)
            {
                array[2, 1] = "o";
                turn = 1;
                pictureBox8.Image = Image.FromFile(o);
                checkForWinner(array);
            }
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            if (turn == 1 && pictureBox9.Image == null)
            {
                array[2, 2] = "x";
                turn = 0;
                pictureBox9.Image = Image.FromFile(x);
                checkForWinner(array);
            }

            else
         if (turn == 0 && pictureBox9.Image == null)
            {
                array[2, 2] = "o";
                turn = 1;
                pictureBox9.Image = Image.FromFile(o);
                checkForWinner(array);
            }
        }
        
        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = "/";
                }
            }
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
        }
    }
}
