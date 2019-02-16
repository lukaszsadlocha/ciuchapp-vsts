using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace CiuchApp.Dashboard.Extensions.TagHelpers
{
    public class CiuchappTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "p";
            output.Attributes.Add("id", context.UniqueId);

            output.PreContent.SetContent("Hello ");
            output.PostContent.SetContent(string.Format(", time is now: {0}",
                    DateTime.Now.ToString("HH:mm")));
        }

    }
}
