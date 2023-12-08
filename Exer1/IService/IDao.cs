﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer1.IService;
internal interface IDao
{
    void AddProduct();
    void ShowProduct();
    void DeleteProduct();
    void FindProduct();
    void UpdateProduct();

    void SortProduct();
}
