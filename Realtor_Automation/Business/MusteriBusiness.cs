using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realtor_Automation.Data;
using AutoMapper;
using Realtor_Automation.DTO;

namespace Realtor_Automation.Business
{
    public class MusteriBusiness
    {

        MapperConfiguration config;
        Mapper mapper;
        MusteriData musteriData;
        public MusteriBusiness()
        {
            config = new MapperConfiguration(q => q.CreateMap<Musteri, MusteriDTO>());
            mapper = new Mapper(config);
            musteriData = new MusteriData();
        }
        
        public void AddCustomer(Musteri musteri)
        {
            musteriData.AddCustomer(musteri);
        }
        public List<Musteri> GetAllCustomers()
        {
            var musteriler = musteriData.GetAllCustomers();
            return musteriler;
        }

        public int ToplamMusteriSayi()
        {
            int sumCustomers = 0;
            var musteriler = musteriData.GetAllCustomers();
            foreach (var musteri in musteriler)
            {
                sumCustomers++;
            }
            return sumCustomers;
        }

        public List<MusteriDTO> GetAllCustomersDTO()
        {
            var musteriler = musteriData.GetAllCustomers();
            var musterlierDTO = mapper.Map<List<Musteri>, List<MusteriDTO>>(musteriler);
            return musterlierDTO;
        }
        public List<MusteriSpDTO> GetAllCustomersFromSp()
        {
           var a =  musteriData.GetAllCustomersFromSp();
           return a;

        }

        public void DeleteCustomer(string ad, string soyad)
        {
            musteriData.DeleteCustomer(ad,soyad);
        }

        public void UpdateCustomer(Musteri musteri , Musteri degiscekMusteri)
        {
            musteriData.UpdateCustomer(musteri,degiscekMusteri);
        }
    }
}
