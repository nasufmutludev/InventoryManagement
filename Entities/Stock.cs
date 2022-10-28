using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities
{
    public class Stock:IEntity
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public string Quantity { get; set; }
        public double Price { get; set; }
    }
}
