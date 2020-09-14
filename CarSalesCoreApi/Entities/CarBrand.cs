using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Entities
{
    public class CarBrand:IEntity
    {
        public int Id { get; set; }
        public string Brand { get; set; }

    }
}
