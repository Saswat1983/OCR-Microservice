using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OCR.Microservice
{
    public class AuthorizeUser : AuthorizeAttribute
    {
        public bool OnAuthorization()
        {
            //Your authorization logic goes here
            return true;
        }
    }
}