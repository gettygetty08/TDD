using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.UI
{
    public class DB : IDB
    {
        public int GetDBValue()
        {
            //実際はデータベースに接続
            return 200;
        }

        public Product GetProduct()
        {
            return new Product(1, "p1");
        }

        public void SaveProduct(Product product)
        {
            //実際はデータベースに接続
        }
    }
}
