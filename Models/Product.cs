using MyWebApiRep.Models.EFCore;
using System;
using System.Collections.Generic;

#nullable disable

namespace MyWebApiRep.Models
{
    public partial class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
    }
}
