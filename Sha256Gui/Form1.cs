using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;



namespace Sha256Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Sha256
        private void btnHash_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            byte[] data = Encoding.UTF8.GetBytes(input);

            using SHA256 sha = SHA256.Create();
            byte[] hash = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
                sb.Append(b.ToString("x2"));

            string result = sb.ToString();
            txtOutput.Text = result;

            // Copy to clipboard
            Clipboard.SetText(result);
        }
        //sha512
        private void btnHash512_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            byte[] data = Encoding.UTF8.GetBytes(input);

            using SHA512 sha = SHA512.Create();
            byte[] hash = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
                sb.Append(b.ToString("x2"));

            string result = sb.ToString();
            txtOutput.Text = result;

            // Copy to clipboard
            Clipboard.SetText(result);
        }
        //use the txtInput box as clear text andAES encrypt with the sha value in the txt Output box as key and IV, then output the ciphertext in the txtCryptOutput box and copy it to clipboard
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plaintext = txtInput.Text;
            string shaHex = txtOutput.Text;

            if (string.IsNullOrWhiteSpace(plaintext) || string.IsNullOrWhiteSpace(shaHex))
            {
                MessageBox.Show("Please compute a SHA hash first.");
                return;
            }

            // Convert SHA hex string to 32-byte AES key
            byte[] key = new byte[32];
            for (int i = 0; i < 32; i++)
                key[i] = Convert.ToByte(shaHex.Substring(i * 2, 2), 16);

            // AES requires a 16-byte IV — we derive it from the last 16 bytes of the SHA
            byte[] iv = new byte[16];
            for (int i = 0; i < 16; i++)
                iv[i] = Convert.ToByte(shaHex.Substring((i + 16) * 2, 2), 16);

            byte[] encrypted;

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using var encryptor = aes.CreateEncryptor();
                byte[] plainBytes = Encoding.UTF8.GetBytes(plaintext);
                encrypted = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
            }

            // Convert ciphertext to Base64 for display
            string cipherText = Convert.ToBase64String(encrypted);
            txtCryptOutput.Text = cipherText;

            // Copy to clipboard
            Clipboard.SetText(cipherText);
        }

        //decrypt the txtCryptOutput box with the same key and IV derived from the txtOutput box and output the plaintext in the txtInput box
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = txtInput.Text;
            string shaHex = txtOutput.Text;

            if (string.IsNullOrWhiteSpace(cipherText) || string.IsNullOrWhiteSpace(shaHex))
            {
                MessageBox.Show("Please paste AES ciphertext into Input and ensure SHA hash is present.");
                return;
            }

            // Convert SHA hex string to 32-byte AES key
            byte[] key = new byte[32];
            for (int i = 0; i < 32; i++)
                key[i] = Convert.ToByte(shaHex.Substring(i * 2, 2), 16);

            // IV = last 16 bytes of SHA
            byte[] iv = new byte[16];
            for (int i = 0; i < 16; i++)
                iv[i] = Convert.ToByte(shaHex.Substring((i + 16) * 2, 2), 16);

            byte[] encryptedBytes;

            try
            {
                encryptedBytes = Convert.FromBase64String(cipherText);
            }
            catch
            {
                MessageBox.Show("Input is not valid Base64 ciphertext.");
                return;
            }

            byte[] decrypted;

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using var decryptor = aes.CreateDecryptor();
                decrypted = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
            }

            string plaintext = Encoding.UTF8.GetString(decrypted);

            // Show result in CryptOutput box
            txtCryptOutput.Text = plaintext;

            // Copy to clipboard
            Clipboard.SetText(plaintext);
        }


    }
}

