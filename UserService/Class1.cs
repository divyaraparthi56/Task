using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataService;

namespace UserService
{
    public class UserMessageService : IUserMessageService
    {
        private readonly IDatabaseConnector _dataservice;
        public UserMessageService(IDatabaseConnector dataservice)
        {
            _dataservice = dataservice;
        }
        public string GetMessageFromDb()
        {
            string msg = _dataservice.GetMsgFromMsgTbl();
            return msg;
        }
    }
}
