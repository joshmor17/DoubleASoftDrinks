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
    public partial class addProducts : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        private Products frm1;
        public addProducts(Products frm)
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
        

        private void generateautoID()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(prodID) FROM products";
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                i++;
                tbID.Text = 2017000 + i.ToString();
            }
            catch { }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        


        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM products WHERE prodName = '" + tbName.Text + "'";
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

                else if (tbName.Text == String.Empty || tbDescription.Text == String.Empty || tbPrice.Text == String.Empty || tbDeposit.Text == String.Empty || tbBrand.Text == String.Empty || tbDeposit.Text == "." || tbPrice.Text == ".")
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
                    cmd.CommandText = "INSERT INTO products (prodID, prodName, description, price, deposit, category, inventorycount) VALUES (@prodID, @prodName, @description, @price, @deposit, @category, @inventorycount)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("prodID", tbID.Text);
                    cmd.Parameters.AddWithValue("prodName", tbName.Text);
                    cmd.Parameters.AddWithValue("description", tbDescription.Text);
                    cmd.Parameters.AddWithValue("price", tbPrice.Text);
                    cmd.Parameters.AddWithValue("deposit", tbDeposit.Text);
                    cmd.Parameters.AddWithValue("category", tbBrand.Text);
                    cmd.Parameters.AddWithValue("inventorycount", '0');
                    cmd.ExecuteNonQuery();

                    MetroMessageBox.Show(this, "Successful");
                    con.Close();

                    con.Open();
                    cmd.CommandText = "INSERT INTO audit (userID, aDate, aTime, description) VALUES ('" + lbluserid.Text + "', '" + DateTime.Now.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() + "', 'Added New Products')";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    generateautoID();
                    Products nxt = new Products();
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
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == 8 || e.KeyChar == '-' || e.KeyChar == '.' || char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void tbDescription_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == '.')
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void tbDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == '.')
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void tbBrand_KeyPress(object sender, KeyPressEventArgs e)
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

        private void addProducts_Load(object sender, EventArgs e)
        {
            lbl5.Hide();
            lbluserid.Hide();
            lbluserid.Text = this.id;
        }

        private bool _altF4Pressed;
        private void addProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }

        private void addProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }
    }
}
