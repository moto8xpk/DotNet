﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebMVC.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext (DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<WebMVC.Models.Product> Product { get; set; }
    }
}
