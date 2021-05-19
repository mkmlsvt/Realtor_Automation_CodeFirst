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
    public class SatilanBusiness
    {
        MapperConfiguration config;
        Mapper mapper;
        SatilanData satilanData;
        public SatilanBusiness()
        {
            satilanData = new SatilanData();
            config = new MapperConfiguration(q => q.CreateMap<Satilan, SatilanDTO>());
            mapper = new Mapper(config);
        }
        public void AddSatilan(Satilan satilan)
        {
            satilanData.AddSatilan(satilan);
        }

        public List<SatilanDTO> GetAllSatilanDTO()
        {
            var satilanlar = satilanData.GetAllSatilan();
            var satilanlarDTO = mapper.Map<List<Satilan>,List<SatilanDTO>>(satilanlar);
            return satilanlarDTO;
        }
    }
}
