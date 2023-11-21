namespace Forms2
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
            label2 = new Label();
            txtSayi1 = new TextBox();
            txtSayi2 = new TextBox();
            lblSonuc = new Label();
            btnTopla = new Button();
            btnCikar = new Button();
            btnBol = new Button();
            btnCarp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(86, 50);
            label1.Name = "label1";
            label1.Size = new Size(90, 35);
            label1.TabIndex = 0;
            label1.Text = "Sayı 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(86, 104);
            label2.Name = "label2";
            label2.Size = new Size(90, 35);
            label2.TabIndex = 1;
            label2.Text = "Sayı 2:";
            // 
            // txtSayi1
            // 
            txtSayi1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            txtSayi1.Location = new Point(221, 50);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(125, 41);
            txtSayi1.TabIndex = 2;
            // 
            // txtSayi2
            // 
            txtSayi2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            txtSayi2.Location = new Point(221, 104);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(125, 41);
            txtSayi2.TabIndex = 3;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblSonuc.Location = new Point(445, 81);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(25, 35);
            lblSonuc.TabIndex = 4;
            lblSonuc.Text = "-";
            // 
            // btnTopla
            // 
            btnTopla.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnTopla.Location = new Point(86, 218);
            btnTopla.Name = "btnTopla";
            btnTopla.Size = new Size(104, 49);
            btnTopla.TabIndex = 5;
            btnTopla.Text = "+";
            btnTopla.UseVisualStyleBackColor = true;
            btnTopla.Click += btnTopla_Click;
            // 
            // btnCikar
            // 
            btnCikar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCikar.Location = new Point(233, 218);
            btnCikar.Name = "btnCikar";
            btnCikar.Size = new Size(103, 49);
            btnCikar.TabIndex = 6;
            btnCikar.Text = "-";
            btnCikar.UseVisualStyleBackColor = true;
            btnCikar.Click += btnCikar_Click;
            // 
            // btnBol
            // 
            btnBol.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnBol.Location = new Point(386, 218);
            btnBol.Name = "btnBol";
            btnBol.Size = new Size(103, 49);
            btnBol.TabIndex = 7;
            btnBol.Text = "/";
            btnBol.UseVisualStyleBackColor = true;
            btnBol.Click += btnBol_Click;
            // 
            // btnCarp
            // 
            btnCarp.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCarp.Location = new Point(544, 218);
            btnCarp.Name = "btnCarp";
            btnCarp.Size = new Size(108, 49);
            btnCarp.TabIndex = 8;
            btnCarp.Text = "x";
            btnCarp.UseVisualStyleBackColor = true;
            btnCarp.Click += btnCarp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 309);
            Controls.Add(btnCarp);
            Controls.Add(btnBol);
            Controls.Add(btnCikar);
            Controls.Add(btnTopla);
            Controls.Add(lblSonuc);
            Controls.Add(txtSayi2);
            Controls.Add(txtSayi1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSayi1;
        private TextBox txtSayi2;
        private Label lblSonuc;
        private Button btnTopla;
        private Button btnCikar;
        private Button btnBol;
        private Button btnCarp;
    }
}