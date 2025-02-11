﻿namespace AzureSQLDatabaseDemo.DAL.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }

        public ICollection<Order> orders { get; set; } = new List<Order>();
    }
}
