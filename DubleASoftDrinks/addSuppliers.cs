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
    public partial class addSuppliers : MetroForm
    {
        //connection
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        private Suppliers frm1;
        public addSuppliers(Suppliers frm)
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

        private void generateautoID()//load auto ID
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(sID) FROM supplier";
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                i++;
                tbID.Text = 2016000 + i.ToString();
            }
            catch { }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close(); //will close the form
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e) //Letter only can input
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

        private void tbAddress_KeyPress(object sender, KeyPressEventArgs e) //No special characters
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

        private void tbContact_KeyPress(object sender, KeyPressEventArgs e) //Number Only
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == '-')
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void metroTile2_Click(object sender, EventArgs e) //Insert data codes
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM supplier WHERE suppName = '" + tbName.Text + "'";
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

                else if (tbName.Text == String.Empty || tbAddress.Text == String.Empty || tbContact.Text == String.Empty || tbTin.Text == String.Empty || tbContact.Text == "-")
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
                    cmd.CommandText = "INSERT INTO supplier (sID, suppName, suppAddress, suppContact, suppTin) VALUES (@sID, @suppName, @suppAddress, @suppContact, @suppTin)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("sID", tbID.Text);
                    cmd.Parameters.AddWithValue("suppName", tbName.Text);
                    cmd.Parameters.AddWithValue("suppAddress", tbAddress.Text);
                    cmd.Parameters.AddWithValue("suppContact", tbContact.Text);
                    cmd.Parameters.AddWithValue("suppTin", tbTin.Text);
                    cmd.ExecuteNonQuery();
                    MetroMessageBox.Show(this, "Successful");
                    con.Close();

                    con.Open();
                    cmd.CommandText = "INSERT INTO audit (userID, aDate, aTime, description) VALUES (@userID, @aDate, @aTime, @description)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("userID", lbluserid.Text);
                    cmd.Parameters.AddWithValue("aDate", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("aTime", DateTime.Now.ToShortTimeString());
                    cmd.Parameters.AddWithValue("description", "Added New Suppliers");
                    cmd.ExecuteNonQuery();
                    con.Close();

                    generateautoID();
                    Suppliers nxt = new Suppliers();
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

        private void addSuppliers_Load(object sender, EventArgs e)
        {
            lbluserid.Hide();
            lbluserid.Text = this.id;
        }

        private bool _altF4Pressed;
        private void addSuppliers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }

        private void addSuppliers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }

        private void tbTin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == '-' || char.IsLetter(e.KeyChar))
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
