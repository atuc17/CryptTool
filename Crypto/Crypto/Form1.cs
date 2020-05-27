using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using Algorithm;

namespace Crypto
{
    public partial class Form1 : Form
    {
        enum Cipher
        {
            tAES,
            tRijndael
        }
        private int CipherType;

        private string StringToHex(string input)
        {
            var sb = new StringBuilder();
            foreach (char t in input)
                sb.Append(Convert.ToInt32(t).ToString("x"));
            return sb.ToString();
        }
        private byte[] HexToString(string input)
        {
            var bytes = new byte[input.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(input.Substring(i * 2, 2), 16);
            }
            return bytes;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void cbBoxAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbBoxAlgorithm.SelectedIndex == -1)
            {
                CipherType = -1;
                textInfoKey.Text = textInfoBlock.Text = string.Empty;
            }
            else
            {
                String type = cbBoxAlgorithm.SelectedItem.ToString();
                if(type == "AES")
                {
                    CipherType = (int)Cipher.tAES;
                    textInfoKey.Text = "256 bit";
                    textInfoBlock.Text = "128 bit";
                }
                if(type == "Rijndael")
                {
                    CipherType = (int)Cipher.tRijndael;
                    textInfoKey.Text = "256 bit";
                    textInfoBlock.Text = "128 bit";
                }
            }
        }

        private void textInfoAlgorithm_TextChanged(object sender, EventArgs e)
        {

        }
        private void textInfoKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPushKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Browse file";
            openFileDialog.ShowDialog();

            String path = openFileDialog.FileName;
            string[] lines = File.ReadAllLines(path);
            if (lines.Length != 2)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBox.Show("Wrong key format. Key file must contain 2 lines: key and iv",
                    "Error Detected in Input", buttons);
            }
            else
            {
                textKey.Text = StringToHex(lines[0]);
                textIV.Text = StringToHex(lines[1]);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Cryptosystem algorithm = null;
            switch(this.CipherType)
            {
                case (int)Cipher.tRijndael:
                    algorithm = new Algorithm.m_Rijndael(textKey.Text, textIV.Text);
                    break;
                case (int)Cipher.tAES:
                    algorithm = new Algorithm.m_AES(textKey.Text, textIV.Text);
                    break;
                default:
                    algorithm = null;
                    break;

            }
            if (algorithm == null)
                return;
            if (algorithm.IsValidKey() == false)
            {
                MessageBox.Show("Lengthes of key and iv are not correct");
            }  
            else
            {
                algorithm.Encrypt(pathOriginalFile.Text, pathEncryptedFile.Text);
            }    
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // Decrypt(pathEncryptedFile.Text, pathOriginalFile.Text, textKey.Text, textIV.Text);
            Cryptosystem algorithm = null;
            switch (this.CipherType)
            {
                case (int)Cipher.tRijndael:
                    algorithm = new Algorithm.m_Rijndael(textKey.Text, textIV.Text);
                    break;
                case (int)Cipher.tAES:
                    algorithm = new Algorithm.m_AES(textKey.Text, textIV.Text);
                    break;
                default:
                    algorithm = null;
                    break;

            }
            if (algorithm == null)
                return;
            if (algorithm.IsValidKey() == false)
            {
                MessageBox.Show("Wrong format key string");
            }
            else
            {
                algorithm.Decrypt(pathEncryptedFile.Text, pathOriginalFile.Text);
            }
        }
        private void pathOriginalFile_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOriginalFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Browse file";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.ShowDialog();

            String path = openFileDialog.FileName.ToString();
            pathOriginalFile.Text = path;
            pathEncryptedFile.Text = path + ".enc";
        }

        private void btnEncryptedFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Browse file";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.ShowDialog();

            String path = openFileDialog.FileName.ToString();
            pathOriginalFile.Text = path + ".original";
            pathEncryptedFile.Text = path;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose file";
            openFileDialog.ShowDialog();

            string path = openFileDialog.FileName;
            FileStream KeyFile = new FileStream(path, FileMode.Open);
            if (textKey.Text == string.Empty || textIV.Text == string.Empty)
            {
                MessageBox.Show("Please provide key and iv in hex mode");
            }
            else
            {
                KeyFile.Write(HexToString(textKey.Text), 0, 32);
                KeyFile.Write(Encoding.UTF8.GetBytes("\n"), 0, 1);
                KeyFile.Write(HexToString(textIV.Text), 0, 16);
            }
            KeyFile.Close();
        }
    }
}
