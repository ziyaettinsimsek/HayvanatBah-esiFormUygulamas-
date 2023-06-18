using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HayvanatBahçesiFormUygulaması.DL
{
    public static class DataLayer
    {
        static MySqlConnection conn = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server = "127.0.0.1" ,
                Database = "hayvanat_bahcesi",
                UserID = "root",
                Password = "1qer8ytb16",

            }.ConnectionString
            );
        public static int HayvanEkle(Hayvan m)
        {

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("hayvanEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@hayvan_id", m.ID);
                komut.Parameters.AddWithValue("@hayvan_adi", m.Hayvan_Ad);
                komut.Parameters.AddWithValue("@hayvan_turu", m.Turu);
                komut.Parameters.AddWithValue("@hayvan_kafesi", m.Kafesi);
                komut.Parameters.AddWithValue("@hayvan_yemi", m.Yemi);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally 
            {
                if (conn.State!= System.Data.ConnectionState.Closed)
                conn.Close();
            }

        }

        internal static int HayvanEkle(object m)
        {
            throw new NotImplementedException();
        }

        internal static DataSet Hayvangetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("hayvanlarHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    
                }
                else
                {
                    komut = new MySqlCommand("hayvanBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);

                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int HayvanGüncelle(Hayvan m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("hayvanGüncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@hayvan_id", m.ID);
                komut.Parameters.AddWithValue("@hayvan_adi", m.Hayvan_Ad);
                komut.Parameters.AddWithValue("@hayvan_turu", m.Turu);
                komut.Parameters.AddWithValue("@hayvan_kafesi", m.Kafesi);
                komut.Parameters.AddWithValue("@hayvan_yemi", m.Yemi);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int HayvanSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("hayvanSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@hayvan_id", id);
                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int ziyaretcilerEkle(ziyaretciler u)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("ziyaretcilerEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ziyaretci_id", u.ID);
                komut.Parameters.AddWithValue("@hayvan_id", u.HayvanID);
                komut.Parameters.AddWithValue("@isim", u.Ziyaretci_İsim);
                komut.Parameters.AddWithValue("@soyisim", u.Ziyaretci_Soyisim);
                komut.Parameters.AddWithValue("@ziyaretci_yası", u.Ziyaretci_Yasi);
                komut.Parameters.AddWithValue("@telefon", u.Ziyaretci_Telefon);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet ziyaretcilergetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("ziyaretcilerHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("ziyaretcilerBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);

                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }
    }
}
