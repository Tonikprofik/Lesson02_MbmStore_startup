﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;


namespace MbmStore.Models
{
    public class Invoice
    {
        private decimal totalPrice;

        public int InvoiceId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; }
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; private set; } = new List<OrderItem>();
        
        public Invoice (int invoiceId, DateTime orderDate
            , Customer customer)
        {
            InvoiceId = invoiceId;
            OrderDate = orderDate;
            Customer = customer;
        }
        public void AddOrderItem(Product product, int quantity)
        {
            
            OrderItems.Add(new OrderItem(product, quantity));
            
        }
    }
}
