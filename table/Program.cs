
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Data.SqlClient;

namespace AdoNetConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   
                string ConString = "Data Source=DRAPARTH-L-5507\\SQLEXPRESS;Initial Catalog=table;Persist Security Info=True;User ID=sa;Password=Welcome2evoke@1234";
                using SqlConnection connection = new SqlConnection(ConString);
                // Creating SqlCommand objcet   
                SqlCommand cm = new SqlCommand("select * from student", connection);

                // Opening Connection  
                connection.Open();

                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["Name"] + ",  " + sdr["Email"] + ",  " + sdr["Mobile"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            Console.ReadKey();
        }
    }
}