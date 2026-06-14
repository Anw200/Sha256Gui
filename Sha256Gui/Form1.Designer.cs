namespace Sha256Gui
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        //sha values
        private TextBox txtInput;
        private Button btnHash;
        private Button btnHash512;
        private TextBox txtOutput;
        //crypto
        private TextBox txtCryptOutput;
        private Button btnEncrypt;
        private Button btnDecrypt;



        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtInput = new TextBox();
            btnHash = new Button();
            txtOutput = new TextBox();
            btnHash512 = new Button();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            txtCryptOutput = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Consolas", 10F);
            txtInput.Location = new Point(12, 12);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Size = new Size(560, 200);
            txtInput.TabIndex = 4;
            // 
            // btnHash
            // 
            btnHash.Location = new Point(12, 220);
            btnHash.Name = "btnHash";
            btnHash.Size = new Size(150, 35);
            btnHash.TabIndex = 5;
            btnHash.Text = "Compute SHA-256";
            btnHash.Click += btnHash_Click;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Consolas", 10F);
            txtOutput.Location = new Point(12, 265);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(560, 60);
            txtOutput.TabIndex = 6;
            // 
            // btnHash512
            // 
            btnHash512.Location = new Point(180, 220);
            btnHash512.Name = "btnHash512";
            btnHash512.Size = new Size(150, 35);
            btnHash512.TabIndex = 0;
            btnHash512.Text = "Compute SHA-512";
            btnHash512.Click += btnHash512_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(350, 220);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(150, 35);
            btnEncrypt.TabIndex = 1;
            btnEncrypt.Text = "AES Encrypt";
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(510, 220);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(150, 35);
            btnDecrypt.TabIndex = 2;
            btnDecrypt.Text = "AES Decrypt";
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // txtCryptOutput
            // 
            txtCryptOutput.Font = new Font("Consolas", 10F);
            txtCryptOutput.Location = new Point(12, 335);
            txtCryptOutput.Multiline = true;
            txtCryptOutput.Name = "txtCryptOutput";
            txtCryptOutput.ReadOnly = true;
            txtCryptOutput.ScrollBars = ScrollBars.Vertical;
            txtCryptOutput.Size = new Size(560, 80);
            txtCryptOutput.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(598, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(578, 116);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 8;
            label1.Text = "Input:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(578, 286);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 9;
            label2.Text = "# Value / AES key";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(577, 363);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 10;
            label3.Text = "Encrypt/Decrypt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(578, 138);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 11;
            label4.Text = "A secret";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(577, 159);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 12;
            label5.Text = "Or AES data";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 430);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnHash512);
            Controls.Add(btnEncrypt);
            Controls.Add(btnDecrypt);
            Controls.Add(txtCryptOutput);
            Controls.Add(txtInput);
            Controls.Add(btnHash);
            Controls.Add(txtOutput);
            Name = "Form1";
            Text = "Open CrypTool - it outputs to clib board  -> SHA box value is the key for AES";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}

