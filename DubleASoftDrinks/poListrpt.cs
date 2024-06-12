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
    public partial class poListrpt : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        public poListrpt()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Escape:
                    btnback.PerformClick();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM tempopurchase";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

                this.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void poListrpt_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = poSlip1;
            crystalReportViewer1.RefreshReport();
        }
    }
}
