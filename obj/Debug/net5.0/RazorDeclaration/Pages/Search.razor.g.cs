// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LoginExample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/chen/RiderProjects/Assignment1Finally/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/chen/RiderProjects/Assignment1Finally/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/chen/RiderProjects/Assignment1Finally/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/chen/RiderProjects/Assignment1Finally/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/chen/RiderProjects/Assignment1Finally/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/chen/RiderProjects/Assignment1Finally/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/chen/RiderProjects/Assignment1Finally/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/chen/RiderProjects/Assignment1Finally/_Imports.razor"
using LoginExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/chen/RiderProjects/Assignment1Finally/_Imports.razor"
using LoginExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/chen/RiderProjects/Assignment1Finally/Pages/Search.razor"
using FileData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/chen/RiderProjects/Assignment1Finally/Pages/Search.razor"
using global::Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "/Users/chen/RiderProjects/Assignment1Finally/Pages/Search.razor"
       
    private IList<Adult> _adults = new List<Adult>();
    private IList<Adult> adults = new List<Adult>();
    private string text;

    protected override async Task OnInitializedAsync()
    {
        _adults = new FileContext().Adults;
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
