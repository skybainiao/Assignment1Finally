#pragma checksum "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\PersonList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b016583c07e59cbcda38be1410563414a8eac0c"
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
#line 2 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\PersonList.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\PersonList.razor"
using global::Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/PersonList")]
    public partial class PersonList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"color: white\">Person List</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p style=\"color: white\">This is the data of all personnel.</p>\r\n<hr style=\"border: 2px solid white\">\r\n<br>");
#nullable restore
#line 12 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\PersonList.razor"
 if (_adults == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 17 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\PersonList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-hover");
            __builder.AddMarkupContent(5, "<thead><tr style=\"color: white\"><th>FirstName</th>\r\n            <th>LastName</th>\r\n            <th>HairColor</th>\r\n            <th>EyeColor</th>\r\n            <th>Age</th>\r\n            <th>Weight</th>\r\n            <th>Height</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 33 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\PersonList.razor"
         foreach (var adult in _adults)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.AddAttribute(8, "style", "color: white");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 36 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\PersonList.razor"
                     adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 37 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\PersonList.razor"
                     adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 38 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\PersonList.razor"
                     adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 39 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\PersonList.razor"
                     adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 40 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\PersonList.razor"
                     adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 41 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\PersonList.razor"
                     adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 42 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\PersonList.razor"
                     adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-dark");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\PersonList.razor"
                                                       () => Delete(adult)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "style", "margin-right: 10px");
            __builder.AddContent(34, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-dark");
            __builder.AddAttribute(38, "style", "left: 10px");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\PersonList.razor"
                                                                          () => Modify(adult)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Modify");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\PersonList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\PersonList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\PersonList.razor"
       
    private IList<Adult> _adults = new List<Adult>();
    private FileContext _fileContext = new FileContext();

    protected override async Task OnInitializedAsync()
    {
        _adults = _fileContext.Adults;
    }

    private void Delete(Adult adult)
    {
        _adults.Remove(adult);
        _fileContext.SaveChanges();
    }

    public void Go()
    {
        _navigationManager.NavigateTo("/Edit");
    }
    
    public void Modify(Adult adult)
    {
        Go();
        _fileContext.Sadults.Add(adult);
        _fileContext.SaveChanges();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
