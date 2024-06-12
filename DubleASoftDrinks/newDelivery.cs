using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace DubleASoftDrinks
{
    public partial class newDelivery : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        public newDelivery()
        {
            InitializeComponent();
            loaddata();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    btnSave.PerformClick();
                    return true;
                case Keys.Escape:
                    btnback.PerformClick();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string id;
        public void setField(string newid)
        {
            this.id = newid;
        }

        private void newDelivery_Load(object sender, EventArgs e)
        {
            lbluserid.Text = this.id;
            lbluserid.Hide();
        }

        public void loaddata()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT prodID AS 'Product ID', prodName AS 'Product Name', price AS 'Price', category AS 'Brand' FROM products Order by prodID";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dtgvcritical.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbName.Clear();
            tbPrice.Clear();
            tbBrand.Clear();
            tbStock.Clear();
        }

        private void dtgvcritical_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string prodID = dtgvcritical.CurrentRow.Cells[0].Value.ToString();
            string prodName = dtgvcritical.CurrentRow.Cells[1].Value.ToString();
            string price = dtgvcritical.CurrentRow.Cells[2].Value.ToString();
            string brand = dtgvcritical.CurrentRow.Cells[3].Value.ToString();

            tbID.Text = prodID;
            tbName.Text = prodName;
            tbPrice.Text = price;    
            tbBrand.Text = brand;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbID.Text == String.Empty || tbName.Text == String.Empty || tbPrice.Text == String.Empty || tbBrand.Text == String.Empty || tbStock.Text == String.Empty || Double.Parse(tbStock.Text) <= 0 || Double.Parse(tbStock.Text) > 100)
                {
                    MetroMessageBox.Show(this, "Invalid Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    pincode pin = new pincode();
                    pin.ShowDialog();

                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO newdelivery (prodID, prodName, price, brand, stockDelivered, ddate, dtime) VALUES (@prodID, @prodName, @price, @brand, @stockDelivered, @ddate, @dtime)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("prodID", tbID.Text);
                    cmd.Parameters.AddWithValue("prodName", tbName.Text);
                    cmd.Parameters.AddWithValue("price", tbPrice.Text);
                    cmd.Parameters.AddWithValue("brand", tbBrand.Text);
                    cmd.Parameters.AddWithValue("stockDelivered", tbStock.Text);
                    cmd.Parameters.AddWithValue("ddate", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("dtime", DateTime.Now.ToShortTimeString());
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO deliveryrecords (prodID, prodName, stockDelivered, ddate, dtime) VALUES ('"+tbID.Text+"', '"+tbName.Text+"', '"+tbStock.Text+"', '"+DateTime.Now.ToShortDateString()+"', '"+DateTime.Now.ToShortTimeString()+"')";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();

                    MetroMessageBox.Show(this, "Successful");
                    con.Close();


                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbStock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT prodID AS 'Product ID', prodName AS 'Product Name', price AS 'Price', category AS 'Brand' FROM products WHERE prodName like '%" + tbFilter.Text + "%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dtgvcritical.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
