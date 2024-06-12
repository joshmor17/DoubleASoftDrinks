using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;

namespace DubleASoftDrinks
{
    public partial class pincode : MetroForm
    {
        public pincode()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    btnEnter.PerformClick();
                    return true;
                case Keys.E:
                    btnEnter.PerformClick();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tbpin.Text == "20140111")
            {
                MetroMessageBox.Show(this, "Pincode Is Correct!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MetroMessageBox.Show(this, "Pincode Is Wrong!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
