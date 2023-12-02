namespace _27__AtYarisiOyunuFormUygulamasi
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            lblFinish = new Label();
            btnBaslat = new Button();
            btnSifirla = new Button();
            pcbAt3 = new PictureBox();
            pcbAt2 = new PictureBox();
            pcbAt1 = new PictureBox();
            lblDurum = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            txtTahmin = new TextBox();
            btnTahmin = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbAt3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAt2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAt1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(12, 230);
            label1.Name = "label1";
            label1.Size = new Size(634, 16);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(12, 379);
            label2.Name = "label2";
            label2.Size = new Size(634, 16);
            label2.TabIndex = 1;
            // 
            // lblFinish
            // 
            lblFinish.BackColor = Color.White;
            lblFinish.Location = new Point(680, 107);
            lblFinish.Name = "lblFinish";
            lblFinish.Size = new Size(10, 415);
            lblFinish.TabIndex = 2;
            // 
            // btnBaslat
            // 
            btnBaslat.BackColor = Color.DarkGreen;
            btnBaslat.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaslat.ForeColor = Color.White;
            btnBaslat.Location = new Point(535, 12);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(142, 82);
            btnBaslat.TabIndex = 3;
            btnBaslat.Text = "YARIŞI BAŞLAT";
            btnBaslat.UseVisualStyleBackColor = false;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // btnSifirla
            // 
            btnSifirla.BackColor = Color.DarkGreen;
            btnSifirla.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSifirla.ForeColor = Color.White;
            btnSifirla.Location = new Point(696, 12);
            btnSifirla.Name = "btnSifirla";
            btnSifirla.Size = new Size(142, 82);
            btnSifirla.TabIndex = 4;
            btnSifirla.Text = "YARIŞI SIFIRLA";
            btnSifirla.UseVisualStyleBackColor = false;
            btnSifirla.Click += btnSifirla_Click;
            // 
            // pcbAt3
            // 
            pcbAt3.Image = (Image)resources.GetObject("pcbAt3.Image");
            pcbAt3.Location = new Point(12, 407);
            pcbAt3.Name = "pcbAt3";
            pcbAt3.Size = new Size(171, 118);
            pcbAt3.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAt3.TabIndex = 7;
            pcbAt3.TabStop = false;
            // 
            // pcbAt2
            // 
            pcbAt2.Image = (Image)resources.GetObject("pcbAt2.Image");
            pcbAt2.Location = new Point(12, 258);
            pcbAt2.Name = "pcbAt2";
            pcbAt2.Size = new Size(171, 118);
            pcbAt2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAt2.TabIndex = 8;
            pcbAt2.TabStop = false;
            // 
            // pcbAt1
            // 
            pcbAt1.Image = (Image)resources.GetObject("pcbAt1.Image");
            pcbAt1.Location = new Point(12, 107);
            pcbAt1.Name = "pcbAt1";
            pcbAt1.Size = new Size(171, 118);
            pcbAt1.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAt1.TabIndex = 9;
            pcbAt1.TabStop = false;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblDurum.ForeColor = Color.White;
            lblDurum.Location = new Point(12, 22);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(30, 35);
            lblDurum.TabIndex = 10;
            lblDurum.Text = "-";
            // 
            // timer1
            // 
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // txtTahmin
            // 
            txtTahmin.Location = new Point(696, 407);
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(142, 27);
            txtTahmin.TabIndex = 11;
            // 
            // btnTahmin
            // 
            btnTahmin.BackColor = Color.DarkGreen;
            btnTahmin.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnTahmin.ForeColor = Color.White;
            btnTahmin.Location = new Point(696, 440);
            btnTahmin.Name = "btnTahmin";
            btnTahmin.Size = new Size(142, 82);
            btnTahmin.TabIndex = 12;
            btnTahmin.Text = "TAHMİN";
            btnTahmin.UseVisualStyleBackColor = false;
            btnTahmin.Click += btnTahmin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(48, 107);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 13;
            label3.Text = "Gönlüşahane";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(48, 258);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 14;
            label4.Text = "Karasevda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(48, 407);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 15;
            label5.Text = "Küheylan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(848, 531);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnTahmin);
            Controls.Add(txtTahmin);
            Controls.Add(lblDurum);
            Controls.Add(pcbAt1);
            Controls.Add(pcbAt2);
            Controls.Add(pcbAt3);
            Controls.Add(btnSifirla);
            Controls.Add(btnBaslat);
            Controls.Add(lblFinish);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pcbAt3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAt2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAt1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblFinish;
        private Button btnBaslat;
        private Button btnSifirla;
        private PictureBox pcbAt3;
        private PictureBox pcbAt2;
        private PictureBox pcbAt1;
        private Label lblDurum;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtTahmin;
        private Button btnTahmin;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}