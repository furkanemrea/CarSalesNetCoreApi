using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Entities
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }
}
