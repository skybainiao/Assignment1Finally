#pragma checksum "/Users/chen/Desktop/AssignmentFinally/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ede5a031d72b4264f7719c26c7111be47a04b2b1"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginExample.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/chen/Desktop/AssignmentFinally/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/chen/Desktop/AssignmentFinally/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/chen/Desktop/AssignmentFinally/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/chen/Desktop/AssignmentFinally/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/chen/Desktop/AssignmentFinally/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/chen/Desktop/AssignmentFinally/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/chen/Desktop/AssignmentFinally/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/chen/Desktop/AssignmentFinally/_Imports.razor"
using LoginExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/chen/Desktop/AssignmentFinally/_Imports.razor"
using LoginExample.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "top-row pl-4 navbar navbar-dark");
                __builder2.AddAttribute(4, "style", "background-color: black");
                __builder2.AddMarkupContent(5, "<a class=\"navbar-brand\" href>Assignment1</a>\n        ");
                __builder2.OpenElement(6, "button");
                __builder2.AddAttribute(7, "class", "navbar-toggler");
                __builder2.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "/Users/chen/Desktop/AssignmentFinally/Shared/NavMenu.razor"
                                                 ToggleNavMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(9, "<span class=\"navbar-toggler-icon\"></span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\n    \n    ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", 
#nullable restore
#line 9 "/Users/chen/Desktop/AssignmentFinally/Shared/NavMenu.razor"
                 NavMenuCssClass

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "/Users/chen/Desktop/AssignmentFinally/Shared/NavMenu.razor"
                                            ToggleNavMenu

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "style", "background-color: black");
                __builder2.OpenElement(15, "ul");
                __builder2.AddAttribute(16, "class", "nav flex-column");
                __builder2.OpenElement(17, "li");
                __builder2.AddAttribute(18, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(19);
                __builder2.AddAttribute(20, "class", "nav-link");
                __builder2.AddAttribute(21, "href", "");
                __builder2.AddAttribute(22, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 12 "/Users/chen/Desktop/AssignmentFinally/Shared/NavMenu.razor"
                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(24, "<span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\n            ");
                __builder2.OpenElement(26, "li");
                __builder2.AddAttribute(27, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(28);
                __builder2.AddAttribute(29, "class", "nav-link");
                __builder2.AddAttribute(30, "href", "personList");
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(32, "<span class=\"oi oi-list\" aria-hidden=\"true\"></span> PersonList\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\n            ");
                __builder2.OpenElement(34, "li");
                __builder2.AddAttribute(35, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(36);
                __builder2.AddAttribute(37, "class", "nav-link");
                __builder2.AddAttribute(38, "href", "search");
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(40, "<span class=\"oi oi-magnifying-glass\" aria-hidden=\"true\"></span> Search\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\n            ");
                __builder2.OpenElement(42, "li");
                __builder2.AddAttribute(43, "class", "nav-item px-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(44);
                __builder2.AddAttribute(45, "class", "nav-link");
                __builder2.AddAttribute(46, "href", "add");
                __builder2.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(48, "<span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Add\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\n            <li style=\"background-color: black; height: 500px\"></li>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "/Users/chen/Desktop/AssignmentFinally/Shared/NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu() {
        collapseNavMenu = !collapseNavMenu;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591