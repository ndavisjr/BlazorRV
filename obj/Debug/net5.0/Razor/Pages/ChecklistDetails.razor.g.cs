#pragma checksum "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\ChecklistDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a770753a0de7bd910b9512e099d55c2bdaed30f9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/checklist/{ChecklistId:int}")]
    public partial class ChecklistDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\ChecklistDetails.razor"
 if (checklists == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>There are no details to display</p>");
#nullable restore
#line 9 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\ChecklistDetails.razor"
}
else
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\ChecklistDetails.razor"
     foreach (var checklist in checklists)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h1");
            __builder.AddContent(2, 
#nullable restore
#line 15 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\ChecklistDetails.razor"
             checklist.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " Checklist");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "<thead><tr><th>Name</th>\r\n                    <th>Category</th>\r\n                    <th>Priority</th></tr></thead>\r\n            ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 25 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\ChecklistDetails.razor"
                 foreach (var item in checklist.ChecklistItems)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 28 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\ChecklistDetails.razor"
                             item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                        ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 29 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\ChecklistDetails.razor"
                             item.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 30 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\ChecklistDetails.razor"
                             item.Priority

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\ChecklistDetails.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\ChecklistDetails.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\ChecklistDetails.razor"
     

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\ChecklistDetails.razor"
       
    [Parameter]
    public int ChecklistId { get; set; }
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
#line 52 "C:\Users\ndavisjr\Desktop\workspace\BlazorRV\Pages\ChecklistDetails.razor"
                                                                          
    }

    public class Checklist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public ChecklistItems[] ChecklistItems { get; set; }
    }

    public class ChecklistItems
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Priority { get; set; }
        public int ChecklistId { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
