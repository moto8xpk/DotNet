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
using Newtonsoft.Json;
using ProductShared;
using ProductClient1;
namespace ProductClient
{
    public partial class Form1 : Form
    {
        public static WebClient client = new WebClient();
        public static String uriString = "http://www.anwebservicerestapi.somee.com/api/productservice/";

        public static List<Product> selectAll()
        {
            String json = client.DownloadString(new Uri(uriString + "getall"));
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);
            return products;
        }

        public static List<Product> searchByName(String keywords)
        {

            String json = client.DownloadString(new Uri(uriString + "search/" + keywords));
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);
            return products;
        }

        public static Product searchById(String id)
        {

            return null;
        }

        public static Boolean updateById(Product product)
        {
            String data = JsonConvert.SerializeObject(product);
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String json = client.UploadString(new Uri(uriString + "update"), "POST", data);
            Boolean flag = JsonConvert.DeserializeObject<Boolean>(json);
            return flag;
        }

        public static Boolean Insert(Product product)
        {
            String data = JsonConvert.SerializeObject(product);
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String json = client.UploadString(new Uri(uriString + "insert"), "POST", data);
            Boolean flag = JsonConvert.DeserializeObject<Boolean>(json);
            return flag;
        }

        public static Boolean deleteById(String id)
        {
            String json = client.UploadString(new Uri(uriString + "delete/" + id), "POST");
            Boolean flag = JsonConvert.DeserializeObject<Boolean>(json);
            return flag;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = selectAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtSearch.Text.Trim();
            List<Product> products = searchByName(keyword).ToList<Product>();
            dataGridView1.DataSource = products;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                id = Int32.Parse(txtId.Text),
                name = txtName.Text.ToString(),
                cateid = Int32.Parse(txtCateId.Text),
                price = Int32.Parse(txtPrice.Text),
                description = txtDesc.Text.ToString(),
                imagelink = txtImageLink.Text.ToString()
            };

            if (Insert(product))
                MessageBox.Show("Success !");
            else
                MessageBox.Show("Fuck You !");
            dataGridView1.DataSource = selectAll();
            this.clearText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String id = txtId.Text.ToString();

            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (deleteById(id))
                    MessageBox.Show("Success !");
                else
                    MessageBox.Show("Fuck You !");
                dataGridView1.DataSource = selectAll();

                this.clearText();
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                id = Int32.Parse(txtId.Text),
                name = txtName.Text.ToString(),
                cateid = Int32.Parse(txtCateId.Text),
                price = Int32.Parse(txtPrice.Text),
                description = txtDesc.Text.ToString(),
                imagelink = txtImageLink.Text.ToString()
            };

            var confirmResult = MessageBox.Show("Are you sure to update this item ??",
                                     "Confirm Update!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (updateById(product))
                    MessageBox.Show("Success !");
                else
                    MessageBox.Show("Fuck You !");
                dataGridView1.DataSource = selectAll();

                this.clearText();
            }
            else
            {
                // If 'No', do something here.
            }
        }

        public void clearText()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtCateId.Text = "";
            txtPrice.Text = "";
            txtDesc.Text = "";
            txtImageLink.Text = "";
        }
    }
}
