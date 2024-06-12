namespace DubleASoftDrinks
{
    partial class addStocks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnback = new MetroFramework.Controls.MetroTile();
            this.tbPrice = new MetroFramework.Controls.MetroTextBox();
            this.tbID = new MetroFramework.Controls.MetroTextBox();
            this.tbCurrent = new MetroFramework.Controls.MetroTextBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.lbl5 = new MetroFramework.Controls.MetroLabel();
            this.lbluserid = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvcritical = new MetroFramework.Controls.MetroGrid();
            this.tbBrand = new MetroFramework.Controls.MetroTextBox();
            this.tbStockDelivered = new MetroFramework.Controls.MetroTextBox();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.tbadd = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvcritical)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.ActiveControl = null;
            this.btnback.Location = new System.Drawing.Point(868, 8);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(41, 42);
            this.btnback.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnback.TabIndex = 46;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnback.TileImage = global::DubleASoftDrinks.Properties.Resources._1499167237_cancel;
            this.btnback.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnback.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnback.UseSelectable = true;
            this.btnback.UseTileImage = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // tbPrice
            // 
            // 
            // 
            // 
            this.tbPrice.CustomButton.Image = null;
            this.tbPrice.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.tbPrice.CustomButton.Name = "";
            this.tbPrice.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPrice.CustomButton.TabIndex = 1;
            this.tbPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPrice.CustomButton.UseSelectable = true;
            this.tbPrice.CustomButton.Visible = false;
            this.tbPrice.Lines = new string[0];
            this.tbPrice.Location = new System.Drawing.Point(645, 243);
            this.tbPrice.MaxLength = 32767;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.PromptText = "Price";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPrice.SelectedText = "";
            this.tbPrice.SelectionLength = 0;
            this.tbPrice.SelectionStart = 0;
            this.tbPrice.ShortcutsEnabled = true;
            this.tbPrice.Size = new System.Drawing.Size(237, 35);
            this.tbPrice.TabIndex = 48;
            this.tbPrice.UseSelectable = true;
            this.tbPrice.WaterMark = "Price";
            this.tbPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
           
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
            this.tbID.Location = new System.Drawing.Point(645, 120);
            this.tbID.MaxLength = 32767;
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.PromptText = "Product ID";
            this.tbID.ReadOnly = true;
            this.tbID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbID.SelectedText = "";
            this.tbID.SelectionLength = 0;
            this.tbID.SelectionStart = 0;
            this.tbID.ShortcutsEnabled = true;
            this.tbID.Size = new System.Drawing.Size(237, 35);
            this.tbID.TabIndex = 47;
            this.tbID.UseSelectable = true;
            this.tbID.WaterMark = "Product ID";
            this.tbID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // tbCurrent
            // 
            // 
            // 
            // 
            this.tbCurrent.CustomButton.Image = null;
            this.tbCurrent.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.tbCurrent.CustomButton.Name = "";
            this.tbCurrent.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbCurrent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCurrent.CustomButton.TabIndex = 1;
            this.tbCurrent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCurrent.CustomButton.UseSelectable = true;
            this.tbCurrent.CustomButton.Visible = false;
            this.tbCurrent.Lines = new string[0];
            this.tbCurrent.Location = new System.Drawing.Point(645, 202);
            this.tbCurrent.MaxLength = 32767;
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.PasswordChar = '\0';
            this.tbCurrent.PromptText = "Current Stocks";
            this.tbCurrent.ReadOnly = true;
            this.tbCurrent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCurrent.SelectedText = "";
            this.tbCurrent.SelectionLength = 0;
            this.tbCurrent.SelectionStart = 0;
            this.tbCurrent.ShortcutsEnabled = true;
            this.tbCurrent.Size = new System.Drawing.Size(237, 35);
            this.tbCurrent.TabIndex = 47;
            this.tbCurrent.UseSelectable = true;
            this.tbCurrent.WaterMark = "Current Stocks";
            this.tbCurrent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCurrent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.White;
            this.metroTile2.Location = new System.Drawing.Point(678, 421);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(84, 52);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile2.TabIndex = 49;
            this.metroTile2.Text = "Save";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile2.TileImage = global::DubleASoftDrinks.Properties.Resources.if_editor_floopy_dish_save_glyph_763361;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
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
            this.tbName.Location = new System.Drawing.Point(645, 161);
            this.tbName.MaxLength = 32767;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PromptText = "Product Name";
            this.tbName.ReadOnly = true;
            this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.ShortcutsEnabled = true;
            this.tbName.Size = new System.Drawing.Size(237, 35);
            this.tbName.TabIndex = 47;
            this.tbName.UseSelectable = true;
            this.tbName.WaterMark = "Product Name";
            this.tbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(747, 19);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(83, 19);
            this.lbl5.TabIndex = 51;
            this.lbl5.Text = "metroLabel5";
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbluserid.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbluserid.Location = new System.Drawing.Point(662, 25);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(17, 25);
            this.lbluserid.Style = MetroFramework.MetroColorStyle.Teal;
            this.lbluserid.TabIndex = 52;
            this.lbluserid.Text = ".";
            this.lbluserid.UseStyleColors = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvcritical);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 407);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Delivered";
            // 
            // dtgvcritical
            // 
            this.dtgvcritical.AllowUserToAddRows = false;
            this.dtgvcritical.AllowUserToDeleteRows = false;
            this.dtgvcritical.AllowUserToResizeRows = false;
            this.dtgvcritical.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvcritical.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvcritical.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvcritical.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvcritical.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvcritical.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvcritical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvcritical.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvcritical.EnableHeadersVisualStyles = false;
            this.dtgvcritical.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgvcritical.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvcritical.Location = new System.Drawing.Point(6, 29);
            this.dtgvcritical.Name = "dtgvcritical";
            this.dtgvcritical.ReadOnly = true;
            this.dtgvcritical.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvcritical.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvcritical.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvcritical.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvcritical.Size = new System.Drawing.Size(579, 372);
            this.dtgvcritical.Style = MetroFramework.MetroColorStyle.Yellow;
            this.dtgvcritical.TabIndex = 0;
            this.dtgvcritical.UseStyleColors = true;
            this.dtgvcritical.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvcritical_CellContentDoubleClick);
            // 
            // tbBrand
            // 
            // 
            // 
            // 
            this.tbBrand.CustomButton.Image = null;
            this.tbBrand.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.tbBrand.CustomButton.Name = "";
            this.tbBrand.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbBrand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbBrand.CustomButton.TabIndex = 1;
            this.tbBrand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbBrand.CustomButton.UseSelectable = true;
            this.tbBrand.CustomButton.Visible = false;
            this.tbBrand.Lines = new string[0];
            this.tbBrand.Location = new System.Drawing.Point(645, 284);
            this.tbBrand.MaxLength = 32767;
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.PasswordChar = '\0';
            this.tbBrand.PromptText = "Brand";
            this.tbBrand.ReadOnly = true;
            this.tbBrand.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbBrand.SelectedText = "";
            this.tbBrand.SelectionLength = 0;
            this.tbBrand.SelectionStart = 0;
            this.tbBrand.ShortcutsEnabled = true;
            this.tbBrand.Size = new System.Drawing.Size(237, 35);
            this.tbBrand.TabIndex = 48;
            this.tbBrand.UseSelectable = true;
            this.tbBrand.WaterMark = "Brand";
            this.tbBrand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbBrand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
     
            // 
            // tbStockDelivered
            // 
            // 
            // 
            // 
            this.tbStockDelivered.CustomButton.Image = null;
            this.tbStockDelivered.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.tbStockDelivered.CustomButton.Name = "";
            this.tbStockDelivered.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbStockDelivered.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbStockDelivered.CustomButton.TabIndex = 1;
            this.tbStockDelivered.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbStockDelivered.CustomButton.UseSelectable = true;
            this.tbStockDelivered.CustomButton.Visible = false;
            this.tbStockDelivered.Lines = new string[0];
            this.tbStockDelivered.Location = new System.Drawing.Point(645, 325);
            this.tbStockDelivered.MaxLength = 32767;
            this.tbStockDelivered.Name = "tbStockDelivered";
            this.tbStockDelivered.PasswordChar = '\0';
            this.tbStockDelivered.PromptText = "Stock Delivered";
            this.tbStockDelivered.ReadOnly = true;
            this.tbStockDelivered.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbStockDelivered.SelectedText = "";
            this.tbStockDelivered.SelectionLength = 0;
            this.tbStockDelivered.SelectionStart = 0;
            this.tbStockDelivered.ShortcutsEnabled = true;
            this.tbStockDelivered.Size = new System.Drawing.Size(237, 35);
            this.tbStockDelivered.TabIndex = 48;
            this.tbStockDelivered.UseSelectable = true;
            this.tbStockDelivered.WaterMark = "Stock Delivered";
            this.tbStockDelivered.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbStockDelivered.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
       
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(768, 421);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 52);
            this.btnReset.TabIndex = 55;
            this.btnReset.Text = "Reset";
            this.btnReset.UseSelectable = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbadd
            // 
            // 
            // 
            // 
            this.tbadd.CustomButton.Image = null;
            this.tbadd.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.tbadd.CustomButton.Name = "";
            this.tbadd.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbadd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbadd.CustomButton.TabIndex = 1;
            this.tbadd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbadd.CustomButton.UseSelectable = true;
            this.tbadd.CustomButton.Visible = false;
            this.tbadd.Lines = new string[0];
            this.tbadd.Location = new System.Drawing.Point(645, 366);
            this.tbadd.MaxLength = 32767;
            this.tbadd.Name = "tbadd";
            this.tbadd.PasswordChar = '\0';
            this.tbadd.PromptText = "Add Stocks";
            this.tbadd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbadd.SelectedText = "";
            this.tbadd.SelectionLength = 0;
            this.tbadd.SelectionStart = 0;
            this.tbadd.ShortcutsEnabled = true;
            this.tbadd.Size = new System.Drawing.Size(237, 35);
            this.tbadd.TabIndex = 48;
            this.tbadd.UseSelectable = true;
            this.tbadd.WaterMark = "Add Stocks";
            this.tbadd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbadd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbadd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbadd_KeyPress);
            // 
            // addStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 553);
            this.ControlBox = false;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.tbadd);
            this.Controls.Add(this.tbStockDelivered);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbCurrent);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnback);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "addStocks";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "New Stocks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addStocks_FormClosing);
            this.Load += new System.EventHandler(this.updateStocks_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addStocks_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvcritical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnback;
        private MetroFramework.Controls.MetroTextBox tbPrice;
        private MetroFramework.Controls.MetroTextBox tbID;
        private MetroFramework.Controls.MetroTextBox tbCurrent;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTextBox tbName;
        private MetroFramework.Controls.MetroLabel lbl5;
        private MetroFramework.Controls.MetroLabel lbluserid;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid dtgvcritical;
        private MetroFramework.Controls.MetroTextBox tbBrand;
        private MetroFramework.Controls.MetroTextBox tbStockDelivered;
        private MetroFramework.Controls.MetroButton btnReset;
        private MetroFramework.Controls.MetroTextBox tbadd;
    }
}