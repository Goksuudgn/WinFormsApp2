namespace WinFormsApp2
{
    partial class frmMusteriSil
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
            btnVazgec = new Button();
            btnSil = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label = new Label();
            lblCustomerId = new Label();
            lblCompanyName = new Label();
            lblContactName = new Label();
            lblCity = new Label();
            lblCountry = new Label();
            SuspendLayout();
            // 
            // btnVazgec
            // 
            btnVazgec.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVazgec.Location = new Point(528, 320);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.Size = new Size(124, 59);
            btnVazgec.TabIndex = 18;
            btnVazgec.Text = "Vazgeç";
            btnVazgec.UseVisualStyleBackColor = true;
            btnVazgec.Click += btnVazgec_Click_1;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSil.Location = new Point(658, 320);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(124, 59);
            btnSil.TabIndex = 17;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click_1;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(30, 252);
            label4.Name = "label4";
            label4.Size = new Size(153, 34);
            label4.TabIndex = 8;
            label4.Text = "Country :";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(30, 215);
            label3.Name = "label3";
            label3.Size = new Size(153, 37);
            label3.TabIndex = 9;
            label3.Text = "City :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(30, 177);
            label2.Name = "label2";
            label2.Size = new Size(153, 38);
            label2.TabIndex = 10;
            label2.Text = "Contact Name :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(30, 146);
            label1.Name = "label1";
            label1.Size = new Size(153, 31);
            label1.TabIndex = 11;
            label1.Text = "Company Name :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label
            // 
            label.BorderStyle = BorderStyle.Fixed3D;
            label.Location = new Point(30, 113);
            label.Name = "label";
            label.Size = new Size(153, 33);
            label.TabIndex = 12;
            label.Text = "Customer ID :";
            label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCustomerId
            // 
            lblCustomerId.BorderStyle = BorderStyle.Fixed3D;
            lblCustomerId.Location = new Point(189, 113);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(593, 33);
            lblCustomerId.TabIndex = 12;
            lblCustomerId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCompanyName
            // 
            lblCompanyName.BorderStyle = BorderStyle.Fixed3D;
            lblCompanyName.Location = new Point(189, 146);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(593, 31);
            lblCompanyName.TabIndex = 11;
            lblCompanyName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblContactName
            // 
            lblContactName.BorderStyle = BorderStyle.Fixed3D;
            lblContactName.Location = new Point(189, 177);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(593, 38);
            lblContactName.TabIndex = 10;
            lblContactName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCity
            // 
            lblCity.BorderStyle = BorderStyle.Fixed3D;
            lblCity.Location = new Point(189, 215);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(593, 37);
            lblCity.TabIndex = 9;
            lblCity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCountry
            // 
            lblCountry.BorderStyle = BorderStyle.Fixed3D;
            lblCountry.Location = new Point(189, 252);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(593, 34);
            lblCountry.TabIndex = 8;
            lblCountry.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmMusteriSil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVazgec);
            Controls.Add(btnSil);
            Controls.Add(lblCountry);
            Controls.Add(label4);
            Controls.Add(lblCity);
            Controls.Add(label3);
            Controls.Add(lblContactName);
            Controls.Add(label2);
            Controls.Add(lblCompanyName);
            Controls.Add(label1);
            Controls.Add(lblCustomerId);
            Controls.Add(label);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMusteriSil";
            Text = "Müşteri Sil";
            Load += frmMusteriSil_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVazgec;
        private Button btnSil;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label;
        private Label lblCustomerId;
        private Label lblCompanyName;
        private Label lblContactName;
        private Label lblCity;
        private Label lblCountry;
    }
}