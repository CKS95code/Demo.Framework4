﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Framework4.Core
{
    [Serializable]
    public class Article
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Ean13 { get; set; }
        public string ProductDescription { get; set; }

    }

}
