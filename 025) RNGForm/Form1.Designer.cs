namespace _25__RNGForm
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
            btnTahminEt = new Button();
            txtTahmin = new TextBox();
            textBox1 = new TextBox();
            lblRastgele = new Label();
            SuspendLayout();
            // 
            // btnTahminEt
            // 
            btnTahminEt.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnTahminEt.Location = new Point(152, 137);
            btnTahminEt.Name = "btnTahminEt";
            btnTahminEt.Size = new Size(158, 47);
            btnTahminEt.TabIndex = 0;
            btnTahminEt.Text = "Tahmin Et";
            btnTahminEt.UseVisualStyleBackColor = true;
            btnTahminEt.Click += btnTahminEt_Click;
            // 
            // txtTahmin
            // 
            txtTahmin.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            txtTahmin.Location = new Point(128, 67);
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(210, 42);
            txtTahmin.TabIndex = 1;
            txtTahmin.TextChanged += txtTahmin_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblRastgele
            // 
            lblRastgele.AutoSize = true;
            lblRastgele.Location = new Point(33, 23);
            lblRastgele.Name = "lblRastgele";
            lblRastgele.Size = new Size(50, 20);
            lblRastgele.TabIndex = 3;
            lblRastgele.Text = "label1";
            lblRastgele.Click += lblRastgele_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(463, 306);
            Controls.Add(lblRastgele);
            Controls.Add(textBox1);
            Controls.Add(txtTahmin);
            Controls.Add(btnTahminEt);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTahminEt;
        private TextBox txtTahmin;
        private TextBox textBox1;
        private Label lblRastgele;
    }
}