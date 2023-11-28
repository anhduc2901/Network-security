using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics;
using System.IO;
using System.Xml;

namespace RSACryptoSystem
{
    public partial class Form1 : Form
    {
        private delegate void btnEncryptDecrypt();
        private RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        private string pathKeyXML = "";
        private bool isEncryptingFile = true;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbboxKeyLength.Items.Add("512 bits");
            this.cbboxKeyLength.Items.Add("1024 bits");
            this.cbboxKeyLength.Items.Add("2048 bits");
            this.cbboxKeyLength.Items.Add("4096 bits");
            this.tbModule.Enabled = false;
            this.tbD.Enabled = false;
            this.tbExponent.Enabled = false;
            label_MD5.Enabled = false;
            Label_SHA1.Enabled = false;
            Label_SHA256.Enabled = false;
            this.cbboxKeyLength.Text = "1024 bits";
            // xử lý threads
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void enabledOrDisableButtons(bool isEnable)
        {
            this.btnResetForm.Enabled = isEnable;
            this.btnOutOpen.Enabled = isEnable;
            this.textbox_Output.Enabled = isEnable;
            this.btnEncrypt.Enabled = isEnable;
            this.btnDecrypt.Enabled = isEnable;
            this.TaoKey.Enabled = isEnable;
            this.btnOpenFileIn.Enabled = isEnable;
            this.btnOpenFileKeys.Enabled = isEnable;
            this.btnOpenFolderIn.Enabled = isEnable;
            this.selectOutput.Enabled = isEnable;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            //Tạo file chứa key
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = "xml";
            saveFile.Filter = "Xml File|*.xml|All File|*.*";
            saveFile.Title = "Chọn tên file";
            if (saveFile.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            int lengthKey = 0;
            if (this.cbboxKeyLength.Text == "1024 bits") 
                lengthKey = 1024;
            else if (this.cbboxKeyLength.Text == "512 bits")
                lengthKey = 512;
            else if (this.cbboxKeyLength.Text == "2048 bits") 
                lengthKey = 2048;
            else if (this.cbboxKeyLength.Text == "4096 bits")
                lengthKey = 4096;
            saveFile.RestoreDirectory = true;


            String pathPrivateKey = saveFile.FileName;

            //tạo key có độ dài lengthKey
            RSA = new RSACryptoServiceProvider(lengthKey); //tạo key có độ dài lengtheKey

            //The RSAKeyValue, Modulus, and Exponent tags  because  used the method ToXmlString().
            /*
            The private key has these fields:

                <RSAKeyValue>
                   <Modulus>…</Modulus>
                   <Exponent>…</Exponent>
                   <P>…</P>
                   <Q>…</Q>
                   <DP>…</DP>
                   <DQ>…</DQ>
                   <InverseQ>…</InverseQ>
                   <D>…</D>
                </RSAKeyValue>
              */
            File.WriteAllText(pathPrivateKey, RSA.ToXmlString(true));  // Private Key

            // đường dẫn tới key
            pathKeyXML = pathPrivateKey;

            tbKeysPath.Text = pathPrivateKey; //Hiển thị đường dẫn key

            if (File.Exists(pathKeyXML))
            {
                if (Path.GetExtension(pathKeyXML) == ".xml") //kiểm tra định dạng
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(File.ReadAllText(pathKeyXML)); //đọc RSA Key
                    // thông tin Module N , mũ mã hóa E và mũ giải mã D
                    try
                    {
                        XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue/Modulus");
                        tbModule.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/Exponent");
                        tbExponent.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/D");
                        tbD.Text = xnList.InnerText;
                        tbModule.Enabled = true;
                        tbExponent.Enabled = true;
                        tbD.Enabled = true;
                    }
                    catch (Exception ix)
                    {
                        MessageBox.Show(ix.Message);
                    }
                }
            }
            MessageBox.Show("Tạo key có độ dài " + lengthKey.ToString() + " bits thành công.");
        }

