using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities
{
    public class Company:IEntity
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public bool Status { get; set; }
    }
}
