using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KTPM_Week_3.Service;


namespace KTPM_Week_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            txt_Encrypted.Text = HashService.MD5Hash(txt_Password.Text.Trim());
            if (txt_Encrypted.Text.Equals(""))
            {
                MessageBox.Show("Fuck You !");
            }
            else
            {
                MessageBox.Show("Success !");
            }
        }
    }
}
