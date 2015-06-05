﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
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
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 2 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
    using NewLife.CMX;
    
    #line default
    #line hidden
    using NewLife.Cube;
    
    #line 1 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
    using NewLife.Model;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Index/_Left.cshtml")]
    public partial class _Areas_Admin_Views_Index__Left_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_Index__Left_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
  
    var user = ManageProvider.Provider.Current as IUser;

    var fact = ObjectContainer.Current.Resolve<IMenuFactory>();

    var Menus = fact.Root.Childs;
    if (user != null && user.Role != null)
    {
        Menus = fact.GetMySubMenus(fact.Root.ID);
    }

    // 如果顶级只有一层，并且至少有三级目录，则提升一级
    if (Menus.Count == 1 && Menus[0].Childs.All(m => m.Childs.Count > 0)) { Menus = Menus[0].Childs; }

    String[] icos = new String[] { "fa-tachometer", "fa-desktop", "fa-list", "fa-pencil-square-o", "fa-list-alt", "fa-calendar", "fa-picture-o", "fa-tag", "fa-file-o" };
    Int32 _idx = 0;

            
            #line default
            #line hidden
WriteLiteral("\r\n<ul");

WriteLiteral(" class=\"nav nav-list\"");

WriteLiteral(">\r\n");

            
            #line 21 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
    
            
            #line default
            #line hidden
            
            #line 21 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
     foreach (IMenu menu in Menus.Where(m => m.Visible))
    {
        var childs = fact.GetMySubMenus(menu.ID).Where(m => m.Visible);
        if (childs.IsEmpty()) { continue; }
        if (_idx >= icos.Length) { _idx = 0; }

            
            #line default
            #line hidden
WriteLiteral("        <li>\r\n            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"dropdown-toggle\"");

WriteLiteral(">\r\n                <i");

WriteAttribute("class", Tuple.Create(" class=\"", 995), Tuple.Create("\"", 1029)
, Tuple.Create(Tuple.Create("", 1003), Tuple.Create("menu-icon", 1003), true)
, Tuple.Create(Tuple.Create(" ", 1012), Tuple.Create("fa", 1013), true)
            
            #line 28 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
, Tuple.Create(Tuple.Create(" ", 1015), Tuple.Create<System.Object, System.Int32>(icos[_idx++]
            
            #line default
            #line hidden
, 1016), false)
);

WriteLiteral("></i>\r\n                <span");

WriteLiteral(" class=\"menu-text\"");

WriteLiteral(">");

            
            #line 29 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                                   Write(menu.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\r\n                <b");

WriteLiteral(" class=\"arrow fa fa-angle-down\"");

WriteLiteral("></b>\r\n            </a>\r\n\r\n            <b");

WriteLiteral(" class=\"arrow\"");

WriteLiteral("></b>\r\n\r\n            <ul");

WriteLiteral(" class=\"submenu\"");

WriteLiteral(">\r\n");

            
            #line 37 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                
            
            #line default
            #line hidden
            
            #line 37 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                 foreach (IMenu menu2 in childs)
                {
                    var childs2 = fact.GetMySubMenus(menu2.ID).Where(m => m.Visible);
                    if (childs2.IsEmpty()) { continue; }

            
            #line default
            #line hidden
WriteLiteral("                    <li>\r\n");

            
            #line 42 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 42 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                         if (menu2.Childs.Count > 0)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"dropdown-toggle\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"menu-icon fa fa-caret-right\"");

WriteLiteral("></i>\r\n");

WriteLiteral("                                ");

            
            #line 46 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                           Write(menu2.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </a>\r\n");

            
            #line 48 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                        }
                        else
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1916), Tuple.Create("\"", 1946)
            
            #line 51 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
, Tuple.Create(Tuple.Create("", 1923), Tuple.Create<System.Object, System.Int32>(Url.Content(menu2.Url)
            
            #line default
            #line hidden
, 1923), false)
);

WriteLiteral(" target=\"main\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"menu-icon fa fa-caret-right\"");

WriteLiteral("></i>\r\n");

WriteLiteral("                                ");

            
            #line 53 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                           Write(menu2.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </a>\r\n");

            
            #line 55 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <b");

WriteLiteral(" class=\"arrow\"");

WriteLiteral("></b>\r\n                        <ul");

WriteLiteral(" class=\"submenu\"");

WriteLiteral(">\r\n");

            
            #line 59 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 59 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                             foreach (IMenu menu3 in childs2)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li>\r\n                                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2419), Tuple.Create("\"", 2449)
            
            #line 62 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
, Tuple.Create(Tuple.Create("", 2426), Tuple.Create<System.Object, System.Int32>(Url.Content(menu3.Url)
            
            #line default
            #line hidden
, 2426), false)
);

