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
    public partial class orderListForm : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        public orderListForm()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    btnback.PerformClick();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO transactionss (transNO, customerName, itemcode , itemname, itemprice, itemquan, subtotal, totalCost, tranamount, tranchange, transDate, transTime, status, cashiername) SELECT transNO, customer, productCode, productName, productPrice, quantity, subtotal, grandtotal, amount, temchange, temdate, temtime, status, cashiername FROM tempo";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();


                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM tempo";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();

                this.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void orderListForm_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = orderList1;
            crystalReportViewer1.RefreshReport();
        }
    }
}
