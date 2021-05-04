
namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_playWithComputer = new System.Windows.Forms.Button();
            this.button_playWithFriend = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_X = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_playWithComputer
            // 
            this.button_playWithComputer.FlatAppearance.BorderSize = 0;
            this.button_playWithComputer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.button_playWithComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_playWithComputer.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_playWithComputer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_playWithComputer.Location = new System.Drawing.Point(107, 384);
            this.button_playWithComputer.Name = "button_playWithComputer";
            this.button_playWithComputer.Size = new System.Drawing.Size(333, 55);
            this.button_playWithComputer.TabIndex = 0;
            this.button_playWithComputer.Text = "Play With Computer";
            this.button_playWithComputer.UseVisualStyleBackColor = true;
            // 
            // button_playWithFriend
            // 
            this.button_playWithFriend.FlatAppearance.BorderSize = 0;
            this.button_playWithFriend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.button_playWithFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_playWithFriend.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_playWithFriend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_playWithFriend.Location = new System.Drawing.Point(107, 455);
            this.button_playWithFriend.Name = "button_playWithFriend";
            this.button_playWithFriend.Size = new System.Drawing.Size(333, 55);
            this.button_playWithFriend.TabIndex = 1;
            this.button_playWithFriend.Text = "Play With Friend";
            this.button_playWithFriend.UseVisualStyleBackColor = true;
            // 
            // button_about
            // 
            this.button_about.FlatAppearance.BorderSize = 0;
            this.button_about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_about.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_about.Location = new System.Drawing.Point(107, 526);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(333, 55);
            this.button_about.TabIndex = 2;
            this.button_about.Text = "About";
            this.button_about.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(193)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_exit.Location = new System.Drawing.Point(107, 597);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(333, 55);
            this.button_exit.TabIndex = 3;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_X);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 50);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button_X
            // 
            this.button_X.FlatAppearance.BorderSize = 0;
            this.button_X.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.button_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_X.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_X.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_X.Location = new System.Drawing.Point(503, 0);
            this.button_X.Name = "button_X";
            this.button_X.Size = new System.Drawing.Size(53, 50);
            this.button_X.TabIndex = 0;
            this.button_X.Text = "X";
            this.button_X.UseVisualStyleBackColor = true;
            this.button_X.Click += new System.EventHandler(this.button_X_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(556, 844);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_playWithFriend);
            this.Controls.Add(this.button_playWithComputer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_playWithComputer;
        private System.Windows.Forms.Button button_playWithFriend;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_X;
    }
}

