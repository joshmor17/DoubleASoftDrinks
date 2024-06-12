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
    public partial class updateSuppliers : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = "); //Connection
        private Suppliers frm1;
        public updateSuppliers(Suppliers frm)
        {
            InitializeComponent();
            frm1 = frm;
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

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int updateID;
        public void setupdate(int num)
        {
            this.updateID = num;
        }

        private void updateSuppliers_Load(object sender, EventArgs e)
        {
            try
            {
                lbluserid.Hide();
                lbluserid.Text = this.id;

                tbID.Text = this.updateID.ToString();
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM supplier WHERE sID = '" + this.updateID + "'";
                cmd.ExecuteNonQuery();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tbName.Text = dataReader["suppName"].ToString();
                    tbAddress.Text = dataReader["suppAddress"].ToString();
                    tbContact.Text = dataReader["suppContact"].ToString();
                    tbTin.Text = dataReader["suppTin"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbName.Text == String.Empty || tbAddress.Text == String.Empty || tbContact.Text == String.Empty || tbContact.Text == "-" || tbTin.Text == String.Empty)
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
                    cmd.CommandText = "UPDATE supplier set suppName = '" + tbName.Text + "' where sID = '" + tbID.Text + "'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE supplier set suppAddress = '" + tbAddress.Text + "' where sID = '" + tbID.Text + "'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE supplier set suppContact = '" + tbContact.Text + "' where sID = '" + tbID.Text + "'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE supplier set suppTin = '" + tbTin.Text + "' where sID = '" + tbID.Text + "'";
                    cmd.ExecuteNonQuery();


                    con.Close();

                    con.Open();
                    cmd.CommandText = "INSERT INTO audit (userID, aDate, aTime, description) VALUES (@userID, @aDate, @aTime, @description)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("userID", lbluserid.Text);
                    cmd.Parameters.AddWithValue("aDate", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("aTime", DateTime.Now.ToShortTimeString());
                    cmd.Parameters.AddWithValue("description", "Edited Suppliers");
                    cmd.ExecuteNonQuery();
                    con.Close();


                    MetroMessageBox.Show(this, "Successful");
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
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == 8 || e.KeyChar == '-' || e.KeyChar == ',' || e.KeyChar == '.' || char.IsNumber(e.KeyChar))
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
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == '-')
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }


        private bool _altF4Pressed;
        private void updateSuppliers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }

        private void updateSuppliers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }

        private void tbTin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == '-')
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
