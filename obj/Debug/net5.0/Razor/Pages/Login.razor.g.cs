#pragma checksum "/Users/chen/Desktop/AssignmentFinally/Pages/Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "996f19f17513aa7cc4d0b97127240f35cb3379c0"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginComponent
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
#nullable restore
#line 3 "/Users/chen/Desktop/AssignmentFinally/Pages/Login.razor"
using LoginExample.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddMarkupContent(3, "<h3 style=\"margin-top:250px; margin-left: 500px\">Login</h3>\n            ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-group");
                __builder2.AddAttribute(6, "style", "margin-left: 500px");
                __builder2.AddMarkupContent(7, "<label>Username:</label>\n                ");
                __builder2.OpenElement(8, "input");
                __builder2.AddAttribute(9, "style", "border-radius: 10px");
                __builder2.AddAttribute(10, "type", "text");
                __builder2.AddAttribute(11, "placeholder", "user name");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "/Users/chen/Desktop/AssignmentFinally/Pages/Login.razor"
                                                                                                    username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddAttribute(17, "style", "margin-left: 500px");
                __builder2.AddMarkupContent(18, "<label>Password:</label>\n                ");
                __builder2.OpenElement(19, "input");
                __builder2.AddAttribute(20, "style", "border-radius: 10px");
                __builder2.AddAttribute(21, "type", "password");
                __builder2.AddAttribute(22, "placeholder", "password");
                __builder2.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "/Users/chen/Desktop/AssignmentFinally/Pages/Login.razor"
                                                                                                       password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\n            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "style", "color:red");
                __builder2.AddContent(28, 
#nullable restore
#line 20 "/Users/chen/Desktop/AssignmentFinally/Pages/Login.razor"
                                    errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n\n            ");
                __builder2.OpenElement(30, "a");
                __builder2.AddAttribute(31, "href", "");
                __builder2.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "/Users/chen/Desktop/AssignmentFinally/Pages/Login.razor"
                                 PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "style", "margin-left: 500px");
                __builder2.AddMarkupContent(34, "\n                Login\n            ");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(35, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(36, "a");
                __builder2.AddAttribute(37, "href", "");
                __builder2.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "/Users/chen/Desktop/AssignmentFinally/Pages/Login.razor"
                             PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(39, "\n            Log out\n        ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "/Users/chen/Desktop/AssignmentFinally/Pages/Login.razor"
       
    private string username;
    private string password;
    private string errorMessage;

    public async Task PerformLogin() {
        errorMessage = "";
        try {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
            username = "";
            password = "";
        } catch (Exception e) {
            errorMessage = e.Message;
        }
    }

    public async Task PerformLogout() {
        errorMessage = "";
        username = "";
        password = "";
        try {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        } catch (Exception e) { }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591