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
                connectionString = string.Format(@"Data Source={0};Initial Catalog={1}; Integrated Security=True;", Form1.sunucu, cboDatabase.Text);
                con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {

                }
                try
                {

                    con.Open();
                    string q = txtsorgu.Text;
                    SqlDataAdapter sda = new SqlDataAdapter(q, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    if (ds != null)
                    {
                        dgvsorgu.DataSource = ds;
                        MessageBox.Show(txtsorgu.Text + " Tamamlandı", "Başarılı");
                    }
                    if (ds != null && ds.Tables.Count > 0)
                    {

                        if (ds.Tables[0].Rows.Count != 0)
                        {
                            dgvsorgu.DataSource = ds.Tables[0];
                        }
                    }
                    con.Close();

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
                    connectionString = string.Format(@"Data Source ={0}; Initial Catalog={1}; User ID = {2}; Password = {3};", Form1.sunucu, cboDatabase.Text, Form1.kullanici_adi, Form1.sifre);
                    con = new SqlConnection(connectionString);
                        if (con.State == ConnectionState.Closed)
                        {

                            con.Open();
                            string qe = txtsorgu.Text;
                            SqlDataAdapter sdad = new SqlDataAdapter(qe, con);
                            DataSet dsd = new DataSet();
                            sdad.Fill(dsd);
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

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.sql != null)
            {
                connectionString = string.Format(@"Data Source ={0}; Integrated Security=True;", Form1.sunucu);
                con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            cboDatabase.Items.Add(dr[0]);
                        }
                    }

                }
            }

            if (Form1.windows != null)
            {
                connectionString = string.Format(@"Data Source ={0};Integrated Security=True;", Form1.sunucu);
                con = new SqlConnection(connectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            cboDatabase.Items.Add(dr[0]);
                        }
                    }

                }
            }
            
            cboDatabase.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboDatabase.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}
