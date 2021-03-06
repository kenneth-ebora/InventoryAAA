﻿using DataAccess.Database.InventoryAAA;
using DataAccess.Entities.Context.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Context
{
    public class AAAInventoryEntities : System.Data.Entity.DbContext, IAAAInventoryEntities
    {
        public AAAInventoryEntities()
            : base("name=")
        { }

        public virtual DbSet<OrderType> OrderTypes { get; set; }
        public virtual DbSet<ProductLog> ProductLogs { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public virtual DbSet<SalesOrder> SalesOrders { get; set; }

    }
}
