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

namespace TicTacToe
{
    public partial class Form_PlayWithFriend : Form
    {
        public Form_PlayWithFriend()
        {
            InitializeComponent();
        }
        SoundPlayer MenubtnClickSound = new SoundPlayer(@"C:\Users\Hafiz\Downloads\TicTacToe\TicTacToe\bin\Debug\click2.wav");
        SoundPlayer player1sound = new SoundPlayer(@"C:\Users\Hafiz\Downloads\TicTacToe\TicTacToe\bin\Debug\player1 click.wav");
        SoundPlayer player2sound = new SoundPlayer(@"C:\Users\Hafiz\Downloads\TicTacToe\TicTacToe\bin\Debug\player2 click.wav");
        SoundPlayer winSound = new SoundPlayer(@"C:\Users\Hafiz\Downloads\TicTacToe\TicTacToe\bin\Debug\Win.wav");

        int count = 0;
        int Player1_result = 0;
        int Player2_result = 0;

        Color Color_Xtext = Color.FromArgb(220, 110, 99);
        Color Color_0tex = Color.FromArgb(15, 183, 201);
        Color Color_unselected = Color.FromArgb(23, 32, 42);
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

        private void button_11_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
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
            else
            {
                player2sound.Play();
                ((Button)btn).FlatAppearance.BorderColor = Color_0tex;

                ((Button)btn).Text = "0";
                ((Button)btn).Enabled = false;
                count++;
            }
            CheckResult(((Button)btn).Text);
        }

        private void CheckResult(string symbol)
        {
            //===================Row=====================
            if (button_11.Text == symbol && button_12.Text == symbol && button_13.Text == symbol)
            {
                MessageBox.Show(symbol + " win", "Result");
                ResultBoard(symbol);
                reset();
            }
            else if (button_21.Text == symbol && button_22.Text == symbol && button_23.Text == symbol)
            {
                MessageBox.Show(symbol + " win", "Result");
                ResultBoard(symbol);
                reset();
            }
            else if (button_31.Text == symbol && button_32.Text == symbol && button_33.Text == symbol)
            {
                MessageBox.Show(symbol + " win", "Result");
                ResultBoard(symbol);
                reset();
            }

            //=====================Column==================
            else if (button_11.Text == symbol && button_21.Text == symbol && button_31.Text == symbol)
            {
                MessageBox.Show(symbol + " win", "Result");
                ResultBoard(symbol);
                reset();
            }
            else if (button_12.Text == symbol && button_22.Text == symbol && button_32.Text == symbol)
            {
                MessageBox.Show(symbol + " win", "Result");
                ResultBoard(symbol);
                reset();
            }
            else if (button_13.Text == symbol && button_23.Text == symbol && button_33.Text == symbol)
            {
                MessageBox.Show(symbol + " win", "Result");
                ResultBoard(symbol);
                reset();
            }

            //=======================Cross==================
            else if (button_11.Text == symbol && button_22.Text == symbol && button_33.Text == symbol)
            {
                MessageBox.Show(symbol + " win", "Result");
                ResultBoard(symbol);
                reset();
            }
            else if (button_31.Text == symbol && button_22.Text == symbol && button_13.Text == symbol)
            {
                MessageBox.Show(symbol + " win", "Result");
                ResultBoard(symbol);
                reset();
            }            
        }

        private void ResultBoard(string symbol)
        {
            if (symbol == "X")
            {
                winSound.Play();
                Player1_result++;
                button_player1_scoreBoard.Text = Player1_result.ToString();
            }
            else if (symbol == "0")
            {
                winSound.Play();
                Player2_result++;
                button_player2_scoreBoard.Text = Player2_result.ToString();
            }
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

        private void MouseEnter(object sender, EventArgs e)
        {
            if (((Button)sender).Enabled)
            {
                if (count % 2 == 0)
                {
                    ((Button)sender).Text = "X";
                }
                else
                {
                    ((Button)sender).Text = "0";
                }
            }            
        }

        private void button_11_MouseLeave(object sender, EventArgs e)
        {
            if (((Button)sender).Enabled)
            {
                    ((Button)sender).Text = "";                
            }
        }
    }
}
