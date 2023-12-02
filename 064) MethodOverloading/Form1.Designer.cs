namespace _064__MethodOverloading
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
            pictureBox1 = new PictureBox();
            btnSaldir = new Button();
            btnOkAt = new Button();
            pictureBox2 = new PictureBox();
            btnBuyuYap = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 286);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnSaldir
            // 
            btnSaldir.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaldir.Location = new Point(12, 320);
            btnSaldir.Name = "btnSaldir";
            btnSaldir.Size = new Size(291, 61);
            btnSaldir.TabIndex = 1;
            btnSaldir.Text = "Saldır";
            btnSaldir.UseVisualStyleBackColor = true;
            btnSaldir.Click += btnSaldir_Click;
            // 
            // btnOkAt
            // 
            btnOkAt.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnOkAt.Location = new Point(330, 320);
            btnOkAt.Name = "btnOkAt";
            btnOkAt.Size = new Size(291, 61);
            btnOkAt.TabIndex = 3;
            btnOkAt.Text = "Ok At";
            btnOkAt.UseVisualStyleBackColor = true;
            btnOkAt.Click += btnOkAt_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(330, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(291, 286);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnBuyuYap
            // 
            btnBuyuYap.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuyuYap.Location = new Point(650, 320);
            btnBuyuYap.Name = "btnBuyuYap";
            btnBuyuYap.Size = new Size(291, 61);
            btnBuyuYap.TabIndex = 5;
            btnBuyuYap.Text = "Büyü Yap";
            btnBuyuYap.UseVisualStyleBackColor = true;
            btnBuyuYap.Click += btnBuyuYap_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(650, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(291, 286);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 414);
            Controls.Add(btnBuyuYap);
            Controls.Add(pictureBox3);
            Controls.Add(btnOkAt);
            Controls.Add(pictureBox2);
            Controls.Add(btnSaldir);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnSaldir;
        private Button btnOkAt;
        private PictureBox pictureBox2;
        private Button btnBuyuYap;
        private PictureBox pictureBox3;
    }
}