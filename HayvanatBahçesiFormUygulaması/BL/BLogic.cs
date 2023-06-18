using HayvanatBahçesiFormUygulaması.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HayvanatBahçesiFormUygulaması.BL
{
    public static class BLogic
    {
        public static bool HayvanEkle(Hayvan m)
        {
            try
            {


                int res = DataLayer.HayvanEkle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu:" +  ex.Message);
                return false;
            }
        }

        internal static DataSet Hayvangetir(string filtre)
        {
            try
            {


                DataSet ds = DataLayer.Hayvangetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool HayvanGüncelle(Hayvan m)
        {
            try
            {


                int res = DataLayer.HayvanGüncelle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool HayvanSil(string id)
        {
            try
            {


                int res = DataLayer.HayvanSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool ziyaretcilerEkle(ziyaretciler u)
        {
            try
            {


                int res = DataLayer.ziyaretcilerEkle(u);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet ziyaretcilergetir(string filtre)
        {
            try
            {


                DataSet ds = DataLayer.ziyaretcilergetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu:" + ex.Message);
                return null;
            }
        }
    
    }
}
