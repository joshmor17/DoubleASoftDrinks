namespace DubleASoftDrinks
{
    partial class updateOngoing
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
            this.btnback = new MetroFramework.Controls.MetroTile();
            this.lbl5 = new MetroFramework.Controls.MetroLabel();
            this.lbluserid = new MetroFramework.Controls.MetroLabel();
            this.lblquantity = new MetroFramework.Controls.MetroLabel();
            this.lblprodID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbostatus = new MetroFramework.Controls.MetroComboBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.tbID = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.ActiveControl = null;
            this.btnback.Location = new System.Drawing.Point(377, 7);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(41, 42);
            this.btnback.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnback.TabIndex = 47;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnback.TileImage = global::DubleASoftDrinks.Properties.Resources._1499167237_cancel;
            this.btnback.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnback.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnback.UseSelectable = true;
            this.btnback.UseTileImage = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl5.Location = new System.Drawing.Point(268, 32);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(17, 25);
            this.lbl5.Style = MetroFramework.MetroColorStyle.Teal;
            this.lbl5.TabIndex = 52;
            this.lbl5.Text = ".";
            this.lbl5.UseStyleColors = true;
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbluserid.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbluserid.Location = new System.Drawing.Point(268, 7);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(17, 25);
            this.lbluserid.Style = MetroFramework.MetroColorStyle.Teal;
            this.lbluserid.TabIndex = 53;
            this.lbluserid.Text = ".";
            this.lbluserid.UseStyleColors = true;
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblquantity.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblquantity.Location = new System.Drawing.Point(240, 85);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(84, 25);
            this.lblquantity.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblquantity.TabIndex = 54;
            this.lblquantity.Text = "quantity";
            this.lblquantity.UseStyleColors = true;
            // 
            // lblprodID
            // 
            this.lblprodID.AutoSize = true;
            this.lblprodID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblprodID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblprodID.Location = new System.Drawing.Point(240, 60);
            this.lblprodID.Name = "lblprodID";
            this.lblprodID.Size = new System.Drawing.Size(71, 25);
            this.lblprodID.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblprodID.TabIndex = 55;
            this.lblprodID.Text = "ProdID";
            this.lblprodID.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(76, 182);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 25);
            this.metroLabel2.TabIndex = 59;
            this.metroLabel2.Text = "Status:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(35, 141);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 25);
            this.metroLabel1.TabIndex = 60;
            this.metroLabel1.Text = "Receipt No:";
            // 
            // cbostatus
            // 
            this.cbostatus.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cbostatus.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cbostatus.FormattingEnabled = true;
            this.cbostatus.ItemHeight = 29;
            this.cbostatus.Items.AddRange(new object[] {
            "Paid"});
            this.cbostatus.Location = new System.Drawing.Point(152, 172);
            this.cbostatus.Name = "cbostatus";
            this.cbostatus.Size = new System.Drawing.Size(199, 35);
            this.cbostatus.TabIndex = 58;
            this.cbostatus.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.White;
            this.metroTile2.Location = new System.Drawing.Point(208, 213);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(84, 52);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile2.TabIndex = 57;
            this.metroTile2.Text = "Save";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile2.TileImage = global::DubleASoftDrinks.Properties.Resources.if_editor_floopy_dish_save_glyph_763361;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // tbID
            // 
            // 
            // 
            // 
            this.tbID.CustomButton.Image = null;
            this.tbID.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.tbID.CustomButton.Name = "";
            this.tbID.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbID.CustomButton.TabIndex = 1;
            this.tbID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbID.CustomButton.UseSelectable = true;
            this.tbID.CustomButton.Visible = false;
            this.tbID.Lines = new string[0];
            this.tbID.Location = new System.Drawing.Point(152, 131);
            this.tbID.MaxLength = 32767;
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.ReadOnly = true;
            this.tbID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbID.SelectedText = "";
            this.tbID.SelectionLength = 0;
            this.tbID.SelectionStart = 0;
            this.tbID.ShortcutsEnabled = true;
            this.tbID.Size = new System.Drawing.Size(199, 35);
            this.tbID.TabIndex = 56;
            this.tbID.UseSelectable = true;
            this.tbID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // updateOngoing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 290);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbostatus);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblquantity);
            this.Controls.Add(this.lblprodID);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.btnback);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "updateOngoing";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Edit Status";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.updateOngoing_FormClosing);
            this.Load += new System.EventHandler(this.updateOngoing_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.updateOngoing_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnback;
        private MetroFramework.Controls.MetroLabel lbl5;
        private MetroFramework.Controls.MetroLabel lbluserid;
        private MetroFramework.Controls.MetroLabel lblquantity;
        private MetroFramework.Controls.MetroLabel lblprodID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbostatus;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTextBox tbID;
    }
}