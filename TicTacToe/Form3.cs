using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace TicTacToe
{
    public partial class Form_PlayWithComputer : Form
    {
        public Form_PlayWithComputer()
        {
            InitializeComponent();
        }
        SoundPlayer MenubtnClickSound = new SoundPlayer(@"C:\Users\Hafiz\Downloads\TicTacToe\TicTacToe\bin\Debug\click2.wav");
        SoundPlayer player1sound = new SoundPlayer(@"C:\Users\Hafiz\Downloads\TicTacToe\TicTacToe\bin\Debug\player1 click.wav");
        SoundPlayer player2sound = new SoundPlayer(@"C:\Users\Hafiz\Downloads\TicTacToe\TicTacToe\bin\Debug\player2 click.wav");
        SoundPlayer winSound = new SoundPlayer(@"C:\Users\Hafiz\Downloads\TicTacToe\TicTacToe\bin\Debug\Win.wav");

        Color Color_Xtext = Color.FromArgb(220, 110, 99);
        Color Color_0tex = Color.FromArgb(15, 183, 201);
        Color Color_unselected = Color.FromArgb(23, 32, 42);

        int count = 0;
        int Player1_result = 0;
        int Player2_result = 0;

        private void button_Exit_Click(object sender, EventArgs e)
        {
            MenubtnClickSound.Play();
            DialogResult check;
            check = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (check == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            MenubtnClickSound.Play();
            DialogResult check;
            check = MessageBox.Show("Are you sure?", "Back", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (check == DialogResult.Yes)
            {
                this.Close();
                Form_HomeScreen frm_homescreen = new Form_HomeScreen();
                frm_homescreen.ShowDialog();
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            MenubtnClickSound.Play();
            reset();
        }
        public void reset()
        {
            button_11.FlatAppearance.BorderColor = Color_unselected;
            button_12.FlatAppearance.BorderColor = Color_unselected;
            button_13.FlatAppearance.BorderColor = Color_unselected;
            button_13.FlatAppearance.BorderColor = Color_unselected;
            button_21.FlatAppearance.BorderColor = Color_unselected;
            button_22.FlatAppearance.BorderColor = Color_unselected;
            button_23.FlatAppearance.BorderColor = Color_unselected;
            button_31.FlatAppearance.BorderColor = Color_unselected;
            button_32.FlatAppearance.BorderColor = Color_unselected;
            button_33.FlatAppearance.BorderColor = Color_unselected;

            button_11.Enabled = true;
            button_12.Enabled = true;
            button_13.Enabled = true;
            button_21.Enabled = true;
            button_22.Enabled = true;
            button_23.Enabled = true;
            button_31.Enabled = true;
            button_32.Enabled = true;
            button_33.Enabled = true;

            button_11.Text = null;
            button_12.Text = null;
            button_13.Text = null;
            button_21.Text = null;
            button_22.Text = null;
            button_23.Text = null;
            button_31.Text = null;
            button_32.Text = null;
            button_33.Text = null;
        }
        private void ButtonClick(object btn)
        {
            if (count % 2 == 0)
            {
                player1sound.Play();
                ((Button)btn).FlatAppearance.BorderColor = Color_Xtext;

                ((Button)btn).Text = "X";
                ((Button)btn).Enabled = false;
                count++;
            }
            CheckResultForX();

            int milliseconds = 1000;
            Thread.Sleep(milliseconds);

            ComputerPlayer();
            CheckResultForY();
            Drawcheck();
        }

        private void ComputerPlayer()
        {
            if (count % 2 != 0)
            {
                winingChance();
            }
            if (count % 2 != 0)
            {
                Defense();
            }
            if (count % 2 != 0)
            {
                if (button_22.Text == "")
                {
                    player2sound.Play();

                    button_22.Text = "0";
                    button_22.Enabled = false;
                }
                else if (button_11.Text == "" || button_13.Text == "" || button_31.Text == "" || button_33.Text == "")
                {
                    player2sound.Play();

                    if (button_11.Text == "")
                    {
                        button_11.Text = "0";
                    }
                    else if (button_13.Text == "")
                    {
                        button_13.Text = "0";
                    }
                    else if (button_31.Text == "")
                    {
                        button_31.Text = "0";
                    }
                    else if (button_33.Text == "")
                    {
                        button_33.Text = "0";
                    }
                }
                else
                {
                    player2sound.Play();

                    if (button_12.Text == "")
                    {
                        button_12.Text = "0";
                    }
                    else if (button_21.Text == "")
                    {
                        button_21.Text = "0";
                    }
                    else if (button_32.Text == "")
                    {
                        button_32.Text = "0";
                    }
                    else if (button_23.Text == "")
                    {
                        button_23.Text = "0";
                    }
                }
                count++;
            }
        }

        private void winingChance()
        {
            //1st row check=========================
            if (button_11.Text == "0" && button_12.Text == "0" && button_13.Text == "" || button_11.Text == "0" && button_13.Text == "0" && button_12.Text == "" || button_12.Text == "0" && button_13.Text == "0" && button_11.Text == "")
            {
                player2sound.Play();
                if (button_11.Text == "")
                {
                    button_11.Text = "0";
                    button_11.Enabled = false;
                }
                else if (button_12.Text == "")
                {
                    button_12.Text = "0";
                    button_12.Enabled = false;
                }
                else if (button_13.Text == "")
                {
                    button_13.Text = "0";
                    button_13.Enabled = false;
                }
                count++;
            }
            //2nd row check
            else if (button_21.Text == "0" && button_22.Text == "0" && button_23.Text == "" || button_21.Text == "0" && button_23.Text == "0" && button_22.Text == "" || button_22.Text == "0" && button_23.Text == "0" && button_21.Text == "")
            {
                player2sound.Play();
                if (button_21.Text == "")
                {
                    button_21.Text = "0";
                    button_21.Enabled = false;
                }
                else if (button_22.Text == "")
                {
                    button_22.Text = "0";
                    button_22.Enabled = false;
                }
                else if (button_23.Text == "")
                {
                    button_23.Text = "0";
                    button_23.Enabled = false;
                }
                count++;
            }
            //3rd row check
            else if (button_31.Text == "0" && button_32.Text == "0" && button_33.Text == "" || button_31.Text == "0" && button_33.Text == "0" && button_32.Text == "" || button_32.Text == "0" && button_33.Text == "0" && button_31.Text == "")
            {
                player2sound.Play();
                if (button_31.Text == "")
                {
                    button_31.Text = "0";
                    button_31.Enabled = false;
                }
                else if (button_32.Text == "")
                {
                    button_32.Text = "0";
                    button_32.Enabled = false;
                }
                else if (button_33.Text == "")
                {
                    button_33.Text = "0";
                    button_33.Enabled = false;
                }
                count++;
            }
            //1st Column check=========
            else if (button_11.Text == "0" && button_21.Text == "0" && button_31.Text == "" || button_11.Text == "0" && button_31.Text == "0" && button_21.Text == "" || button_21.Text == "0" && button_31.Text == "0" && button_11.Text == "")
            {
                player2sound.Play();
                if (button_11.Text == "")
                {
                    button_11.Text = "0";
                    button_11.Enabled = false;
                }
                else if (button_21.Text == "")
                {
                    button_21.Text = "0";
                    button_21.Enabled = false;
                }
                else if (button_31.Text == "")
                {
                    button_31.Text = "0";
                    button_31.Enabled = false;
                }
                count++;
            }
            //2nd Column check
            else if (button_12.Text == "0" && button_22.Text == "0" && button_32.Text == "" || button_12.Text == "0" && button_32.Text == "0" && button_22.Text == "" || button_22.Text == "0" && button_32.Text == "0" && button_12.Text == "")
            {
                player2sound.Play();
                if (button_12.Text == "")
                {
                    button_12.Text = "0";
                    button_12.Enabled = false;
                }
                else if (button_22.Text == "")
                {
                    button_22.Text = "0";
                    button_22.Enabled = false;
                }
                else if (button_32.Text == "")
                {
                    button_32.Text = "0";
                    button_32.Enabled = false;
                }
                count++;
            }
            //3rd Column check
            else if (button_13.Text == "0" && button_23.Text == "0" && button_33.Text == "" || button_13.Text == "0" && button_33.Text == "0" && button_23.Text == "" || button_23.Text == "0" && button_33.Text == "0" && button_13.Text == "")
            {
                player2sound.Play();
                if (button_13.Text == "")
                {
                    button_13.Text = "0";
                    button_13.Enabled = false;
                }
                else if (button_23.Text == "")
                {
                    button_23.Text = "0";
                    button_23.Enabled = false;
                }
                else if (button_33.Text == "")
                {
                    button_33.Text = "0";
                    button_33.Enabled = false;
                }
                count++;
            }
            //1st cross check=======
            else if (button_11.Text == "0" && button_22.Text == "0" && button_33.Text == "" || button_11.Text == "0" && button_33.Text == "0" && button_22.Text == "" || button_22.Text == "0" && button_33.Text == "0" && button_11.Text == "")
            {
                player2sound.Play();
                if (button_11.Text == "")
                {
                    button_11.Text = "0";
                    button_11.Enabled = false;
                }
                else if (button_22.Text == "")
                {
                    button_22.Text = "0";
                    button_22.Enabled = false;
                }
                else if (button_33.Text == "")
                {
                    button_33.Text = "0";
                    button_33.Enabled = false;
                }
                count++;
            }
            //2nd cross check
            else if (button_13.Text == "0" && button_22.Text == "0" && button_31.Text == "" || button_13.Text == "0" && button_31.Text == "0" && button_22.Text == "" || button_22.Text == "0" && button_31.Text == "0" && button_13.Text == "")
            {
                player2sound.Play();
                if (button_13.Text == "")
                {
                    button_13.Text = "0";
                    button_13.Enabled = false;
                }
                else if (button_22.Text == "")
                {
                    button_22.Text = "0";
                    button_22.Enabled = false;
                }
                else if (button_31.Text == "")
                {
                    button_31.Text = "0";
                    button_31.Enabled = false;
                }
                count++;
            }
        }

        private void button_11_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button_12_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button_13_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button_21_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button_22_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button_23_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button_31_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button_32_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button_33_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void Defense()
        {
            //1st row check=========================
            if (button_11.Text == "X" && button_12.Text == "X" && button_13.Text==""|| button_11.Text == "X" && button_13.Text == "X" &&button_12.Text=="" || button_12.Text == "X" && button_13.Text == "X" && button_11.Text=="")
            {
                player2sound.Play();
                if (button_11.Text == "")
                {
                    button_11.Text = "0";
                    button_11.Enabled = false;
                }
                else if (button_12.Text == "")
                {
                    button_12.Text = "0";
                    button_12.Enabled = false;
                }
                else if (button_13.Text == "")
                {
                    button_13.Text = "0";
                    button_13.Enabled = false;
                }
                count++;
            }
            //2nd row check
            else if (button_21.Text == "X" && button_22.Text == "X" && button_23.Text=="" || button_21.Text == "X" && button_23.Text == "X" && button_22.Text==""|| button_22.Text == "X" && button_23.Text == "X" && button_21.Text=="")
            {
                player2sound.Play();
                if (button_21.Text == "")
                {
                    button_21.Text = "0";
                    button_21.Enabled = false;
                }
                else if (button_22.Text == "")
                {
                    button_22.Text = "0";
                    button_22.Enabled = false;
                }
                else if (button_23.Text == "")
                {
                    button_23.Text = "0";
                    button_23.Enabled = false;
                }
                count++;
            }
            //3rd row check
            else if (button_31.Text == "X" && button_32.Text == "X" && button_33 .Text=="" || button_31.Text == "X" && button_33.Text == "X" && button_32.Text=="" || button_32.Text == "X" && button_33.Text == "X" && button_31.Text=="")
            {
                player2sound.Play();
                if (button_31.Text == "")
                {
                    button_31.Text = "0";
                    button_31.Enabled = false;
                }
                else if (button_32.Text == "")
                {
                    button_32.Text = "0";
                    button_32.Enabled = false;
                }
                else if (button_33.Text == "")
                {
                    button_33.Text = "0";
                    button_33.Enabled = false;
                }
                count++;
            }
            //1st Column check=========
            else if (button_11.Text == "X" && button_21.Text == "X" && button_31.Text==""|| button_11.Text == "X" && button_31.Text == "X" && button_21.Text==""|| button_21.Text == "X" && button_31.Text == "X" && button_11.Text=="")
            {
                player2sound.Play();
                if (button_11.Text == "")
                {
                    button_11.Text = "0";
                    button_11.Enabled = false;
                }
                else if (button_21.Text == "")
                {
                    button_21.Text = "0";
                    button_21.Enabled = false;
                }
                else if (button_31.Text == "")
                {
                    button_31.Text = "0";
                    button_31.Enabled = false;
                }
                count++;
            }
            //2nd Column check
            else if (button_12.Text == "X" && button_22.Text == "X" && button_32.Text==""|| button_12.Text == "X" && button_32.Text == "X" && button_22.Text==""|| button_22.Text == "X" && button_32.Text == "X" && button_12.Text=="")
            {
                player2sound.Play();
                if (button_12.Text == "")
                {
                    button_12.Text = "0";
                    button_12.Enabled = false;
                }
                else if (button_22.Text == "")
                {
                    button_22.Text = "0";
                    button_22.Enabled = false;
                }
                else if (button_32.Text == "")
                {
                    button_32.Text = "0";
                    button_32.Enabled = false;
                }
                count++;
            }
            //3rd Column check
            else if (button_13.Text == "X" && button_23.Text == "X" && button_33.Text==""|| button_13.Text == "X" && button_33.Text == "X" && button_23.Text==""|| button_23.Text == "X" && button_33.Text == "X" && button_13.Text=="")
            {
                player2sound.Play();
                if (button_13.Text == "")
                {
                    button_13.Text = "0";
                    button_13.Enabled = false;
                }
                else if (button_23.Text == "")
                {
                    button_23.Text = "0";
                    button_23.Enabled = false;
                }
                else if (button_33.Text == "")
                {
                    button_33.Text = "0";
                    button_33.Enabled = false;
                }
                count++;
            }
            //1st cross check=======
            else if (button_11.Text == "X" && button_22.Text == "X" && button_33.Text==""|| button_11.Text == "X" && button_33.Text == "X" && button_22.Text==""|| button_22.Text == "X" && button_33.Text == "X" && button_11.Text=="")
            {
                player2sound.Play();
                if (button_11.Text == "")
                {
                    button_11.Text = "0";
                    button_11.Enabled = false;
                }
                else if (button_22.Text == "")
                {
                    button_22.Text = "0";
                    button_22.Enabled = false;
                }
                else if (button_33.Text == "")
                {
                    button_33.Text = "0";
                    button_33.Enabled = false;
                }
                count++;
            }
            //2nd cross check
            else if (button_13.Text == "X" && button_22.Text == "X" && button_31.Text==""|| button_13.Text == "X" && button_31.Text == "X" && button_22.Text==""|| button_22.Text == "X" && button_31.Text == "X" && button_13.Text=="")
            {
                player2sound.Play();
                if (button_13.Text == "")
                {
                    button_13.Text = "0";
                    button_13.Enabled = false;
                }
                else if (button_22.Text == "")
                {
                    button_22.Text = "0";
                    button_22.Enabled = false;
                }
                else if (button_31.Text == "")
                {
                    button_31.Text = "0";
                    button_31.Enabled = false;
                }
                count++;
            }
        }

        private void CheckResultForX()
        {
            //===================Row=====================
            if (button_11.Text == "X" && button_12.Text == "X" && button_13.Text == "X")
            {
                winSound.Play();
                MessageBox.Show("X win", "Result");
                reset();
                ResultBoard("X");               
            }
            else if (button_21.Text == "X" && button_22.Text == "X" && button_23.Text == "X")
            {
                winSound.Play();
                MessageBox.Show("X win", "Result");
                reset();
                ResultBoard("X");                
            }
            else if (button_31.Text == "X" && button_32.Text == "X" && button_33.Text == "X")
            {
                winSound.Play();
                MessageBox.Show("X win", "Result");
                reset();
                ResultBoard("X");                
            }

            //=====================Column==================
            else if (button_11.Text == "X" && button_21.Text == "X" && button_31.Text == "X")
            {
                winSound.Play();
                MessageBox.Show("X win", "Result");
                reset();
                ResultBoard("X");                
            }
            else if (button_12.Text == "X" && button_22.Text == "X" && button_32.Text == "X")
            {
                winSound.Play();
                MessageBox.Show("X win", "Result");
                reset();
                ResultBoard("X");                
            }
            else if (button_13.Text == "X" && button_23.Text == "X" && button_33.Text == "X")
            {
                winSound.Play();
                MessageBox.Show("X win", "Result");
                reset();
                ResultBoard("X");                
            }

            //=======================Cross==================
            else if (button_11.Text == "X" && button_22.Text == "X" && button_33.Text == "X")
            {
                winSound.Play();
                MessageBox.Show("X win", "Result");
                reset();
                ResultBoard("X");                
            }
            else if (button_31.Text == "X" && button_22.Text == "X" && button_13.Text == "X")
            {
                winSound.Play();
                MessageBox.Show("X win", "Result");
                reset();
                ResultBoard("X");                
            }
        }

        private void ResultBoard(string v)
        {
            if (v == "X")
            {
                Player1_result = Player1_result + 1;
                button_player1_scoreBoard.Text = Player1_result.ToString();
            }
            else if (v == "0")
            {
                Player2_result = Player2_result + 1;
                button_player2_scoreBoard.Text = Player2_result.ToString();
            }
        }

        private void CheckResultForY()
        {
            //===================Row=====================
            if (button_11.Text == "0" && button_12.Text == "0" && button_13.Text == "0")
            {
                winSound.Play();
                MessageBox.Show("0 win", "Result");
                reset();
                ResultBoard("0");                
            }
            else if (button_21.Text == "0" && button_22.Text == "0" && button_23.Text == "0")
            {
                winSound.Play();
                MessageBox.Show("0 win", "Result");
                reset();
                ResultBoard("0");                
            }
            else if (button_31.Text == "0" && button_32.Text == "0" && button_33.Text == "0")
            {
                winSound.Play();
                MessageBox.Show("0 win", "Result");
                reset();
                ResultBoard("0");                
            }

            //=====================Column==================
            else if (button_11.Text == "0" && button_21.Text == "0" && button_31.Text == "0")
            {
                winSound.Play();
                MessageBox.Show("0 win", "Result");
                reset();
                ResultBoard("0");                
            }
            else if (button_12.Text == "0" && button_22.Text == "0" && button_32.Text == "0")
            {
                winSound.Play();
                MessageBox.Show("0 win", "Result");
                reset();
                ResultBoard("0");                
            }
            else if (button_13.Text == "0" && button_23.Text == "0" && button_33.Text == "0")
            {
                winSound.Play();
                MessageBox.Show("0 win", "Result");
                reset();
                ResultBoard("0");                
            }

            //=======================Cross==================
            else if (button_11.Text == "0" && button_22.Text == "0" && button_33.Text == "0")
            {
                winSound.Play();
                MessageBox.Show("0 win", "Result");
                reset();
                ResultBoard("0");
                
            }
            else if (button_31.Text == "0" && button_22.Text == "0" && button_13.Text == "0")
            {
                winSound.Play();
                MessageBox.Show("0 win", "Result");
                reset();
                ResultBoard("0");                
            }
        }        

        private void Drawcheck()
        {
            if (button_11.Text!="" && button_12.Text!="" && button_13.Text != "" && button_21.Text != "" && button_22.Text != "" && button_23.Text != "" && button_31.Text != "" && button_32.Text != "" && button_33.Text != "")
            {
                winSound.Play();
                MessageBox.Show("Draw","Result");
                reset();
            }
        }
    }
}
