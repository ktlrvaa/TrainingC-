using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProductAccounting
{
    public class Product
    {
        public readonly string Name;
        public readonly int Article;

        public Product(string name, int article)
        {
            Name = name;
            Article = article;
        }
    }
}