        private void btnOpenFileKeys_Click(object sender, EventArgs e)
        {
            this.tbD.Clear(); this.tbExponent.Clear(); this.tbModule.Clear();
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Xml files (*.xml)|*.xml|All Files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK) //This means that the modal dialog continues running. OK
            {
                pathKeyXML = op.FileName;
                tbKeysPath.Text = op.FileName;
            }

            if (File.Exists(pathKeyXML))
            {

                if (Path.GetExtension(pathKeyXML) == ".xml")
                {
                    XmlDocument xml = new XmlDocument();
                    xml.LoadXml(File.ReadAllText(pathKeyXML));
                    try
                    {
                        XmlNode xnList = xml.SelectSingleNode("/RSAKeyValue/Modulus");
                        tbModule.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/Exponent");
                        tbExponent.Text = xnList.InnerText;
                        xnList = xml.SelectSingleNode("/RSAKeyValue/D");
                        tbD.Text = xnList.InnerText;
                        tbModule.Enabled = true;
                        tbExponent.Enabled = true;
                        tbD.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed: " + ex.Message);
                    }
                }
            }
        }

        private void btnOpenFileIn_Click(object sender, EventArgs e)
        {
            // Hiện tên file ra tbInput
            isEncryptingFile = true;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                textbox_Input.Text = openFileDialog.FileName;
        }

