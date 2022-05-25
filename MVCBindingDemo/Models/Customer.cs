using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBindingDemo.Models
{
    public class Customer
    {
        public int CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public DateTime CustomerDOJ { get; set; }
        public bool CustomerStatus { get; set; }
        public string CustomerType { get; set; }
    }
}