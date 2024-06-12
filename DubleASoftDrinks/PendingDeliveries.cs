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
    public partial class PendingDeliveries : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        public PendingDeliveries()
        {
            InitializeComponent();
            loaddata();
            loadongoing();
            loadalltrans();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    metroTile1.PerformClick();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public string id;
        public void setField(string newid)
        {
            this.id = newid;
        }

        public void loaddata()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT transID AS 'Transaction ID', transNO AS 'Receipt No', customerName AS 'Customer Name', itemcode AS 'Product ID', itemname AS 'Product Name', itemprice AS 'Price/Case', itemquan AS 'Quantity', subtotal AS 'Sub Total', transDate AS 'Date', transTime AS 'Time', status AS 'Status' FROM transactionss WHERE status = 'Pending' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dtgv1.DataSource = dt;
                con.Close();
            } catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadongoing()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT transID AS 'Transaction ID', transNO AS 'Receipt No', customerName AS 'Customer Name', itemcode AS 'Product ID', itemname AS 'Product Name', itemprice AS 'Price/Case', itemquan AS 'Quantity', subtotal AS 'Sub Total', transDate AS 'Date', transTime AS 'Time', status AS 'Status' FROM transactionss WHERE status = 'On-Going' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dtgvongoing.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadalltrans()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT transID AS 'Transaction ID', transNO AS 'Receipt No', customerName AS 'Customer Name', itemcode AS 'Product ID', itemname AS 'Product Name', itemprice AS 'Price/Case', itemquan AS 'Quantity', subtotal AS 'Sub Total', transDate AS 'Date', transTime AS 'Time', status AS 'Status' FROM transactionss ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dtgvalltrans.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int cellID;

        private void PendingDeliveries_Load(object sender, EventArgs e)
        {
            lbluserid.Hide();
            lbluserid.Text = this.id;
        }

        private bool _altF4Pressed;
        private void PendingDeliveries_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }

        private void PendingDeliveries_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }

        private void dtgv1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            cellID = Int32.Parse(dtgv1.CurrentRow.Cells[0].Value.ToString());

            if (cellID != 0)
            {
                updateTransaction nxt = new updateTransaction(this);
                nxt.setupdate(this.cellID);
                nxt.setField(id);
                nxt.ShowDialog();

            }
        }

        private void dtgvongoing_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cellID = Int32.Parse(dtgvongoing.CurrentRow.Cells[1].Value.ToString());

            if (cellID != 0)
            {
                updateOngoing nxt = new updateOngoing(this);
                nxt.setupdate(this.cellID);
                nxt.setField(id);
                nxt.ShowDialog();
            }
        }
    }
}
