namespace DubleASoftDrinks
{
    partial class newDelivery
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
            this.lbluserid = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvcritical = new MetroFramework.Controls.MetroGrid();
            this.tbID = new MetroFramework.Controls.MetroTextBox();
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.tbPrice = new MetroFramework.Controls.MetroTextBox();
            this.tbBrand = new MetroFramework.Controls.MetroTextBox();
            this.tbStock = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.tbFilter = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvcritical)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.ActiveControl = null;
            this.btnback.Location = new System.Drawing.Point(908, 18);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(41, 42);
            this.btnback.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnback.TabIndex = 30;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnback.TileImage = global::DubleASoftDrinks.Properties.Resources._1499167237_cancel;
            this.btnback.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnback.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnback.UseSelectable = true;
            this.btnback.UseTileImage = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbluserid.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbluserid.Location = new System.Drawing.Point(616, 9);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(17, 25);
            this.lbluserid.Style = MetroFramework.MetroColorStyle.Teal;
            this.lbluserid.TabIndex = 35;
            this.lbluserid.Text = ".";
            this.lbluserid.UseStyleColors = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFilter);
            this.groupBox1.Controls.Add(this.dtgvcritical);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 465);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product List";
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
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvcritical.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvcritical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvcritical.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvcritical.EnableHeadersVisualStyles = false;
            this.dtgvcritical.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgvcritical.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvcritical.Location = new System.Drawing.Point(10, 64);
            this.dtgvcritical.Name = "dtgvcritical";
            this.dtgvcritical.ReadOnly = true;
            this.dtgvcritical.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvcritical.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvcritical.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvcritical.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvcritical.Size = new System.Drawing.Size(575, 391);
            this.dtgvcritical.Style = MetroFramework.MetroColorStyle.Green;
            this.dtgvcritical.TabIndex = 0;
            this.dtgvcritical.UseStyleColors = true;
            this.dtgvcritical.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvcritical_CellContentDoubleClick);
            // 
            // tbID
            // 
            // 
            // 
            // 
            this.tbID.CustomButton.Image = null;
            this.tbID.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.tbID.CustomButton.Name = "";
            this.tbID.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.tbID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbID.CustomButton.TabIndex = 1;
            this.tbID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbID.CustomButton.UseSelectable = true;
            this.tbID.CustomButton.Visible = false;
            this.tbID.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbID.Lines = new string[0];
            this.tbID.Location = new System.Drawing.Point(688, 159);
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
            this.tbID.Size = new System.Drawing.Size(201, 33);
            this.tbID.TabIndex = 37;
            this.tbID.UseSelectable = true;
            this.tbID.WaterMark = "Product ID";
            this.tbID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbName
            // 
            // 
            // 
            // 
            this.tbName.CustomButton.Image = null;
            this.tbName.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.tbName.CustomButton.Name = "";
            this.tbName.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.tbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbName.CustomButton.TabIndex = 1;
            this.tbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbName.CustomButton.UseSelectable = true;
            this.tbName.CustomButton.Visible = false;
            this.tbName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbName.Lines = new string[0];
            this.tbName.Location = new System.Drawing.Point(688, 198);
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
            this.tbName.Size = new System.Drawing.Size(201, 33);
            this.tbName.TabIndex = 37;
            this.tbName.UseSelectable = true;
            this.tbName.WaterMark = "Product Name";
            this.tbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbPrice
            // 
            // 
            // 
            // 
            this.tbPrice.CustomButton.Image = null;
            this.tbPrice.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.tbPrice.CustomButton.Name = "";
            this.tbPrice.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.tbPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPrice.CustomButton.TabIndex = 1;
            this.tbPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPrice.CustomButton.UseSelectable = true;
            this.tbPrice.CustomButton.Visible = false;
            this.tbPrice.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbPrice.Lines = new string[0];
            this.tbPrice.Location = new System.Drawing.Point(688, 237);
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
            this.tbPrice.Size = new System.Drawing.Size(201, 33);
            this.tbPrice.TabIndex = 37;
            this.tbPrice.UseSelectable = true;
            this.tbPrice.WaterMark = "Price";
            this.tbPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbBrand
            // 
            // 
            // 
            // 
            this.tbBrand.CustomButton.Image = null;
            this.tbBrand.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.tbBrand.CustomButton.Name = "";
            this.tbBrand.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.tbBrand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbBrand.CustomButton.TabIndex = 1;
            this.tbBrand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbBrand.CustomButton.UseSelectable = true;
            this.tbBrand.CustomButton.Visible = false;
            this.tbBrand.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbBrand.Lines = new string[0];
            this.tbBrand.Location = new System.Drawing.Point(688, 276);
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
            this.tbBrand.Size = new System.Drawing.Size(201, 33);
            this.tbBrand.TabIndex = 37;
            this.tbBrand.UseSelectable = true;
            this.tbBrand.WaterMark = "Brand";
            this.tbBrand.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbBrand.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbStock
            // 
            // 
            // 
            // 
            this.tbStock.CustomButton.Image = null;
            this.tbStock.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.tbStock.CustomButton.Name = "";
            this.tbStock.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.tbStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbStock.CustomButton.TabIndex = 1;
            this.tbStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbStock.CustomButton.UseSelectable = true;
            this.tbStock.CustomButton.Visible = false;
            this.tbStock.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbStock.Lines = new string[0];
            this.tbStock.Location = new System.Drawing.Point(688, 315);
            this.tbStock.MaxLength = 32767;
            this.tbStock.Name = "tbStock";
            this.tbStock.PasswordChar = '\0';
            this.tbStock.PromptText = "Stock Delivered";
            this.tbStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbStock.SelectedText = "";
            this.tbStock.SelectionLength = 0;
            this.tbStock.SelectionStart = 0;
            this.tbStock.ShortcutsEnabled = true;
            this.tbStock.Size = new System.Drawing.Size(201, 33);
            this.tbStock.TabIndex = 37;
            this.tbStock.UseSelectable = true;
            this.tbStock.WaterMark = "Stock Delivered";
            this.tbStock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbStock.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStock_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(706, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 49);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(791, 354);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(79, 49);
            this.btnReset.TabIndex = 38;
            this.btnReset.Text = "Reset";
            this.btnReset.UseSelectable = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbFilter
            // 
            // 
            // 
            // 
            this.tbFilter.CustomButton.Image = null;
            this.tbFilter.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.tbFilter.CustomButton.Name = "";
            this.tbFilter.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbFilter.CustomButton.TabIndex = 1;
            this.tbFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbFilter.CustomButton.UseSelectable = true;
            this.tbFilter.CustomButton.Visible = false;
            this.tbFilter.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbFilter.Lines = new string[0];
            this.tbFilter.Location = new System.Drawing.Point(131, 20);
            this.tbFilter.MaxLength = 32767;
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.PasswordChar = '\0';
            this.tbFilter.PromptText = "Search";
            this.tbFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFilter.SelectedText = "";
            this.tbFilter.SelectionLength = 0;
            this.tbFilter.SelectionStart = 0;
            this.tbFilter.ShortcutsEnabled = true;
            this.tbFilter.Size = new System.Drawing.Size(195, 38);
            this.tbFilter.TabIndex = 39;
            this.tbFilter.UseSelectable = true;
            this.tbFilter.WaterMark = "Search";
            this.tbFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // newDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 541);
            this.ControlBox = false;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.btnback);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "newDelivery";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "New Delivery";
            this.Load += new System.EventHandler(this.newDelivery_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvcritical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnback;
        private MetroFramework.Controls.MetroLabel lbluserid;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid dtgvcritical;
        private MetroFramework.Controls.MetroTextBox tbID;
        private MetroFramework.Controls.MetroTextBox tbName;
        private MetroFramework.Controls.MetroTextBox tbPrice;
        private MetroFramework.Controls.MetroTextBox tbBrand;
        private MetroFramework.Controls.MetroTextBox tbStock;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnReset;
        private MetroFramework.Controls.MetroTextBox tbFilter;
    }
}