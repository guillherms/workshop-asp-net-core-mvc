﻿using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Ammount { get; set; }
        public int MyProperty { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double ammount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Ammount = ammount;
            Status = status;
            Seller = seller;
        }
    }
}