WriteLiteral(" target=\"main\"");

WriteLiteral(">\r\n                                        <i");

WriteLiteral(" class=\"menu-icon fa fa-caret-right\"");

WriteLiteral("></i>\r\n");

WriteLiteral("                                        ");

            
            #line 64 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                                   Write(menu3.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </a>\r\n\r\n                                   " +
" <b");

WriteLiteral(" class=\"arrow\"");

WriteLiteral("></b>\r\n                                </li>\r\n");

            
            #line 69 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </ul>\r\n                    </li>\r\n");

            
            #line 72 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n        </li>\r\n");

            
            #line 75 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral("\r\n");

            
            #line 77 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
    
            
            #line default
            #line hidden
            
            #line 77 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
     foreach (var chn in Channel.FindAllWithCache().ToList().Where(e => e.Enable))
    {
        var provider = chn.Model.Provider;
        var cats = (provider.CategoryFactory.Default as IEntityTree).Childs;

            
            #line default
            #line hidden
WriteLiteral("        <li>\r\n            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"dropdown-toggle\"");

WriteLiteral(">\r\n                <i");

WriteAttribute("class", Tuple.Create(" class=\"", 3218), Tuple.Create("\"", 3252)
, Tuple.Create(Tuple.Create("", 3226), Tuple.Create("menu-icon", 3226), true)
, Tuple.Create(Tuple.Create(" ", 3235), Tuple.Create("fa", 3236), true)
            
            #line 83 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
, Tuple.Create(Tuple.Create(" ", 3238), Tuple.Create<System.Object, System.Int32>(icos[_idx++]
            
            #line default
            #line hidden
, 3239), false)
);

WriteLiteral("></i>\r\n                <span");

WriteLiteral(" class=\"menu-text\"");

WriteLiteral(">");

            
            #line 84 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                                   Write(chn.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\r\n                <b");

WriteLiteral(" class=\"arrow fa fa-angle-down\"");

WriteLiteral("></b>\r\n            </a>\r\n\r\n            <b");

WriteLiteral(" class=\"arrow\"");

WriteLiteral("></b>\r\n\r\n            <ul");

WriteLiteral(" class=\"submenu\"");

WriteLiteral(">\r\n                <li>\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3518), Tuple.Create("\"", 3564)
, Tuple.Create(Tuple.Create("", 3525), Tuple.Create<System.Object, System.Int32>(Href("~/CMS/")
, 3525), false)
            
            #line 93 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
, Tuple.Create(Tuple.Create("", 3531), Tuple.Create<System.Object, System.Int32>(chn.Model.Name
            
            #line default
            #line hidden
, 3531), false)
, Tuple.Create(Tuple.Create("", 3548), Tuple.Create("Category/", 3548), true)
            
            #line 93 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
, Tuple.Create(Tuple.Create("", 3557), Tuple.Create<System.Object, System.Int32>(chn.ID
            
            #line default
            #line hidden
, 3557), false)
);

WriteLiteral(" target=\"main\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"menu-icon fa fa-caret-right\"");

WriteLiteral("></i>\r\n                        分类管理\r\n                    </a>\r\n                </" +
"li>\r\n");

            
            #line 98 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                
            
            #line default
            #line hidden
            
            #line 98 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                 foreach (IEntityCategory cat in cats)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li>\r\n");

            
            #line 101 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 101 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                         if (cat.Childs.Count > 0)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"dropdown-toggle\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"menu-icon fa fa-caret-right\"");

WriteLiteral("></i>\r\n");

WriteLiteral("                                ");

            
            #line 105 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                           Write(cat.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </a>\r\n");

            
            #line 107 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                        }
                        else
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4244), Tuple.Create("\"", 4292)
, Tuple.Create(Tuple.Create("", 4251), Tuple.Create<System.Object, System.Int32>(Href("~/CMS/")
, 4251), false)
            
            #line 110 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
, Tuple.Create(Tuple.Create("", 4257), Tuple.Create<System.Object, System.Int32>(chn.Model.Name
            
            #line default
            #line hidden
, 4257), false)
, Tuple.Create(Tuple.Create("", 4274), Tuple.Create("/", 4274), true)
            
            #line 110 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
, Tuple.Create(Tuple.Create("", 4275), Tuple.Create<System.Object, System.Int32>(chn.ID
            
            #line default
            #line hidden
, 4275), false)
, Tuple.Create(Tuple.Create("", 4284), Tuple.Create("_", 4284), true)
            
            #line 110 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
, Tuple.Create(Tuple.Create("", 4285), Tuple.Create<System.Object, System.Int32>(cat.ID
            
            #line default
            #line hidden
, 4285), false)
);

