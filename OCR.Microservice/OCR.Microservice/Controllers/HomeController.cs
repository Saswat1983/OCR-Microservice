using OCR.Microservice.Business;
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
        private ICharacterRecogniser _characterRecogniser;

        public HomeController(ICharacterRecogniser characterRecogniser)
        {
            _characterRecogniser = characterRecogniser;
        }

        [HttpPost]
        [AuthorizeUser]
        public IHttpActionResult GetContent(FileRequest request)
        {
            // Any logging for input request details goes here
            var result = _characterRecogniser.ReturnContent(request.Content, request.FileType);
            return Ok(result);
        }
    }
}
