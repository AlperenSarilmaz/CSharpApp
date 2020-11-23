using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Papatia
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        //Nesneler
        SqlConnection con;
        string connectionString;

        //Ana Sayfa
        private void label1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        //Sorgu Butonu
        private void btngiris_Click(object sender, EventArgs e)
        {
            //Windows Auth. ile bağlanınca:
                if (Form1.windows != null)
                {
                    try
                    {
                        connectionString = string.Format(@"Data Source={0};Integrated Security=True;", Form1.sunucu);
                        con = new SqlConnection(connectionString);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                            string q = txtsorgu.Text;
                            SqlDataAdapter sda = new SqlDataAdapter(q, con);
                            DataSet ds = new DataSet();
                            sda.Fill(ds);
                            con.Close();
                            dgvsorgu.DataSource = ds;
                            dgvsorgu.DataSource = ds.Tables[0];
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



            }
            //Sql Auth. ile bağlanınca:
            if (Form1.sql !=null)
            {
                try
                {
                    connectionString = string.Format(@"Data Source ={0}; User ID = {1}; Password = {2};", Form1.sunucu, Form1.kullanici_adi, Form1.sifre);
                    con = new SqlConnection(connectionString);
                    if (con.State == ConnectionState.Closed)
                    {
                        DataSet dsd = new DataSet();
                        string qe = txtsorgu.Text;
                        SqlDataAdapter sdad = new SqlDataAdapter(qe, con);
                        sdad.Fill(dsd);
                        con.Open();
                        dgvsorgu.ReadOnly = true;
                        dgvsorgu.DataSource = dsd;
                        dgvsorgu.DataSource = dsd.Tables[0];
                        con.Close();
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }

            
        }

    }
}
