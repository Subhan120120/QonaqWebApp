﻿using Microsoft.AspNetCore.Mvc.Rendering;
using QonaqWebApp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QonaqWebApp.Models.ViewModel
{
    public class ProductVM
    {
        public ProductVM()
        {
        }

        public ProductVM(List<AppDetail> appDetails)
        {
            this.AppDetails = appDetails;
        }

        public ProductVM(List<AppDetail> appDetails, List<Category> categories)
            : this(appDetails)
        {
            this.Categories = categories;
        }

        public ProductVM(List<AppDetail> appDetails, List<Category> categories, List<Product> product)
            : this(appDetails, categories)
        {
            this.Product = product;
        }

        public List<AppDetail> AppDetails { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Product { get; set; }
    }
}