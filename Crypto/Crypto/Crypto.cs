using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Algorithm
{
    class m_Rijndael : Cryptosystem
    {
        public m_Rijndael(string key = "", string iv = "", int mode = 2) : base(key, iv, mode)
        {

        }
        public override bool IsValidKey()
        {
            if (this.key.Length == 32 && this.iv.Length == 16)
                return true;
            return false;
        }
        public override void Encrypt(string inputfile, string outputfile)
        {
            byte[] salt = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            byte[] password = System.Text.Encoding.UTF8.GetBytes(this.key);
            FileStream fsCrypt = new FileStream(outputfile, FileMode.Create);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;

            var _key = new Rfc2898DeriveBytes(password, salt, 1000);
            AES.Key = _key.GetBytes(32);
            AES.IV = _key.GetBytes(16);
            AES.Mode = CipherMode.CFB;

            fsCrypt.Write(salt, 0, salt.Length);

            Console.WriteLine(Encoding.Default.GetString(AES.Key));
            Console.WriteLine(Encoding.Default.GetString(AES.IV));

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);
            FileStream fsIn = new FileStream(inputfile, FileMode.Open);

            int read = 0;
            byte[] buffer = new byte[1048576];
            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    cs.Write(buffer, 0, read);
                }
                fsIn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
            }
        }
        public override void Decrypt(string inputfile, string outputfile)
        {
            byte[] salt = new byte[8];
            byte[] password = System.Text.Encoding.UTF8.GetBytes(key);
            FileStream fsCrypt = new FileStream(inputfile, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;
            var _key = new Rfc2898DeriveBytes(password, salt, 1000);
            AES.Key = _key.GetBytes(32);
            AES.IV = _key.GetBytes(16);

            AES.Mode = CipherMode.CFB;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);
            FileStream fsOut = new FileStream(outputfile, FileMode.Create);

            int read = 0;
            byte[] buffer = new byte[1048576];
            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsOut.Write(buffer, 0, read);
                }
            }
            catch (CryptographicException ex_crypto)
            {
                Console.WriteLine("CryptographicException: " + ex_crypto);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing CryptoStream" + ex);
            }
            finally
            {
                fsCrypt.Close();
                fsOut.Close();
            }
        }
    }
    class m_AES : Cryptosystem
    {
        public m_AES(string key = "", string iv = "", int mode = 2) : base(key, iv, mode)
        {

        }
        public override bool IsValidKey()
        {
            if (this.key.Length == 32 && this.iv.Length == 16)
                return true;
            return false;
        }

        public override void Encrypt(string inputfile, string outputfile)
        {
            byte[] salt = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            byte[] password = System.Text.Encoding.UTF8.GetBytes(this.key);
            FileStream fsCrypt = new FileStream(outputfile, FileMode.Create);

            AesManaged AES = new AesManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;

            var _key = new Rfc2898DeriveBytes(password, salt, 1000);
            AES.Key = _key.GetBytes(32);
            AES.IV = _key.GetBytes(16);
            AES.Mode = CipherMode.CBC;

            fsCrypt.Write(salt, 0, salt.Length);

            Console.WriteLine(Encoding.Default.GetString(AES.Key));
            Console.WriteLine(Encoding.Default.GetString(AES.IV));

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);
            FileStream fsIn = new FileStream(inputfile, FileMode.Open);

            int read = 0;
            byte[] buffer = new byte[1048576];
            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    cs.Write(buffer, 0, read);
                }
                fsIn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
            }
        }

        public override void Decrypt(string inputfile, string outputfile)
        {
            byte[] salt = new byte[8];
            byte[] password = System.Text.Encoding.UTF8.GetBytes(key);
            FileStream fsCrypt = new FileStream(inputfile, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);

            AesManaged AES = new AesManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;
            var _key = new Rfc2898DeriveBytes(password, salt, 1000);
            AES.Key = _key.GetBytes(32);
            AES.IV = _key.GetBytes(16);

            AES.Mode = CipherMode.CBC;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);
            FileStream fsOut = new FileStream(outputfile, FileMode.Create);

            int read = 0;
            byte[] buffer = new byte[1048576];
            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsOut.Write(buffer, 0, read);
                }
            }
            catch (CryptographicException ex_crypto)
            {
                Console.WriteLine("CryptographicException: " + ex_crypto);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing CryptoStream" + ex);
            }
            finally
            {
                fsCrypt.Close();
                fsOut.Close();
            }
        }
    }
    class Cryptosystem
    {
        protected string key;
        protected string iv;
        protected int mode;
        public Cryptosystem(string key = "", string iv = "", int mode = 2) // CFB = 2
        {
            this.key = key;
            this.iv = iv;
            this.mode = mode;
        }
        public virtual void Encrypt(string inputfile, string outputfile)
        {

        }
        public virtual void Decrypt(string inputfile, string outputfile)
        {

        }
        public virtual bool IsValidKey()
        {
            return false;
        }
    }
}
