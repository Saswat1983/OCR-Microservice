using Microsoft.AspNetCore.Http;

using System.Web.Http;


namespace OCR.Api.Service.Controllers
{
    public class RecognizeController : ApiController
    {
        // GET: RecognizeController

        // POST: RecognizeController/Create


        // GET: RecognizeController/Edit/5


        // POST: RecognizeController/Edit/5



        // POST: RecognizeController/Delete/5
        [HttpPost]
        public IHttpActionResult Check(int id, IFormCollection collection)
        {
            return Ok();
        }
    }
}
