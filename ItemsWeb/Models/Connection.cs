using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ItemsWeb.Models
{
    public class Connection
    {
        public SqlConnection Cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);

        public SqlConnection TempCn = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);

        public SqlDataAdapter da = new SqlDataAdapter();
        public SqlDataReader reader;
        public SqlTransaction transaction;

        DataSet ds = new DataSet();

        public DataSet Select(string sql, string Table)
        {

            if (Cn.State != ConnectionState.Open)
            {
                Cn.Open();
            }
            //ds.Clear() ; 
            da = new SqlDataAdapter(sql, Cn);
            da.Fill(ds, Table);

            Cn.Close();

            return ds;
        }

        public DataTable SelectProc(string proname, string[] colums, params object[] values)
        {
            SqlCommand Com = new SqlCommand();


            if (Cn.State != ConnectionState.Open)
            {
                Cn.Open();
            }
            Com.Connection = Cn;
            Com.CommandType = CommandType.StoredProcedure;
            Com.CommandText = proname;
            if (values != null)
            {
                for (int i = 0; i < values.Count(); i++)
                {
                    Com.Parameters.AddWithValue("@" + colums[i], values[i]);
                }
            }
            SqlDataAdapter da1 = new SqlDataAdapter(Com);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            Cn.Close();
            return dt1;
        }

        public void Excute(string sql)
        {

            if (Cn.State != ConnectionState.Open)
            {
                Cn.Open();
            }
            SqlCommand Run = new SqlCommand(sql, Cn);
            SqlTransaction tr;
            tr = Cn.BeginTransaction();
            Run.Transaction = tr;
            Run.CommandTimeout = 0;
            try
            {
                Run.ExecuteNonQuery();
                tr.Commit();
            }
            catch (Exception ex)
            {
                //int o = 8;
                tr.Rollback();
            }
            Cn.Close();
        }

        public void ExcuteProc(string procname, string[] colums, params object[] values)
        {
            SqlCommand Com = new SqlCommand();


            if (Cn.State != ConnectionState.Open)
            {
                Cn.Open();
            }


            Com.Connection = Cn;
            Com.CommandType = CommandType.StoredProcedure;


            Com.CommandText = procname;
            if (values != null)
            {
                for (int i = 0; i < values.Count(); i++)
                {
                    Com.Parameters.AddWithValue("@" + colums[i], values[i]);
                }
            }
            Com.CommandTimeout = 0;
            Com.ExecuteNonQuery();
            Cn.InfoMessage += new SqlInfoMessageEventHandler(connection_InfoMessage);
            Cn.Close();

        }

        static void connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            // e contains info message etc

            if (e.Message.ToString() == "Sucess")
            {

            }
        }
 
    }
    
}