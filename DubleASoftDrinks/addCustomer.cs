﻿using System;
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
    public partial class addCustomer : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        private Customers frm1;
        public addCustomer(Customers frm)
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
                    metroTile1.PerformClick();
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
                cmd.CommandText = "SELECT COUNT(cID) FROM customers";
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                i++;
                tbID.Text = 2015000 + i.ToString();
            }
            catch
            {

            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM customers WHERE custName = '" + tbName.Text + "'";
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

                else if (tbName.Text == String.Empty || tbAddress.Text == String.Empty || tbContact.Text == String.Empty || tbContact.Text == "-")
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
                    cmd.CommandText = "INSERT INTO customers (cID, custName, custAddress, custContact) VALUES (@cID, @custName, @custAddress, @custContact)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("cID", tbID.Text);
                    cmd.Parameters.AddWithValue("custName", tbName.Text);
                    cmd.Parameters.AddWithValue("custAddress", tbAddress.Text);
                    cmd.Parameters.AddWithValue("custContact", tbContact.Text);
                    cmd.ExecuteNonQuery();
                    MetroMessageBox.Show(this, "Successful");
                    con.Close();

                    con.Open();
                    cmd.CommandText = "INSERT INTO audit (userID, aDate, aTime, description) VALUES (@userID, @aDate, @aTime, @description)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("userID", lbluserid.Text);
                    cmd.Parameters.AddWithValue("aDate", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("aTime", DateTime.Now.ToShortTimeString());
                    cmd.Parameters.AddWithValue("description", "Added New Customers");
                    cmd.ExecuteNonQuery();
                    con.Close();

                    generateautoID();
                    Customers nxt = new Customers();
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

        private void tbAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == 8 || e.KeyChar == '-' || e.KeyChar == ',' || e.KeyChar == '.' || char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void tbContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == '-' || e.KeyChar == '(' || e.KeyChar == ')')
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void addCustomer_Load(object sender, EventArgs e)
        {
            lbluserid.Hide();
            lbluserid.Text = this.id;
        }

        private bool _altF4Pressed;
        private void addCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }

        private void addCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }
    }
}
