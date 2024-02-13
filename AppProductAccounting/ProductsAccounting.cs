using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace AppProductAccounting
{
    public class ProductsAccounting
    {
        private List<Product> _products;
        private Dictionary<int, int> _countByArticleDictionary;
        public ProductsAccounting()
        {
            _products = new List<Product>();
            _countByArticleDictionary = new Dictionary<int, int>();
        }

        public bool AddProduct(string name, int article)
        {
            if (name != null && article.ToString().Length > 0 && article.ToString().Length < 10)
            {
                _products.Add(new Product(name, article));
                _countByArticleDictionary.Add(article, 0);
                return true;
            }

            return false;

        }
        public bool ChangingQuantityOfProduct(int article, int count)
        {
            if (СheckingExistenceOfProduct(article))
            {
                _countByArticleDictionary.Add(article, count);
                return true;
            }

            return false;
        }

        private bool СheckingExistenceOfProduct(int article)
        {
            foreach (Product product in _products)
            {
                if (article == product.Article)
                {
                    return true;
                }
            }
            return false;
        }

        public void ReadList()
        {
            foreach (var product in _countByArticleDictionary)
            {
                Console.WriteLine($" Артикул: {product.Key} Количество: {product.Value}");
            }
        }


    }
}
