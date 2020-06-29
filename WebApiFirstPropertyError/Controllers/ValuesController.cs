using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiFirstPropertyError.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpPost]
        public string Get(ParameterFill param)
        {
            return "";
        }
    
    }


    public class ParameterFill
    {
        private string _accounttoken;

        public string AccountToken { get { return _accounttoken; } set { AccountTokenToIdAssign(value); } }

        public string AccountTokenToIdAssign(string accountToken)
        {
            accountToken = "5";

            throw new Exception("Hatalı işlem");


            return accountToken;
        }

    }


}
