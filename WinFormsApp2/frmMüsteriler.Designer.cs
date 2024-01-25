namespace WinFormsApp2
{
    partial class frmMüsteriler
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMüsteriler));
            toolStrip1 = new ToolStrip();
            btnYeniKayit = new ToolStripButton();
            panel1 = new Panel();
            btnAra = new Button();
            label1 = new Label();
            txtAra = new TextBox();
            gridList = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuItemSil = new ToolStripMenuItem();
            menuItemDuzenle = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnYeniKayit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(967, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnYeniKayit
            // 
            btnYeniKayit.Image = (Image)resources.GetObject("btnYeniKayit.Image");
            btnYeniKayit.ImageTransparentColor = Color.Magenta;
            btnYeniKayit.Name = "btnYeniKayit";
            btnYeniKayit.Size = new Size(97, 24);
            btnYeniKayit.Text = "Yeni Kayıt";
            btnYeniKayit.Click += btnYeniKayit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAra);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtAra);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 94);
            panel1.TabIndex = 1;
            // 
            // btnAra
            // 
            btnAra.ForeColor = SystemColors.ControlText;
            btnAra.Image = (Image)resources.GetObject("btnAra.Image");
            btnAra.Location = new Point(762, 24);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(73, 34);
            btnAra.TabIndex = 2;
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 34);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 1;
            label1.Text = "Müşteri Ara";
            // 
            // txtAra
            // 
            txtAra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAra.Location = new Point(117, 24);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(639, 34);
            txtAra.TabIndex = 0;
            txtAra.KeyPress += txtAra_KeyPress;
            // 
            // gridList
            // 
            gridList.AllowUserToAddRows = false;
            gridList.AllowUserToDeleteRows = false;
            gridList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridList.ContextMenuStrip = contextMenuStrip1;
            gridList.Dock = DockStyle.Fill;
            gridList.Location = new Point(0, 121);
            gridList.Name = "gridList";
            gridList.ReadOnly = true;
            gridList.RowHeadersWidth = 51;
            gridList.RowTemplate.Height = 29;
            gridList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridList.Size = new Size(967, 444);
            gridList.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { menuItemSil, menuItemDuzenle });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(133, 52);
            // 
            // menuItemSil
            // 
            menuItemSil.Name = "menuItemSil";
            menuItemSil.Size = new Size(132, 24);
            menuItemSil.Text = "Sil";
            menuItemSil.Click += menuItemSil_Click;
            // 
            // menuItemDuzenle
            // 
            menuItemDuzenle.Name = "menuItemDuzenle";
            menuItemDuzenle.Size = new Size(132, 24);
            menuItemDuzenle.Text = "Düzenle";
            menuItemDuzenle.Click += menuItemDuzenle_Click;
            // 
            // frmMüsteriler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 565);
            Controls.Add(gridList);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "frmMüsteriler";
            Text = "Müsteriler";
            WindowState = FormWindowState.Maximized;
            Load += frmMüsteriler_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnYeniKayit;
        private Panel panel1;
        private Button btnAra;
        private Label label1;
        private TextBox txtAra;
        private DataGridView gridList;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuItemSil;
        private ToolStripMenuItem menuItemDuzenle;
    }
}