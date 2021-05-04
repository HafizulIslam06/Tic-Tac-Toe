﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        Color mouseOverColor = Color.FromArgb(40, 116, 166);
        Color mouseOutColor = Color.FromArgb(27, 79, 114);
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

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

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button_X_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
