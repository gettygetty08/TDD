﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.UI
{
    public interface IDB
    {
        int GetDBValue();
        Product GetProduct();

        void SaveProduct(Product product);
    }
}
