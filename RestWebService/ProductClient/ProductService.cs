using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ProductShared;
namespace ProductClient1
{
    class ProductService
    {
        public static WebClient client = new WebClient();
        public static String uriString = "http://localhost:60507/api/productservice/";

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
            String json = client.UploadString(new Uri(uriString + "insert"), "POST", data);
            Boolean flag = JsonConvert.DeserializeObject<Boolean>(json);
            return flag;
        }

        public static Boolean Insert(Product product)
        {
            String data = JsonConvert.SerializeObject(product);
            String json = client.UploadString(new Uri(uriString + "insert"), "POST", data);
            Boolean flag = JsonConvert.DeserializeObject<Boolean>(json);
            return flag;
        }

        public static Boolean deleteById(String id)
        {
            String json = client.UploadString(new Uri(uriString + "delete/"+id), "POST");
            Boolean flag = JsonConvert.DeserializeObject<Boolean>(json);
            return flag;
        }
    }

}

