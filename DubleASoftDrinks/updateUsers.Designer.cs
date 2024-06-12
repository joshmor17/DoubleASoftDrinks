namespace DubleASoftDrinks
{
    partial class updateUsers
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
            this.cboDescription = new MetroFramework.Controls.MetroComboBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.tbLname = new MetroFramework.Controls.MetroTextBox();
            this.tbID = new MetroFramework.Controls.MetroTextBox();
            this.btnback = new MetroFramework.Controls.MetroTile();
            this.cboStatus = new MetroFramework.Controls.MetroComboBox();
            this.lbluserid = new MetroFramework.Controls.MetroLabel();
            this.tbFname = new MetroFramework.Controls.MetroTextBox();
            this.tbMname = new MetroFramework.Controls.MetroTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cboDescription
            // 
            this.cboDescription.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cboDescription.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cboDescription.FormattingEnabled = true;
            this.cboDescription.ItemHeight = 29;
            this.cboDescription.Items.AddRange(new object[] {
            "Admin",
            "Clerk"});
            this.cboDescription.Location = new System.Drawing.Point(94, 328);
            this.cboDescription.Name = "cboDescription";
            this.cboDescription.Size = new System.Drawing.Size(237, 35);
            this.cboDescription.TabIndex = 32;
            this.cboDescription.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.White;
            this.metroTile2.Location = new System.Drawing.Point(170, 369);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(84, 52);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile2.TabIndex = 31;
            this.metroTile2.Text = "Save";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile2.TileImage = global::DubleASoftDrinks.Properties.Resources.if_editor_floopy_dish_save_glyph_763361;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // tbPassword
            // 
            // 
            // 
            // 
            this.tbPassword.CustomButton.Image = null;
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword.CustomButton.TabIndex = 1;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.CustomButton.Visible = false;
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(94, 246);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.PromptText = "Password";
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(237, 35);
            this.tbPassword.TabIndex = 28;
            this.tbPassword.UseSelectable = true;
            this.tbPassword.WaterMark = "Password";
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            // 
            // tbLname
            // 
            // 
            // 
            // 
            this.tbLname.CustomButton.Image = null;
            this.tbLname.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.tbLname.CustomButton.Name = "";
            this.tbLname.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbLname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLname.CustomButton.TabIndex = 1;
            this.tbLname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLname.CustomButton.UseSelectable = true;
            this.tbLname.CustomButton.Visible = false;
            this.tbLname.Lines = new string[0];
            this.tbLname.Location = new System.Drawing.Point(94, 123);
            this.tbLname.MaxLength = 32767;
            this.tbLname.Name = "tbLname";
            this.tbLname.PasswordChar = '\0';
            this.tbLname.PromptText = "Last Name";
            this.tbLname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLname.SelectedText = "";
            this.tbLname.SelectionLength = 0;
            this.tbLname.SelectionStart = 0;
            this.tbLname.ShortcutsEnabled = true;
            this.tbLname.Size = new System.Drawing.Size(237, 35);
            this.tbLname.TabIndex = 29;
            this.tbLname.UseSelectable = true;
            this.tbLname.WaterMark = "Last Name";
            this.tbLname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // tbID
            // 
            // 
            // 
            // 
            this.tbID.CustomButton.Image = null;
            this.tbID.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.tbID.CustomButton.Name = "";
            this.tbID.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbID.CustomButton.TabIndex = 1;
            this.tbID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbID.CustomButton.UseSelectable = true;
            this.tbID.CustomButton.Visible = false;
            this.tbID.Lines = new string[0];
            this.tbID.Location = new System.Drawing.Point(94, 82);
            this.tbID.MaxLength = 32767;
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.ReadOnly = true;
            this.tbID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbID.SelectedText = "";
            this.tbID.SelectionLength = 0;
            this.tbID.SelectionStart = 0;
            this.tbID.ShortcutsEnabled = true;
            this.tbID.Size = new System.Drawing.Size(237, 35);
            this.tbID.TabIndex = 30;
            this.tbID.UseSelectable = true;
            this.tbID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnback
            // 
            this.btnback.ActiveControl = null;
            this.btnback.Location = new System.Drawing.Point(377, 7);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(41, 42);
            this.btnback.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnback.TabIndex = 33;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnback.TileImage = global::DubleASoftDrinks.Properties.Resources._1499167237_cancel;
            this.btnback.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnback.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnback.UseSelectable = true;
            this.btnback.UseTileImage = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cboStatus.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.ItemHeight = 29;
            this.cboStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboStatus.Location = new System.Drawing.Point(94, 287);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(237, 35);
            this.cboStatus.TabIndex = 34;
            this.cboStatus.UseSelectable = true;
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbluserid.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbluserid.Location = new System.Drawing.Point(197, 24);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(17, 25);
            this.lbluserid.Style = MetroFramework.MetroColorStyle.Teal;
            this.lbluserid.TabIndex = 35;
            this.lbluserid.Text = ".";
            this.lbluserid.UseStyleColors = true;
            // 
            // tbFname
            // 
            // 
            // 
            // 
            this.tbFname.CustomButton.Image = null;
            this.tbFname.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.tbFname.CustomButton.Name = "";
            this.tbFname.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbFname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbFname.CustomButton.TabIndex = 1;
            this.tbFname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbFname.CustomButton.UseSelectable = true;
            this.tbFname.CustomButton.Visible = false;
            this.tbFname.Lines = new string[0];
            this.tbFname.Location = new System.Drawing.Point(94, 164);
            this.tbFname.MaxLength = 32767;
            this.tbFname.Name = "tbFname";
            this.tbFname.PasswordChar = '\0';
            this.tbFname.PromptText = "First Name";
            this.tbFname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFname.SelectedText = "";
            this.tbFname.SelectionLength = 0;
            this.tbFname.SelectionStart = 0;
            this.tbFname.ShortcutsEnabled = true;
            this.tbFname.Size = new System.Drawing.Size(237, 35);
            this.tbFname.TabIndex = 29;
            this.tbFname.UseSelectable = true;
            this.tbFname.WaterMark = "First Name";
            this.tbFname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbFname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFname_KeyPress);
            // 
            // tbMname
            // 
            // 
            // 
            // 
            this.tbMname.CustomButton.Image = null;
            this.tbMname.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.tbMname.CustomButton.Name = "";
            this.tbMname.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbMname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMname.CustomButton.TabIndex = 1;
            this.tbMname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMname.CustomButton.UseSelectable = true;
            this.tbMname.CustomButton.Visible = false;
            this.tbMname.Lines = new string[0];
            this.tbMname.Location = new System.Drawing.Point(94, 205);
            this.tbMname.MaxLength = 32767;
            this.tbMname.Name = "tbMname";
            this.tbMname.PasswordChar = '\0';
            this.tbMname.PromptText = "Middle Name";
            this.tbMname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMname.SelectedText = "";
            this.tbMname.SelectionLength = 0;
            this.tbMname.SelectionStart = 0;
            this.tbMname.ShortcutsEnabled = true;
            this.tbMname.Size = new System.Drawing.Size(237, 35);
            this.tbMname.TabIndex = 29;
            this.tbMname.UseSelectable = true;
            this.tbMname.WaterMark = "Middle Name";
            this.tbMname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbMname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMname_KeyPress);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(337, 246);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 25);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // updateUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 439);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.cboDescription);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbMname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.tbID);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "updateUsers";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.updateUsers_FormClosing);
            this.Load += new System.EventHandler(this.updateUsers_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.updateUsers_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cboDescription;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTextBox tbPassword;
        private MetroFramework.Controls.MetroTextBox tbLname;
        private MetroFramework.Controls.MetroTextBox tbID;
        private MetroFramework.Controls.MetroTile btnback;
        private MetroFramework.Controls.MetroComboBox cboStatus;
        private MetroFramework.Controls.MetroLabel lbluserid;
        private MetroFramework.Controls.MetroTextBox tbFname;
        private MetroFramework.Controls.MetroTextBox tbMname;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}