WriteLiteral(" target=\"main\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"menu-icon fa fa-caret-right\"");

WriteLiteral("></i>\r\n");

WriteLiteral("                                ");

            
            #line 112 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                           Write(cat.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </a>\r\n");

            
            #line 114 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        <b");

WriteLiteral(" class=\"arrow\"");

WriteLiteral("></b>\r\n                        <ul");

WriteLiteral(" class=\"submenu\"");

WriteLiteral(">\r\n");

            
            #line 117 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 117 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                             foreach (IEntityCategory cat2 in cat.Childs)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li>\r\n");

            
            #line 120 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 120 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                                     if (cat2.Childs.Count > 0)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"dropdown-toggle\"");

WriteLiteral(">\r\n                                            <i");

WriteLiteral(" class=\"menu-icon fa fa-caret-right\"");

WriteLiteral("></i>\r\n");

WriteLiteral("                                            ");

            
            #line 124 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                                       Write(cat2.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </a>\r\n");

            
            #line 126 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                                    }
                                    else
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5263), Tuple.Create("\"", 5312)
, Tuple.Create(Tuple.Create("", 5270), Tuple.Create<System.Object, System.Int32>(Href("~/CMS/")
, 5270), false)
            
            #line 129 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
, Tuple.Create(Tuple.Create("", 5276), Tuple.Create<System.Object, System.Int32>(chn.Model.Name
            
            #line default
            #line hidden
, 5276), false)
, Tuple.Create(Tuple.Create("", 5293), Tuple.Create("/", 5293), true)
            
            #line 129 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
, Tuple.Create(Tuple.Create("", 5294), Tuple.Create<System.Object, System.Int32>(chn.ID
            
            #line default
            #line hidden
, 5294), false)
, Tuple.Create(Tuple.Create("", 5303), Tuple.Create("_", 5303), true)
            
            #line 129 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
   , Tuple.Create(Tuple.Create("", 5304), Tuple.Create<System.Object, System.Int32>(cat2.ID
            
            #line default
            #line hidden
, 5304), false)
);

WriteLiteral(" target=\"main\"");

WriteLiteral(">\r\n                                            <i");

WriteLiteral(" class=\"menu-icon fa fa-caret-right\"");

WriteLiteral("></i>\r\n");

WriteLiteral("                                            ");

            
            #line 131 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                                       Write(cat2.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </a>\r\n");

            
            #line 133 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    <b");

WriteLiteral(" class=\"arrow\"");

WriteLiteral("></b>\r\n                                    <ul");

WriteLiteral(" class=\"submenu\"");

WriteLiteral(">\r\n");

            
            #line 136 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 136 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                                         foreach (IEntityCategory cat3 in cat2.Childs)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <li>\r\n                               " +
"                 <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5908), Tuple.Create("\"", 5957)
, Tuple.Create(Tuple.Create("", 5915), Tuple.Create<System.Object, System.Int32>(Href("~/CMS/")
, 5915), false)
            
            #line 139 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
, Tuple.Create(Tuple.Create("", 5921), Tuple.Create<System.Object, System.Int32>(chn.Model.Name
            
            #line default
            #line hidden
, 5921), false)
, Tuple.Create(Tuple.Create("", 5938), Tuple.Create("/", 5938), true)
            
            #line 139 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
  , Tuple.Create(Tuple.Create("", 5939), Tuple.Create<System.Object, System.Int32>(chn.ID
            
            #line default
            #line hidden
, 5939), false)
, Tuple.Create(Tuple.Create("", 5948), Tuple.Create("_", 5948), true)
            
            #line 139 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
           , Tuple.Create(Tuple.Create("", 5949), Tuple.Create<System.Object, System.Int32>(cat3.ID
            
            #line default
            #line hidden
, 5949), false)
);

WriteLiteral(" target=\"main\"");

WriteLiteral(">\r\n                                                    <i");

WriteLiteral(" class=\"menu-icon fa fa-caret-right\"");

WriteLiteral("></i>\r\n");

WriteLiteral("                                                    ");

            
            #line 141 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                                               Write(cat3.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                </a>\r\n                         " +
"                       <b");

WriteLiteral(" class=\"arrow\"");

WriteLiteral("></b>\r\n                                            </li>\r\n");

            
            #line 145 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </ul>\r\n                                </li>\r" +
"\n");

            
            #line 148 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </ul>\r\n                    </li>\r\n");

            
            #line 151 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n        </li>\r\n");

            
            #line 154 "..\..\Areas\Admin\Views\Index\_Left.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>\r\n<!-- /.nav-list -->\r\n");

        }
    }
}
#pragma warning restore 1591
