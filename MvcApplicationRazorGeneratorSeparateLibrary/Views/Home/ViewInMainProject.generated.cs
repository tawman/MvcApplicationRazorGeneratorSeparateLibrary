﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplicationRazorGeneratorSeparateLibrary.Views.Home
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.4.1.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/ViewInMainProject.cshtml")]
    public class ViewInMainProject : System.Web.Mvc.WebViewPage<MvcApplicationRazorGeneratorSeparateLibrary.Models.RegisterModel>
    {
        public ViewInMainProject()
        {
        }
        public override void Execute()
        {

WriteLiteral("<h2>This view comes from the main project</h2>\n\n<script type=\"text/javascript\">\r\n" +
"        jQuery[\'table01GridData\'] = ");


            
            #line 5 "..\..\Views\Home\ViewInMainProject.cshtml"
                                Write(new HtmlString(Json.Encode(Model)));

            
            #line default
            #line hidden
WriteLiteral(";\r\n</script>");


        }
    }
}
#pragma warning restore 1591
