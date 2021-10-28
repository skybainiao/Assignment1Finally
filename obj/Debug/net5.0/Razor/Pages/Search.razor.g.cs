#pragma checksum "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95ed9443cfb297edb79e189a69c5025316c79891"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginExample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\_Imports.razor"
using LoginExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\_Imports.razor"
using LoginExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
using LoginExample.Data.Impl;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"color: white\">Search</h1>\r\n<hr style=\"border: 2px solid white\">\r\n<br>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "sousuo");
            __builder.AddAttribute(3, "style", "text-align: center");
            __builder.OpenElement(4, "form");
            __builder.AddAttribute(5, "class", "chaxun");
            __builder.OpenElement(6, "span");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "style", "width:400px; height: 30px; border-radius: 10px");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "placeholder", "Entertext");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
                                                                                                                       text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => text = __value, text));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "span");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "style", "width: 70px; height: 30px;text-align: center; border-radius: 10px");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
                                                                                                                        search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Search");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
 if (_adults == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "<p><em>Error In File</em></p>");
#nullable restore
#line 23 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "table");
            __builder.AddAttribute(22, "class", "table table-striped");
            __builder.AddAttribute(23, "style", "margin-top: 30px");
            __builder.AddMarkupContent(24, "<thead><tr style=\"color: white\"><th>FirstName</th>\r\n            <th>LastName</th>\r\n            <th>HairColor</th>\r\n            <th>EyeColor</th>\r\n            <th>Age</th>\r\n            <th>Weight</th>\r\n            <th>Height</th></tr></thead>");
#nullable restore
#line 38 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
         foreach (var adult in _adults)
           {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "tbody");
            __builder.OpenElement(26, "tr");
            __builder.AddAttribute(27, "style", "color: white");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 42 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
                        adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                   ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 43 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
                        adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                   ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 44 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
                        adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                   ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 45 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
                        adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                   ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 46 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
                        adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                   ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 47 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
                        adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                   ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 48 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
                        adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
           }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Search.razor"
       
    private IList<Adult> _adults = new List<Adult>();
    private IList<Adult> adults = new List<Adult>();
    private string text;
    private IAdultData iAdultData = new AdultService();

    protected override async Task OnInitializedAsync()
    {
        _adults = await iAdultData.GetAdultsAsync();
    }

    public void search()
    {
        for (int i = 0; i < _adults.Count; i++)
        {
            if (text!=null)
            {
                if (_adults[i].FirstName!=null)
                {
                    if (_adults[i].FirstName.Contains(text))
                    {
                        Console.WriteLine(_adults[i].FirstName);
                        for (int a = 0; a < adults.Count; a++)
                        {
                            if (adults!=null)
                            {
                                adults.Remove(adults[a]);
                            }
                        }
                        adults.Add(_adults[i]);
                    }
                }
            }
        }
    }
    


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
