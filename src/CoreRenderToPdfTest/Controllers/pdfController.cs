using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreRenderToPdfTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class pdfController : ControllerBase
    {
        [HttpGet]
        public byte[] Get()
        {
            CoreRenderToPdf.PdfFromHtml pdf= new CoreRenderToPdf.PdfFromHtml();

            var by= pdf.Get("<h1>Test</h1>");

            return by; 
        }
    }
}
