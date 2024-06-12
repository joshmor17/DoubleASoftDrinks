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
    public partial class forgotPassword : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        public forgotPassword()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    btnOK.PerformClick();
                    return true;
                case Keys.Escape:
                    metroTile1.PerformClick();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
            
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbuserID.Text = String.Empty;
            tbanswer.Clear();
            tbsecu.Clear();
        }
        

        public string answer;
        public string password;

        int count = 0;
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbanswer.Text == answer)
                {
                    DialogResult dialog = MetroMessageBox.Show(this,"Your Password for your user " + tbuserID.Text + " is " + Environment.NewLine + password);

                    if (dialog == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    count++;
                    MetroMessageBox.Show(this, "Invalid Answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbanswer.Clear();
                }
                if (count == 3)
                {
                    MetroMessageBox.Show(this, "Sorry You Reached The Number Of Tries", "Application Will Close", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbuserID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * FROM users where userID = '" + tbuserID.Text + "'";

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tbsecu.Text = reader["secQuestion"].ToString();
                    answer = reader["secAnswer"].ToString();
                    password = reader["password"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
