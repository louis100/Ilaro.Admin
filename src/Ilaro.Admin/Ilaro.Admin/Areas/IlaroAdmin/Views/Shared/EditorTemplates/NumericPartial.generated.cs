﻿using System;
using System.CodeDom.Compiler;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.WebPages;
using Ilaro.Admin.Core;
using Ilaro.Admin.Extensions;

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
    [PageVirtualPath("~/Areas/IlaroAdmin/Views/Shared/EditorTemplates/NumericPartial.cshtml")]
    public partial class _Areas_IlaroAdmin_Views_Shared_EditorTemplates_NumericPartial_cshtml_ : WebViewPage<Property>
    {
        public _Areas_IlaroAdmin_Views_Shared_EditorTemplates_NumericPartial_cshtml_()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\NumericPartial.cshtml"
  Html.ClearPrefix();
            
            #line default
            #line hidden
WriteLiteral("\r\n<label");

WriteAttribute("for", Tuple.Create(" for=\"", 49), Tuple.Create("\"", 75)
            
            #line 4 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\NumericPartial.cshtml"
, Tuple.Create(Tuple.Create("", 55), Tuple.Create<Object, Int32>(Html.Id(Model.Name)
            
            #line default
            #line hidden
, 55), false)
);

WriteLiteral(" class=\"control-label col-md-2\"");

WriteLiteral(">");

            
            #line 4 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\NumericPartial.cshtml"
                                                            Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 4 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\NumericPartial.cshtml"
                                                                               Write(Html.Condition(Model.IsRequired, () => "<span class=\"text-danger\">*</span>"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n<div");

WriteLiteral(" class=\"controls col-md-3\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"input-group\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 7 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\NumericPartial.cshtml"
   Write(Html.TextBox(Model.Name, Model.Value.AsString, Model, Model.ControlsAttributes.Merge(new { @class = "form-control numeric", autocomplete = "off" })));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

WriteLiteral("    ");

            
            #line 9 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\NumericPartial.cshtml"
Write(Html.Condition(!string.IsNullOrEmpty(Model.Description), () => "<span class=\"help-block\">" + Model.Description + "</span>"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

            
            #line 11 "..\..\Areas\IlaroAdmin\Views\Shared\EditorTemplates\NumericPartial.cshtml"
Write(Html.ValidationMessage(Model.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
