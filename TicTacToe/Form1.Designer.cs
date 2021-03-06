
namespace TicTacToe
{
    partial class Form_HomeScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HomeScreen));
            this.button_playWithComputer = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_playWithFriend = new System.Windows.Forms.Button();
            this.button_Help = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_X = new System.Windows.Forms.Button();
            this.label_nubGames = new System.Windows.Forms.Label();
            this.pictureBox_NumGames = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NumGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_playWithComputer
            // 
            this.button_playWithComputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.button_playWithComputer.FlatAppearance.BorderSize = 0;
            this.button_playWithComputer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button_playWithComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_playWithComputer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_playWithComputer.ForeColor = System.Drawing.Color.White;
            this.button_playWithComputer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_playWithComputer.ImageIndex = 1;
            this.button_playWithComputer.ImageList = this.imageList1;
            this.button_playWithComputer.Location = new System.Drawing.Point(103, 448);
            this.button_playWithComputer.Name = "button_playWithComputer";
            this.button_playWithComputer.Size = new System.Drawing.Size(348, 55);
            this.button_playWithComputer.TabIndex = 0;
            this.button_playWithComputer.TabStop = false;
            this.button_playWithComputer.Text = "   NEW GAME";
            this.button_playWithComputer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_playWithComputer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_playWithComputer.UseVisualStyleBackColor = false;
            this.button_playWithComputer.Click += new System.EventHandler(this.button_playWithComputer_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "group-xxl.png");
            this.imageList1.Images.SetKeyName(1, "hand-cursor-xxl.png");
            this.imageList1.Images.SetKeyName(2, "help-xxl.png");
            this.imageList1.Images.SetKeyName(3, "settings-17-xxl.png");
            // 
            // button_playWithFriend
            // 
            this.button_playWithFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(96)))), ((int)(((byte)(26)))));
            this.button_playWithFriend.FlatAppearance.BorderSize = 0;
            this.button_playWithFriend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button_playWithFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_playWithFriend.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_playWithFriend.ForeColor = System.Drawing.Color.White;
            this.button_playWithFriend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_playWithFriend.ImageIndex = 0;
            this.button_playWithFriend.ImageList = this.imageList1;
            this.button_playWithFriend.Location = new System.Drawing.Point(103, 519);
            this.button_playWithFriend.Name = "button_playWithFriend";
            this.button_playWithFriend.Size = new System.Drawing.Size(348, 55);
            this.button_playWithFriend.TabIndex = 1;
            this.button_playWithFriend.TabStop = false;
            this.button_playWithFriend.Text = "   MULTIPLAYER";
            this.button_playWithFriend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_playWithFriend.UseVisualStyleBackColor = false;
            this.button_playWithFriend.Click += new System.EventHandler(this.button_playWithFriend_Click);
            // 
            // button_Help
            // 
            this.button_Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(149)))), ((int)(((byte)(11)))));
            this.button_Help.FlatAppearance.BorderSize = 0;
            this.button_Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.button_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Help.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Help.ForeColor = System.Drawing.Color.White;
            this.button_Help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Help.ImageIndex = 2;
            this.button_Help.ImageList = this.imageList1;
            this.button_Help.Location = new System.Drawing.Point(103, 665);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(348, 55);
            this.button_Help.TabIndex = 2;
            this.button_Help.TabStop = false;
            this.button_Help.Text = "   HELP";
            this.button_Help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Help.UseVisualStyleBackColor = false;
            this.button_Help.Click += new System.EventHandler(this.button_about_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_X);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 55);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button_X
            // 
            this.button_X.FlatAppearance.BorderSize = 0;
            this.button_X.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.button_X.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.button_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_X.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_X.Location = new System.Drawing.Point(497, 0);
            this.button_X.Name = "button_X";
            this.button_X.Size = new System.Drawing.Size(58, 49);
            this.button_X.TabIndex = 0;
            this.button_X.Text = "X";
            this.button_X.UseVisualStyleBackColor = true;
            this.button_X.Click += new System.EventHandler(this.button_X_Click);
            // 
            // label_nubGames
            // 
            this.label_nubGames.AutoSize = true;
            this.label_nubGames.Font = new System.Drawing.Font("Pristina", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nubGames.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_nubGames.Location = new System.Drawing.Point(422, 803);
            this.label_nubGames.Name = "label_nubGames";
            this.label_nubGames.Size = new System.Drawing.Size(124, 32);
            this.label_nubGames.TabIndex = 11;
            this.label_nubGames.Text = "NuB Games";
            // 
            // pictureBox_NumGames
            // 
            this.pictureBox_NumGames.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_NumGames.Image")));
            this.pictureBox_NumGames.Location = new System.Drawing.Point(445, 754);
            this.pictureBox_NumGames.Name = "pictureBox_NumGames";
            this.pictureBox_NumGames.Size = new System.Drawing.Size(78, 46);
            this.pictureBox_NumGames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_NumGames.TabIndex = 10;
            this.pictureBox_NumGames.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(68)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 3;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(103, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 55);
            this.button1.TabIndex = 14;
            this.button1.TabStop = false;
            this.button1.Text = "   SETTINGS";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicTacToe.Properties.Resources.X;
            this.pictureBox1.Location = new System.Drawing.Point(252, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TicTacToe.Properties.Resources.TicTacToe;
            this.pictureBox2.Location = new System.Drawing.Point(33, 289);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(490, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TicTacToe.Properties.Resources._0;
            this.pictureBox3.Location = new System.Drawing.Point(103, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(206, 222);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // Form_HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(556, 842);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_nubGames);
            this.Controls.Add(this.pictureBox_NumGames);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Help);
            this.Controls.Add(this.button_playWithFriend);
            this.Controls.Add(this.button_playWithComputer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_NumGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_playWithComputer;
        private System.Windows.Forms.Button button_playWithFriend;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_NumGames;
        private System.Windows.Forms.Label label_nubGames;
        private System.Windows.Forms.Button button_X;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

