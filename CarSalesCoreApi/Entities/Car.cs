using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Entities
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int ModelId { get; set; }
        public int KM { get; set; }
        public string Color { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? EndDate { get; set; }
        public Statuses Status { get; set; }
        public int? CharacteristicId { get; set; }


        public enum Statuses { ACTIVE,PASSIVE,ON_HOLD };
    }
}
