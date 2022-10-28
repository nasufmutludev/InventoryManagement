using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class InventoryManager:IInventoryService
    {
        private IInventoryDal _inventoryDal;

        public InventoryManager(IInventoryDal inventoryDal)
        {
            _inventoryDal = inventoryDal;
        }

        public List<Inventory> GetList()
        {
            return _inventoryDal.GetAll();
        }

        public void Add(Inventory inventory)
        {
            _inventoryDal.Add(inventory);
        }
    }
}
