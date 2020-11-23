namespace Papatia
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ServerName = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.KullaniciTxt = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Giris = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.hatirla = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(33, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(247, 22);
            this.textBox1.TabIndex = 3;
            // 
            // ServerName
            // 
            this.ServerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServerName.AutoSize = true;
            this.ServerName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ServerName.ForeColor = System.Drawing.Color.Black;
            this.ServerName.Location = new System.Drawing.Point(12, 9);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(79, 17);
            this.ServerName.TabIndex = 9;
            this.ServerName.Text = "Sunucu Adı";
            // 
            // UserName
            // 
            this.UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserName.ForeColor = System.Drawing.Color.Black;
            this.UserName.Location = new System.Drawing.Point(12, 136);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(86, 17);
            this.UserName.TabIndex = 6;
            this.UserName.Text = "Kullanıcı Adı";
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.Location = new System.Drawing.Point(12, 198);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(33, 17);
            this.Password.TabIndex = 7;
            this.Password.Text = "Şifre";
            // 
            // KullaniciTxt
            // 
            this.KullaniciTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KullaniciTxt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciTxt.Location = new System.Drawing.Point(33, 156);
            this.KullaniciTxt.Name = "KullaniciTxt";
            this.KullaniciTxt.Size = new System.Drawing.Size(247, 22);
            this.KullaniciTxt.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-119, 353);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(313, 296);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // Giris
            // 
            this.Giris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Giris.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Giris.BackColor = System.Drawing.Color.Gold;
            this.Giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Giris.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Giris.ForeColor = System.Drawing.Color.Snow;
            this.Giris.Location = new System.Drawing.Point(104, 299);
            this.Giris.Name = "Giris";
            this.Giris.Size = new System.Drawing.Size(117, 48);
            this.Giris.TabIndex = 5;
            this.Giris.Text = "Giriş";
            this.Giris.UseVisualStyleBackColor = false;
            this.Giris.Click += new System.EventHandler(this.Giris_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sql Bağlantısı",
            "Windows Bağlantısı"});
            this.comboBox1.Location = new System.Drawing.Point(33, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Sql Bağlantısı";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Bağlantı Türü";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(309, 2);
            this.dataGridView1.TabIndex = 20;
            // 
            // txtserver
            // 
            this.txtserver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtserver.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtserver.Location = new System.Drawing.Point(33, 29);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(247, 22);
            this.txtserver.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(272, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 22);
            this.button2.TabIndex = 22;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(272, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 22);
            this.button1.TabIndex = 22;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // hatirla
            // 
            this.hatirla.AutoSize = true;
            this.hatirla.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hatirla.ForeColor = System.Drawing.Color.Black;
            this.hatirla.Location = new System.Drawing.Point(33, 257);
            this.hatirla.Name = "hatirla";
            this.hatirla.Size = new System.Drawing.Size(99, 21);
            this.hatirla.TabIndex = 4;
            this.hatirla.Text = "Beni Hatırla";
            this.hatirla.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(309, 532);
            this.Controls.Add(this.hatirla);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Giris);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.txtserver);
            this.Controls.Add(this.KullaniciTxt);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Papatia - Sql Server Bağlantı Bilgileri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ServerName;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox KullaniciTxt;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button Giris;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox hatirla;
    }
}

