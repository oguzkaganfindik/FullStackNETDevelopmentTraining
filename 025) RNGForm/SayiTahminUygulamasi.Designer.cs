namespace _25__RNGForm
{
    partial class SayiTahminUygulamasi
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
            txtTahmin = new TextBox();
            btnTahminEt = new Button();
            label1 = new Label();
            lblCanHakki = new Label();
            btnYenidenBasla = new Button();
            SuspendLayout();
            // 
            // txtTahmin
            // 
            txtTahmin.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtTahmin.Location = new Point(110, 50);
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(229, 42);
            txtTahmin.TabIndex = 0;
            // 
            // btnTahminEt
            // 
            btnTahminEt.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnTahminEt.Location = new Point(152, 94);
            btnTahminEt.Name = "btnTahminEt";
            btnTahminEt.Size = new Size(156, 61);
            btnTahminEt.TabIndex = 1;
            btnTahminEt.Text = "Tahmin Et";
            btnTahminEt.UseVisualStyleBackColor = true;
            btnTahminEt.Click += btnTahminEt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 211);
            label1.Name = "label1";
            label1.Size = new Size(193, 35);
            label1.TabIndex = 3;
            label1.Text = "CAN HAKKI : ";
            // 
            // lblCanHakki
            // 
            lblCanHakki.AutoSize = true;
            lblCanHakki.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblCanHakki.Location = new Point(202, 211);
            lblCanHakki.Name = "lblCanHakki";
            lblCanHakki.Size = new Size(30, 35);
            lblCanHakki.TabIndex = 4;
            lblCanHakki.Text = "-";
            // 
            // btnYenidenBasla
            // 
            btnYenidenBasla.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnYenidenBasla.Location = new Point(329, 170);
            btnYenidenBasla.Name = "btnYenidenBasla";
            btnYenidenBasla.Size = new Size(130, 92);
            btnYenidenBasla.TabIndex = 5;
            btnYenidenBasla.Text = "Yeniden Başlat";
            btnYenidenBasla.UseVisualStyleBackColor = true;
            btnYenidenBasla.Click += btnYenidenBasla_Click;
            // 
            // SayiTahminUygulamasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(471, 274);
            Controls.Add(btnYenidenBasla);
            Controls.Add(lblCanHakki);
            Controls.Add(label1);
            Controls.Add(btnTahminEt);
            Controls.Add(txtTahmin);
            Name = "SayiTahminUygulamasi";
            Text = "SayiTahminUygulamasi";
            Load += SayiTahminUygulamasi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTahmin;
        private Button btnTahminEt;
        private Label label1;
        private Label lblCanHakki;
        private Button btnYenidenBasla;
    }
}