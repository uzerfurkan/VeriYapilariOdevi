namespace VeriYapilariOdev1
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
            this.ekleBTN = new System.Windows.Forms.Button();
            this.cikarBTN = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.aracnoTXT = new System.Windows.Forms.TextBox();
            this.listeeBTN = new System.Windows.Forms.Button();
            this.ortBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekleBTN
            // 
            this.ekleBTN.Location = new System.Drawing.Point(198, 43);
            this.ekleBTN.Name = "ekleBTN";
            this.ekleBTN.Size = new System.Drawing.Size(75, 23);
            this.ekleBTN.TabIndex = 0;
            this.ekleBTN.Text = "Araç Ekleme";
            this.ekleBTN.UseVisualStyleBackColor = true;
            this.ekleBTN.Click += new System.EventHandler(this.ekleBTN_Click);
            // 
            // cikarBTN
            // 
            this.cikarBTN.Location = new System.Drawing.Point(322, 43);
            this.cikarBTN.Name = "cikarBTN";
            this.cikarBTN.Size = new System.Drawing.Size(75, 23);
            this.cikarBTN.TabIndex = 1;
            this.cikarBTN.Text = "Araç Çıkışı";
            this.cikarBTN.UseVisualStyleBackColor = true;
            this.cikarBTN.Click += new System.EventHandler(this.cikarBTN_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(44, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 173);
            this.listBox1.TabIndex = 3;
            // 
            // aracnoTXT
            // 
            this.aracnoTXT.Location = new System.Drawing.Point(44, 43);
            this.aracnoTXT.Name = "aracnoTXT";
            this.aracnoTXT.Size = new System.Drawing.Size(100, 20);
            this.aracnoTXT.TabIndex = 4;
            // 
            // listeeBTN
            // 
            this.listeeBTN.Location = new System.Drawing.Point(198, 97);
            this.listeeBTN.Name = "listeeBTN";
            this.listeeBTN.Size = new System.Drawing.Size(75, 23);
            this.listeeBTN.TabIndex = 5;
            this.listeeBTN.Text = "Liste Yenile";
            this.listeeBTN.UseVisualStyleBackColor = true;
            this.listeeBTN.Click += new System.EventHandler(this.listeeBTN_Click);
            // 
            // ortBTN
            // 
            this.ortBTN.Location = new System.Drawing.Point(322, 97);
            this.ortBTN.Name = "ortBTN";
            this.ortBTN.Size = new System.Drawing.Size(75, 23);
            this.ortBTN.TabIndex = 7;
            this.ortBTN.Text = "İşlem Ort.";
            this.ortBTN.UseVisualStyleBackColor = true;
            this.ortBTN.Click += new System.EventHandler(this.ortBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 345);
            this.Controls.Add(this.ortBTN);
            this.Controls.Add(this.listeeBTN);
            this.Controls.Add(this.aracnoTXT);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cikarBTN);
            this.Controls.Add(this.ekleBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ekleBTN;
        private System.Windows.Forms.Button cikarBTN;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox aracnoTXT;
        private System.Windows.Forms.Button listeeBTN;
        private System.Windows.Forms.Button ortBTN;
    }
}

