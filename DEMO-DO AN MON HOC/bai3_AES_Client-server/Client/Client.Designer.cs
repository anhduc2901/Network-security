
namespace Client
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.txbMessage2 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.txbKey_encrypt = new System.Windows.Forms.TextBox();
            this.txbKey_decrypt = new System.Windows.Forms.TextBox();
            this.txbPlaintext = new System.Windows.Forms.TextBox();
            this.txbCipher2 = new System.Windows.Forms.TextBox();
            this.txbCiphertex = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message";
            // 
            // lsvMessage
            // 
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(41, 24);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(357, 229);
            this.lsvMessage.TabIndex = 2;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.List;
            // 
            // txbMessage2
            // 
            this.txbMessage2.Location = new System.Drawing.Point(44, 417);
            this.txbMessage2.Name = "txbMessage2";
            this.txbMessage2.Size = new System.Drawing.Size(255, 22);
            this.txbMessage2.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(317, 316);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(81, 123);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your name";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(44, 316);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(255, 22);
            this.txbName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message to encrypt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "==> CIPHERTEXT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(574, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Key to encrypt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(574, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Key to decrypt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ciphertext to decrypt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(574, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "==> PLAINTEXT";
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(712, 61);
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(255, 22);
            this.txbMessage.TabIndex = 12;
            // 
            // txbKey_encrypt
            // 
            this.txbKey_encrypt.Location = new System.Drawing.Point(712, 122);
            this.txbKey_encrypt.Name = "txbKey_encrypt";
            this.txbKey_encrypt.Size = new System.Drawing.Size(255, 22);
            this.txbKey_encrypt.TabIndex = 13;
            // 
            // txbKey_decrypt
            // 
            this.txbKey_decrypt.Location = new System.Drawing.Point(712, 328);
            this.txbKey_decrypt.Name = "txbKey_decrypt";
            this.txbKey_decrypt.Size = new System.Drawing.Size(255, 22);
            this.txbKey_decrypt.TabIndex = 14;
            // 
            // txbPlaintext
            // 
            this.txbPlaintext.Location = new System.Drawing.Point(712, 392);
            this.txbPlaintext.Name = "txbPlaintext";
            this.txbPlaintext.Size = new System.Drawing.Size(255, 22);
            this.txbPlaintext.TabIndex = 16;
            // 
            // txbCipher2
            // 
            this.txbCipher2.Location = new System.Drawing.Point(712, 261);
            this.txbCipher2.Name = "txbCipher2";
            this.txbCipher2.Size = new System.Drawing.Size(255, 22);
            this.txbCipher2.TabIndex = 17;
            // 
            // txbCiphertex
            // 
            this.txbCiphertex.Location = new System.Drawing.Point(712, 200);
            this.txbCiphertex.Name = "txbCiphertex";
            this.txbCiphertex.Size = new System.Drawing.Size(255, 22);
            this.txbCiphertex.TabIndex = 18;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(1130, 61);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(178, 44);
            this.btnEncrypt.TabIndex = 19;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click_1);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(1130, 269);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(178, 44);
            this.btnDecrypt.TabIndex = 20;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 684);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txbCiphertex);
            this.Controls.Add(this.txbCipher2);
            this.Controls.Add(this.txbPlaintext);
            this.Controls.Add(this.txbKey_decrypt);
            this.Controls.Add(this.txbKey_encrypt);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbMessage2);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lsvMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "CLIENT";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvMessage;
        private System.Windows.Forms.TextBox txbMessage2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.TextBox txbKey_encrypt;
        private System.Windows.Forms.TextBox txbKey_decrypt;
        private System.Windows.Forms.TextBox txbPlaintext;
        private System.Windows.Forms.TextBox txbCipher2;
        private System.Windows.Forms.TextBox txbCiphertex;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
    }
}

