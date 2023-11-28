
namespace DES
{
    partial class Form1
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
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.btnSelectFileToEncrypt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(61, 171);
            this.txtEncrypt.Multiline = true;
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(382, 71);
            this.txtEncrypt.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Encrypted";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Input";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(59, 63);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(384, 70);
            this.txtInput.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "Decrypted";
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(59, 297);
            this.txtDecrypt.Multiline = true;
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(383, 66);
            this.txtDecrypt.TabIndex = 61;
            // 
            // btnSelectFileToEncrypt
            // 
            this.btnSelectFileToEncrypt.Location = new System.Drawing.Point(254, 470);
            this.btnSelectFileToEncrypt.Name = "btnSelectFileToEncrypt";
            this.btnSelectFileToEncrypt.Size = new System.Drawing.Size(91, 26);
            this.btnSelectFileToEncrypt.TabIndex = 62;
            this.btnSelectFileToEncrypt.Text = "Encrpyt";
            this.btnSelectFileToEncrypt.UseVisualStyleBackColor = true;
            this.btnSelectFileToEncrypt.Click += new System.EventHandler(this.btnSelectFileToEncrypt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 63;
            this.label6.Text = "key";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(61, 417);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(384, 22);
            this.txtKey.TabIndex = 64;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(351, 470);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(91, 26);
            this.btnDecrypt.TabIndex = 65;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 568);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSelectFileToEncrypt);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEncrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDecrypt;
        private System.Windows.Forms.Button btnSelectFileToEncrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnDecrypt;
    }
}

