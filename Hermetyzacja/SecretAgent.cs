using System;
using System.Collections.Generic;
using System.Text;

namespace Hermetyzacja
{
    class SecretAgent
    {
        private string alias = "Dash Martin";
        private string realName = "Herb Jones";
        private string Password = "12345";

        public string AgentGreeting(string password)
        {
            if(password == Password)
            {
                return realName;
            }
            else
            {
                return alias;
            }
        }

    }
}
