namespace TP1
{
    partial class MenuUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUtama));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnBeli = new System.Windows.Forms.Button();
            this.btnKatalog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbJenis = new System.Windows.Forms.ComboBox();
            this.cmbHarga = new System.Windows.Forms.ComboBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Turquoise;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(141, 333);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.MintCream;
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.DeepPink;
            this.btnLogOut.Location = new System.Drawing.Point(24, 261);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(97, 60);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnBeli
            // 
            this.btnBeli.BackColor = System.Drawing.Color.MintCream;
            this.btnBeli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeli.BackgroundImage")));
            this.btnBeli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeli.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeli.ForeColor = System.Drawing.Color.Gold;
            this.btnBeli.Location = new System.Drawing.Point(24, 25);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(97, 50);
            this.btnBeli.TabIndex = 4;
            this.btnBeli.Text = "Menu Beli";
            this.btnBeli.UseVisualStyleBackColor = false;
            // 
            // btnKatalog
            // 
            this.btnKatalog.BackColor = System.Drawing.Color.MintCream;
            this.btnKatalog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKatalog.BackgroundImage")));
            this.btnKatalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKatalog.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKatalog.ForeColor = System.Drawing.Color.Gold;
            this.btnKatalog.Location = new System.Drawing.Point(24, 96);
            this.btnKatalog.Name = "btnKatalog";
            this.btnKatalog.Size = new System.Drawing.Size(97, 53);
            this.btnKatalog.TabIndex = 5;
            this.btnKatalog.Text = "Menu Katalog";
            this.btnKatalog.UseVisualStyleBackColor = false;
            this.btnKatalog.Click += new System.EventHandler(this.btnKatalog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Misael Trifosa 1805100";
            // 
            // cmbJenis
            // 
            this.cmbJenis.FormattingEnabled = true;
            this.cmbJenis.Location = new System.Drawing.Point(259, 17);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(111, 21);
            this.cmbJenis.TabIndex = 7;
            this.cmbJenis.Text = "Jenis Barang";
            // 
            // cmbHarga
            // 
            this.cmbHarga.FormattingEnabled = true;
            this.cmbHarga.Location = new System.Drawing.Point(376, 17);
            this.cmbHarga.Name = "cmbHarga";
            this.cmbHarga.Size = new System.Drawing.Size(99, 21);
            this.cmbHarga.TabIndex = 8;
            this.cmbHarga.Text = "Harga";
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.MintCream;
            this.btnCari.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.Location = new System.Drawing.Point(481, 12);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(68, 28);
            this.btnCari.TabIndex = 9;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 333);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.cmbHarga);
            this.Controls.Add(this.cmbJenis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKatalog);
            this.Controls.Add(this.btnBeli);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.splitter1);
            this.Name = "MenuUtama";
            this.Text = "MenuUtama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Button btnKatalog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.ComboBox cmbHarga;
        private System.Windows.Forms.Button btnCari;
    }
}