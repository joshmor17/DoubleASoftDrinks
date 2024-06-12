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
    public partial class backupandrestore : MetroForm
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=igwt; user = root; password = ");
        public backupandrestore()
        {
            InitializeComponent();
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

        private void backupandrestore_Load(object sender, EventArgs e)
        {
            lbluserid.Hide();
            lbluserid.Text = this.id;
        }
        

        public MySqlCommand command;
        public MySqlConnection connect;
        public MySqlDataReader reader;

        
        private void btnbackup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog f = new SaveFileDialog();
                f.InitialDirectory = "C:\\";
                f.FilterIndex = 1;
                f.OverwritePrompt = true;
                f.Filter = @"SQL Backup files (*.sql) |*.sql|All files(*.*) |*.*";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    string con = "server=localhost;user=root;password=;Database=igwt;";
                    string file = f.FileName;
                    string filen = @"C:";

                    using (connect = new MySqlConnection(con))
                    {
                        using (command = new MySqlCommand())
                        {
                            using (MySqlBackup bk = new MySqlBackup(command))
                            {
                                command.Connection = connect;
                                connect.Open();
                                bk.ExportToFile(file);

                                connect.Close();
                            }
                        }
                    }

                    using (connect = new MySqlConnection(con))
                    {
                        using (command = new MySqlCommand())
                        {
                            using (MySqlBackup bk = new MySqlBackup(command))
                            {
                                command.Connection = connect;
                                connect.Open();

                                bk.ExportToFile(filen);
                                connect.Close();

                                MetroMessageBox.Show(this, "BackUp Success");
                            }
                        }
                    }
                }
                Menu nxt = new Menu();
                nxt.Show();
                this.Close();
            } catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void btnrestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.InitialDirectory = "C:\\";
            f.Filter = @"SQL Backup files (*.sql) |*.sql|All files(*.*) |*.*";
            if (f.ShowDialog() == DialogResult.OK)
            {
                string con = "server=localhost;user=root;password=;Database=igwt;";
                string file = f.FileName;

                using (connect = new MySqlConnection(con))
                {
                    using (command = new MySqlCommand())
                    {
                        using (MySqlBackup bk = new MySqlBackup(command))
                        {
                            command.Connection = connect;
                            connect.Open();
                            bk.ImportFromFile(file);
                            connect.Close();

                            MetroMessageBox.Show(this,"Restore Success");
                        }
                    }
                }
            }
            Menu nxt = new Menu();
            nxt.Show();
            this.Hide();
        }
    }
}
