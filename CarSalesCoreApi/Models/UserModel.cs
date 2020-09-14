using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Username { get; set; }
       
        public string Photo { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string Adress { get; set; }
    }
}
