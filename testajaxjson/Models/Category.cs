﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testajaxjson.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Praducts { get; set; }
    }
}