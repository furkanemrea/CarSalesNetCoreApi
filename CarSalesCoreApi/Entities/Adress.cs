using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Entities
{
    public class Adress:IEntity
    {
        public int Id { get; set; }
        public int DistinctId { get; set; }
        public int CityId { get; set; }
        public string AdressName { get; set; }
    }
}
