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
            txtInput = new TextBox();
            btnHash = new Button();
            txtOutput = new TextBox();
            SuspendLayout();

            // txtInput
            txtInput.Multiline = true;
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Location = new System.Drawing.Point(12, 12);
            txtInput.Size = new System.Drawing.Size(560, 200);
            txtInput.Font = new System.Drawing.Font("Consolas", 10);

            // btnHash
            btnHash.Location = new System.Drawing.Point(12, 220);
            btnHash.Size = new System.Drawing.Size(150, 35);
            btnHash.Text = "Compute SHA-256";
            btnHash.Click += btnHash_Click;
            // btnHash512

            btnHash512 = new Button();
            btnHash512.Location = new System.Drawing.Point(180, 220);
            btnHash512.Size = new System.Drawing.Size(150, 35);
            btnHash512.Text = "Compute SHA-512";
            btnHash512.Click += btnHash512_Click;
            Controls.Add(btnHash512);

            // txtOutput
            txtOutput.Multiline = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Location = new System.Drawing.Point(12, 265);
            txtOutput.Size = new System.Drawing.Size(560, 60);
            txtOutput.ReadOnly = true;
            txtOutput.Font = new System.Drawing.Font("Consolas", 10);

            // btnEncrypt
            btnEncrypt = new Button();
            btnEncrypt.Location = new System.Drawing.Point(350, 220);
            btnEncrypt.Size = new System.Drawing.Size(150, 35);
            btnEncrypt.Text = "AES Encrypt";
            btnEncrypt.Click += btnEncrypt_Click;
            Controls.Add(btnEncrypt);

            // btnDecrypt
            btnDecrypt = new Button();
            btnDecrypt.Location = new System.Drawing.Point(510, 220);   // Right of Encrypt button
            btnDecrypt.Size = new System.Drawing.Size(150, 35);         // Same height, wider
            btnDecrypt.Text = "AES Decrypt";
            btnDecrypt.Click += btnDecrypt_Click;
            Controls.Add(btnDecrypt);




            // txtCryptOutput
            txtCryptOutput = new TextBox();
            txtCryptOutput.Multiline = true;
            txtCryptOutput.ScrollBars = ScrollBars.Vertical;
            txtCryptOutput.Location = new System.Drawing.Point(12, 335);
            txtCryptOutput.Size = new System.Drawing.Size(560, 80);
            txtCryptOutput.ReadOnly = true;
            txtCryptOutput.Font = new System.Drawing.Font("Consolas", 10);
            Controls.Add(txtCryptOutput);

            // Form1
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            //update size when needed
           
            ClientSize = new System.Drawing.Size(680, 430);

            Controls.Add(txtInput);
            Controls.Add(btnHash);
            Controls.Add(txtOutput);
            Text = "Open CrypTool - use Clibboard and have fun - sha box is the key";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

