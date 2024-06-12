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
    public partial class stockInformation : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        public stockInformation()
        {
            InitializeComponent();
            loaddata();
            loadcritical();
            loadbad();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    btnAddStocks.PerformClick();
                    return true;
                case Keys.F2:
                    btnbad.PerformClick();
                    return true;
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

        public void loadbad()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT prodID AS 'Product ID', prodName AS 'Product Name', prodqty AS 'Quantity', description AS 'Description', status AS 'Status' FROM badproducts WHERE status = 'Pending' Order by prodID";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dtgvbad.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        public void loaddata()
        {
            try
            {
                dtgv1.Rows.Clear();
                String[] array = new String[6];
                string getTodayTime = DateTime.Now.ToString();
                string query = "SELECT * FROM products Order by prodID; ";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows == false)
                {
                    MetroMessageBox.Show(this, "No Records Found", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public int cellID;

        private void stockInformation_Load(object sender, EventArgs e)
        {
            lbluserid.Hide();
            lbluserid.Text = this.id;
        }

        private bool _altF4Pressed;
        private void stockInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }

        private void stockInformation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }

        private void dtgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cellID = Int32.Parse(dtgv1.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnbad_Click(object sender, EventArgs e)
        {
            if (cellID != 0)
            {
                addBadProducts nxt = new addBadProducts(this);
                nxt.setupdate(this.cellID);
                nxt.setField(id);
                nxt.ShowDialog();

            }
            else { MetroMessageBox.Show(this,"Please Choose a Product First"); }
        }


        private void dtgvbad_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cellID = Int32.Parse(dtgvbad.CurrentRow.Cells[0].Value.ToString());

            if (cellID != 0)
            {
                updateBadProducts nxt = new updateBadProducts(this);
                nxt.setupdate(this.cellID);
                nxt.setField(id);
                nxt.ShowDialog();

            }
        }

        private void btnAddStocks_Click(object sender, EventArgs e)
        {
            addStocks nxt = new addStocks(this);
            nxt.setupdate(this.cellID);
            nxt.setField(id);
            nxt.ShowDialog();
        }
    }
}
