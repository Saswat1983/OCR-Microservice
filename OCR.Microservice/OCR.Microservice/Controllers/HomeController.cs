using OCR.Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OCR.Microservice.Controllers
{
    public class HomeController : ApiController
    {
        [HttpPost]
        [AuthorizeUser]
        public IHttpActionResult GetContent(FileRequest request)
        {
            var result = string.Empty;
            return Ok(result);
        }
    }
}
