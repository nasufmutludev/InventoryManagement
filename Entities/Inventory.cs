using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities
{
    public class Inventory : IEntity
    {
        public int Id { get; set; }
        public string InventoryName { get; set; }
        public int Quantity { get; set; }
        public int CompanyId { get; set; }
        public DateTime DateOfEntry { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
