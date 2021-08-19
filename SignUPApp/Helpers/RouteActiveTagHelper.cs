using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUPApp.Helpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement(Attributes ="asp-active-route")]
    // tag name of css class in the html page 
    public class RouteActiveTagHelper : TagHelper
    {   [ViewContext]
        public ViewContext ViewContext { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {  
            // fetch the current controller and action
            var controller = ViewContext.RouteData.Values["Controller"].ToString();
            var action = ViewContext.RouteData.Values["Action"].ToString();

            // fetch the tag to which the custom css needs to be applied
            var tagController = context.AllAttributes.FirstOrDefault(a => a.Name == "asp-controller").Value.ToString();
            var tagAction = context.AllAttributes.FirstOrDefault(a => a.Name == "asp-action").Value.ToString();

            if( controller == tagController && action  ==tagAction )
            {
                var cssClass = context.AllAttributes.FirstOrDefault(a => a.Name == "class").Value.ToString();

                var newCss = context.AllAttributes.FirstOrDefault(a => a.Name == "asp-active-route").Value.ToString();

                output.Attributes.SetAttribute("class", cssClass + " " + newCss);
            }
        }
    }
}
