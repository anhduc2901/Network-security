using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFileToEncrypt_Click(object sender, EventArgs e)
        {
            txtEncrypt.Text = Encrypt(txtInput.Text, txtKey.Text);
        }
        public string Encrypt(string source, string key)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    // key dưới dạng byte
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    // key dùng để mã hóa 
                    tripleDESCryptoService.Key = byteHash;
                    // mode của DES
                    tripleDESCryptoService.Mode = CipherMode.ECB;//CBC, CFB
                    // source = message
                    byte[] data = Encoding.Unicode.GetBytes(source);
                    // mess đc mã hóa
                    return Convert.ToBase64String(tripleDESCryptoService.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));
                }
            }
        }
        public static string Decrypt(string encrypt, string key)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    // key dưới dạng byte
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    // key dùng để giải mã 
                    tripleDESCryptoService.Key = byteHash;
                    // mode của DES
                    tripleDESCryptoService.Mode = CipherMode.ECB;//CBC, CFB
                    // byteBuff : mess đc mã hóa dưới dạng byte
                    byte[] byteBuff = Convert.FromBase64String(encrypt);
                    // mess ban đầu
                    return Encoding.Unicode.GetString(tripleDESCryptoService.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtDecrypt.Text = Decrypt(txtEncrypt.Text, txtKey.Text);
        }
    }
}
