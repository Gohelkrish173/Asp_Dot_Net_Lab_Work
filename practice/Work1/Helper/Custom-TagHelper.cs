using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Work1.Helper
{
    [HtmlTargetElement("MyEmail")]
    public class Custom_tagHelper : TagHelper
    {
        public string Email { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Content.SetContent($"{Email}");
            output.Attributes.SetAttribute("class", "text-danger");
            output.Attributes.SetAttribute("href", Email);
        }
    }
}
