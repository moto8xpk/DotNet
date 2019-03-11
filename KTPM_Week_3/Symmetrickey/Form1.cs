using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Symmetrickey.Service;

namespace Symmetrickey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            try {

                txt_encrypted.Text = ClsTripleDES.Encrypt(txt_message.Text.Trim(), txt_secrect_key_1.Text.Trim());
                txt_Encrypted_Message.Text = txt_encrypted.Text;
                MessageBox.Show("Success !");

            } catch {
                MessageBox.Show("Fuck You !");
            }
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Decrypt_Message.Text = ClsTripleDES.Decrypt(txt_Encrypted_Message.Text.Trim(), txt_secrect_key_2.Text.Trim());
                MessageBox.Show("Success !");
            }
            catch
            {
                MessageBox.Show("Fuck You !");
            }
                
        }
    }
}
