using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asymmetrickey.Service;

namespace Asymmetrickey
{
    public partial class Form1 : Form
    {

        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        
        byte[] plaintext;
        byte[] encryptedtext;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //txt_Private_Key.Text = RSA.ToXmlString(true);
            //txt_Public_Key.Text = RSA.ToXmlString(false);
            txt_Private_Key.Text = Convert.ToBase64String(Encoding.Unicode.GetBytes(RSA.ToXmlString(true)));
            txt_Public_Key.Text = Convert.ToBase64String(Encoding.Unicode.GetBytes(RSA.ToXmlString(false)));
            txt_secrect_key_1.Text = txt_Public_Key.Text;
            txt_secrect_key_2.Text = txt_Private_Key.Text;
            
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            //plaintext = ByteConverter.GetBytes(txt_message.Text);
            //txt_encrypted.Text = Convert.ToBase64String(Generator.Encrypt(txt_secrect_key_1.Text, plaintext));
            //txt_Encrypted_Message.Text = txt_encrypted.Text;
            var xmlkey = Encoding.Unicode.GetString(Convert.FromBase64String(txt_secrect_key_1.Text));
            plaintext = ByteConverter.GetBytes(txt_message.Text);
            encryptedtext = Generator.Encryption(plaintext, xmlkey, false);
            txt_encrypted.Text = ByteConverter.GetString(encryptedtext);
            txt_Encrypted_Message.Text = ByteConverter.GetString(encryptedtext);
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            var xmlkey = Encoding.Unicode.GetString(Convert.FromBase64String(txt_secrect_key_2.Text));
            //txt_Decrypt_Message.Text = Convert.ToBase64String(Generator.Decrypt(txt_secrect_key_2.Text, Convert.FromBase64String(txt_Encrypted_Message.Text)));
            byte[] decryptedtex = Generator.Decryption(encryptedtext, xmlkey, false);
            txt_Decrypt_Message.Text = ByteConverter.GetString(decryptedtex);
        }
    }
}
