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
    public partial class Orders : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        public Orders()
        {
            InitializeComponent();
            loaddata();
            loadcustomer();
            TransID();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    metroButton1.PerformClick();
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
        public string lname;
        public string fname;
        public string mname;
        public void setField(string newid, string lastname, string firstname, string middlename)
        {
            this.id = newid;
            this.lname = lastname;
            this.fname = firstname;
            this.mname = middlename;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            lbluserid.Text = this.id;
            lblname.Text = this.lname + ", " + this.fname + " " + this.mname;
            lblname.Hide();
            lbluserid.Hide();
        }

        public void loaddata()
        {
            try
            {
                dtgv1.Rows.Clear();
                String[] array = new String[6];
                string getTodayTime = DateTime.Now.ToString();
                string query = "SELECT * FROM products WHERE inventorycount != 0 ORDER BY prodID;";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows == false)
                {
                    //do nothing
                }
                else
                {
                    while (Reader.Read())
                    {
                        array[0] = (string)Reader["prodID"].ToString();
                        array[1] = (string)Reader["prodName"].ToString();
                        array[2] = (string)Reader["description"].ToString();
                        array[3] = (string)Reader["category"].ToString();
                        array[4] = (string)Reader["price"].ToString();
                        array[5] = (string)Reader["inventorycount"].ToString();
                        dtgv1.Rows.Add(array);
                    }
                }
                Reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    dtgv1.Rows.Clear();
                    String[] array = new String[6];
                    string getTodayTime = DateTime.Now.ToString();
                    string query = "SELECT * FROM products WHERE inventorycount != 0 AND prodName like '%" + tbFilter.Text + "%' ";
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader Reader = cmd.ExecuteReader();

                    if (Reader.HasRows == false)
                    {
                        //do nothing
                    }
                    else
                    {
                        while (Reader.Read())
                        {
                            array[0] = (string)Reader["prodID"].ToString();
                            array[1] = (string)Reader["prodName"].ToString();
                            array[2] = (string)Reader["description"].ToString();
                            array[3] = (string)Reader["category"].ToString();
                            array[4] = (string)Reader["price"].ToString();
                            array[5] = (string)Reader["inventorycount"].ToString();
                            dtgv1.Rows.Add(array);
                        }
                    }
                    Reader.Close();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbsearchcust_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT cID as 'Customer ID', custName 'Customer Name' , custAddress 'Address' , custContact 'Contact Number' FROM customers WHERE custName LIKE '%" + tbsearchcust.Text + "%'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dtgvcustomer.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void loadcustomer()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT cID as 'Customer ID', custName 'Customer Name' , custAddress 'Address' , custContact 'Contact Number' FROM customers ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dtgvcustomer.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgvcustomer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string custName = dtgvcustomer.CurrentRow.Cells[1].Value.ToString();

            tbCustomer.Text = custName;
        }

        private void dtgv1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                addQuantity nxt = new addQuantity();
                nxt.ShowDialog();
                double qty = nxt.getQuantity();
                string prodID = dtgv1.CurrentRow.Cells[0].Value.ToString();
                string prodName = dtgv1.CurrentRow.Cells[1].Value.ToString();
                string brand = dtgv1.CurrentRow.Cells[2].Value.ToString();
                string desc = dtgv1.CurrentRow.Cells[3].Value.ToString();
                string price = dtgv1.CurrentRow.Cells[4].Value.ToString();
                string stocks = dtgv1.CurrentRow.Cells[5].Value.ToString();

                if (qty > Double.Parse(stocks))
                {
                    MetroMessageBox.Show(this, "Insuficient Stock", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (qty != 0)
                    {
                        dtgv1.CurrentRow.Cells[5].Value = (Double.Parse(stocks) - qty);
                        dtgv2.Rows.Add(prodID, prodName, price, desc, qty, (Double.Parse(price) * qty));
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgv2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string itemCode = dtgv2.CurrentRow.Cells[0].Value.ToString();
            string qty = dtgv2.CurrentRow.Cells[4].Value.ToString();
            int holder = dtgv1.Rows.Count;

            for (int rowIndex = 0; rowIndex < holder; rowIndex++)
            {

                if (Double.Parse(dtgv1.Rows[rowIndex].Cells[0].Value.ToString()) == Double.Parse(itemCode))
                {
                    double currentStock = Double.Parse(dtgv1.Rows[rowIndex].Cells[5].Value.ToString());
                    dtgv1.Rows[rowIndex].Cells[5].Value = (currentStock + Double.Parse(qty));
                }

            }
            dtgv2.CurrentRow.Visible = false;
        }

        public void Total()
        {
            tbTotal.Text = "0";
            for (int i = 0; i < dtgv2.Rows.Count; i++)
            {

                if (dtgv2.Rows[i].Visible == true)
                {
                    tbTotal.Text = Convert.ToString(Double.Parse(tbTotal.Text) + Double.Parse(dtgv2.Rows[i].Cells[5].Value.ToString()));
                }
            }
        }

        private void dtgv2_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            Total();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(this, "Are You Sure?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                loaddata(); dtgv2.Rows.Clear();
            }
            loaddata();
            tbCustomer.Clear();
        }

        public void TransID()
        {
            try
            {
                int lastid = 0;
                con.Open();
                string query = "SELECT transNO FROM transactionss; ";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    lastid = Convert.ToInt32(dataReader["transNO"].ToString());
                }
                lastid++;
                lbltransID.Text = lastid.ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCustomer.Text == String.Empty)
                {
                    MetroMessageBox.Show(this, "Invalid Input");
                }
                else
                {

                    string items = "";
                    double quan = 0.0;

                    for (int rowIndex = 0; rowIndex < dtgv2.Rows.Count; rowIndex++)
                    {
                        if (dtgv2.Rows[rowIndex].Visible == true)
                        {
                            items = dtgv2.Rows[rowIndex].Cells[1].Value.ToString();
                            quan = Convert.ToDouble(dtgv2.Rows[rowIndex].Cells[4].Value.ToString());
                        }

                    }


                    DialogResult result = MetroMessageBox.Show(this, "Are You Sure?", "Buy These Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        int holder = dtgv2.Rows.Count;
                        for (int i = 0; i < holder; i++)
                        {
                            if (dtgv2.Rows[i].Visible == true)
                            {
                                con.Open();
                                MySqlCommand cmd1 = con.CreateCommand();
                                cmd1.CommandType = CommandType.Text;
                                cmd1.CommandText = "INSERT INTO tempo (transNo, customer, productCode, productName, productPrice, quantity, subtotal, grandtotal, amount, temchange, temdate, temtime, status, cashiername) VALUES ('" + lbltransID.Text + "', '" + tbCustomer.Text + "', '" + dtgv2.Rows[i].Cells[0].Value.ToString() + "', '" + dtgv2.Rows[i].Cells[1].Value.ToString() + "' , " + Convert.ToDouble(dtgv2.Rows[i].Cells[2].Value.ToString()) + ", '" + dtgv2.Rows[i].Cells[4].Value.ToString() + "', " + Convert.ToDouble(dtgv2.Rows[i].Cells[5].Value.ToString()) + ", " + tbTotal.Text + ", '0', '0', '" + DateTime.Now.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() + "', 'Pending', '" + lblname.Text + "' )";
                                cmd1.Connection = con;
                                cmd1.ExecuteNonQuery();
                                con.Close();

                                con.Open();
                                cmd1.CommandType = CommandType.Text;
                                cmd1.CommandText = "UPDATE products SET inventoryCount = inventorycount - " + Convert.ToDouble(dtgv2.Rows[i].Cells[4].Value.ToString()) + " where prodName = '" + dtgv2.Rows[i].Cells[1].Value.ToString() + "'";
                                cmd1.Connection = con;
                                cmd1.ExecuteNonQuery();
                                con.Close();
                            }
                        }

                        orderListForm nxt = new orderListForm();
                        nxt.ShowDialog();

                        dtgv2.Rows.Clear();
                        loaddata();
                        Total();
                        TransID();
                        tbFilter.Clear();
                        tbCustomer.Clear();
                        loadcustomer();
                        
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO audit (userID, aDate, aTime, description) VALUES (@userID, @aDate, @aTime, @description)";
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("userID", lbluserid.Text);
                        cmd.Parameters.AddWithValue("aDate", DateTime.Now.ToShortDateString());
                        cmd.Parameters.AddWithValue("aTime", DateTime.Now.ToShortTimeString());
                        cmd.Parameters.AddWithValue("description", "Made A Transaction");
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        loaddata(); dtgv2.Rows.Clear(); Total(); TransID();
                        tbCustomer.Clear();
                        loadcustomer();
                    }

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnpending_Click(object sender, EventArgs e)
        {
            PendingDeliveries nxt = new PendingDeliveries();
            nxt.setField(id);
            nxt.ShowDialog();
            this.Close();
        }
    }
}
