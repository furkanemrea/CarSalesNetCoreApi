using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Entities
{
    public class Favorite:IEntity
    {
        public int Id { get; set; }
        public int FavoriteAdvertisement { get; set; }
        public int Advertiser { get; set; }
        public int UserId { get; set; }
    }
}
