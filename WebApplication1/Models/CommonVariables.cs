namespace WebApplication1.Models
{
    public  static class CommonVariables
    {
        public static string connString = "Data Source=DRAPARTH-L-5507\\SQLEXPRESS;Initial Catalog=Employeedb;Persist Security Info=True;User ID=sa;Password=Welcome2evoke@1234";
        public static string selectquery= "select * from Employee";
        public static string insertquery= "INSERT INTO Employee(Id, Name) VALUES(@Id, @Name)";
   
    }
}
