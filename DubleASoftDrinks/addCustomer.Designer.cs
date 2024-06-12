namespace DubleASoftDrinks
{
    partial class addCustomer
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
            this.tbContact = new MetroFramework.Controls.MetroTextBox();
            this.tbAddress = new MetroFramework.Controls.MetroTextBox();
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.tbID = new MetroFramework.Controls.MetroTextBox();
            this.btnback = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.lbluserid = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // tbContact
            // 
            // 
            // 
            // 
            this.tbContact.CustomButton.Image = null;
            this.tbContact.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.tbContact.CustomButton.Name = "";
            this.tbContact.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbContact.CustomButton.TabIndex = 1;
            this.tbContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbContact.CustomButton.UseSelectable = true;
            this.tbContact.CustomButton.Visible = false;
            this.tbContact.Lines = new string[0];
            this.tbContact.Location = new System.Drawing.Point(89, 260);
            this.tbContact.MaxLength = 32767;
            this.tbContact.Name = "tbContact";
            this.tbContact.PasswordChar = '\0';
            this.tbContact.PromptText = "Contact Number";
            this.tbContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbContact.SelectedText = "";
            this.tbContact.SelectionLength = 0;
            this.tbContact.SelectionStart = 0;
            this.tbContact.ShortcutsEnabled = true;
            this.tbContact.Size = new System.Drawing.Size(237, 35);
            this.tbContact.TabIndex = 12;
            this.tbContact.UseSelectable = true;
            this.tbContact.WaterMark = "Contact Number";
            this.tbContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbContact_KeyPress);
            // 
            // tbAddress
            // 
            // 
            // 
            // 
            this.tbAddress.CustomButton.Image = null;
            this.tbAddress.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tbAddress.CustomButton.Name = "";
            this.tbAddress.CustomButton.Size = new System.Drawing.Size(81, 81);
            this.tbAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAddress.CustomButton.TabIndex = 1;
            this.tbAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAddress.CustomButton.UseSelectable = true;
            this.tbAddress.CustomButton.Visible = false;
            this.tbAddress.Lines = new string[0];
            this.tbAddress.Location = new System.Drawing.Point(89, 168);
            this.tbAddress.MaxLength = 32767;
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.PasswordChar = '\0';
            this.tbAddress.PromptText = "Address";
            this.tbAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAddress.SelectedText = "";
            this.tbAddress.SelectionLength = 0;
            this.tbAddress.SelectionStart = 0;
            this.tbAddress.ShortcutsEnabled = true;
            this.tbAddress.Size = new System.Drawing.Size(237, 86);
            this.tbAddress.TabIndex = 13;
            this.tbAddress.UseSelectable = true;
            this.tbAddress.WaterMark = "Address";
            this.tbAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddress_KeyPress);
            // 
            // tbName
            // 
            // 
            // 
            // 
            this.tbName.CustomButton.Image = null;
            this.tbName.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.tbName.CustomButton.Name = "";
            this.tbName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbName.CustomButton.TabIndex = 1;
            this.tbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbName.CustomButton.UseSelectable = true;
            this.tbName.CustomButton.Visible = false;
            this.tbName.Lines = new string[0];
            this.tbName.Location = new System.Drawing.Point(89, 127);
            this.tbName.MaxLength = 32767;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PromptText = "Name";
            this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.ShortcutsEnabled = true;
            this.tbName.Size = new System.Drawing.Size(237, 35);
            this.tbName.TabIndex = 14;
            this.tbName.UseSelectable = true;
            this.tbName.WaterMark = "Name";
            this.tbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
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
            this.tbID.Location = new System.Drawing.Point(89, 86);
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
            this.tbID.TabIndex = 15;
            this.tbID.UseSelectable = true;
            this.tbID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnback
            // 
            this.btnback.ActiveControl = null;
            this.btnback.Location = new System.Drawing.Point(376, 9);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(41, 42);
            this.btnback.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnback.TabIndex = 17;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnback.TileImage = global::DubleASoftDrinks.Properties.Resources._1499167237_cancel;
            this.btnback.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnback.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnback.UseSelectable = true;
            this.btnback.UseTileImage = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.White;
            this.metroTile1.Location = new System.Drawing.Point(168, 301);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(84, 52);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 16;
            this.metroTile1.Text = "Save";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile1.TileImage = global::DubleASoftDrinks.Properties.Resources.if_editor_floopy_dish_save_glyph_763361;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbluserid.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbluserid.Location = new System.Drawing.Point(267, 9);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(17, 25);
            this.lbluserid.Style = MetroFramework.MetroColorStyle.Teal;
            this.lbluserid.TabIndex = 18;
            this.lbluserid.Text = ".";
            this.lbluserid.UseStyleColors = true;
            // 
            // addCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 439);
            this.ControlBox = false;
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "addCustomer";
            this.Resizable = false;
            this.Text = "New Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addCustomer_FormClosing);
            this.Load += new System.EventHandler(this.addCustomer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addCustomer_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox tbContact;
        private MetroFramework.Controls.MetroTextBox tbAddress;
        private MetroFramework.Controls.MetroTextBox tbName;
        private MetroFramework.Controls.MetroTextBox tbID;
        private MetroFramework.Controls.MetroTile btnback;
        private MetroFramework.Controls.MetroLabel lbluserid;
    }
}