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

    }
}
