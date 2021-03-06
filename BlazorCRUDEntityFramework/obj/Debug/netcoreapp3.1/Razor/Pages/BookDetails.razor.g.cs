#pragma checksum "C:\Users\vcaceres\source\repos\BlazorCRUDEntityFramework\BlazorCRUDEntityFramework\Pages\BookDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a808336dcbe27e0f6e31a54f448467b22828c78a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUDEntityFramework.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\vcaceres\source\repos\BlazorCRUDEntityFramework\BlazorCRUDEntityFramework\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vcaceres\source\repos\BlazorCRUDEntityFramework\BlazorCRUDEntityFramework\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vcaceres\source\repos\BlazorCRUDEntityFramework\BlazorCRUDEntityFramework\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vcaceres\source\repos\BlazorCRUDEntityFramework\BlazorCRUDEntityFramework\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vcaceres\source\repos\BlazorCRUDEntityFramework\BlazorCRUDEntityFramework\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vcaceres\source\repos\BlazorCRUDEntityFramework\BlazorCRUDEntityFramework\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vcaceres\source\repos\BlazorCRUDEntityFramework\BlazorCRUDEntityFramework\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vcaceres\source\repos\BlazorCRUDEntityFramework\BlazorCRUDEntityFramework\_Imports.razor"
using BlazorCRUDEntityFramework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vcaceres\source\repos\BlazorCRUDEntityFramework\BlazorCRUDEntityFramework\_Imports.razor"
using BlazorCRUDEntityFramework.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vcaceres\source\repos\BlazorCRUDEntityFramework\BlazorCRUDEntityFramework\_Imports.razor"
using BlazorCRUDEntityFramework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\vcaceres\source\repos\BlazorCRUDEntityFramework\BlazorCRUDEntityFramework\_Imports.razor"
using BlazorCRUDEntityFramework.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bookdetails")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/bookdetails/{id:int}")]
    public partial class BookDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Book Details</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\vcaceres\source\repos\BlazorCRUDEntityFramework\BlazorCRUDEntityFramework\Pages\BookDetails.razor"
                  book

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table");
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "tr");
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.AddMarkupContent(10, "<td>Title:</td>\r\n            ");
                __builder2.OpenElement(11, "td");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "class", "form-control col-sm-4");
                __builder2.AddAttribute(14, "type", "text");
                __builder2.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\vcaceres\source\repos\BlazorCRUDEntityFramework\BlazorCRUDEntityFramework\Pages\BookDetails.razor"
                                                                        book.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.Title = __value, book.Title));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenElement(19, "tr");
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.AddMarkupContent(21, "<td>Author:</td>\r\n            ");
                __builder2.OpenElement(22, "td");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "class", "form-control col-sm-4");
                __builder2.AddAttribute(25, "type", "text");
                __builder2.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\vcaceres\source\repos\BlazorCRUDEntityFramework\BlazorCRUDEntityFramework\Pages\BookDetails.razor"
                                                                        book.Author

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => book.Author = __value, book.Author));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n\r\n        ");
                __builder2.OpenElement(30, "tr");
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenElement(32, "td");
                __builder2.AddAttribute(33, "colspan", "2");
                __builder2.AddAttribute(34, "style", "text-align: center");
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.OpenElement(36, "input");
                __builder2.AddAttribute(37, "type", "submit");
                __builder2.AddAttribute(38, "value", "Save");
                __builder2.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\vcaceres\source\repos\BlazorCRUDEntityFramework\BlazorCRUDEntityFramework\Pages\BookDetails.razor"
                                                            SaveBook

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                ");
                __builder2.OpenElement(41, "input");
                __builder2.AddAttribute(42, "type", "button");
                __builder2.AddAttribute(43, "value", "Cancel");
                __builder2.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\vcaceres\source\repos\BlazorCRUDEntityFramework\BlazorCRUDEntityFramework\Pages\BookDetails.razor"
                                                              CancelBook

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\vcaceres\source\repos\BlazorCRUDEntityFramework\BlazorCRUDEntityFramework\Pages\BookDetails.razor"
       
    [Parameter]
    public int id { get; set; }

    Book book = new Book();

    protected async Task SaveBook()
    {
        await BookService.SaveBook(book);
        NavigationManager.NavigateTo("/");
    }

    protected void CancelBook()
    {
        NavigationManager.NavigateTo("/");
    }

    protected override async Task OnInitializedAsync()
    {
        if (id != 0)
        {
            book = await BookService.GetBookDetails(id);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookService BookService { get; set; }
    }
}
#pragma warning restore 1591
