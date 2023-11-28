
namespace RSACryptoSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbKeysPath = new System.Windows.Forms.TextBox();
            this.btnOpenFileKeys = new System.Windows.Forms.Button();
            this.TaoKey = new System.Windows.Forms.Button();
            this.cbboxKeyLength = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOpenFolderIn = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnOutOpen = new System.Windows.Forms.Button();
            this.selectOutput = new System.Windows.Forms.Button();
            this.btnOpenFileIn = new System.Windows.Forms.Button();
            this.textbox_Output = new System.Windows.Forms.TextBox();
            this.textbox_Input = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbD = new System.Windows.Forms.TextBox();
            this.tbExponent = new System.Windows.Forms.TextBox();
            this.tbModule = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MODULE = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_checksum = new System.Windows.Forms.Button();
            this.btn_chonfile = new System.Windows.Forms.Button();
            this.Label_SHA256 = new System.Windows.Forms.TextBox();
            this.Label_SHA1 = new System.Windows.Forms.TextBox();
            this.label_MD5 = new System.Windows.Forms.TextBox();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.label1f = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbKeysPath);
            this.panel1.Controls.Add(this.btnOpenFileKeys);
            this.panel1.Controls.Add(this.TaoKey);
            this.panel1.Controls.Add(this.cbboxKeyLength);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 217);
            this.panel1.TabIndex = 0;
            // 
            // tbKeysPath
            // 
            this.tbKeysPath.Location = new System.Drawing.Point(157, 125);
            this.tbKeysPath.Name = "tbKeysPath";
            this.tbKeysPath.Size = new System.Drawing.Size(217, 22);
            this.tbKeysPath.TabIndex = 6;
            // 
            // btnOpenFileKeys
            // 
            this.btnOpenFileKeys.Location = new System.Drawing.Point(389, 125);
            this.btnOpenFileKeys.Name = "btnOpenFileKeys";
            this.btnOpenFileKeys.Size = new System.Drawing.Size(160, 24);
            this.btnOpenFileKeys.TabIndex = 5;
            this.btnOpenFileKeys.Text = "OPEN";
            this.btnOpenFileKeys.UseVisualStyleBackColor = true;
            this.btnOpenFileKeys.Click += new System.EventHandler(this.btnOpenFileKeys_Click);
            // 
            // TaoKey
            // 
            this.TaoKey.Location = new System.Drawing.Point(389, 59);
            this.TaoKey.Name = "TaoKey";
            this.TaoKey.Size = new System.Drawing.Size(160, 24);
            this.TaoKey.TabIndex = 4;
            this.TaoKey.Text = "TẠO KEY TỰ ĐỘNG";
            this.TaoKey.UseVisualStyleBackColor = true;
            this.TaoKey.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbboxKeyLength
            // 
            this.cbboxKeyLength.FormattingEnabled = true;
            this.cbboxKeyLength.Location = new System.Drawing.Point(157, 59);
            this.cbboxKeyLength.Name = "cbboxKeyLength";
            this.cbboxKeyLength.Size = new System.Drawing.Size(120, 24);
            this.cbboxKeyLength.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "FILE KEY (XML)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ĐỘ DÀI KEY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO KEY";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnOpenFolderIn);
            this.panel2.Controls.Add(this.btnDecrypt);
            this.panel2.Controls.Add(this.btnEncrypt);
            this.panel2.Controls.Add(this.progressBar);
            this.panel2.Controls.Add(this.btnOutOpen);
            this.panel2.Controls.Add(this.selectOutput);
            this.panel2.Controls.Add(this.btnOpenFileIn);
            this.panel2.Controls.Add(this.textbox_Output);
            this.panel2.Controls.Add(this.textbox_Input);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(30, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 242);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnOpenFolderIn
            // 
            this.btnOpenFolderIn.Location = new System.Drawing.Point(441, 74);
            this.btnOpenFolderIn.Name = "btnOpenFolderIn";
            this.btnOpenFolderIn.Size = new System.Drawing.Size(108, 23);
            this.btnOpenFolderIn.TabIndex = 15;
            this.btnOpenFolderIn.Text = "SelectFolder";
            this.btnOpenFolderIn.UseVisualStyleBackColor = true;
            this.btnOpenFolderIn.Click += new System.EventHandler(this.btnOpenFolderIn_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(282, 157);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(102, 22);
            this.btnDecrypt.TabIndex = 14;
            this.btnDecrypt.Text = "GIẢI MÃ";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(117, 157);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(102, 22);
            this.btnEncrypt.TabIndex = 13;
            this.btnEncrypt.Text = "MÃ HÓA";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(42, 206);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(507, 30);
            this.progressBar.TabIndex = 12;
            // 
            // btnOutOpen
            // 
            this.btnOutOpen.Location = new System.Drawing.Point(441, 156);
            this.btnOutOpen.Name = "btnOutOpen";
            this.btnOutOpen.Size = new System.Drawing.Size(108, 23);
            this.btnOutOpen.TabIndex = 11;
            this.btnOutOpen.Text = "OpenFolder";
            this.btnOutOpen.UseVisualStyleBackColor = true;
            this.btnOutOpen.Click += new System.EventHandler(this.btnOutOpen_Click);
            // 
            // selectOutput
            // 
            this.selectOutput.Location = new System.Drawing.Point(441, 123);
            this.selectOutput.Name = "selectOutput";
            this.selectOutput.Size = new System.Drawing.Size(108, 23);
            this.selectOutput.TabIndex = 10;
            this.selectOutput.Text = "SelectFolder";
            this.selectOutput.UseVisualStyleBackColor = true;
            this.selectOutput.Click += new System.EventHandler(this.selectOutput_Click);
            // 
            // btnOpenFileIn
            // 
            this.btnOpenFileIn.Location = new System.Drawing.Point(441, 39);
            this.btnOpenFileIn.Name = "btnOpenFileIn";
            this.btnOpenFileIn.Size = new System.Drawing.Size(108, 23);
            this.btnOpenFileIn.TabIndex = 9;
            this.btnOpenFileIn.Text = "SelectFile";
            this.btnOpenFileIn.UseVisualStyleBackColor = true;
            this.btnOpenFileIn.Click += new System.EventHandler(this.btnOpenFileIn_Click);
            // 
            // textbox_Output
            // 
            this.textbox_Output.Location = new System.Drawing.Point(129, 118);
            this.textbox_Output.Name = "textbox_Output";
            this.textbox_Output.Size = new System.Drawing.Size(217, 22);
            this.textbox_Output.TabIndex = 8;
            // 
            // textbox_Input
            // 
            this.textbox_Input.Location = new System.Drawing.Point(132, 58);
            this.textbox_Input.Name = "textbox_Input";
            this.textbox_Input.Size = new System.Drawing.Size(217, 22);
            this.textbox_Input.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "INPUT :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "OUTPUT :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "MÃ HÓA VÀ GIẢI MÃ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tbD);
            this.panel3.Controls.Add(this.tbExponent);
            this.panel3.Controls.Add(this.tbModule);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.MODULE);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(696, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(627, 217);
            this.panel3.TabIndex = 2;
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(200, 170);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(332, 22);
            this.tbD.TabIndex = 6;
            // 
            // tbExponent
            // 
            this.tbExponent.Location = new System.Drawing.Point(200, 122);
            this.tbExponent.Name = "tbExponent";
            this.tbExponent.Size = new System.Drawing.Size(332, 22);
            this.tbExponent.TabIndex = 5;
            // 
            // tbModule
            // 
            this.tbModule.Location = new System.Drawing.Point(200, 67);
            this.tbModule.Name = "tbModule";
            this.tbModule.Size = new System.Drawing.Size(332, 22);
            this.tbModule.TabIndex = 4;
            this.tbModule.TextChanged += new System.EventHandler(this.tbModule_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "MŨ GIẢI MÃ (D) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "MŨ MÃ HÓA (E) :";
            // 
            // MODULE
            // 
            this.MODULE.AutoSize = true;
            this.MODULE.Location = new System.Drawing.Point(17, 66);
            this.MODULE.Name = "MODULE";
            this.MODULE.Size = new System.Drawing.Size(99, 17);
            this.MODULE.TabIndex = 1;
            this.MODULE.Text = "MODULE (N) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "THÔNG TIN KEY";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btn_checksum);
            this.panel4.Controls.Add(this.btn_chonfile);
            this.panel4.Controls.Add(this.Label_SHA256);
            this.panel4.Controls.Add(this.Label_SHA1);
            this.panel4.Controls.Add(this.label_MD5);
            this.panel4.Controls.Add(this.txt_input);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(696, 321);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(627, 242);
            this.panel4.TabIndex = 3;
            // 
            // btn_checksum
            // 
            this.btn_checksum.Location = new System.Drawing.Point(253, 71);
            this.btn_checksum.Name = "btn_checksum";
            this.btn_checksum.Size = new System.Drawing.Size(160, 24);
            this.btn_checksum.TabIndex = 11;
            this.btn_checksum.Text = "KIỂM TRA";
            this.btn_checksum.UseVisualStyleBackColor = true;
            this.btn_checksum.Click += new System.EventHandler(this.btn_checksum_Click);
            // 
            // btn_chonfile
            // 
            this.btn_chonfile.Location = new System.Drawing.Point(490, 42);
            this.btn_chonfile.Name = "btn_chonfile";
            this.btn_chonfile.Size = new System.Drawing.Size(111, 24);
            this.btn_chonfile.TabIndex = 7;
            this.btn_chonfile.Text = "OpenFile";
            this.btn_chonfile.UseVisualStyleBackColor = true;
            this.btn_chonfile.Click += new System.EventHandler(this.btn_chonfile_Click);
            // 
            // Label_SHA256
            // 
            this.Label_SHA256.Location = new System.Drawing.Point(197, 173);
            this.Label_SHA256.Name = "Label_SHA256";
            this.Label_SHA256.Size = new System.Drawing.Size(275, 22);
            this.Label_SHA256.TabIndex = 10;
            // 
            // Label_SHA1
            // 
            this.Label_SHA1.Location = new System.Drawing.Point(197, 137);
            this.Label_SHA1.Name = "Label_SHA1";
            this.Label_SHA1.Size = new System.Drawing.Size(275, 22);
            this.Label_SHA1.TabIndex = 9;
            // 
            // label_MD5
            // 
            this.label_MD5.Location = new System.Drawing.Point(197, 101);
            this.label_MD5.Name = "label_MD5";
            this.label_MD5.Size = new System.Drawing.Size(275, 22);
            this.label_MD5.TabIndex = 8;
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(197, 42);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(275, 22);
            this.txt_input.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "MD5 :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "SHA1 :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "SHA256 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "KIỂM TRA FILE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "KIỂM TRA FILE";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(405, 572);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(608, 33);
            this.btnResetForm.TabIndex = 4;
            this.btnResetForm.Text = "RESET FORM";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // label1f
            // 
            this.label1f.AutoSize = true;
            this.label1f.Location = new System.Drawing.Point(15, 582);
            this.label1f.Name = "label1f";
            this.label1f.Size = new System.Drawing.Size(0, 17);
            this.label1f.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 615);
            this.Controls.Add(this.label1f);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RSA-Crypto-System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbKeysPath;
        private System.Windows.Forms.Button btnOpenFileKeys;
        private System.Windows.Forms.Button TaoKey;
        private System.Windows.Forms.ComboBox cbboxKeyLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnOutOpen;
        private System.Windows.Forms.Button selectOutput;
        private System.Windows.Forms.Button btnOpenFileIn;
        private System.Windows.Forms.TextBox textbox_Output;
        private System.Windows.Forms.TextBox textbox_Input;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.TextBox tbExponent;
        private System.Windows.Forms.TextBox tbModule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MODULE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_checksum;
        private System.Windows.Forms.Button btn_chonfile;
        private System.Windows.Forms.TextBox Label_SHA256;
        private System.Windows.Forms.TextBox Label_SHA1;
        private System.Windows.Forms.TextBox label_MD5;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnOpenFolderIn;
        private System.Windows.Forms.Label label1f;
    }
}

