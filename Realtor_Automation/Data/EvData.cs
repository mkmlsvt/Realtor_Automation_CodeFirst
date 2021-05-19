using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Realtor_Automation.DTO;

namespace Realtor_Automation.Data
{
    
    public class EvData
    {
        public DatabaseContext db;
        public EvData()
        {
           this.db = new DatabaseContext();
        }
        public Ev Get_By_Id(int id)
        {
            var data = db.TBLEv.FirstOrDefault(q => q.Id == id);
            return data;
        }
        public void AddHouse(Ev ev)
        {
            db.TBLEv.Add(ev);
            db.SaveChanges();
        }
        public List<Ev> GetAllHouse()
        {
            List<Ev> evler = db.TBLEv
                            .Include(q => q.Musteri)
                            .Include(q => q.EvTur)
                            .ToList();
            return evler;
        }

        public List<Ev> GetFilteredHouseData(EvFilterDTO evFilterObject)
        {
            var query = db.TBLEv
                        .Include(q => q.Musteri)
                        .Include(q => q.EvTur);

            if (evFilterObject.Esyali.HasValue)
            {
                query = query.Where(q => q.Esyali == evFilterObject.Esyali);
            }
            if (evFilterObject.Musait.HasValue)
            {
                query = query.Where(q => q.Musait == evFilterObject.Musait);
            }
            if (evFilterObject.MaxFiyat.HasValue)
            {
                query = query.Where(q => q.Fiyat <= evFilterObject.MaxFiyat);
            }
            if (evFilterObject.MetreKare.HasValue)
            {
                query = query.Where(q => q.Metrekare >= evFilterObject.MetreKare);
            }
            if (evFilterObject.MinFiyat.HasValue)
            {
                query = query.Where(q => q.Fiyat >= evFilterObject.MinFiyat);
            }
            if (evFilterObject.Kat.HasValue)
            {
                query = query.Where(q => q.Kat >= evFilterObject.Kat);
            }
            if (evFilterObject.OdaSayisi.HasValue)
            {
                query = query.Where(q => q.OdaSayi >= evFilterObject.OdaSayisi);
            }
            if (!string.IsNullOrEmpty(evFilterObject.MusteriAd))
            {
                query = query.Where(q => q.Musteri.Ad.Equals(evFilterObject.MusteriAd));
            }
            if (!string.IsNullOrEmpty(evFilterObject.MusteriSoyad))
            {
                query = query.Where(q => q.Musteri.Soyad.Equals(evFilterObject.MusteriSoyad));
            }
            if (!string.IsNullOrEmpty(evFilterObject.SatilikKiralik))
            {
                query = query.Where(q => q.KiralikSatilik.Equals(evFilterObject.SatilikKiralik));
            }

            var filteredList = query.ToList();
            return filteredList;
        }

        internal void HouseUnAvailable(int unavailableId)
        {
            Ev ev = db.TBLEv.FirstOrDefault(q => q.Id == unavailableId);
            ev.Musait = false;
            db.SaveChanges();
        }

        internal void UpdateHouse(int duzenlenecekId, Ev ev)
        {
            Ev duzenlecenekEv = db.TBLEv.FirstOrDefault(q => q.Id == duzenlenecekId);
            duzenlecenekEv.Adres = ev.Adres;
            duzenlecenekEv.Esyali = ev.Esyali;
            duzenlecenekEv.EvTurId = ev.EvTurId;
            duzenlecenekEv.Fiyat = ev.Fiyat;
            duzenlecenekEv.Kat = ev.Kat;
            duzenlecenekEv.KiralikSatilik = ev.KiralikSatilik;
            duzenlecenekEv.Metrekare = ev.Metrekare;
            duzenlecenekEv.MusteriId = ev.MusteriId;
            duzenlecenekEv.OdaSayi = ev.OdaSayi;
            duzenlecenekEv.Resim = ev.Resim;
            db.SaveChanges();
        }

        public Ev GetHouseById(int id)
        {
            Ev ev = db.TBLEv.FirstOrDefault(q => q.Id == id);
            return ev;
        }

        public void DeleteHouse(int id)
        {
            var sil  = db.TBLEv.FirstOrDefault(q => q.Id == id);
            db.TBLEv.Remove(sil);
            db.SaveChanges();
        }
    }
}
