#pragma checksum "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbf2d00ababc496f7e5a75e2499f8858e703ae17"
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
#line 2 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
using FileData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Edit")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"color: white\">Edit</h3>\r\n");
            __builder.AddMarkupContent(1, "<p style=\"color: white\">modify imformation</p>\r\n<hr style=\"border: 2px solid white\">\r\n<br>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container mt-3");
            __builder.AddAttribute(4, "style", "width: 30%;");
            __builder.AddMarkupContent(5, "<h1 style=\"margin-left: 70px; margin-top: 60px; color: white\">Enter Imformation</h1>\r\n  ");
            __builder.OpenElement(6, "form");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "input-group mb-3");
            __builder.AddMarkupContent(9, "<div class=\"input-group-prepend\"><span class=\"input-group-text\">FirstName</span></div>\r\n      ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "placeholder", 
#nullable restore
#line 16 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
                                                            _adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
                                                                                     _adult.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _adult.FirstName = __value, _adult.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n  ");
            __builder.OpenElement(17, "form");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "input-group mb-3");
            __builder.AddMarkupContent(20, "<div><span class=\"input-group-text\">LastName</span></div>\r\n      ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "text");
            __builder.AddAttribute(23, "class", "form-control");
            __builder.AddAttribute(24, "placeholder", 
#nullable restore
#line 25 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
                                                            _adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
                                                                                    _adult.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _adult.LastName = __value, _adult.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n  ");
            __builder.OpenElement(28, "form");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "input-group mb-3");
            __builder.AddMarkupContent(31, "<div class=\"input-group-prepend\"><span class=\"input-group-text\">HairColor</span></div>\r\n      ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "text");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "placeholder", 
#nullable restore
#line 34 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
                                                            _adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
                                                                                     _adult.HairColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _adult.HairColor = __value, _adult.HairColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n  ");
            __builder.OpenElement(39, "form");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "input-group mb-3");
            __builder.AddMarkupContent(42, "<div><span class=\"input-group-text\">EyeColor</span></div>\r\n      ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "text");
            __builder.AddAttribute(45, "class", "form-control");
            __builder.AddAttribute(46, "placeholder", 
#nullable restore
#line 43 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
                                                            _adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
                                                                                    _adult.EyeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _adult.EyeColor = __value, _adult.EyeColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n  ");
            __builder.OpenElement(50, "form");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "input-group mb-3");
            __builder.AddMarkupContent(53, "<div class=\"input-group-prepend\"><span class=\"input-group-text\">Age</span></div>\r\n      ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "type", "text");
            __builder.AddAttribute(56, "class", "form-control");
            __builder.AddAttribute(57, "placeholder", 
#nullable restore
#line 52 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
                                                            _adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(58, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
                                                                               _adult.Age

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _adult.Age = __value, _adult.Age));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n  ");
            __builder.OpenElement(61, "form");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "input-group mb-3");
            __builder.AddMarkupContent(64, "<div><span class=\"input-group-text\">Weight</span></div>\r\n      ");
            __builder.OpenElement(65, "input");
            __builder.AddAttribute(66, "type", "text");
            __builder.AddAttribute(67, "class", "form-control");
            __builder.AddAttribute(68, "placeholder", 
#nullable restore
#line 61 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
                                                            _adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
                                                                                  _adult.Weight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _adult.Weight = __value, _adult.Weight));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n\r\n  ");
            __builder.OpenElement(72, "form");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "input-group mb-3");
            __builder.AddMarkupContent(75, "<div class=\"input-group-prepend\"><span class=\"input-group-text\">Height</span></div>\r\n      ");
            __builder.OpenElement(76, "input");
            __builder.AddAttribute(77, "type", "text");
            __builder.AddAttribute(78, "class", "form-control");
            __builder.AddAttribute(79, "placeholder", 
#nullable restore
#line 70 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
                                                            _adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(80, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
                                                                                  _adult.Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _adult.Height = __value, _adult.Height));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n\r\n  ");
            __builder.OpenElement(83, "form");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "input-group mb-3");
            __builder.AddMarkupContent(86, "<div><span class=\"input-group-text\">Sex</span></div>\r\n      ");
            __builder.OpenElement(87, "input");
            __builder.AddAttribute(88, "type", "text");
            __builder.AddAttribute(89, "class", "form-control");
            __builder.AddAttribute(90, "placeholder", 
#nullable restore
#line 79 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
                                                            _adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(91, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 79 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
                                                                               _adult.Sex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _adult.Sex = __value, _adult.Sex));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n\r\n  ");
            __builder.OpenElement(94, "button");
            __builder.AddAttribute(95, "type", "button");
            __builder.AddAttribute(96, "class", "btn btn-dark btn-sm btn-block");
            __builder.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
                                                                        Submit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(98, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Edit.razor"
       
  
  public Adult _adult = new Adult();
  private FileContext _fileContext = new FileContext();
  private IList<Adult> sadults = new List<Adult>();
  private IList<Adult> _adults = new List<Adult>();

  protected override async Task OnInitializedAsync()
  {
    sadults = _fileContext.Sadults;
    _adults = _fileContext.Adults;
    for (int i = 0; i < sadults.Count; i++)
    {
      _adult = sadults[i];
    }
  }

  private void Submit()
  {
    for (int i = 0; i < _adults.Count; i++)
    {
      if (_adults[i].FirstName.Equals(_adult.FirstName) && _adults[i].LastName.Equals(_adult.LastName))
      {
        _adults.Remove(_adults[i]);
        _adults.Add(_adult);
      }
    }
    for (int a = 0; a < sadults.Count; a++)
    {
      sadults.Remove(sadults[a]);
    }
    _fileContext.SaveChanges();
  }





#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
