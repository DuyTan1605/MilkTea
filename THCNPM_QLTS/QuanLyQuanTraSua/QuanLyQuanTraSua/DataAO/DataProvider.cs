using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DAO
{
   public class DataProvider
    {
       private static DataProvider instance;
       private string connectionStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLiTraSua;Integrated Security=True";

        public static DataProvider Instance {
            get { if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }

        public DataSet ExcuteQuery1(string query,object[] parameter=null)
        {
          
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);//excute query

                if (parameter!=null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                SqlDataAdapter adapter = new SqlDataAdapter(command); //connect DB with user

                adapter.Fill(data);
                connection.Close();
            }
            //string temp = "Trà sữa truyền thống";
            //foreach (DataRow i in data.Rows)
            //{
            //    foreach (DataColumn j in data.Columns)
            //    {
            //        Console.WriteLine(i[j].ToString());
            //    }
            //}
            Console.WriteLine(data.GetXml());
          
            return data;
        }


        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {

            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);//excute query

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                SqlDataAdapter adapter = new SqlDataAdapter(command); //connect DB with user

                adapter.Fill(data);
                connection.Close();
            }
            String[] temp= new String[1000];
            int dem = 0;
            foreach (DataRow i in data.Rows)
            {
                foreach (DataColumn j in data.Columns)
                {
                    //Console.WriteLine(i[j].ToString());
                    temp[dem] = String.Copy(i[j].ToString());
                    dem++;
                }
            }
            foreach (String i in temp)
            {
                Console.WriteLine(i);
            }
            return data;
        }

        public int ExcuteNonQuery(string query, object[] parameter = null)
        {

            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);//excute query

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                data = command.ExecuteNonQuery();
                connection.Close();
            }
            //string temp = "Trà sữa truyền thống";
            //foreach (DataRow i in data.Rows)
            //{
            //    foreach (DataColumn j in data.Columns)
            //    {
            //        Console.WriteLine(i[j].ToString());
            //    }
            //}


            return data;
        }

        public object ExcuteScalar(string query, object[] parameter = null)
        {

            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);//excute query

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                data = command.ExecuteScalar();
                connection.Close();
            }
            //string temp = "Trà sữa truyền thống";
            //foreach (DataRow i in data.Rows)
            //{
            //    foreach (DataColumn j in data.Columns)
            //    {
            //        Console.WriteLine(i[j].ToString());
            //    }
            //}


            return data;
        }
    }
}
