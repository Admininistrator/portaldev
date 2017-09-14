using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;

namespace PLEXEDC.WEB.BAL.AuthWeb
{
    public class AuthHeader : SoapHeader
    {
        public string Username;
        public string Password;
    }
}
