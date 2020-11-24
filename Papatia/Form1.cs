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
    public partial class Form1 : Form
    {
       
        

        public Form1()
        {
            InitializeComponent();
            
        }
        //Nesneler
        SqlConnection con;
        string connectionString;
        public static string sunucu, kullanici_adi, sifre;
        public static string sql, windows;

        //Şifre Gösteren tuş:
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '*')
            {
                button2.BringToFront();
                textBox1.PasswordChar = '\0';
            }
        }
        //Şifre Gizleyen tuş:
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '\0')
            {
                button1.BringToFront();
                textBox1.PasswordChar = '*';
            }

        }
        //Hatırlatma komutu:
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            if (Properties.Settings.Default.Sunucuadi != string.Empty)
            {
                txtserver.Text = Properties.Settings.Default.Sunucuadi;
                comboBox1.Text = Properties.Settings.Default.Bağlantı_Türü;
                KullaniciTxt.Text = Properties.Settings.Default.Kullanıcı_Adı;
                textBox1.Text = Properties.Settings.Default.Şifre;
                hatirla.Checked = true;
            }
        }

      

        //Windows Auth. seçili olunca kullanıcı şifre gizleme:
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Windows Bağlantısı")
            {
                KullaniciTxt.Enabled = false;
                textBox1.Enabled = false;
            }
            else
            {
                KullaniciTxt.Enabled = true;
                textBox1.Enabled = true;
            }
            
        }
       
        private void Giris_Click_1(object sender, EventArgs e)
        {
            //Hatırlama komutu:
            if (hatirla.Checked == true)
            {
                Properties.Settings.Default.Sunucuadi = txtserver.Text;
                Properties.Settings.Default.Bağlantı_Türü = comboBox1.Text;
                Properties.Settings.Default.Kullanıcı_Adı = KullaniciTxt.Text;
                Properties.Settings.Default.Şifre = textBox1.Text;
                Properties.Settings.Default.Save();
            }
            if (hatirla.Checked == false)
            {

                Properties.Settings.Default.Sunucuadi = "";
                Properties.Settings.Default.Bağlantı_Türü = "";
                Properties.Settings.Default.Kullanıcı_Adı = "";
                Properties.Settings.Default.Şifre = "";
                Properties.Settings.Default.Save();
            }

          //Sql Server'a bağlanma komutu:

            //Windows Auth. ile bağlanırken:
            if (comboBox1.Text=="Windows Bağlantısı") 
            {

                
                try
                {
                    connectionString = string.Format("Data Source={0};Integrated Security=True;", txtserver.Text);
                    con = new SqlConnection(connectionString);

                    if (txtserver.Text==string.Empty)
                    {
                        MessageBox.Show("Sunucu Adını giriniz");
                    }
                    else
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                            sunucu = txtserver.Text;
                            windows = comboBox1.Text;
                            Form2 f2 = new Form2();
                            f2.Show();
                            this.Hide();
                        }
                    }
                    
                   
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
            //Sql Auth. ile bağlanırken:
            if (comboBox1.Text=="Sql Bağlantısı")
            {
                
                     
                try
                {
                    connectionString = string.Format(@"Data Source ={0}; User ID = {1}; Password = {2};", txtserver.Text, KullaniciTxt.Text.Trim(), textBox1.Text.Trim());
                    con = new SqlConnection(connectionString);
                    if (txtserver.Text==string.Empty)
                    {
                        MessageBox.Show("Sunucu Adını Giriniz");
                    }
                    else
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                            sunucu = txtserver.Text;
                            kullanici_adi = KullaniciTxt.Text;
                            sifre = textBox1.Text;
                            sql = comboBox1.Text;
                            Form2 f2 = new Form2();
                            f2.Show();
                            this.Hide();
                        }

                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
      

        }
    }
}
