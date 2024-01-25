namespace WinFormsApp2
{
    partial class frmMusteri
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
            label = new Label();
            txtCustomerID = new TextBox();
            label1 = new Label();
            txtCompanyName = new TextBox();
            label2 = new Label();
            txtContactName = new TextBox();
            label3 = new Label();
            txtCity = new TextBox();
            label4 = new Label();
            txtCountry = new TextBox();
            btnKaydet = new Button();
            btnVazgec = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.BorderStyle = BorderStyle.Fixed3D;
            label.Location = new Point(36, 45);
            label.Name = "label";
            label.Size = new Size(137, 25);
            label.TabIndex = 0;
            label.Text = "Customer ID :";
            label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomerID.Location = new Point(179, 45);
            txtCustomerID.MaxLength = 5;
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(559, 34);
            txtCustomerID.TabIndex = 0;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(36, 70);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 0;
            label1.Text = "Company Name :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCompanyName.Location = new Point(179, 70);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(559, 34);
            txtCompanyName.TabIndex = 1;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(36, 95);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 0;
            label2.Text = "Contact Name :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtContactName
            // 
            txtContactName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContactName.Location = new Point(179, 95);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(559, 34);
            txtContactName.TabIndex = 2;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(36, 120);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 0;
            label3.Text = "City :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.Location = new Point(179, 120);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(559, 34);
            txtCity.TabIndex = 3;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(36, 145);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 0;
            label4.Text = "Country :";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCountry.Location = new Point(179, 145);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(559, 34);
            txtCountry.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydet.Location = new Point(664, 244);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(124, 59);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnVazgec
            // 
            btnVazgec.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVazgec.Location = new Point(534, 244);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.Size = new Size(124, 59);
            btnVazgec.TabIndex = 6;
            btnVazgec.Text = "Vazgeç";
            btnVazgec.UseVisualStyleBackColor = true;
            btnVazgec.Click += btnVazgec_Click;
            // 
            // frmMusteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVazgec);
            Controls.Add(btnKaydet);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtContactName);
            Controls.Add(txtCompanyName);
            Controls.Add(txtCustomerID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Name = "frmMusteri";
            Text = "Müşteri Bilgileri";
            Load += frmMusteri_Load;
            KeyDown += frmMusteri_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnKaydet;
        private Button btnVazgec;
        public TextBox txtCustomerID;
        public TextBox txtCompanyName;
        public TextBox txtContactName;
        public TextBox txtCity;
        public TextBox txtCountry;
    }
}