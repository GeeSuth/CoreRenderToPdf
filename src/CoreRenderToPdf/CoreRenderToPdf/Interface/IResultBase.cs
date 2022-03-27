using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreRenderToPdf.Interface
{
    public abstract class IResultBase : IActionResult
    {
        public Task ExecuteResultAsync(ActionContext context)
        {
            throw new NotImplementedException();
        }

        protected abstract byte[] GetPdfHtml(string htmlCode);

    }
}
