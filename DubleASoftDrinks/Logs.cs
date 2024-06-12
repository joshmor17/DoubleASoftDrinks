using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework;
using MetroFramework.Forms;
using System.Text.RegularExpressions;

namespace DubleASoftDrinks
{
    public partial class Logs : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        public Logs()
        {
            InitializeComponent();
            loaddata();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F5:
                    btnShowAll.PerformClick();
                    return true;
                case Keys.Escape:
                    btnback.PerformClick();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loaddata()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT a.userID AS 'User ID', a.Lname AS 'Last Name', a.Fname AS 'First Name', a.Mname AS 'Middle Name', b.aDate AS 'Date', b.aTime AS 'Time', b.description AS 'Activity' FROM users a INNER JOIN audit b ON a.userID = b.userID";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dtgv1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            int count;
            try
            {
                count = 0;
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT a.userID AS 'User ID', a.Lname AS 'Last Name', a.Fname AS 'First Name', a.Mname AS 'Middle Name', b.aDate AS 'Date', b.aTime AS 'Time', b.description AS 'Activity' FROM users a INNER JOIN audit b ON a.userID = b.userID WHERE b.aDate = '" + metroDateTime1.Text+"' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dtgv1.DataSource = dt;
                con.Close();

                if (count == 0)
                {
                    MetroMessageBox.Show(this, "Record Not Found");
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool _altF4Pressed;
        private void Logs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }

        private void Logs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }
    }
}
