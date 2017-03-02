using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreateCustomHelper.Helpers
{
    public static class CustomHelper
    {
        public static MvcHtmlString TextBox(string id, string name = "")
        {
            if (string.IsNullOrEmpty(name))
                name = id;
            string inputHtml = string.Format("<input type='text' id='{0}' name='{1}' />", id, name);
            MvcHtmlString textBox = MvcHtmlString.Create(inputHtml);
            return textBox;
        }

        public static MvcHtmlString TextBox2(this HtmlHelper helper, string id, string name = "")
        {
            if (string.IsNullOrEmpty(name))
                name = id;
            string inputHtml = string.Format("<input type='text' id='{0}' name='{1}' />", id, name);
            MvcHtmlString textBox = MvcHtmlString.Create(inputHtml);
            return textBox;
        }
    }
}