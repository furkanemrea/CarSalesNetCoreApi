using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Entities
{
    public class Model:IEntity
    {
        public int Id { get; set; }
        public int Brand { get; set; }
        public string ModelName { get; set; }

    }
}
