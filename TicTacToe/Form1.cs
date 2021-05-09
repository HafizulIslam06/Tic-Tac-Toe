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
    public partial class Form_HomeScreen : Form
    {
        public Form_HomeScreen()
        {
            InitializeComponent();
        }

        SoundPlayer MenubtnClickSound = new SoundPlayer(@"C:\Users\Hafiz\Downloads\TicTacToe\TicTacToe\bin\Debug\click2.wav");

        Color mouseOverColor = Color.FromArgb(40, 116, 166);
        Color mouseOutColor = Color.FromArgb(27, 79, 114);

        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {

                panel1.BackColor = mouseOverColor;
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
            else
            {
                panel1.BackColor = mouseOutColor;
            }
        }

        private void button_X_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_playWithFriend_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenubtnClickSound.Play();
            Form_PlayWithFriend frm_PlayWithFriend = new Form_PlayWithFriend();
            frm_PlayWithFriend.ShowDialog();
        }

        private void button_playWithComputer_Click(object sender, EventArgs e)
        {
            MenubtnClickSound.Play();
            this.Hide();
            Form_PlayWithComputer frm_PlayWithComputer = new Form_PlayWithComputer();
            frm_PlayWithComputer.ShowDialog();
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            MenubtnClickSound.Play();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
