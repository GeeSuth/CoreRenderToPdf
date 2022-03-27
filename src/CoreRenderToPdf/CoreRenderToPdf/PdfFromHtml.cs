using CoreRenderToPdf.Interface;
using CoreRenderToPdf.Services;
using CoreRenderToPdf.Wk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreRenderToPdf
{
    public class PdfFromHtml : IResultBase
    {
        protected override byte[] GetPdfHtml(string htmlCode)
        {
            return WkhtmlDriver.Convert(WkConfig.WkhtmltoxPath, "", htmlCode,"");
        }

        public byte[] Get(string html)
        {
            return this.GetPdfHtml(html);
        }
    }
}
