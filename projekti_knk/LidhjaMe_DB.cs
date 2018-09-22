using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Projekti_KNK
{
    class LidhjaMe_DB
    {
        public string MesazhiGabim = "";

        public DataSet LexoShenime(string Query)
        {
            SqlConnection objKonektimi = new SqlConnection(Parametra._KonektimiDB);
            SqlCommand objKomanda = new SqlCommand(Query, objKonektimi);
            SqlDataAdapter objAdapter = new SqlDataAdapter(objKomanda);

            DataSet _Shenimet = new DataSet();
            try
            {
                objKonektimi.Open();
                objAdapter.Fill(_Shenimet);
                MesazhiGabim = "";
            }
            catch (Exception exe)
            {
                MesazhiGabim = exe.Message;

            }
            finally { objKonektimi.Close(); }
            return _Shenimet;
        }
        public string InsUpdDel(string Query)
        {
            SqlConnection objKonektimi = new SqlConnection(Parametra._KonektimiDB);
            SqlCommand objKomanda = new SqlCommand(Query, objKonektimi);
            try
            {
                objKonektimi.Open();
                objKomanda.ExecuteNonQuery();
                MesazhiGabim = "";
            }
            catch (Exception ex)
            {
                MesazhiGabim = ex.Message;
            }
            finally { objKonektimi.Close(); }
            return MesazhiGabim;
        }
    }

}

