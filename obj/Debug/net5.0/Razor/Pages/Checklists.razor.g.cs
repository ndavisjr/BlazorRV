#pragma checksum "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\Checklists.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f78b644c47db818da684e86fda03fbdf178dfad1"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorRV.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\_Imports.razor"
using BlazorRV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\_Imports.razor"
using BlazorRV.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/checklists")]
    public partial class Checklists : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Checklists</h1>");
#nullable restore
#line 6 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\Checklists.razor"
 if (checklists == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>There are no checklists</em></p>");
#nullable restore
#line 9 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\Checklists.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
#nullable restore
#line 15 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\Checklists.razor"
             foreach (var checklist in checklists)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-sm");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card");
            __builder.AddAttribute(10, "style", "width: 18rem;");
            __builder.AddMarkupContent(11, "<img class=\"card-img-top\" src=\"/images/img_placeholder.png\" alt=\"Card image cap\">\r\n                        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-body");
            __builder.OpenElement(14, "h5");
            __builder.AddAttribute(15, "class", "card-title");
            __builder.AddContent(16, 
#nullable restore
#line 21 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\Checklists.razor"
                                                    checklist.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                            ");
            __builder.OpenElement(18, "p");
            __builder.AddAttribute(19, "class", "card-text");
            __builder.AddContent(20, "Category: ");
            __builder.AddContent(21, 
#nullable restore
#line 22 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\Checklists.razor"
                                                            checklist.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "href", "/checklist/" + (
#nullable restore
#line 23 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\Checklists.razor"
                                                 checklist.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "class", "btn btn-primary");
            __builder.AddContent(26, "View Checklist");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\Checklists.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\Checklists.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\Checklists.razor"
       
    private Checklist[] checklists;
    //private string url;

    protected override async Task OnInitializedAsync()
    {
        // use dummy data for now
        checklists = await Http.GetFromJsonAsync<Checklist[]>("sample-data/checklists.json");

        // call api to get all checklists
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\Checklists.razor"
                                                                          
    }

    public class Checklist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
