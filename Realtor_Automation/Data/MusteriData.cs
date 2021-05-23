using Realtor_Automation.DTO;
using Realtor_Automation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Realtor_Automation.Data
{
    public class MusteriData
    {
        DatabaseContext db;
        public MusteriData()
        {
            db = new DatabaseContext();
        }
        public void AddCustomer(Musteri musteri)
        {
            db.TBLMusteri.Add(musteri);
            db.SaveChanges();
        }
        public List<Musteri> GetAllCustomers()
        {
            List<Musteri> musteriler =  db.TBLMusteri.ToList();
            return musteriler;
        }

        public List<MusteriSpDTO> GetAllCustomersFromSp()
        {
            var musteriSpDTO = db.Database.SqlQuery<MusteriSpDTO>("exec lsp_get_all_musteri").ToList();
            return musteriSpDTO;
        }

        public void DeleteCustomer(string ad , string soyad)
        {
            try
            {
                var deletingCustomer = db.TBLMusteri.FirstOrDefault(q => q.Ad == ad && q.Soyad == soyad);
                db.TBLMusteri.Remove(deletingCustomer);
                db.SaveChanges();
                MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception e )
            {
                MessageBox.Show("Silme İşlemi Başarısız Lütfen Önce Musterinin Evini Silin", "hata", MessageBoxButton.OK, MessageBoxImage.Error);
                
            }
            
        }

        internal void UpdateCustomer(Musteri musteri,Musteri degiscekMusteri)
        {
            var a =  db.TBLMusteri.FirstOrDefault(q => q.Ad == degiscekMusteri.Ad && q.Soyad == degiscekMusteri.Soyad && q.TelNo == degiscekMusteri.TelNo);
            a.Ad = musteri.Ad;
            a.Soyad = musteri.Soyad;
            a.TelNo = musteri.TelNo;
            a.MusteriTurId = musteri.MusteriTurId;
            db.SaveChanges();
        }
    }
}
