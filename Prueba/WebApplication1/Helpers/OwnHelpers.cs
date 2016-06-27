using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Helpers
{
    public static class OwnHelpers
    {

        public static MvcHtmlString Usuario(this HtmlHelper helper)
        {
            var result="<input type=text placeholder=Usuario>";
            return new MvcHtmlString(result);
        }
        public static MvcHtmlString Password(this HtmlHelper helper)
        {
            var result = "<input type=password placeholder=Password>";
            return new MvcHtmlString(result);
        }

        public static MvcHtmlString Apellido(this HtmlHelper helper)
        {
            var result = "<input type=text placeholder=Apellido>";
            return new MvcHtmlString(result);
        }
        public static MvcHtmlString Ubicacion(this HtmlHelper helper)
        {
            var result = "<input type=text placeholder=Ubicacion>";
            return new MvcHtmlString(result);
        }
    }
}