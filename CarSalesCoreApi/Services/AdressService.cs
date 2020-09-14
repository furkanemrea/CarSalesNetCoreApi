using CarSalesCoreApi.Entities;
using CarSalesCoreApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSalesCoreApi.Services
{
    public class AdressService
    {
        IAdressDal _adressDal;
        public AdressService(IAdressDal adressDal)
        {
            _adressDal = adressDal;
        }
        
        public List<Adress> GetAdress()
        {
            var list = _adressDal.GetList();
            return list;
        }

        public Adress GetAdressById(int Id)
        {
            var adres = _adressDal.Get(x=>x.Id==Id);
            return adres;
        }

        public Adress AddAdress(Adress adress)
        {
            _adressDal.Add(adress);
            return adress;
        }

        public Adress UpdateAdress(Adress adress)
        {
            _adressDal.Update(adress);
            return adress;
        }
        public int DeleteAdress(int Id)
        {
            _adressDal.Delete(new Adress { Id = Id });
            return Id;
        }
    }
}
