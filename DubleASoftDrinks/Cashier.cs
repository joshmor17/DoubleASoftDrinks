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
    public partial class Cashier : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        public Cashier()
        {
            InitializeComponent();
            loaddata();
            TransID();
            loadcustomer();
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


        public int updateID;
        public void setupdate(int num)
        {
            this.updateID = num;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
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
                MetroMessageBox.Show(this, ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            tbTotal.Text = "0";
            tbChange.Text = "0";
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(this, "Are You Sure?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                loaddata(); dtgv2.Rows.Clear();
            }
            tbTotal.Text = "0";
            tbChange.Text = "0";
            tbpayment.Clear();
            loaddata();
            tbCustomer.Clear();
        }

        private void dtgv2_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            Total(); Change();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            Change();
        }

        public void Change()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(tbpayment.Text))
                {
                    string change;
                    string num2 = tbpayment.Text, num1 = tbTotal.Text;

                    change = (Double.Parse(num2) - Double.Parse(num1)) + "";
                    tbChange.Text = change;
                }
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (double.Parse(tbpayment.Text) <= 0 || tbpayment.Text == String.Empty || double.Parse(tbChange.Text) < 0 || tbCustomer.Text == String.Empty)
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
                            items =  dtgv2.Rows[rowIndex].Cells[1].Value.ToString();
                             quan =  Convert.ToDouble(dtgv2.Rows[rowIndex].Cells[4].Value.ToString());
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
                                cmd1.CommandText = "INSERT INTO tempo (transNo, customer, productCode, productName, productPrice, quantity, subtotal, grandtotal, amount, temchange, temdate, temtime, status, cashiername) VALUES ('"+lbltransID.Text+"', '" + tbCustomer.Text + "', '" + dtgv2.Rows[i].Cells[0].Value.ToString() + "', '" + dtgv2.Rows[i].Cells[1].Value.ToString() + "' , " + Convert.ToDouble(dtgv2.Rows[i].Cells[2].Value.ToString()) + ", '" + dtgv2.Rows[i].Cells[4].Value.ToString() + "', " + Convert.ToDouble(dtgv2.Rows[i].Cells[5].Value.ToString()) + ", " + tbTotal.Text + ", " + Convert.ToDouble(tbpayment.Text) + ", '" + tbChange.Text + "', '"+DateTime.Now.ToShortDateString()+"', '"+DateTime.Now.ToShortTimeString()+"', 'Paid', '"+lblname.Text+"' )";
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

                        Receipts nxt = new Receipts();
                        nxt.ShowDialog();

                        dtgv2.Rows.Clear();
                        Change();
                        tbpayment.Text = "0";
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
                        loaddata(); dtgv2.Rows.Clear(); Total(); TransID(); Change(); tbpayment.Text = "0";
                        tbCustomer.Clear();
                        loadcustomer();
                    }

                }
            } catch(Exception ex)
                 {
                    MetroMessageBox.Show(this, ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
            }

        


        private void tbpayment_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Cashier_Load(object sender, EventArgs e)
        {   
            tbTotal.Text = "0";
            tbpayment.Text = "0";
            tbChange.Text = "0";
            lbluserid.Hide();
            lbluserid.Text = this.id;
            lblname.Text = this.lname + ", "+ this.fname + " " + this.mname ;
            lblname.Hide();
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
        

        private bool _altF4Pressed;
        private void Cashier_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }

        private void Cashier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
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

        private void dtgvcustomer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string custName = dtgvcustomer.CurrentRow.Cells[1].Value.ToString();

            tbCustomer.Text = custName;
        }
    }
}
