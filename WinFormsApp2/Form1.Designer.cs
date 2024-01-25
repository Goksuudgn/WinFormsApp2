namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            uygulamayıKapatToolStripMenuItem = new ToolStripMenuItem();
            cariKartlarToolStripMenuItem = new ToolStripMenuItem();
            müşterilerToolStripMenuItem = new ToolStripMenuItem();
            tedarikçilerToolStripMenuItem = new ToolStripMenuItem();
            ürünYönetimiToolStripMenuItem = new ToolStripMenuItem();
            ürünListesiToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, cariKartlarToolStripMenuItem, ürünYönetimiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1107, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uygulamayıKapatToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(64, 24);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // uygulamayıKapatToolStripMenuItem
            // 
            uygulamayıKapatToolStripMenuItem.Name = "uygulamayıKapatToolStripMenuItem";
            uygulamayıKapatToolStripMenuItem.Size = new Size(213, 26);
            uygulamayıKapatToolStripMenuItem.Text = "Uygulamayı Kapat";
            // 
            // cariKartlarToolStripMenuItem
            // 
            cariKartlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { müşterilerToolStripMenuItem, tedarikçilerToolStripMenuItem });
            cariKartlarToolStripMenuItem.Name = "cariKartlarToolStripMenuItem";
            cariKartlarToolStripMenuItem.Size = new Size(97, 24);
            cariKartlarToolStripMenuItem.Text = "Cari Kartlar";
            // 
            // müşterilerToolStripMenuItem
            // 
            müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            müşterilerToolStripMenuItem.Size = new Size(224, 26);
            müşterilerToolStripMenuItem.Text = "Müşteriler";
            müşterilerToolStripMenuItem.Click += müşterilerToolStripMenuItem_Click;
            // 
            // tedarikçilerToolStripMenuItem
            // 
            tedarikçilerToolStripMenuItem.Name = "tedarikçilerToolStripMenuItem";
            tedarikçilerToolStripMenuItem.Size = new Size(224, 26);
            tedarikçilerToolStripMenuItem.Text = "Tedarikçiler";
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ürünListesiToolStripMenuItem });
            ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            ürünYönetimiToolStripMenuItem.Size = new Size(116, 24);
            ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // ürünListesiToolStripMenuItem
            // 
            ürünListesiToolStripMenuItem.Name = "ürünListesiToolStripMenuItem";
            ürünListesiToolStripMenuItem.Size = new Size(167, 26);
            ürünListesiToolStripMenuItem.Text = "Ürün Listesi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 626);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem uygulamayıKapatToolStripMenuItem;
        private ToolStripMenuItem cariKartlarToolStripMenuItem;
        private ToolStripMenuItem müşterilerToolStripMenuItem;
        private ToolStripMenuItem tedarikçilerToolStripMenuItem;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private ToolStripMenuItem ürünListesiToolStripMenuItem;
    }
}
