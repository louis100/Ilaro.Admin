﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ilaro.Admin.Views.IlaroAdmin.DisplayTemplates
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
    using Ilaro.Admin.Commons.Paging;
    using Ilaro.Admin.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IlaroAdmin/DisplayTemplates/DatePartial.cshtml")]
    public partial class _DatePartial : System.Web.Mvc.WebViewPage<Ilaro.Admin.ViewModels.CellValueViewModel>
    {
        public _DatePartial()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\IlaroAdmin\DisplayTemplates\DatePartial.cshtml"
Write(((DateTime)Model.RawValue).ToShortDateString());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
