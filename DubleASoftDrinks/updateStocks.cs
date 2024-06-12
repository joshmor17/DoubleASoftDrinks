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
    public partial class updateStocks : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = "); //Connection
        private stockInformation frm1;
        public updateStocks(stockInformation frm)
        {
            InitializeComponent();
            frm1 = frm;
            generateautoID();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generateautoID()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(stockID) FROM stocks";
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            i++;
            lbl5.Text = 1000 + i.ToString();
        }

        public int updateID;
        public void setupdate(int num)
        {
            this.updateID = num;
        }

        private void updateStocks_Load(object sender, EventArgs e)
        {
            lbl5.Hide();

            tbID.Text = this.updateID.ToString();
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM stockview WHERE prodID = '" + this.updateID + "'";
            cmd.ExecuteNonQuery();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                tbName.Text = dataReader["prodName"].ToString();
                tbCurrent.Text = dataReader["Total"].ToString();
            }
            con.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if (tbStock.Text == String.Empty)
            {
                MetroMessageBox.Show(this, "Invalid Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO stocks (stockID, prodID, quantity, stockDate, stockDelivered) VALUES (@stockID, @prodID, @quantity, @stockDate, @stockDelivered)");
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("stockID", lbl5.Text);
                cmd.Parameters.AddWithValue("prodID", tbID.Text);
                cmd.Parameters.AddWithValue("quantity", tbCurrent.Text);
                cmd.Parameters.AddWithValue("stockDate", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("stockDelivered", tbStock.Text);
                cmd.ExecuteNonQuery();
                MetroMessageBox.Show(this, "Successful");
                con.Close();

                stockInformation nxt = new stockInformation();
                frm1.loaddata();
                nxt.Show();
                this.Close();
            }
        }
    }
}
