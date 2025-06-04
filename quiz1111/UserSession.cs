using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1111
{
    internal class UserSession
    {
        private static UserSession instance_ = new UserSession();
        private String loginID = "";
        private string idString = "";
        private bool admin = false;

        public static UserSession GetInstance()
        {
            return instance_;
        }

        private UserSession()
        {
        }

        public string getId()
        {
            return loginID;
        }

        public void setId(String id)
        {
            loginID = id;
        }

        public string getIdString()
        {
            return idString;
        }

        public void setIdString(String id)
        {
            idString = id;
        }

        public void setAdmin()
        {
            admin = true;
        }

        public void reset()
        {
            loginID = "";
            admin = false;
        }

        public bool adminCheck()
        {
            return admin;
        }
    }
}
