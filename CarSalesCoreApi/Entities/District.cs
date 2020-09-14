using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Entities
{
    public class District:IEntity
    {
        public int Id { get; set; }

        public string DistrictName { get; set; }
        public int City { get; set; }
    }
}
