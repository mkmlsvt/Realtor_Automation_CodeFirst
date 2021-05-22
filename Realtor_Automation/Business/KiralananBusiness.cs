using AutoMapper;
using Realtor_Automation.Data;
using Realtor_Automation.DTO;
using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtor_Automation.Business
{
    class KiralananBusiness
    {
        MapperConfiguration config;
        Mapper mapper;
        KiralananData kiralananData;
        public KiralananBusiness()
        {
            kiralananData = new KiralananData();
            config = new MapperConfiguration(q => q.CreateMap<Kiralanan, KiralananDTO>());
            mapper = new Mapper(config);
        }
        public void AddKiralanan(Kiralanan kiralanan)
        {
            kiralananData.AddKiralanan(kiralanan);
        }
        public List<KiralananDTO> GetAllKiralananDTO ()
        {
            var kiralananlar = kiralananData.GetAllKiralanan();
            var kiralananlarDTO = mapper.Map<List<Kiralanan>, List<KiralananDTO>>(kiralananlar);
            return kiralananlarDTO;
        }

        public int ToplamKiralananSayi()
        {
            int toplam = 0;
            var kiralananlar = kiralananData.GetAllKiralanan();
            foreach(var kiralanan in kiralananlar)
            {
                toplam++;
            }
            return toplam;
        }
        public double KiralananOrtalama()
        {
            double ortKira = 0;
            var kiralananlar = kiralananData.GetAllKiralanan();
            var kiralananlarDTO = mapper.Map<List<Kiralanan>, List<KiralananDTO>>(kiralananlar);
            foreach(var kiralananDto in kiralananlarDTO)
            {
                ortKira += int.Parse(kiralananDto.EvFiyat.ToString());
            }
            ortKira = ortKira / ToplamKiralananSayi();
            return ortKira;
        }

    }
}
