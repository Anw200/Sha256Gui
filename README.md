OpenCrypTool

A lightweight Windows utility for secure, offline hashing and encryption.
It provides quick SHA‑256 / SHA‑512 hashing and AES‑256 encryption/decryption using a simple, intuitive GUI.

Features

SHA‑256 and SHA‑512 hashing  
Enter any secret or passphrase and instantly generate a cryptographic hash.

AES‑256 Encryption 

The generated SHA value is used as the AES key (and IV) to encrypt any text pasted into the input box.

AES‑256 Decryption 

Paste the encrypted Base64 text into the input box, provide the correct SHA value, and decrypt back to cleartext.

Automatic Clipboard Copy 

Every SHA hash, encrypted message, or decrypted message is automatically copied to the clipboard for easy use in email or messaging apps.

Offline and deterministic  

No network, no servers, no accounts. Everything happens locally on your machine.

How to Use

1. Generate a SHA Hash:
Paste your secret into the Input box (top box).

Click SHA‑256 or SHA‑512.

The hash appears in the SHA Output box and is automatically copied to your clipboard.

2. Encrypt a Message:
Enter your secret and generate the SHA hash.

Paste the message you want to encrypt into the Input box.

Click AES Encrypt.

The encrypted Base64 text appears in the Crypt Output box and is copied to your clipboard.

3. Decrypt a Message:
Enter the same secret used for encryption.

Generate the same SHA‑256 or SHA‑512 hash.

Paste the encrypted Base64 text into the Input box.

Click AES Decrypt.

The cleartext appears in the Crypt Output box and is copied to your clipboard.

Important Notes:
The secret must be identical on both sides.

The SHA value must match exactly.

Wrong secrets or wrong SHA values will cause decryption to fail.

Simply re‑enter the correct secret and try again.

Purpose

This tool is ideal for:

Secure offline communication

Sharing encrypted messages via email

Using pre‑shared secrets or random data chunks

Simple cryptographic experimentation

Teaching hashing and encryption concepts
