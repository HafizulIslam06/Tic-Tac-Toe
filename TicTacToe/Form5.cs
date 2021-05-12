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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button_X_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_HomeScreen frm_hmScreen = new Form_HomeScreen();
            frm_hmScreen.ShowDialog();
        }
    }
}
