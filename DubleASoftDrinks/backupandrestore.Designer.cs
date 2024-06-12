namespace DubleASoftDrinks
{
    partial class backupandrestore
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
            this.lbluserid = new MetroFramework.Controls.MetroLabel();
            this.btnbackup = new MetroFramework.Controls.MetroButton();
            this.btnrestore = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.ActiveControl = null;
            this.btnback.Location = new System.Drawing.Point(528, 10);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(41, 42);
            this.btnback.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnback.TabIndex = 18;
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
            this.lbluserid.Location = new System.Drawing.Point(386, 27);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(17, 25);
            this.lbluserid.Style = MetroFramework.MetroColorStyle.Teal;
            this.lbluserid.TabIndex = 19;
            this.lbluserid.Text = ".";
            this.lbluserid.UseStyleColors = true;
            // 
            // btnbackup
            // 
            this.btnbackup.Location = new System.Drawing.Point(146, 94);
            this.btnbackup.Name = "btnbackup";
            this.btnbackup.Size = new System.Drawing.Size(279, 49);
            this.btnbackup.TabIndex = 20;
            this.btnbackup.Text = "Back-up Database";
            this.btnbackup.UseSelectable = true;
            this.btnbackup.Click += new System.EventHandler(this.btnbackup_Click);
            // 
            // btnrestore
            // 
            this.btnrestore.Location = new System.Drawing.Point(146, 149);
            this.btnrestore.Name = "btnrestore";
            this.btnrestore.Size = new System.Drawing.Size(279, 49);
            this.btnrestore.TabIndex = 20;
            this.btnrestore.Text = "Restore Database";
            this.btnrestore.UseSelectable = true;
            this.btnrestore.Click += new System.EventHandler(this.btnrestore_Click);
            // 
            // backupandrestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 274);
            this.ControlBox = false;
            this.Controls.Add(this.btnrestore);
            this.Controls.Add(this.btnbackup);
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.btnback);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "backupandrestore";
            this.Resizable = false;
            this.Text = "Database Backup And Restore";
            this.Load += new System.EventHandler(this.backupandrestore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnback;
        private MetroFramework.Controls.MetroLabel lbluserid;
        private MetroFramework.Controls.MetroButton btnbackup;
        private MetroFramework.Controls.MetroButton btnrestore;
    }
}