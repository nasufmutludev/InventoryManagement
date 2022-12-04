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

        public void Sale(int id, int quantity, string inventoryNo, int companyId, DateTime DateOfEntry, DateTime ReleaseDate)
        {
            var inventoryFind = _inventoryDal.Get(x => x.Id == id);
            if (inventoryFind != null)
            {
                var sale = inventoryFind.Quantity - quantity;
                var result = new Inventory
                {
                    Id = id,
                    InventoryName = inventoryNo,
                    CompanyId = companyId,
                    Quantity = sale,
                    DateOfEntry = DateOfEntry,
                    ReleaseDate = ReleaseDate
                };
                _inventoryDal.Update(result);
            }
        }
    }
}
