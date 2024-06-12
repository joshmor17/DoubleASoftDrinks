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
using System.Text.RegularExpressions;

namespace DubleASoftDrinks
{
    public partial class Suppliers : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        public Suppliers()
        {
            InitializeComponent();
            loaddata();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    metroTile2.PerformClick();
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

        public int cellID;
        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loaddata()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT sID as 'Supplier ID', suppName 'Supplier Name' , suppAddress 'Address' , suppContact 'Contact Number', suppTin 'Tin No.' FROM supplier ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dtgv1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            addSuppliers nxt = new addSuppliers(this);
            nxt.setField(id);
            nxt.ShowDialog();
        }

        private void dtgv1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cellID = Int32.Parse(dtgv1.CurrentRow.Cells[0].Value.ToString());

            if (cellID != 0)
            {
                updateSuppliers nxt = new updateSuppliers(this);
                nxt.setupdate(this.cellID);
                nxt.setField(id);
                nxt.ShowDialog();

            }
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            lbluserid.Hide();
            lbluserid.Text = this.id;
        }

        private bool _altF4Pressed;
        private void Suppliers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }
        }

        private void Suppliers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT sID as 'Supplier ID', suppName 'Supplier Name' , suppAddress 'Address' , suppContact 'Contact Number', suppTin 'Tin No.' FROM supplier WHERE suppName LIKE '%"+tbFilter.Text+"%' ";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                    dtgv1.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
