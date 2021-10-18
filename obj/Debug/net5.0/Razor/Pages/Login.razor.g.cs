#pragma checksum "C:\Users\45527\RiderProjects\Assignment1Finally1\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "865b07f434f67a828d80fafdbd91a7896eab0307"
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
#line 1 "C:\Users\45527\RiderProjects\Assignment1Finally1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\45527\RiderProjects\Assignment1Finally1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\45527\RiderProjects\Assignment1Finally1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\45527\RiderProjects\Assignment1Finally1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\45527\RiderProjects\Assignment1Finally1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\45527\RiderProjects\Assignment1Finally1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\45527\RiderProjects\Assignment1Finally1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\45527\RiderProjects\Assignment1Finally1\_Imports.razor"
using LoginExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\45527\RiderProjects\Assignment1Finally1\_Imports.razor"
using LoginExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\45527\RiderProjects\Assignment1Finally1\Pages\Login.razor"
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
                __builder2.AddAttribute(3, "style", "left: 44%; right: 50%; margin-top: 300px; position: absolute");
                __builder2.AddMarkupContent(4, "<h3>Login</h3>\r\n            ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "form-group");
                __builder2.AddMarkupContent(7, "<label>Username:</label>\r\n                ");
                __builder2.OpenElement(8, "input");
                __builder2.AddAttribute(9, "style", "border-radius: 10px");
                __builder2.AddAttribute(10, "type", "text");
                __builder2.AddAttribute(11, "placeholder", "user name");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\45527\RiderProjects\Assignment1Finally1\Pages\Login.razor"
                                                                                                    username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "<label>Password:</label>\r\n                ");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "style", "border-radius: 10px");
                __builder2.AddAttribute(20, "type", "password");
                __builder2.AddAttribute(21, "placeholder", "password");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\45527\RiderProjects\Assignment1Finally1\Pages\Login.razor"
                                                                                                       password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "style", "color:red");
                __builder2.AddContent(27, 
#nullable restore
#line 20 "C:\Users\45527\RiderProjects\Assignment1Finally1\Pages\Login.razor"
                                    errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n            ");
                __builder2.OpenElement(29, "a");
                __builder2.AddAttribute(30, "href", "");
                __builder2.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\45527\RiderProjects\Assignment1Finally1\Pages\Login.razor"
                                 PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(32, "\r\n                Login\r\n            ");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(33, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(34, "a");
                __builder2.AddAttribute(35, "href", "");
                __builder2.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\45527\RiderProjects\Assignment1Finally1\Pages\Login.razor"
                             PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(37, "\r\n            Log out\r\n        ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\45527\RiderProjects\Assignment1Finally1\Pages\Login.razor"
       
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
