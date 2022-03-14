using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Runtime.InteropServices;

namespace CreatingCustomTagHelpers.CustomTagHelpers;

//This makes our class target system-info elements (it's not case sensitive)
[HtmlTargetElement("system-info")]
public class SystemInfoTagHelper : TagHelper {
    private readonly HtmlEncoder _encoder;

    //Inject a HtmlEncoder with DI
    public SystemInfoTagHelper(HtmlEncoder encoder) {
       _encoder = encoder; 
    }

    //This will target the attribute add-os
    //Meaning that the value of IncludeOSINfo would be equal to the add-os attribute value
    [HtmlAttributeName("add-os")]
    public bool IncludeOSInfo {get; set;} = true;

    [HtmlAttributeName("add-machine")]
    public bool IncludeMachineInfo {get; set; } = true;

    //The context object provides us info about the tag helper and the output would be the html output when rendered by razor pages
    public override void Process(TagHelperContext context, TagHelperOutput output) {
        output.TagName = "div"; //Would set the output tag to div
        output.TagMode = TagMode.StartTagAndEndTag; //Would create the following: <div></div> (start tag and end tag)
        
        var sb = new StringBuilder();
        
        if(IncludeMachineInfo) {
            sb.Append("<strong>Machine Inf: </strong>");
            sb.Append(_encoder.Encode(Environment.MachineName));
        }

        if(IncludeOSInfo) {
            sb.Append("<strong>OS inf:</strong>");
            sb.Append(_encoder.Encode(RuntimeInformation.OSDescription));
        }

        output.Content.SetHtmlContent(sb.ToString());
    }
}
