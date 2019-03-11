using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LoginFormWithFormFirebase;

namespace LoginFormWithFormFirebase
{
    public partial class Form1 : Form
    {

        public static WebClient client = new WebClient();
        public static String uriString = "http://loginrestservice.somee.com/api/accountservice/";

        //public static List<Account> selectAll()
        //{
        //    String json = client.DownloadString(new Uri(uriString + "getall"));
        //    List<Account> accounts = JsonConvert.DeserializeObject<List<Account>>(json);
        //    return accounts;
        //}

        //public static List<Account> searchByName(String keywords)
        //{

        //    String json = client.DownloadString(new Uri(uriString + "search/" + keywords));
        //    List<Account> accounts = JsonConvert.DeserializeObject<List<Account>>(json);
        //    return accounts;
        //}

        //public static Account searchById(String id)
        //{

        //    return null;
        //}

        //public static Boolean updateById(Account account)
        //{
        //    String data = JsonConvert.SerializeObject(account);
        //    client.Headers[HttpRequestHeader.ContentType] = "application/json";
        //    String json = client.UploadString(new Uri(uriString + "update"), "POST", data);
        //    Boolean flag = JsonConvert.DeserializeObject<Boolean>(json);
        //    return flag;
        //}

        //public static Boolean Insert(account account)
        //{
        //    String data = JsonConvert.SerializeObject(account);
        //    client.Headers[HttpRequestHeader.ContentType] = "application/json";
        //    String json = client.UploadString(new Uri(uriString + "insert"), "POST", data);
        //    Boolean flag = JsonConvert.DeserializeObject<Boolean>(json);
        //    return flag;
        //}

        //public static Boolean deleteById(String id)
        //{
        //    String json = client.UploadString(new Uri(uriString + "delete/" + id), "POST");
        //    Boolean flag = JsonConvert.DeserializeObject<Boolean>(json);
        //    return flag;
        //}

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text.Trim();
            String pass = textBox2.Text.Trim();

            String json = client.DownloadString(new Uri(uriString + "search/" + name));
            List<Account> accounts = JsonConvert.DeserializeObject<List<Account>>(json);
            if(accounts.Count()==0)
            {
                MessageBox.Show("Duplcated !");
            }
            else
            {
                FormFirebase f = new FormFirebase();
                f.Show();
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text.Trim();
            String pass = textBox2.Text.Trim();
            Account acc = new Account()
            {
                Username = name,
                Password = pass

            };
            String data = JsonConvert.SerializeObject(acc);
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String json = client.UploadString(new Uri(uriString + "insert"), "POST", data);
            Boolean flag = JsonConvert.DeserializeObject<Boolean>(json);
            if (flag==true)
            {
                MessageBox.Show("Success !");
            }
            else
            {
                MessageBox.Show("Fuck you !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
