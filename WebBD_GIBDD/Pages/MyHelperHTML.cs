using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HtmlHelpersApp.App_Code
{
    public static class ListHelper
    {
        public static HtmlString CreateList(this IHtmlHelper html)
        {
            string result = $"привет";
            return new HtmlString(result);
        }
    }
}