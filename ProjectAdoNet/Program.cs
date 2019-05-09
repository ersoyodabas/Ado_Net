using ProjectAdoNet.Models.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAdoNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            //ADD NEW PRODUCT
            bool result = product.InsertOrUpdate();

            //LIST PRODUCTS
            var productList = product.GetListProduct();

            //PRINT PRODUCT NAMES
            foreach (var item in productList)
            {
                Console.Write(item.Header);
            }

            Console.Read();

        }
    }
}
