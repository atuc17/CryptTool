namespace Crypto
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
            this.cbBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.textKey = new System.Windows.Forms.TextBox();
            this.textIV = new System.Windows.Forms.TextBox();
            this.btnPushKey = new System.Windows.Forms.Button();
            this.btnSaveKey = new System.Windows.Forms.Button();
            this.btnGenKey = new System.Windows.Forms.Button();
            this.pathOriginalFile = new System.Windows.Forms.TextBox();
            this.btnOriginalFile = new System.Windows.Forms.Button();
            this.pathEncryptedFile = new System.Windows.Forms.TextBox();
            this.btnEncryptedFile = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.textInfoKey = new System.Windows.Forms.TextBox();
            this.textInfoBlock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbBoxAlgorithm
            // 
            this.cbBoxAlgorithm.FormattingEnabled = true;
            this.cbBoxAlgorithm.Items.AddRange(new object[] {
            "AES",
            "Rijndael"});
            this.cbBoxAlgorithm.Location = new System.Drawing.Point(277, 30);
            this.cbBoxAlgorithm.Name = "cbBoxAlgorithm";
            this.cbBoxAlgorithm.Size = new System.Drawing.Size(109, 32);
            this.cbBoxAlgorithm.TabIndex = 2;
            this.cbBoxAlgorithm.SelectedIndexChanged += new System.EventHandler(this.cbBoxAlgorithm_SelectedIndexChanged);
            // 
            // textKey
            // 
            this.textKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textKey.Location = new System.Drawing.Point(277, 70);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(548, 29);
            this.textKey.TabIndex = 5;
            // 
            // textIV
            // 
            this.textIV.Location = new System.Drawing.Point(278, 105);
            this.textIV.Name = "textIV";
            this.textIV.Size = new System.Drawing.Size(546, 29);
            this.textIV.TabIndex = 7;
            // 
            // btnPushKey
            // 
            this.btnPushKey.Location = new System.Drawing.Point(277, 160);
            this.btnPushKey.Name = "btnPushKey";
            this.btnPushKey.Size = new System.Drawing.Size(152, 40);
            this.btnPushKey.TabIndex = 8;
            this.btnPushKey.Text = "Nạp Khóa và IV";
            this.btnPushKey.UseVisualStyleBackColor = true;
            this.btnPushKey.Click += new System.EventHandler(this.btnPushKey_Click);
            // 
            // btnSaveKey
            // 
            this.btnSaveKey.Location = new System.Drawing.Point(462, 160);
            this.btnSaveKey.Name = "btnSaveKey";
            this.btnSaveKey.Size = new System.Drawing.Size(151, 40);
            this.btnSaveKey.TabIndex = 9;
            this.btnSaveKey.Text = "Lưu Khóa và IV";
            this.btnSaveKey.UseVisualStyleBackColor = true;
            this.btnSaveKey.Click += new System.EventHandler(this.btnSaveKey_Click);
            // 
            // btnGenKey
            // 
            this.btnGenKey.Location = new System.Drawing.Point(659, 160);
            this.btnGenKey.Name = "btnGenKey";
            this.btnGenKey.Size = new System.Drawing.Size(165, 39);
            this.btnGenKey.TabIndex = 10;
            this.btnGenKey.Text = "Sinh Khóa và IV";
            this.btnGenKey.UseVisualStyleBackColor = true;
            // 
            // pathOriginalFile
            // 
            this.pathOriginalFile.Location = new System.Drawing.Point(227, 219);
            this.pathOriginalFile.Name = "pathOriginalFile";
            this.pathOriginalFile.Size = new System.Drawing.Size(451, 29);
            this.pathOriginalFile.TabIndex = 12;
            this.pathOriginalFile.TextChanged += new System.EventHandler(this.pathOriginalFile_TextChanged);
            // 
            // btnOriginalFile
            // 
            this.btnOriginalFile.Location = new System.Drawing.Point(696, 219);
            this.btnOriginalFile.Name = "btnOriginalFile";
            this.btnOriginalFile.Size = new System.Drawing.Size(117, 38);
            this.btnOriginalFile.TabIndex = 13;
            this.btnOriginalFile.Text = "Chọn file";
            this.btnOriginalFile.UseVisualStyleBackColor = true;
            this.btnOriginalFile.Click += new System.EventHandler(this.btnOriginalFile_Click);
            // 
            // pathEncryptedFile
            // 
            this.pathEncryptedFile.Location = new System.Drawing.Point(227, 266);
            this.pathEncryptedFile.Name = "pathEncryptedFile";
            this.pathEncryptedFile.Size = new System.Drawing.Size(450, 29);
            this.pathEncryptedFile.TabIndex = 15;
            // 
            // btnEncryptedFile
            // 
            this.btnEncryptedFile.Location = new System.Drawing.Point(696, 263);
            this.btnEncryptedFile.Name = "btnEncryptedFile";
            this.btnEncryptedFile.Size = new System.Drawing.Size(116, 36);
            this.btnEncryptedFile.TabIndex = 16;
            this.btnEncryptedFile.Text = "Chọn file";
            this.btnEncryptedFile.UseVisualStyleBackColor = true;
            this.btnEncryptedFile.Click += new System.EventHandler(this.btnEncryptedFile_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(227, 317);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(168, 37);
            this.btnEncrypt.TabIndex = 17;
            this.btnEncrypt.Text = "Mã hóa";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(440, 319);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(150, 35);
            this.btnDecrypt.TabIndex = 18;
            this.btnDecrypt.Text = "Giải mã";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // textInfoKey
            // 
            this.textInfoKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInfoKey.Location = new System.Drawing.Point(528, 35);
            this.textInfoKey.Name = "textInfoKey";
            this.textInfoKey.Size = new System.Drawing.Size(54, 22);
            this.textInfoKey.TabIndex = 19;
            this.textInfoKey.TextChanged += new System.EventHandler(this.textInfoKey_TextChanged);
            // 
            // textInfoBlock
            // 
            this.textInfoBlock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInfoBlock.Location = new System.Drawing.Point(732, 35);
            this.textInfoBlock.Name = "textInfoBlock";
            this.textInfoBlock.Size = new System.Drawing.Size(60, 22);
            this.textInfoBlock.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Chọn thuật toán mã hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Thông tin khóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Thông tin block";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Khóa (dạng hexa)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "IV (dạng hexa)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "File ban đầu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "File mã hóa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 369);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textInfoBlock);
            this.Controls.Add(this.textInfoKey);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnEncryptedFile);
            this.Controls.Add(this.pathEncryptedFile);
            this.Controls.Add(this.btnOriginalFile);
            this.Controls.Add(this.pathOriginalFile);
            this.Controls.Add(this.btnGenKey);
            this.Controls.Add(this.btnSaveKey);
            this.Controls.Add(this.btnPushKey);
            this.Controls.Add(this.textIV);
            this.Controls.Add(this.textKey);
            this.Controls.Add(this.cbBoxAlgorithm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbBoxAlgorithm;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.TextBox textIV;
        private System.Windows.Forms.Button btnPushKey;
        private System.Windows.Forms.Button btnSaveKey;
        private System.Windows.Forms.Button btnGenKey;
        private System.Windows.Forms.TextBox pathOriginalFile;
        private System.Windows.Forms.Button btnOriginalFile;
        private System.Windows.Forms.TextBox pathEncryptedFile;
        private System.Windows.Forms.Button btnEncryptedFile;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox textInfoKey;
        private System.Windows.Forms.TextBox textInfoBlock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

