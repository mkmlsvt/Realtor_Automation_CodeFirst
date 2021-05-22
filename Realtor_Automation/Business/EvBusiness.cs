using AutoMapper;
using Realtor_Automation.Data;
using Realtor_Automation.DTO;
using Realtor_Automation.Loglar.EvLog;
using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realtor_Automation.Business
{
    public class EvBusiness
    {
        //mapper ekleme
        MapperConfiguration config;
        Mapper mapper;
        EvData evData;
        public EvBusiness()
        {
            evData = new EvData();
            config = new MapperConfiguration(q => q.CreateMap<Ev, EvDTO>());
            mapper = new Mapper(config);
        }
        public Ev Get_By_Id(int id)
        {
            var data = evData.Get_By_Id(id);      
            return data;
        }

        public int ToplamEvSayi()
        {
            int toplamEvSayi = 0;
            List<Ev> evler = evData.GetAllHouse();
            foreach(var tev in evler)
            {
                toplamEvSayi++;
            }
            return toplamEvSayi;
        }

        public void AddHouse(Ev ev)
        {
            try
            {
                evData.AddHouse(ev);
            }
            catch (Exception exception)
            {
                var evlog = new EvLog();
                using (StreamWriter writer = new StreamWriter(evlog.fullpath, true))
                {
                    writer.WriteLine(exception.Message + "\tEv Kaydetme Başarısız\t" + System.DateTime.Now.ToString());
                }
            }
        }
        public List<EvDTO> GetAllHouseDTO()
        {
            var evler = evData.GetAllHouse();
            var evlerDTO = mapper.Map<List<Ev>, List<EvDTO>>(evler);
            return evlerDTO;
        }

        public List<EvDTO> GetFilteredHouseData(EvFilterDTO evFilterObject)
        {
            var filteredEntity = evData.GetFilteredHouseData(evFilterObject);
            var filteredDTO = mapper.Map<List<Ev>, List<EvDTO>>(filteredEntity);
            return filteredDTO;
        }

        public void DeleteHouse(int id)
        {
            evData.DeleteHouse(id);
        }

        public Ev GetHouseById(int id)
        {
            Ev ev = evData.GetHouseById(id);
            return ev;
        }

        internal void UpdateHouse(int duzenlenecekId, Ev ev)
        {
            evData.UpdateHouse(duzenlenecekId, ev);
        }

        internal void HouseUnAvailable(int unavailableId)
        {
            evData.HouseUnAvailable(unavailableId);
        }
    }
}
