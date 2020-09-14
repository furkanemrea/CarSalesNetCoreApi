using CarSalesCoreApi.Entities;
using CarSalesCoreApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Services
{
    public class CategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetCategories()
        {
            var result = _categoryDal.GetList();
            return result;
        }

        public Category GetCategoryById(int Id)
        {
            var category = _categoryDal.Get(x=>x.Id==Id);
            return category;
        }

        public Category AddCategory(Category category)
        {

            _categoryDal.Add(category);
            return category;
        }
        public Category UpdateCategory(Category category)
        {
            _categoryDal.Update(category);
            return category;
        }

        public int DeleteCategory(int Id)
        {
            _categoryDal.Delete(new Category { Id = Id });
            return Id;
        }

    }
}
