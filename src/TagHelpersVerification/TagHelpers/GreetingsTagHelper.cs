using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;

namespace TagHelpersVerification.TagHelpers
{
    [HtmlTargetElement("greeting")]
    public class GreetingTagHelper : TagHelper
    {
        public string text { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = null;
            output.Content.AppendEncoded("<b>");
            output.Content.Append(text);
            output.Content.AppendEncoded("</b>");
        }
    }
}
