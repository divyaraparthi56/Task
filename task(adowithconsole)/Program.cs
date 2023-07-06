using System.Data.SqlClient;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=DRAPARTH-L-5507\\SQLEXPRESS;Initial Catalog=sales;User ID=sa;Password=Welcome2evoke@1234");
            con.Open();
            Console.WriteLine("connection established successfully");
            //Select Query
            //SqlCommand cmd = new SqlCommand("Select * from Employee where Id=@Id", con);
            //cmd.Parameters.Add(new SqlParameter("Id", 12));
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine(String.Format("{0} \t | {1} \t", reader[0], reader[1]));
            //}
            //Insert Query
            Console.WriteLine("Insert Command");
            SqlCommand insert = new SqlCommand("Insert into Employee(Id,Name) values (@Id,@Name)", con);
            insert.Parameters.Add(new SqlParameter("Id", 1));
            insert.Parameters.Add(new SqlParameter("Name", "john"));
            Console.WriteLine("Command executed" + insert.ExecuteNonQuery());
            insert.ExecuteNonQuery();
            //Update Query
            //SqlCommand update = new SqlCommand("Update categories set category_name = @updatename where category_id = @updateId",con);
            //update.Parameters.Add(new SqlParameter("updatename", "jam"));
            //update.Parameters.Add(new SqlParameter("updateId", 16));
            //Console.WriteLine("Update command executed" + update.ExecuteNonQuery());
            //Delete Query
            //SqlCommand delete = new SqlCommand("Delete from categories where category_id = @deleteId",con);
            //delete.Parameters.Add(new SqlParameter("@deleteId", 16));
            //Console.WriteLine("Delete command executed" + delete.ExecuteNonQuery());

        }
    }
}