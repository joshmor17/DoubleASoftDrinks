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
using System.Text.RegularExpressions;

namespace DubleASoftDrinks
{
    public partial class updateUsers : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = "); //Connection
        private Users frm1;
        public updateUsers(Users frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    metroTile2.PerformClick();
                    return true;
                case Keys.Escape:
                    btnback.PerformClick();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
            
        }

        public string id;
        public void setField(string newid)
        {
            this.id = newid;
        }

        public int updateID;
        public void setupdate(int num)
        {
            this.updateID = num;
        }

        private void updateUsers_Load(object sender, EventArgs e)
        {
            try
            {
                lbluserid.Hide();
                lbluserid.Text = this.id;

                tbID.Text = this.updateID.ToString();
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM users WHERE userID = '" + this.updateID + "'";
                cmd.ExecuteNonQuery();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tbLname.Text = dataReader["Lname"].ToString();
                    tbFname.Text = dataReader["Fname"].ToString();
                    tbMname.Text = dataReader["Mname"].ToString();
                    tbPassword.Text = dataReader["password"].ToString();
                    cboStatus.Text = dataReader["status"].ToString();
                    cboDescription.Text = dataReader["description"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbLname.Text == String.Empty || tbPassword.Text == String.Empty || cboStatus.Text == String.Empty || cboDescription.Text == String.Empty || tbFname.Text == String.Empty || tbMname.Text == String.Empty)
                {
                    MetroMessageBox.Show(this, "Invalid Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
                else
                {
                    pincode pin = new pincode();
                    pin.ShowDialog();

                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE users set Lname = '" + tbLname.Text + "' where userID = '" + tbID.Text + "'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE users set Fname = '" + tbFname.Text + "' where userID = '" + tbID.Text + "'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE users set Mname = '" + tbMname.Text + "' where userID = '" + tbID.Text + "'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE users set password = '" + tbPassword.Text + "' where userID = '" + tbID.Text + "'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE users set status = '" + cboStatus.Text + "' where userID = '" + tbID.Text + "'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE users set description = '" + cboDescription.Text + "' where userID = '" + tbID.Text + "'";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    con.Open();
                    cmd.CommandText = "INSERT INTO audit (userID, aDate, aTime, description) VALUES (@userID, @aDate, @aTime, @description)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("userID", lbluserid.Text);
                    cmd.Parameters.AddWithValue("aDate", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("aTime", DateTime.Now.ToShortTimeString());
                    cmd.Parameters.AddWithValue("description", "Edited Users");
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MetroMessageBox.Show(this, "Successful");
                    Users nxt = new Users();
                    frm1.loaddata();
                    nxt.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == 8 || e.KeyChar == '-' || e.KeyChar == '.')
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == 8 || e.KeyChar == '-' || e.KeyChar == ',' || e.KeyChar == '.' || char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private bool _altF4Pressed;
        private void updateUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }

        private void updateUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbPassword.UseSystemPasswordChar = true;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = false;
            }
        }

        private void tbFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == 8 || e.KeyChar == '-' || e.KeyChar == '.')
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void tbMname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == 8 || e.KeyChar == '-' || e.KeyChar == '.')
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }
    }
}
