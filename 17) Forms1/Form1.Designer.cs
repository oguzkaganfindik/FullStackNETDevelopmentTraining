namespace Forms1
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
            label1 = new Label();
            button1 = new Button();
            btnButton1 = new Button();
            btnDeneme2 = new Button();
            txtMesaj = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(256, 50);
            label1.Name = "label1";
            label1.Size = new Size(254, 32);
            label1.TabIndex = 0;
            label1.Text = "İlk Form Uygulamam";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(256, 128);
            button1.Name = "button1";
            button1.Size = new Size(254, 119);
            button1.TabIndex = 1;
            button1.Text = "MESAJ VER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // btnButton1
            // 
            btnButton1.Location = new Point(276, 263);
            btnButton1.Name = "btnButton1";
            btnButton1.Size = new Size(207, 50);
            btnButton1.TabIndex = 2;
            btnButton1.Text = "Deneme butonu 1";
            btnButton1.UseVisualStyleBackColor = true;
            btnButton1.Click += btnButton1_Click;
            // 
            // btnDeneme2
            // 
            btnDeneme2.Location = new Point(276, 387);
            btnDeneme2.Name = "btnDeneme2";
            btnDeneme2.Size = new Size(207, 36);
            btnDeneme2.TabIndex = 3;
            btnDeneme2.Text = "Deneme Butonu 2";
            btnDeneme2.UseVisualStyleBackColor = true;
            btnDeneme2.Click += btnDeneme2_Click;
            // 
            // txtMesaj
            // 
            txtMesaj.Location = new Point(315, 336);
            txtMesaj.Name = "txtMesaj";
            txtMesaj.Size = new Size(120, 27);
            txtMesaj.TabIndex = 4;
            txtMesaj.TextChanged += txtMesaj_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMesaj);
            Controls.Add(btnDeneme2);
            Controls.Add(btnButton1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btnButton1;
        private Button btnDeneme2;
        private TextBox txtMesaj;
    }
}