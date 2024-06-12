using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DubleASoftDrinks
{
    public partial class purchaseOrder : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        public purchaseOrder()
        {
            InitializeComponent();
            loadcritical();
            loadsupplier();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    btnDelivery.PerformClick();
                    return true;
                case Keys.Enter:
                    btnPrint.PerformClick();
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

        private void purchaseOrder_Load(object sender, EventArgs e)
        {
            lbluserid.Text = this.id;
            lbluserid.Hide();
        }

        public void loadcritical()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT prodID AS 'Product ID', prodName AS 'Product Name', price AS 'Price', category AS 'Brand', inventorycount AS 'Stocks' FROM products WHERE inventorycount <= 15 Order by prodID";
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

        private void dtgvcritical_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addQuantity nxt = new addQuantity();
            nxt.ShowDialog();
            double qty = nxt.getQuantity();
            string prodName = dtgvcritical.CurrentRow.Cells[1].Value.ToString();
            string brand = dtgvcritical.CurrentRow.Cells[3].Value.ToString();

            if (qty != 0)
            {
                dtgv2.Rows.Add(prodName, brand, qty);
            }
        }

        private void dtgv2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgv2.CurrentRow.Visible = false;
        }

        private void loadsupplier()
        {
            if (cboSupplier.Items.Count != 0)
            {
                cboSupplier.Items.Clear();
            }
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * FROM supplier order by sID";

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboSupplier.Items.Add(reader["suppName"].ToString());
            }
            con.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroMessageBox.Show(this, "Are You Sure?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (cboSupplier.Text == String.Empty)
                {
                    MetroMessageBox.Show(this, "Invalid Input");
                }
                else
                {
                    int holder = dtgv2.Rows.Count;
                    for (int i = 0; i < holder; i++)
                    {
                        if (dtgv2.Rows[i].Visible == true)
                        {
                            con.Open();
                            MySqlCommand cmd1 = con.CreateCommand();
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandText = "INSERT INTO tempopurchase (suppName, prodName, brandName, quantity, poDate, poTime) VALUES ('" + cboSupplier.Text + "','" + dtgv2.Rows[i].Cells[0].Value.ToString() + "','" + dtgv2.Rows[i].Cells[1].Value.ToString() + "','" + dtgv2.Rows[i].Cells[2].Value.ToString() + "','" + DateTime.Now.ToShortDateString() + "','" + DateTime.Now.ToShortTimeString() + "')";
                            cmd1.Connection = con;
                            cmd1.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }

                poListrpt nxt = new poListrpt();
                nxt.ShowDialog();
                dtgv2.Rows.Clear();
            }
         }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            newDelivery nxt = new newDelivery();
            nxt.ShowDialog();
        }
    }
}
