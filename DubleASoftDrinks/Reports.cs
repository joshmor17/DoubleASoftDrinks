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
using DGVPrinterHelper;

namespace DubleASoftDrinks
{
    public partial class Reports : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        public Reports()
        {
            InitializeComponent();
            stockreport();
            loadsalesdata();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    metroTile1.PerformClick();
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

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void audit()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO audit (userID, aDate, aTime, description) VALUES (@userID, @aDate, @aTime, @description)";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("userID", lbluserid.Text);
                cmd.Parameters.AddWithValue("aDate", DateTime.Now.ToShortDateString());
                cmd.Parameters.AddWithValue("aTime", DateTime.Now.ToShortTimeString());
                cmd.Parameters.AddWithValue("description", "Printed File Critical Items");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void stockreport()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT deliveryNo AS 'Delivery No', prodID AS 'Product ID', prodname AS 'Product Name', stockDelivered AS 'Stock Delivered', ddate AS 'Date', dtime AS 'Time' FROM deliveryrecords ORDER BY ddate";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dtgvStocks.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrintStock_Click(object sender, EventArgs e)
        {
            DGVPrinter printer1 = new DGVPrinter();
            printer1.Title = "Double A Softdrinks Stock Reports";
            printer1.SubTitle = string.Format("Date: {0}", DateTime.Now);
            printer1.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer1.PageNumbers = true;
            printer1.PageNumberInHeader = false;
            printer1.PorportionalColumns = true;
            printer1.HeaderCellAlignment = StringAlignment.Near;
            printer1.FooterSpacing = 15;
            printer1.printDocument.DefaultPageSettings.Landscape = true;
            printer1.PrintDataGridView(dtgvStocks);

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO audit (userID, aDate, aTime, description) VALUES ('"+lbluserid.Text+"', '"+ DateTime.Now.ToShortDateString() + "', '"+ DateTime.Now.ToShortTimeString() + "', 'Printed File Stock Reports')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        int count;
        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                count = 0;
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT deliveryNo AS 'Delivery No', prodID AS 'Product ID', prodname AS 'Product Name', stockDelivered AS 'Stock Delivered', ddate AS 'Date', dtime AS 'Time' FROM deliveryrecords WHERE ddate = '" + metroDateTime1.Text+"' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dtgvStocks.DataSource = dt;
                con.Close();

                if (count == 0)
                {
                    MetroMessageBox.Show(this,"Record Not Found");
                }
            }catch(Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
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
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == '.' || e.KeyChar == 8)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void tbNotes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == '.' || e.KeyChar == 8)
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }
        

     

        private void Reports_Load(object sender, EventArgs e)
        {
            lbluserid.Hide();
            lbluserid.Text = this.id;
            
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT deliveryNo AS 'Delivery No', prodID AS 'Product ID', prodname AS 'Product Name', stockDelivered AS 'Stock Delivered', ddate AS 'Date', dtime AS 'Time' FROM deliveryrecords ORDER BY ddate";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dtgvStocks.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        public void loadsalesdata()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT DISTINCT transNO  AS 'Transaction ID', customerName AS 'Customer Name', transDate AS 'Date',  totalCost AS 'Total', status AS 'Status' FROM transactionss WHERE status = 'Paid' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dtgvsales.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (startdate.Value > enddate.Value)
                {
                    MetroMessageBox.Show(this, "Invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(startdate.Value == enddate.Value)
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT DISTINCT transNO  AS 'Transaction ID', customerName AS 'Customer Name', transDate AS 'Date',  totalCost AS 'Total', status AS 'Status' FROM transactionss WHERE transDate BETWEEN '" + startdate.Text + "' AND '" + enddate.Text + "' AND status = 'Paid' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dtgvsales.DataSource = dt;
                    con.Close();
                }
                else if (startdate.Value < enddate.Value)
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT DISTINCT transNO  AS 'Transaction ID', customerName AS 'Customer Name', transDate AS 'Date',  totalCost AS 'Total', status AS 'Status' FROM transactionss WHERE transDate >= '" + startdate.Text+"' AND transDate <= '"+enddate.Text+ "' AND status = 'Paid' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dtgvsales.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool _altF4Pressed;
        private void Reports_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }

        private void Reports_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dtgvsales.Rows.Count; i++)
                {
                    if (dtgvsales.Rows[i].Visible == true)
                    {
                        con.Open();
                        MySqlCommand cmd1 = con.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "INSERT INTO temposales (transNO, customerName, transDate, totalCost) VALUES ('"+dtgvsales.Rows[i].Cells[0].Value.ToString()+ "', '" + dtgvsales.Rows[i].Cells[1].Value.ToString() + "', '" + dtgvsales.Rows[i].Cells[2].Value.ToString() + "', '" + Convert.ToDouble(dtgvsales.Rows[i].Cells[3].Value.ToString()) + "' )";
                        cmd1.Connection = con;
                        cmd1.ExecuteNonQuery();
                        con.Close();
                    }
                }

                Salesrpt nxt = new Salesrpt();
                nxt.ShowDialog();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
