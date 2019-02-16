using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using CiuchApp.Domain;

namespace CiuchApp.Dashboard.Extensions
{
    public static class CiuchAppHtml
    {
        // Example of @MyOwnHtmlHelper
        //public static HtmlString MyOwnHtmlHelper(this HtmlHelper helper, string message)
        //{
        //    return new HtmlString($"<span>{message}<span>");
        //}

        public static SelectList SelectList<T>(object viewBagObject) where T : DropDownValueBase
        {
            if(viewBagObject is IEnumerable<T>)
            {
                return new SelectList(viewBagObject as IEnumerable<T>, "Id", "Name");
            }

            return null;
        }
        public static IHtmlContent HelloWorldHTMLString(this IHtmlHelper htmlHelper)
            => new HtmlString("<strong>Hello World</strong>");


        public static IHtmlContent CiuchAppAction(this IHtmlHelper hh, string action)
        {
            return null;
        }

        public static IHtmlContent CiuchAppDropdown(this IHtmlHelper htmlHelper, Piece model, string forFieldLabel, string forFieldSelect, IEnumerable<SelectListItem> values)
        {
            var newViewData = new ViewDataDictionary(htmlHelper.ViewData) { { "values", values }, { "forFieldLabel", forFieldLabel }, { "forFieldSelect", forFieldSelect } };
            return htmlHelper.Partial("CiuchAppControls/_Dropdown", model, newViewData);
        }

    }
}
