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

namespace DubleASoftDrinks
{
    public partial class addStocks : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = "); //Connection
        private stockInformation frm1;
        public addStocks(stockInformation frm)
        {
            InitializeComponent();
            frm1 = frm;
            loaddata();
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
        

        public int updateID;
        public void setupdate(int num)
        {
            this.updateID = num;
        }

        public void loaddata()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT prodID AS 'Product ID', prodName AS 'Product Name', price AS 'Price', brand AS 'Brand', stockDelivered AS 'Stock Delivered' FROM newdelivery WHERE stockDelivered > 0";
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
        private void updateStocks_Load(object sender, EventArgs e)
        {
            lbl5.Hide();

            lbluserid.Hide();
            lbluserid.Text = this.id;

            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from products where prodID = '"+tbID.Text+"' ";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tbCurrent.Text = reader["inventorycount"].ToString();
            }
            con.Close();

        }
        
        
        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                double sum = Double.Parse(tbCurrent.Text) + Double.Parse(tbadd.Text);

            if (sum > 100)
            {
                MetroMessageBox.Show(this, "Over Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.Close();
            }

            else if (Double.Parse(tbadd.Text) <= 0.4 || Double.Parse(tbadd.Text) >= 0.6 && Double.Parse(tbadd.Text) < 1 || tbadd.Text == ".")
            {
                MetroMessageBox.Show(this, "Invalid Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

            else if (tbadd.Text == String.Empty || tbadd.Text == "." || Double.Parse(tbadd.Text) == 0 || Double.Parse(tbadd.Text) > 100 || tbID.Text == String.Empty || tbName.Text == String.Empty || tbPrice.Text == String.Empty || tbCurrent.Text == String.Empty || tbBrand.Text == String.Empty)
            {
                MetroMessageBox.Show(this, "Invalid Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                pincode pin = new pincode();
                pin.ShowDialog();

                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE products set inventorycount = inventorycount + " + tbadd.Text + " where prodID = '" + tbID.Text + "'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE newdelivery set stockDelivered = stockDelivered - " + tbadd.Text + " where prodID = '" + tbID.Text + "'";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                MetroMessageBox.Show(this, "Successful");
                con.Close();

                con.Open();
                cmd.CommandText = "INSERT INTO audit (userID, aDate, aTime, description) VALUES (@userID, @aDate, @aTime, @description)";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("userID", lbluserid.Text);
                cmd.Parameters.AddWithValue("aDate", DateTime.Now.ToShortDateString());
                cmd.Parameters.AddWithValue("aTime", DateTime.Now.ToShortTimeString());
                cmd.Parameters.AddWithValue("description", "Added New Stocks");
                cmd.ExecuteNonQuery();
                con.Close();

                stockInformation nxt = new stockInformation();
                frm1.loaddata();
                nxt.Show();
                this.Close();
            }

            } catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        

        private bool _altF4Pressed;
        private void addStocks_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }

        private void addStocks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }

        private void dtgvcritical_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string prodID = dtgvcritical.CurrentRow.Cells[0].Value.ToString();
            string prodName = dtgvcritical.CurrentRow.Cells[1].Value.ToString();
            string price = dtgvcritical.CurrentRow.Cells[2].Value.ToString();
            string brand = dtgvcritical.CurrentRow.Cells[3].Value.ToString();
            string stock = dtgvcritical.CurrentRow.Cells[4].Value.ToString();

            tbID.Text = prodID;
            tbName.Text = prodName;
            tbPrice.Text = price;
            tbBrand.Text = brand;
            tbStockDelivered.Text = stock;
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from products where prodID = '" + tbID.Text + "' ";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tbCurrent.Text = reader["inventorycount"].ToString();
            }
            con.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbID.Clear();
            tbName.Clear();
            tbPrice.Clear();
            tbBrand.Clear();
            tbCurrent.Clear();
            tbStockDelivered.Clear();
        }

        private void tbadd_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
