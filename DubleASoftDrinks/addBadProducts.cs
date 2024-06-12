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
    public partial class addBadProducts : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = "); //Connection
        private stockInformation frm1;
        public addBadProducts(stockInformation frm)
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

        private void addBadProducts_Load(object sender, EventArgs e)
        {
            try
            {
                lbluserid.Hide();
                lbluserid.Text = this.id;

                tbID.Text = this.updateID.ToString();
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM products WHERE prodID = '" + this.updateID + "'";
                cmd.ExecuteNonQuery();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tbName.Text = dataReader["prodName"].ToString();
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

        private void tbQuan_KeyPress(object sender, KeyPressEventArgs e)
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

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM badproducts WHERE prodID = '" + tbID.Text + "' and status = 'Pending'";
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

                else if (tbName.Text == String.Empty || tbDescription.Text == String.Empty || tbQuan.Text == String.Empty || tbQuan.Text == ".")
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
                    cmd.CommandText = "INSERT INTO badproducts (prodID, prodName, prodqty, description, status) VALUES (@prodID, @prodName, @prodqty, @description, @status)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("prodID", tbID.Text);
                    cmd.Parameters.AddWithValue("prodName", tbName.Text);
                    cmd.Parameters.AddWithValue("prodqty", tbQuan.Text);
                    cmd.Parameters.AddWithValue("description", tbDescription.Text);
                    cmd.Parameters.AddWithValue("status", "Pending");
                    cmd.ExecuteNonQuery();

                    MetroMessageBox.Show(this, "Successful");
                    con.Close();

                    con.Open();
                    cmd.CommandText = "INSERT INTO audit (userID, aDate, aTime, description) VALUES ('" + lbluserid.Text + "', '" + DateTime.Now.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() + "', 'Added New Products')";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    stockInformation nxt = new stockInformation();
                    frm1.loadbad();
                    nxt.Show();
                    this.Close();


                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
