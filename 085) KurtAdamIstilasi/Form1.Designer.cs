namespace _085__KurtAdamIstilasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNickName = new TextBox();
            cmbRace = new ComboBox();
            cmbBranch = new ComboBox();
            btnChoose = new Button();
            btnAttack = new Button();
            pictureBox1 = new PictureBox();
            lblHealth = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 54);
            label1.Name = "label1";
            label1.Size = new Size(236, 32);
            label1.TabIndex = 0;
            label1.Text = "KARAKTER SEÇİMİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 108);
            label2.Name = "label2";
            label2.Size = new Size(72, 32);
            label2.TabIndex = 1;
            label2.Text = "İsim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 184);
            label3.Name = "label3";
            label3.Size = new Size(60, 32);
            label3.TabIndex = 2;
            label3.Text = "Irk:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 258);
            label4.Name = "label4";
            label4.Size = new Size(76, 32);
            label4.TabIndex = 3;
            label4.Text = "Sınıf:";
            // 
            // txtNickName
            // 
            txtNickName.Location = new Point(123, 101);
            txtNickName.Name = "txtNickName";
            txtNickName.Size = new Size(226, 40);
            txtNickName.TabIndex = 4;
            // 
            // cmbRace
            // 
            cmbRace.FormattingEnabled = true;
            cmbRace.Items.AddRange(new object[] { "İnsan", "Orc" });
            cmbRace.Location = new Point(123, 177);
            cmbRace.Name = "cmbRace";
            cmbRace.Size = new Size(226, 40);
            cmbRace.TabIndex = 5;
            // 
            // cmbBranch
            // 
            cmbBranch.FormattingEnabled = true;
            cmbBranch.Items.AddRange(new object[] { "Savaşçı", "Büyücü", "Okçu" });
            cmbBranch.Location = new Point(123, 251);
            cmbBranch.Name = "cmbBranch";
            cmbBranch.Size = new Size(226, 40);
            cmbBranch.TabIndex = 6;
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(32, 326);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(317, 52);
            btnChoose.TabIndex = 7;
            btnChoose.Text = "Seç";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // btnAttack
            // 
            btnAttack.Location = new Point(104, 428);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(181, 59);
            btnAttack.TabIndex = 8;
            btnAttack.Text = "Saldır";
            btnAttack.UseVisualStyleBackColor = true;
            btnAttack.Click += btnAttack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(417, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 386);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblHealth
            // 
            lblHealth.BackColor = Color.Maroon;
            lblHealth.Location = new Point(417, 54);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(291, 44);
            lblHealth.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 548);
            Controls.Add(lblHealth);
            Controls.Add(pictureBox1);
            Controls.Add(btnAttack);
            Controls.Add(btnChoose);
            Controls.Add(cmbBranch);
            Controls.Add(cmbRace);
            Controls.Add(txtNickName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNickName;
        private ComboBox cmbRace;
        private ComboBox cmbBranch;
        private Button btnChoose;
        private Button btnAttack;
        private PictureBox pictureBox1;
        private Label lblHealth;
    }
}
