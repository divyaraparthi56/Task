using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService
{
    public class DatabaseConnector : IDatabaseConnector
    {
        List<UserObj> userList = new List<UserObj>();

        public DababaseConnector()
        {
            userList.Add(new UserObj() { Id = 1, Name = "A" });
            userList.Add(new UserObj() { Id = 2, Name = "B" });
            userList.Add(new UserObj() { Id = 3, Name = "C" });
            userList.Add(new UserObj() { Id = 4, Name = "D" });
            userList.Add(new UserObj() { Id = 5, Name = "E" });
            userList.Add(new UserObj() { Id = 6, Name = "F" });
        }
        public string GetMsgFromMsgTbl()
        {
            return "I am from main data";
        }

    }
}
