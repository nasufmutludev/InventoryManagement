using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.Abstract
{
    public interface IInventoryService
    {
        List<Inventory> GetList();
        void Add(string inventoryName,int companyId,DateTime dateOfEntry,DateTime releaseDate,int quantity);
        void Sale(int id, int quantity, string inventoryNo, int companyId, DateTime DateOfEntry, DateTime ReleaseDate);
    }
}
