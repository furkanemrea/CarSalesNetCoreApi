using CarSalesCoreApi.Entities;
using CarSalesCoreApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Services
{
    public class ModelService
    {
        IModelDal _modelDal;
        public ModelService(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }
        [HttpGet("")]
        public List<Model> GetModels()
        {
            var result = _modelDal.GetList();
            return result;
        }
        [HttpGet("{Id}")]
        public Model GetModelById(int Id)
        {
            var result = _modelDal.Get(x => x.Id == Id);
            return result;
        }
        [HttpPut]
        public Model UpdateModel(Model model)
        {
            _modelDal.Update(model);
            return model;
        }
        [HttpPost]
        public Model AddModel(Model model)
        {
            _modelDal.Add(model);
            return model;
        }

        [HttpDelete("{Id}")]
        public int DeleteModel(int Id)
        {
            _modelDal.Delete(new Model { Id = Id });
            return Id;
        }


    }
}
