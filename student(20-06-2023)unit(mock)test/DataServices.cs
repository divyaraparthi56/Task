namespace student_20_06_2023_unit_mock_test
{
    public class DataServices :IDataService
    {
        //public DataServices() { }
       
        public List<Student> GetStudentData()
        {
            List<Student> data = new List<Student>();
            data.Add(new Student() { Id = 1, Name = "div" });
            data.Add(new Student() { Id = 2, Name = "divya" });
            data.Add(new Student() { Id = 3, Name = "alessa" });
            return data;
        }

        

       

        //public List<Student> GetStudents()
        //{
        //    throw new NotImplementedException();
        //}

        //object IDataServices.GetStudentData()
        //{
        //    throw new NotImplementedException();
        //}
    }
}