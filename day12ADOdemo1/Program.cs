using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;

namespace day12ADOdemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region simple open database
            //String connStr = "server=127.0.0.1;uid=sa;pwd=Cst001.com; database=Market";
            //SqlConnection conn = new SqlConnection(connStr);
            //conn.Open(); // open datbase

            //Console.WriteLine("data base is opened successfully");
            //Thread.Sleep(5000);


            //conn.Close();
            //Console.WriteLine("Database is closed properly");
            //Console.ReadLine(); 
            #endregion

            #region Second example
            //string connStr = "server=192.168.70.105;uid=sa;pwd=Cst001.com;database=Market";

            //SqlConnection conn = new SqlConnection(connStr);

            //try
            //{
            //    SqlCommand cmd = new SqlCommand();

            //    cmd.Connection = conn;

            //    conn.Open();
            //    cmd.CommandText = "insert into Customers( CustomerName, CustomerContact, CustomerCity, CustomerBirthday)values ('Cst College999','Bob','Missisauga','01-12-2020')";

            //    int num = cmd.ExecuteNonQuery();

            //    if (num != 0)
            //    {
            //        Console.WriteLine("data is saved successfully");

            //    }


            //}
            //finally
            //{
            //    conn.Close();
            //} 
            #endregion

            // using --close resoure automatically
            // regular coding

            #region MyRegion
            string connStr = "server=localhost;uid=sa;pwd=Cst001.com;database=Market";

            using (SqlConnection conn = new SqlConnection(connStr))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.CommandText = "insert into Customers( CustomerName, CustomerContact, CustomerCity, CustomerBirthday)values ('Cst 001 College','Jerry','Brampton','04 - 12 - 2000')";
                    int num = cmd.ExecuteNonQuery();
                    if (num != 0)
                    {
                        Console.WriteLine("data is saved properly");
                    }

                } 
                #endregion




            }
             

            Console.ReadLine();


        }
    }
}
