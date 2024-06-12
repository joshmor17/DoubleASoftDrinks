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
using System.Windows.Threading;

namespace DubleASoftDrinks
{
    public partial class Menu : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        public Menu()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    btnPos.PerformClick();
                    return true;
                case Keys.F2:
                    btnOrder.PerformClick();
                    return true;
                case Keys.F3:
                    btnCustomer.PerformClick();
                    return true;
                case Keys.F4:
                    btnLog.PerformClick();
                    return true;
                case Keys.F5:
                    btnUsers.PerformClick();
                    return true;
                case Keys.F6:
                    btnProducts.PerformClick();
                    return true;
                case Keys.F7:
                    btnStocks.PerformClick();
                    return true;
                case Keys.F8:
                    btnSuppliers.PerformClick();
                    return true;
                case Keys.F9:
                    btnReports.PerformClick();
                    return true;
                case Keys.F10:
                    btnPO.PerformClick();
                    return true;
                case Keys.Escape:
                    metroTile1.PerformClick();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MetroMessageBox.Show(this, "Are You Sure?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO audit (userID, aDate, aTime, description) VALUES (@userID, @aDate, @aTime, @description)";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("userID", lbl3.Text);
                    cmd.Parameters.AddWithValue("aDate", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("aTime", DateTime.Now.ToShortTimeString());
                    cmd.Parameters.AddWithValue("description", "Successfully Logout!");
                    cmd.ExecuteNonQuery();
                    con.Close();

                    Login nxt = new Login();
                    nxt.Show();
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //getting values from other form
        public string lastname;
        public string fname;
        public string mname;
        public string classification;
        public string id;
        public void setField(string newlastname, string newfname, string newmname, string newclassification, string newid)
        {
            this.lastname = newlastname;
            this.fname = newfname;
            this.mname = newmname;
            this.classification = newclassification;
            this.id = newid;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lbllast.Text = this.lastname + ", " + this.fname +" "+ this.mname + ".";
            lbl2.Text = this.classification;
            lbl3.Text = this.id;
            lbl4.Text = DateTime.Now.ToLongDateString();
            lbltime.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Logs nxt = new Logs();
            nxt.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customers nxt = new Customers();
            nxt.setField(id);
            nxt.ShowDialog();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            if (lbl2.Text == "Admin" || lbl2.Text == "Masteraccount")
            {
                Suppliers nxt = new Suppliers();
                nxt.setField(id);
                nxt.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "Your Not Allowed To Access This Form", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (lbl2.Text == "Admin" || lbl2.Text == "Masteraccount")
            {
                Users nxt = new Users();
                nxt.setField(id);
                nxt.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "Your Not Allowed To Access This Form", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (lbl2.Text == "Admin" || lbl2.Text == "Masteraccount")
            {
                Products nxt = new Products();
                nxt.setField(id);
                nxt.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "Your Not Allowed To Access This Form", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            if (lbl2.Text == "Admin" || lbl2.Text == "Masteraccount")
            {
                stockInformation nxt = new stockInformation();
                nxt.setField(id);
                nxt.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "Your Not Allowed To Access This Form", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void btnPos_Click(object sender, EventArgs e)
        {
            Cashier nxt = new Cashier();
            nxt.setField(id, lastname, fname, mname);
            nxt.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (lbl2.Text == "Admin" || lbl2.Text == "Masteraccount")
            {
                pincode pin = new pincode();
                pin.ShowDialog();

                Reports nxt = new Reports();
                nxt.setField(id);
                nxt.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "Your Not Allowed To Access This Form", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private bool _altF4Pressed;
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (lbl2.Text == "Admin" || lbl2.Text == "Masteraccount")
            {
                backupandrestore nxt = new backupandrestore();
                nxt.setField(id);
                nxt.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "Your Not Allowed To Access This Form", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Orders nxt = new Orders();
            nxt.setField(id, lastname, fname, mname);
            nxt.ShowDialog();
        }

        private void btnPO_Click(object sender, EventArgs e)
        {
            if (lbl2.Text == "Admin" || lbl2.Text == "Masteraccount")
            {
                
                purchaseOrder nxt = new purchaseOrder();
                nxt.setField(id);
                nxt.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "Your Not Allowed To Access This Form", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
