﻿namespace AzureSQLDatabaseDemo.DAL.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
