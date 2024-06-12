namespace DubleASoftDrinks
{
    partial class Orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnback = new MetroFramework.Controls.MetroTile();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv1 = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFilter = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCustomer = new MetroFramework.Controls.MetroTextBox();
            this.dtgv2 = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tbTotal = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblname = new MetroFramework.Controls.MetroLabel();
            this.lbluserid = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbsearchcust = new MetroFramework.Controls.MetroTextBox();
            this.dtgvcustomer = new MetroFramework.Controls.MetroGrid();
            this.lbltransID = new MetroFramework.Controls.MetroLabel();
            this.metrolabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnpending = new MetroFramework.Controls.MetroButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.ActiveControl = null;
            this.btnback.Location = new System.Drawing.Point(1321, 8);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(41, 42);
            this.btnback.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnback.TabIndex = 28;
            this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnback.TileImage = global::DubleASoftDrinks.Properties.Resources._1499167237_cancel;
            this.btnback.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnback.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnback.UseSelectable = true;
            this.btnback.UseTileImage = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv1);
            this.groupBox2.Controls.Add(this.tbFilter);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(23, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 364);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // dtgv1
            // 
            this.dtgv1.AllowUserToAddRows = false;
            this.dtgv1.AllowUserToDeleteRows = false;
            this.dtgv1.AllowUserToResizeColumns = false;
            this.dtgv1.AllowUserToResizeRows = false;
            this.dtgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv1.EnableHeadersVisualStyles = false;
            this.dtgv1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgv1.Location = new System.Drawing.Point(6, 73);
            this.dtgv1.Name = "dtgv1";
            this.dtgv1.ReadOnly = true;
            this.dtgv1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv1.Size = new System.Drawing.Size(685, 285);
            this.dtgv1.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtgv1.TabIndex = 10;
            this.dtgv1.UseStyleColors = true;
            this.dtgv1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv1_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Brand";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price/Case";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Stocks";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // tbFilter
            // 
            // 
            // 
            // 
            this.tbFilter.CustomButton.Image = null;
            this.tbFilter.CustomButton.Location = new System.Drawing.Point(158, 2);
            this.tbFilter.CustomButton.Name = "";
            this.tbFilter.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbFilter.CustomButton.TabIndex = 1;
            this.tbFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbFilter.CustomButton.UseSelectable = true;
            this.tbFilter.CustomButton.Visible = false;
            this.tbFilter.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbFilter.Lines = new string[0];
            this.tbFilter.Location = new System.Drawing.Point(6, 39);
            this.tbFilter.MaxLength = 32767;
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.PasswordChar = '\0';
            this.tbFilter.PromptText = "Search";
            this.tbFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFilter.SelectedText = "";
            this.tbFilter.SelectionLength = 0;
            this.tbFilter.SelectionStart = 0;
            this.tbFilter.ShortcutsEnabled = true;
            this.tbFilter.Size = new System.Drawing.Size(184, 28);
            this.tbFilter.TabIndex = 2;
            this.tbFilter.UseSelectable = true;
            this.tbFilter.WaterMark = "Search";
            this.tbFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCustomer);
            this.groupBox1.Controls.Add(this.dtgv2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(726, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 364);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cart";
            // 
            // tbCustomer
            // 
            // 
            // 
            // 
            this.tbCustomer.CustomButton.Image = null;
            this.tbCustomer.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.tbCustomer.CustomButton.Name = "";
            this.tbCustomer.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tbCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCustomer.CustomButton.TabIndex = 1;
            this.tbCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCustomer.CustomButton.UseSelectable = true;
            this.tbCustomer.CustomButton.Visible = false;
            this.tbCustomer.Lines = new string[0];
            this.tbCustomer.Location = new System.Drawing.Point(6, 40);
            this.tbCustomer.MaxLength = 32767;
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.PasswordChar = '\0';
            this.tbCustomer.PromptText = "Customer Name";
            this.tbCustomer.ReadOnly = true;
            this.tbCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCustomer.SelectedText = "";
            this.tbCustomer.SelectionLength = 0;
            this.tbCustomer.SelectionStart = 0;
            this.tbCustomer.ShortcutsEnabled = true;
            this.tbCustomer.Size = new System.Drawing.Size(216, 27);
            this.tbCustomer.TabIndex = 13;
            this.tbCustomer.UseSelectable = true;
            this.tbCustomer.WaterMark = "Customer Name";
            this.tbCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCustomer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtgv2
            // 
            this.dtgv2.AllowUserToAddRows = false;
            this.dtgv2.AllowUserToDeleteRows = false;
            this.dtgv2.AllowUserToResizeColumns = false;
            this.dtgv2.AllowUserToResizeRows = false;
            this.dtgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgv2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column7,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv2.EnableHeadersVisualStyles = false;
            this.dtgv2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgv2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgv2.Location = new System.Drawing.Point(6, 73);
            this.dtgv2.Name = "dtgv2";
            this.dtgv2.ReadOnly = true;
            this.dtgv2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv2.Size = new System.Drawing.Size(605, 285);
            this.dtgv2.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtgv2.TabIndex = 11;
            this.dtgv2.UseStyleColors = true;
            this.dtgv2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv2_CellContentDoubleClick);
            this.dtgv2.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dtgv2_RowStateChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Product ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Price/Case";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Sub Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.Location = new System.Drawing.Point(319, 99);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(102, 54);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Reset";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(211, 99);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(102, 54);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Submit";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.tbTotal.CustomButton.Image = null;
            this.tbTotal.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.tbTotal.CustomButton.Name = "";
            this.tbTotal.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.tbTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTotal.CustomButton.TabIndex = 1;
            this.tbTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTotal.CustomButton.UseSelectable = true;
            this.tbTotal.CustomButton.Visible = false;
            this.tbTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbTotal.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tbTotal.Lines = new string[0];
            this.tbTotal.Location = new System.Drawing.Point(229, 62);
            this.tbTotal.MaxLength = 32767;
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.PasswordChar = '\0';
            this.tbTotal.ReadOnly = true;
            this.tbTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTotal.SelectedText = "";
            this.tbTotal.SelectionLength = 0;
            this.tbTotal.SelectionStart = 0;
            this.tbTotal.ShortcutsEnabled = true;
            this.tbTotal.Size = new System.Drawing.Size(174, 31);
            this.tbTotal.TabIndex = 1;
            this.tbTotal.UseSelectable = true;
            this.tbTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label1.Location = new System.Drawing.Point(89, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.Style = MetroFramework.MetroColorStyle.Teal;
            this.label1.TabIndex = 0;
            this.label1.Text = "Grand Total:  P";
            this.label1.UseStyleColors = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroButton2);
            this.groupBox3.Controls.Add(this.metroButton1);
            this.groupBox3.Controls.Add(this.tbTotal);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Teal;
            this.groupBox3.Location = new System.Drawing.Point(726, 427);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(617, 305);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payments";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblname.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblname.Location = new System.Drawing.Point(980, 33);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(17, 25);
            this.lblname.Style = MetroFramework.MetroColorStyle.Teal;
            this.lblname.TabIndex = 32;
            this.lblname.Text = ".";
            this.lblname.UseStyleColors = true;
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbluserid.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbluserid.Location = new System.Drawing.Point(980, 8);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(17, 25);
            this.lbluserid.Style = MetroFramework.MetroColorStyle.Teal;
            this.lbluserid.TabIndex = 33;
            this.lbluserid.Text = ".";
            this.lbluserid.UseStyleColors = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbsearchcust);
            this.groupBox4.Controls.Add(this.dtgvcustomer);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Teal;
            this.groupBox4.Location = new System.Drawing.Point(23, 427);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(697, 329);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Choose Customer";
            // 
            // tbsearchcust
            // 
            // 
            // 
            // 
            this.tbsearchcust.CustomButton.Image = null;
            this.tbsearchcust.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.tbsearchcust.CustomButton.Name = "";
            this.tbsearchcust.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.tbsearchcust.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbsearchcust.CustomButton.TabIndex = 1;
            this.tbsearchcust.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbsearchcust.CustomButton.UseSelectable = true;
            this.tbsearchcust.CustomButton.Visible = false;
            this.tbsearchcust.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbsearchcust.Lines = new string[0];
            this.tbsearchcust.Location = new System.Drawing.Point(238, 21);
            this.tbsearchcust.MaxLength = 32767;
            this.tbsearchcust.Name = "tbsearchcust";
            this.tbsearchcust.PasswordChar = '\0';
            this.tbsearchcust.PromptText = "Search";
            this.tbsearchcust.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbsearchcust.SelectedText = "";
            this.tbsearchcust.SelectionLength = 0;
            this.tbsearchcust.SelectionStart = 0;
            this.tbsearchcust.ShortcutsEnabled = true;
            this.tbsearchcust.Size = new System.Drawing.Size(184, 25);
            this.tbsearchcust.TabIndex = 3;
            this.tbsearchcust.UseSelectable = true;
            this.tbsearchcust.WaterMark = "Search";
            this.tbsearchcust.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbsearchcust.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbsearchcust.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsearchcust_KeyPress);
            // 
            // dtgvcustomer
            // 
            this.dtgvcustomer.AllowUserToAddRows = false;
            this.dtgvcustomer.AllowUserToDeleteRows = false;
            this.dtgvcustomer.AllowUserToResizeRows = false;
            this.dtgvcustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvcustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvcustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvcustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvcustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvcustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvcustomer.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvcustomer.EnableHeadersVisualStyles = false;
            this.dtgvcustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtgvcustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtgvcustomer.Location = new System.Drawing.Point(6, 52);
            this.dtgvcustomer.Name = "dtgvcustomer";
            this.dtgvcustomer.ReadOnly = true;
            this.dtgvcustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvcustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvcustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvcustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvcustomer.Size = new System.Drawing.Size(680, 260);
            this.dtgvcustomer.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtgvcustomer.TabIndex = 0;
            this.dtgvcustomer.UseStyleColors = true;
            this.dtgvcustomer.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvcustomer_CellContentDoubleClick);
            // 
            // lbltransID
            // 
            this.lbltransID.AutoSize = true;
            this.lbltransID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbltransID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbltransID.Location = new System.Drawing.Point(715, 35);
            this.lbltransID.Name = "lbltransID";
            this.lbltransID.Size = new System.Drawing.Size(17, 25);
            this.lbltransID.Style = MetroFramework.MetroColorStyle.Teal;
            this.lbltransID.TabIndex = 36;
            this.lbltransID.Text = ".";
            this.lbltransID.UseStyleColors = true;
            // 
            // metrolabel1
            // 
            this.metrolabel1.AutoSize = true;
            this.metrolabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metrolabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metrolabel1.Location = new System.Drawing.Point(568, 35);
            this.metrolabel1.Name = "metrolabel1";
            this.metrolabel1.Size = new System.Drawing.Size(141, 25);
            this.metrolabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metrolabel1.TabIndex = 37;
            this.metrolabel1.Text = "Transaction ID:";
            this.metrolabel1.UseStyleColors = true;
            // 
            // btnpending
            // 
            this.btnpending.Location = new System.Drawing.Point(1172, 8);
            this.btnpending.Name = "btnpending";
            this.btnpending.Size = new System.Drawing.Size(143, 42);
            this.btnpending.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnpending.TabIndex = 38;
            this.btnpending.Text = "View Transactions";
            this.btnpending.UseSelectable = true;
            this.btnpending.UseStyleColors = true;
            this.btnpending.Click += new System.EventHandler(this.btnpending_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.btnpending);
            this.Controls.Add(this.lbltransID);
            this.Controls.Add(this.metrolabel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnback);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Orders";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvcustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnback;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroGrid dtgv1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private MetroFramework.Controls.MetroTextBox tbFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        public MetroFramework.Controls.MetroGrid dtgv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox tbTotal;
        private MetroFramework.Controls.MetroLabel label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel lblname;
        private MetroFramework.Controls.MetroLabel lbluserid;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroTextBox tbsearchcust;
        private MetroFramework.Controls.MetroGrid dtgvcustomer;
        private MetroFramework.Controls.MetroTextBox tbCustomer;
        private MetroFramework.Controls.MetroLabel lbltransID;
        private MetroFramework.Controls.MetroLabel metrolabel1;
        private MetroFramework.Controls.MetroButton btnpending;
    }
}