namespace DubleASoftDrinks
{
    partial class Login
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
            this.tbpass = new MetroFramework.Controls.MetroTextBox();
            this.lbl1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbuser = new MetroFramework.Controls.MetroTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlog = new MetroFramework.Controls.MetroTile();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpass
            // 
            // 
            // 
            // 
            this.tbpass.CustomButton.Image = null;
            this.tbpass.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.tbpass.CustomButton.Name = "";
            this.tbpass.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbpass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbpass.CustomButton.TabIndex = 1;
            this.tbpass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbpass.CustomButton.UseSelectable = true;
            this.tbpass.DisplayIcon = true;
            this.tbpass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbpass.IconRight = true;
            this.tbpass.Lines = new string[0];
            this.tbpass.Location = new System.Drawing.Point(126, 215);
            this.tbpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpass.MaxLength = 32767;
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '*';
            this.tbpass.PromptText = "Password";
            this.tbpass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbpass.SelectedText = "";
            this.tbpass.SelectionLength = 0;
            this.tbpass.SelectionStart = 0;
            this.tbpass.ShortcutsEnabled = true;
            this.tbpass.ShowButton = true;
            this.tbpass.ShowClearButton = true;
            this.tbpass.Size = new System.Drawing.Size(176, 35);
            this.tbpass.Style = MetroFramework.MetroColorStyle.Teal;
            this.tbpass.TabIndex = 2;
            this.tbpass.UseSelectable = true;
            this.tbpass.WaterMark = "Password";
            this.tbpass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbpass.WaterMarkFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpass_KeyPress);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl1.Location = new System.Drawing.Point(277, 312);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(111, 25);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "metroLabel1";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Teal;
            this.metroLabel1.Location = new System.Drawing.Point(126, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(216, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Welcome! Please Log-In";
            this.metroLabel1.UseStyleColors = true;
            // 
            // tbuser
            // 
            // 
            // 
            // 
            this.tbuser.CustomButton.Image = null;
            this.tbuser.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.tbuser.CustomButton.Name = "";
            this.tbuser.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbuser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbuser.CustomButton.TabIndex = 1;
            this.tbuser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbuser.CustomButton.UseSelectable = true;
            this.tbuser.DisplayIcon = true;
            this.tbuser.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbuser.IconRight = true;
            this.tbuser.Lines = new string[0];
            this.tbuser.Location = new System.Drawing.Point(126, 170);
            this.tbuser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbuser.MaxLength = 32767;
            this.tbuser.Name = "tbuser";
            this.tbuser.PasswordChar = '\0';
            this.tbuser.PromptText = "User ID";
            this.tbuser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbuser.SelectedText = "";
            this.tbuser.SelectionLength = 0;
            this.tbuser.SelectionStart = 0;
            this.tbuser.ShortcutsEnabled = true;
            this.tbuser.ShowButton = true;
            this.tbuser.ShowClearButton = true;
            this.tbuser.Size = new System.Drawing.Size(176, 35);
            this.tbuser.Style = MetroFramework.MetroColorStyle.Teal;
            this.tbuser.TabIndex = 1;
            this.tbuser.UseSelectable = true;
            this.tbuser.WaterMark = "User ID";
            this.tbuser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbuser.WaterMarkFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbuser_KeyPress);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(86, 255);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(117, 16);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(440, 12);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(41, 42);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile1.TabIndex = 5;
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileImage = global::DubleASoftDrinks.Properties.Resources._1499167213_icons_exit2;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DubleASoftDrinks.Properties.Resources._1499163217_Authorisation_lock_padlock_password_privacy_safe_security;
            this.pictureBox2.Location = new System.Drawing.Point(90, 215);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DubleASoftDrinks.Properties.Resources._1499163327_Account;
            this.pictureBox1.Location = new System.Drawing.Point(90, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnlog
            // 
            this.btnlog.ActiveControl = null;
            this.btnlog.Location = new System.Drawing.Point(309, 170);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(79, 80);
            this.btnlog.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnlog.TabIndex = 3;
            this.btnlog.Text = "Login";
            this.btnlog.TileImage = global::DubleASoftDrinks.Properties.Resources._1499163592_login;
            this.btnlog.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlog.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnlog.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnlog.UseSelectable = true;
            this.btnlog.UseTileImage = true;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 348);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbuser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Double A Softdrinks Dealer";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbuser;
        private MetroFramework.Controls.MetroTextBox tbpass;
        private MetroFramework.Controls.MetroTile btnlog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel lbl1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}

