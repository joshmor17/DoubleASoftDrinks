namespace DubleASoftDrinks
{
    partial class pincode
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
            this.btnEnter = new MetroFramework.Controls.MetroButton();
            this.tbpin = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(140, 145);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(99, 48);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "&Enter";
            this.btnEnter.UseSelectable = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbpin
            // 
            // 
            // 
            // 
            this.tbpin.CustomButton.Image = null;
            this.tbpin.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.tbpin.CustomButton.Name = "";
            this.tbpin.CustomButton.Size = new System.Drawing.Size(47, 47);
            this.tbpin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbpin.CustomButton.TabIndex = 1;
            this.tbpin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbpin.CustomButton.UseSelectable = true;
            this.tbpin.CustomButton.Visible = false;
            this.tbpin.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbpin.Lines = new string[0];
            this.tbpin.Location = new System.Drawing.Point(86, 90);
            this.tbpin.MaxLength = 32767;
            this.tbpin.Name = "tbpin";
            this.tbpin.PasswordChar = '*';
            this.tbpin.PromptText = "Enter Pin";
            this.tbpin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbpin.SelectedText = "";
            this.tbpin.SelectionLength = 0;
            this.tbpin.SelectionStart = 0;
            this.tbpin.ShortcutsEnabled = true;
            this.tbpin.Size = new System.Drawing.Size(212, 49);
            this.tbpin.TabIndex = 1;
            this.tbpin.UseSelectable = true;
            this.tbpin.WaterMark = "Enter Pin";
            this.tbpin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbpin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pincode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 223);
            this.ControlBox = false;
            this.Controls.Add(this.tbpin);
            this.Controls.Add(this.btnEnter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "pincode";
            this.Resizable = false;
            this.Text = "              Security Code";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnEnter;
        private MetroFramework.Controls.MetroTextBox tbpin;
    }
}