#pragma checksum "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24132d01bca7a3d701c0d16c3329984952af0a18"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginExample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 2 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Add.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Add.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Add.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Add.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Add")]
    public partial class Add : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div><h3 style=\"margin:auto; color: white\">Add</h3>\r\n    <p style=\"font-size: 20px;margin: auto; color: white\">Enter imformation</p>\r\n    <hr style=\"border: 2px solid white\"></div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "width:40%; margin: 100px auto;");
            __builder.AddAttribute(3, "class", "main");
            __builder.OpenElement(4, "form");
            __builder.AddAttribute(5, "style", "color: white");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "a");
            __builder.AddAttribute(8, "style", "float: left");
            __builder.OpenElement(9, "div");
            __builder.AddMarkupContent(10, "<br>\r\n                ");
            __builder.AddMarkupContent(11, "<label>FirstName:</label>\r\n                <br>\r\n                ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "style", "border-radius: 10px");
            __builder.AddAttribute(14, "placeholder", "FirstName");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Add.razor"
                                                                                  _adult.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _adult.FirstName = __value, _adult.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddMarkupContent(19, "<br>\r\n                ");
            __builder.AddMarkupContent(20, "<label>LastName:</label>\r\n                <br>\r\n                ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "style", "border-radius: 10px");
            __builder.AddAttribute(23, "placeholder", "LastName");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Add.razor"
                                                                                 _adult.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _adult.LastName = __value, _adult.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddMarkupContent(28, "<br>\r\n                ");
            __builder.AddMarkupContent(29, "<label>HairColor:</label>\r\n                <br>\r\n                ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "style", "border-radius: 10px");
            __builder.AddAttribute(32, "placeholder", "HairColor");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Add.razor"
                                                                                  _adult.HairColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _adult.HairColor = __value, _adult.HairColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "div");
            __builder.AddMarkupContent(37, "<br>\r\n                ");
            __builder.AddMarkupContent(38, "<label>EyeColor:</label>\r\n                <br>\r\n                ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "style", "border-radius: 10px");
            __builder.AddAttribute(41, "placeholder", "EyeColor");
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Add.razor"
                                                                                 _adult.EyeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _adult.EyeColor = __value, _adult.EyeColor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "b");
            __builder.AddAttribute(47, "style", "float: right");
            __builder.AddMarkupContent(48, "<br>\r\n            ");
            __builder.OpenElement(49, "div");
            __builder.AddMarkupContent(50, "<label>Age:</label>\r\n                <br>\r\n                ");
            __builder.OpenElement(51, "input");
            __builder.AddAttribute(52, "style", "border-radius: 10px");
            __builder.AddAttribute(53, "placeholder", "Age");
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Add.razor"
                                                                            _adult.Age

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _adult.Age = __value, _adult.Age));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "div");
            __builder.AddMarkupContent(58, "<br>\r\n                ");
            __builder.AddMarkupContent(59, "<label>Weight:</label>\r\n                <br>\r\n                ");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "style", "border-radius: 10px");
            __builder.AddAttribute(62, "placeholder", "Weight");
            __builder.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Add.razor"
                                                                               _adult.Weight

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _adult.Weight = __value, _adult.Weight));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.OpenElement(66, "div");
            __builder.AddMarkupContent(67, "<br>\r\n                ");
            __builder.AddMarkupContent(68, "<label>Height:</label>\r\n                <br>\r\n                ");
            __builder.OpenElement(69, "input");
            __builder.AddAttribute(70, "style", "border-radius: 10px");
            __builder.AddAttribute(71, "placeholder", "Height");
            __builder.AddAttribute(72, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Add.razor"
                                                                               _adult.Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _adult.Height = __value, _adult.Height));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.OpenElement(75, "div");
            __builder.AddMarkupContent(76, "<br>\r\n                ");
            __builder.AddMarkupContent(77, "<label>Sex</label>\r\n                <br>\r\n                ");
            __builder.OpenElement(78, "input");
            __builder.AddAttribute(79, "style", "border-radius: 10px");
            __builder.AddAttribute(80, "placeholder", "Sex");
            __builder.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 64 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Add.razor"
                                                                            _adult.Sex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _adult.Sex = __value, _adult.Sex));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            <br>\r\n            <br>");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n\r\n        ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "container mt-3");
            __builder.AddAttribute(87, "style", "padding-top: 20px; width: 50%");
            __builder.OpenElement(88, "button");
            __builder.AddAttribute(89, "type", "button");
            __builder.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Add.razor"
                                             save

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "style", "width: 100%;");
            __builder.AddContent(92, "Save");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\45527\RiderProjects\Sep3Assignment1\Assignment1Finally\Pages\Add.razor"
       
    private Adult _adult = new Adult();
    private FileContext _fileContext = new FileContext();

    public void save()
    {
        _fileContext.Adults.Add(_adult);
        _fileContext.SaveChanges();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
