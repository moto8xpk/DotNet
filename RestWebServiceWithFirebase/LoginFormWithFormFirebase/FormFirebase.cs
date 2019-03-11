using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using LoginFormWithFormFirebase;
namespace LoginFormWithFormFirebase
{
    public partial class FormFirebase : Form
    {
        private const string FIREBASE_APP = "https://shoppingcartasp-1659c.firebaseio.com/";
        private FirebaseClient firebase;

        public FormFirebase()
        {
            InitializeComponent();
            firebase = new FirebaseClient(FIREBASE_APP);
        }

        private async void btnInsert_Click(object sender, EventArgs e)
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

            try
            {
                //await firebase.Child("sc_product").PostAsync(product);
                await firebase.Child("sc_product").Child("product" + product.id).PutAsync(product);
                MessageBox.Show("Success !");
            }
            catch (Exception)
            {
                MessageBox.Show("Fuck You !");
            }
            this.clearText();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtSearch.Text.Trim();
            List<Product> products = new List<Product>();
            var fb_products = await firebase.Child("sc_product").OnceAsync<Product>();

            foreach (var i in fb_products)
            {
                if (i.Object.name.Contains(keyword))
                {
                    products.Add(i.Object);
                }
            }
            dataGridView1.DataSource = products;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            String id = txtId.Text.ToString();
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    //await firebase.Child("sc_product").PostAsync(product);
                    await firebase.Child("sc_product").Child("product" + id).DeleteAsync();
                    MessageBox.Show("Success !");
                }
                catch (Exception)
                {
                    MessageBox.Show("Fuck You !");
                }
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
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

            try
            {
                //await firebase.Child("sc_product").PostAsync(product);
                await firebase.Child("sc_product").Child("product" + product.id).PutAsync(product);
                MessageBox.Show("Success !");
            }
            catch (Exception)
            {
                MessageBox.Show("Fuck You !");
            }
            this.clearText();
        }

        private void FormFirebase_Load(object sender, EventArgs e)
        {
            firebase.Child("sc_product").AsObservable<Product>().Subscribe(async item =>
            {
                List<Product> products = new List<Product>();
                var fb_products = await firebase.Child("sc_product").OnceAsync<Product>();
                foreach (var i in fb_products)
                {
                    products.Add(i.Object);
                }

                dataGridView1.BeginInvoke(new MethodInvoker(delegate
                {
                    dataGridView1.DataSource = products;
                }));
            });
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
