using CarSalesCoreApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Repository.EfDataAccessLayers
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category, CarSalesContext>, ICategoryDal
    {
    }
}
