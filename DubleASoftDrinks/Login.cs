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
    public partial class Login : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        public Login()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    btnlog.PerformClick();
                    return true;
                case Keys.Escape:
                    metroTile1.PerformClick();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lbl1.Text = DateTime.Now.ToString();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(this, "Are You Sure?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //Login
        private void btnlog_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from users where userID = '" + tbuser.Text + "' and password = '" + tbpass.Text + "' and status = 'active'";
            int count = 0;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                count = count + 1;
                string lname = (string)reader["Lname"].ToString();
                string fname = (string)reader["Fname"].ToString();
                string mname = (string)reader["Mname"].ToString();
                string id = (string)reader["userID"].ToString();
                string status = (string)reader["description"].ToString();
                MetroMessageBox.Show(this, "Welcome!");
                Menu nxt = new Menu();
                nxt.setField(lname, fname, mname, status, id);
                nxt.ShowDialog();
                this.Hide();
            }
            con.Close();

            if (count == 1)
            {  
                con.Open();
                cmd.CommandText = "INSERT INTO audit (userID, aDate, aTime, description) VALUES (@userID, @aDate, @aTime, @description)";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("userID", tbuser.Text);
                cmd.Parameters.AddWithValue("aDate", DateTime.Now.ToShortDateString());
                cmd.Parameters.AddWithValue("aTime", DateTime.Now.ToShortTimeString());
                cmd.Parameters.AddWithValue("description", "Successfully Login!");
                cmd.ExecuteNonQuery();
                con.Close();
            }

            else
            {
                MetroMessageBox.Show(this,"Username or password is incorrect");
            }
        }

        private void tbuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void tbpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPassword nxt = new forgotPassword();
            nxt.ShowDialog();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPassword nxt = new forgotPassword();
            nxt.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl1.Text = DateTime.Now.ToString();
        }
    }
}
