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
    public partial class addUsers : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        private Users frm1;
        public addUsers(Users frm)
        {
            InitializeComponent();
            frm1 = frm;
            generateautoID();
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

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generateautoID()//load auto ID
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(userID) FROM users";
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                i++;
                tbID.Text = 2014000 + i.ToString();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM users WHERE Lname = '" + tbLname.Text + "' and Fname ='"+tbFname.Text+ "' and Mname ='" + tbMname.Text + "' ";
                int count = 0;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    count = count + 1;
                }
                con.Close();

                if (count == 1)
                {
                    MetroMessageBox.Show(this, "Duplicate Entries", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }

                else if (tbLname.Text == String.Empty || tbPassword.Text == String.Empty || cboDescription.Text == String.Empty || tbFname.Text == String.Empty || tbMname.Text == String.Empty || tbAnswer.Text == String.Empty)
                {
                    MetroMessageBox.Show(this, "Invalid Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
                else
                {
                    pincode pin = new pincode();
                    pin.ShowDialog();

                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO users (userID, Lname, Fname, Mname, password, status, description, secQuestion, secAnswer) VALUES (@userID, @Lname, @Fname, @Mname, @password, @status, @description, @secQuestion, @secAnswer)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("userID", tbID.Text);
                    cmd.Parameters.AddWithValue("Lname", tbLname.Text);
                    cmd.Parameters.AddWithValue("Fname", tbFname.Text);
                    cmd.Parameters.AddWithValue("Mname", tbMname.Text);
                    cmd.Parameters.AddWithValue("password", tbPassword.Text);
                    cmd.Parameters.AddWithValue("status", "Active");
                    cmd.Parameters.AddWithValue("description", cboDescription.Text);
                    cmd.Parameters.AddWithValue("secQuestion", secuQuestions.Text);
                    cmd.Parameters.AddWithValue("secAnswer", tbAnswer.Text);

                    cmd.ExecuteNonQuery();
                    MetroMessageBox.Show(this, "Successful");
                    con.Close();

                    con.Open();
                    cmd.CommandText = "INSERT INTO audit (userID, aDate, aTime, description) VALUES ('" + lbluserid.Text + "', '" + DateTime.Now.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() + "', 'Added New Users')";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    generateautoID();
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

        private void addUsers_Load(object sender, EventArgs e)
        {
            lbluserid.Hide();
            lbluserid.Text = this.id;
        }

        private bool _altF4Pressed;
        private void addUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }

        private void addUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
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
    }
}