        //Mở cái folder lưu output ra
        private void btnOutOpen_Click(object sender, EventArgs e)
        {
            if (textbox_Output.Text.Length > 0)
            {
                try
                {
                    System.Diagnostics.Process prc = new System.Diagnostics.Process();
                    prc.StartInfo.FileName = textbox_Output.Text;
                    prc.Start();
                }
                catch (Exception ioex)
                {
                    MessageBox.Show("Failed: " + ioex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đường dẫn !");
            }
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (textbox_Output.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn đến thư mục Output");
                return;
            }
            if (tbKeysPath.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn của Private Key!");
                return;
            }
            btnEncryptDecrypt s = new btnEncryptDecrypt(btnEncryptClick);
            s.BeginInvoke(null, null);
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (textbox_Output.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn đến thư mục Output");
                return;
            }
            btnEncryptDecrypt s = new btnEncryptDecrypt(btnDecryptClick);
            s.BeginInvoke(null, null);
        }
       private void btnDecryptClick()
        {
            enabledOrDisableButtons(false);

            try
            {
                if (textbox_Input.Text.Length != 0 &&
                   tbKeysPath.Text.Length != 0 &&
                   tbModule.Text.Length != 0)
                {
                    //Calculator time ex...
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();

                    string inputFileName = textbox_Input.Text, outputFileName = "";

                    if (isEncryptingFile && Path.GetExtension(inputFileName) != ".lhde")
                    {
                        MessageBox.Show("Tệp tin này không được hỗ trợ đển giải mã!");
                        enabledOrDisableButtons(true);
                        return;
                    }
                    // xác định đường dẫn của file chứa thư mục đc giải mã
                    if (isEncryptingFile)
                    {
                        outputFileName = textbox_Output.Text + "\\" + Path.GetFileName(inputFileName.Substring(0, inputFileName.Length - 5));
                    }
                    
                    
                    RSA = new RSACryptoServiceProvider();
                    RSA.FromXmlString(File.ReadAllText(this.pathKeyXML));

                    if (isEncryptingFile)
                        RSA_Algorithm(inputFileName, outputFileName, RSA.ExportParameters(true), false);
                    else
                    {
                        string[] filePaths = Directory.GetFiles(inputFileName, "*.lhde", SearchOption.AllDirectories);
                        if (filePaths.Length == 0 || (filePaths.Length == 1 && (Path.GetFileName(filePaths[0]) == "Thumbs.db")))
                        {
                            MessageBox.Show("Thư mục rỗng!");
                            enabledOrDisableButtons(true);
                            return;
                        }

                        for (int i = 0; i < filePaths.Length; i++)
                            if (Path.GetFileName(filePaths[i]) != "Thumbs.db")
                            {
                                outputFileName = textbox_Output.Text + "\\" + Path.GetFileName(filePaths[i].Substring(0, filePaths[i].Length - 5));
                                RSA_Algorithm(filePaths[i], outputFileName, RSA.ExportParameters(true), false);

                            }

                    }
                    enabledOrDisableButtons(true);
                    sw.Stop();
                    double elapsedMs = sw.Elapsed.TotalMilliseconds / 1000;
                    MessageBox.Show("Tổng thời gian thực thi: " + elapsedMs.ToString() + "s");
                }
                else
                {
                    MessageBox.Show("Không đủ điều kiện để giải mã !");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message);
            }
            enabledOrDisableButtons(true);
        }   
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RSA_Algorithm(string inputFile, string outputFile, RSAParameters RSAKeyInfo, bool isEncrypt)
        {
            try
            {
                //Đọc file input
                FileStream fsInput = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
                //Tạo file output
                FileStream fsCiperText = new FileStream(outputFile, FileMode.Create, FileAccess.Write);

                fsCiperText.SetLength(0);
                byte[] bin, encryptedData;
                long rdlen = 0;
                long dodaiinput = fsInput.Length;
                int len;
                this.progressBar.Minimum = 0;
                this.progressBar.Maximum = 100;

                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                //Nhập thông tin khoá RSA (bao gồm khoá riêng) để có thể tìm đc đường dẫn khi mã hóa và giải mã
                RSA.ImportParameters(RSAKeyInfo);

                int maxBytesCanEncrypted;
                //RSA chỉ có thể mã hóa các khối dữ liệu ngắn hơn độ dài khóa,
                //chia dữ liệu cho một số khối và sau đó mã hóa từng khối và sau đó hợp nhất chúng

                if (isEncrypt)
                    maxBytesCanEncrypted = ((RSA.KeySize - 384) / 8) + 37; // 245bytes with 2048 rsa keys
                // + 7: OAEP - Đệm mã hóa bất đối xứng tối ưu
                else
                    maxBytesCanEncrypted = (RSA.KeySize / 8);

                //Read from the input file, then encrypt and write to the output file.
                while (rdlen < dodaiinput)
                {
                    if (dodaiinput - rdlen < maxBytesCanEncrypted) maxBytesCanEncrypted = (int)(dodaiinput - rdlen);

                    bin = new byte[maxBytesCanEncrypted];
                    len = fsInput.Read(bin, 0, maxBytesCanEncrypted); // đọc bytes trong fsInput r ghi vào bin

                    if (isEncrypt) encryptedData = RSA.Encrypt(bin, false); //Mã Hoá
                    else encryptedData = RSA.Decrypt(bin, false); //Giải mã

                    fsCiperText.Write(encryptedData, 0, encryptedData.Length);// ghi dữ liệu đc mã hóa vào bản mã
                    rdlen = rdlen + len; // rdlen thay doi

                    this.label1f.Text = "Tên tệp xử lý : " + Path.GetFileName(inputFile) + "\t Thành công: "
                        + ((long)(rdlen * 100) / dodaiinput).ToString() + " %";
                    this.label1f.Update();
                    this.label1f.Refresh();

                    this.progressBar.Value = (int)((rdlen * 100) / dodaiinput);//thanh tiến trình
                }

                fsCiperText.Close(); //save file
                fsInput.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message);
            }
        }
        private void btnEncryptClick()
        {
            enabledOrDisableButtons(false);
            if (this.tbKeysPath.Text.Length == 0 || this.tbModule.Text.Length == 0 ||
                this.tbD.Text.Length == 0 || this.tbExponent.Text.Length == 0)
            {
                MessageBox.Show("Key không hợp lệ!");
                enabledOrDisableButtons(true);
                return;
            }

            try
            {
                if (textbox_Input.Text.Length != 0 &&
                tbKeysPath.Text.Length != 0 &&
                tbModule.Text.Length != 0)
                {

                    //Calculator time ex...
                    Stopwatch sw = Stopwatch.StartNew();
                    sw.Start();
                    string inputFileName = textbox_Input.Text, outputFileName = "";

                    if (isEncryptingFile)
                    {
                        outputFileName = textbox_Output.Text + "\\" + Path.GetFileName(textbox_Input.Text) + ".lhde";
                    }
                    //get Keys.
                    RSA = new RSACryptoServiceProvider();
                    RSA.FromXmlString(File.ReadAllText(this.pathKeyXML));
                    if (isEncryptingFile)
                        RSA_Algorithm(inputFileName, outputFileName, RSA.ExportParameters(true), true);
                    else
                    {
                        string[] filePaths = Directory.GetFiles(inputFileName, "*");

                        if (filePaths.Length == 0 || (filePaths.Length == 1 && 
                            (Path.GetFileName(filePaths[0]) == "Thumbs.db")))
                        {
                            MessageBox.Show("Thư mục rỗng!");
                            enabledOrDisableButtons(true);
                            return;
                        }
                        // tbt.Text = Path.GetDirectoryName(outputFileName);
                        for (int i = 0; i < filePaths.Length; i++)
                        {
                            outputFileName = textbox_Output.Text + "\\" + Path.GetFileName(filePaths[i]);
                            if (Path.GetFileName(filePaths[i]) != "Thumbs.db")
                                RSA_Algorithm(filePaths[i], outputFileName + ".lhde", RSA.ExportParameters(true), true);
                        }
                    }
                    enabledOrDisableButtons(true);
                    sw.Stop();
                    double elapsedMs = sw.Elapsed.TotalMilliseconds / 1000;
                    MessageBox.Show("Thời gian thực thi " + elapsedMs.ToString() + "s");
                }
                else
                {
                    enabledOrDisableButtons(true);
                    MessageBox.Show("Dữ liệu không đủ để mã hóa!");
                }
            }
            catch (Exception ex)
            {
                enabledOrDisableButtons(true);
                MessageBox.Show("Failed: " + ex.Message);
            }
            enabledOrDisableButtons(true);
        }

        private void selectOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f1 = new FolderBrowserDialog();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                this.textbox_Output.Text = f1.SelectedPath;
            }
        }

        private void btnOpenFolderIn_Click(object sender, EventArgs e)
        {
            isEncryptingFile = false;
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                this.textbox_Input.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btn_chonfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txt_input.Text = dialog.FileName;
                }
            }
        }
        public static string MD5(string path)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                }
            }
        }
        public static string SHA1(string path)
        {
            using (var cryptoProvider = new SHA1CryptoServiceProvider())
            {
                var stream = File.OpenRead(path);
                string hash = BitConverter
                    .ToString(cryptoProvider.ComputeHash(stream)).Replace("-", "");
                return hash.ToLower();
            }
        }
        public static string SHA256(string path)
        {
            using (FileStream stream = File.OpenRead(path))
            {
                SHA256Managed sha = new SHA256Managed();
                byte[] hash = sha.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }
        private void btn_checksum_Click(object sender, EventArgs e)
        {
            label_MD5.Text = MD5(txt_input.Text);
            Label_SHA1.Text = SHA1(txt_input.Text);
            Label_SHA256.Text = SHA256(txt_input.Text);
            label_MD5.Enabled = true;
            Label_SHA1.Enabled = true;
            Label_SHA256.Enabled = true;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {

            tbModule.Enabled = false;
            tbExponent.Enabled = false;
            tbD.Enabled = false;
            txt_input.Clear();
            label_MD5.Clear();
            Label_SHA1.Clear();
            Label_SHA256.Clear(); 

            this.textbox_Output.Clear();
            this.pathKeyXML = "";
            this.cbboxKeyLength.Text = "1024 bits";
            this.label1f.Text = "";
            this.label1f.Update();

            label_MD5.Enabled = false;
            Label_SHA1.Enabled = false;
            Label_SHA256.Enabled = false;
            this.isEncryptingFile = true;
            this.tbKeysPath.Clear();
            this.textbox_Input.Clear();
            this.tbModule.Clear();
            this.tbD.Clear();
            this.tbExponent.Clear();
            RSA = new RSACryptoServiceProvider();
            if (this.progressBar.Value > 0)
            {
                this.progressBar.Value = 0;

            }
        }

        private void tbModule_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
