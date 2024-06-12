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
    public partial class updateBadProducts : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = "); //Connection
        private stockInformation frm1;
        public updateBadProducts(stockInformation frm)
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

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBadProducts_Load(object sender, EventArgs e)
        {
            try
            {
                lbluserid.Hide();
                lbluserid.Text = this.id;

                tbID.Text = this.updateID.ToString();
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM badproducts WHERE prodID = '" + this.updateID + "'";
                cmd.ExecuteNonQuery();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tbName.Text = dataReader["prodName"].ToString();
                    tbQuan.Text = dataReader["prodqty"].ToString();
                    tbDescription.Text = dataReader["description"].ToString();
                    cbostatus.Text = dataReader["status"].ToString();
                }
                con.Close();
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
                if (tbName.Text == String.Empty || tbDescription.Text == String.Empty || tbQuan.Text == String.Empty || tbQuan.Text == ".")
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
                    cmd.CommandText = "UPDATE badproducts set prodqty = '" + tbQuan.Text + "' where prodID = '" + tbID.Text + "'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE badproducts set description = '" + tbDescription.Text + "' where prodID = '" + tbID.Text + "'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE badproducts set status = '" + cbostatus.Text + "' where prodID = '" + tbID.Text + "'";
                    cmd.ExecuteNonQuery();
                    

                    con.Close();

                    con.Open();
                    cmd.CommandText = "INSERT INTO audit (userID, aDate, aTime, description) VALUES (@userID, @aDate, @aTime, @description)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("userID", lbluserid.Text);
                    cmd.Parameters.AddWithValue("aDate", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("aTime", DateTime.Now.ToShortTimeString());
                    cmd.Parameters.AddWithValue("description", "Edited Products");
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MetroMessageBox.Show(this, "Successful");
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
    }
}
