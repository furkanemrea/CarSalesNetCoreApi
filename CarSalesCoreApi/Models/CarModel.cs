using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string CategoryName { get; set; }
        public string ModelName { get; set; }
        public int KM { get; set; }
        public string Color { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int? CharacteristicId { get; set; }
    }
}
