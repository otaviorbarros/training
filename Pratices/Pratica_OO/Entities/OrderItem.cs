﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Pratica_OO.Entities
{
    class OrderItem : Product
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        public double subTotal()
        {
            return Quantity * Price;
        }
        public override string ToString()
        {
            return Product.Name 
                + ", $" 
                + Price.ToString("F2", CultureInfo.InvariantCulture) 
                +", Quantity: "
                + Quantity
                + ", SubTotal:  " 
                + subTotal().ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
