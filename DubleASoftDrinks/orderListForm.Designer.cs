namespace DubleASoftDrinks
{
    partial class orderListForm
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnback = new MetroFramework.Controls.MetroTile();
            this.orderList1 = new DubleASoftDrinks.orderList();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.AutoSize = true;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(16, 67);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.orderList1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(588, 682);
            this.crystalReportViewer1.TabIndex = 29;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnback
            // 
            this.btnback.ActiveControl = null;
            this.btnback.Location = new System.Drawing.Point(563, 19);
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
            // orderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 768);
            this.ControlBox = false;
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.crystalReportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "orderListForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Order Slip";
            this.Load += new System.EventHandler(this.orderListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnback;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private orderList orderList1;
    }
}