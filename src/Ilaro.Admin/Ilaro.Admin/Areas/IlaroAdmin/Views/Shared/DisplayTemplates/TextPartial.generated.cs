﻿using System.CodeDom.Compiler;
using System.Web.Mvc;
using System.Web.WebPages;
using Ilaro.Admin.Models;

#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36213
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    [GeneratedCode("RazorGenerator", "2.0.0.0")]
    [PageVirtualPath("~/Areas/IlaroAdmin/Views/Shared/DisplayTemplates/TextPartial.cshtml")]
    public partial class _Areas_IlaroAdmin_Views_Shared_DisplayTemplates_TextPartial_cshtml_ : WebViewPage<CellValue>
    {
        public _Areas_IlaroAdmin_Views_Shared_DisplayTemplates_TextPartial_cshtml_()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\IlaroAdmin\Views\Shared\DisplayTemplates\TextPartial.cshtml"
Write(Model.AsString);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
