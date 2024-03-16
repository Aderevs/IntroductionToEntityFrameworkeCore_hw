using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public Product(Guid id, string name, double cost, string? description, int quantity)
        {
            Id = id;
            Name = name;
            Cost = cost;
            Description = description;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"{Name} - {Cost} ({Quantity})";
        }
    }
}
