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
    public partial class updateTransaction : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = "); //Connection
        private PendingDeliveries frm1;
        public updateTransaction(PendingDeliveries frm)
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

        private void updateTransaction_Load(object sender, EventArgs e)
        {
            try
            {
                lbluserid.Hide();
                lbl5.Hide();
                lblquantity.Hide();
                lblprodID.Hide();
                lbluserid.Text = this.id;

                tbID.Text = this.updateID.ToString();
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM transactionss WHERE transID = '" + this.updateID + "'";
                cmd.ExecuteNonQuery();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    lblprodID.Text = dataReader["itemcode"].ToString();
                    lblquantity.Text = dataReader["itemquan"].ToString();
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
                if (cbostatus.Text == String.Empty)
                {
                    MetroMessageBox.Show(this, "Invalid Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (cbostatus.Text == "Cancelled")
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE products set inventorycount = inventorycount + " + Convert.ToDouble(lblquantity.Text) + " where prodID = '" + lblprodID.Text + "'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE transactionss set status = '" + cbostatus.Text + "' where transID = '" + tbID.Text + "'";
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MetroMessageBox.Show(this, "Successful");
                    PendingDeliveries nxt = new PendingDeliveries();
                    frm1.loaddata();
                    frm1.loadongoing();
                    frm1.loadalltrans();
                    nxt.Show();
                    this.Close();
                }
                else
                {
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE transactionss set status = '" + cbostatus.Text + "' where transID = '" + tbID.Text + "'";
                        cmd.ExecuteNonQuery();

                        con.Close();

                        con.Open();
                        cmd.CommandText = "INSERT INTO audit (userID, aDate, aTime, description) VALUES (@userID, @aDate, @aTime, @description)";
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("userID", lbluserid.Text);
                        cmd.Parameters.AddWithValue("aDate", DateTime.Now.ToShortDateString());
                        cmd.Parameters.AddWithValue("aTime", DateTime.Now.ToShortTimeString());
                        cmd.Parameters.AddWithValue("description", "Updated Transactions");
                        cmd.ExecuteNonQuery();
                        con.Close();
                    
                        MetroMessageBox.Show(this, "Successful");
                        PendingDeliveries nxt = new PendingDeliveries();
                        frm1.loaddata();
                        frm1.loadongoing();
                        frm1.loadalltrans();
                        nxt.Show();
                        this.Close();
                }
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

        private bool _altF4Pressed;
        private void updateTransaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }

        private void updateTransaction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }
    }
}
