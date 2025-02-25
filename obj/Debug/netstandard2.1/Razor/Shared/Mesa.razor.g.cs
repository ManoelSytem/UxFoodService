#pragma checksum "C:\Users\Tees\source\repos\UXFoodService\Shared\Mesa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8b154d80c0581837e88cdb3afded6d12d139b0b"
// <auto-generated/>
#pragma warning disable 1591
namespace UxFoodService.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Tees\source\repos\UXFoodService\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tees\source\repos\UXFoodService\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tees\source\repos\UXFoodService\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tees\source\repos\UXFoodService\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tees\source\repos\UXFoodService\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tees\source\repos\UXFoodService\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tees\source\repos\UXFoodService\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Tees\source\repos\UXFoodService\_Imports.razor"
using UxFoodService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tees\source\repos\UXFoodService\_Imports.razor"
using UxFoodService.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Tees\source\repos\UXFoodService\_Imports.razor"
using UxFoodService.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Tees\source\repos\UXFoodService\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Tees\source\repos\UXFoodService\_Imports.razor"
using Service.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Tees\source\repos\UXFoodService\_Imports.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Tees\source\repos\UXFoodService\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    public partial class Mesa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\Tees\source\repos\UXFoodService\Shared\Mesa.razor"
 if (listMesa == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<label>Carregando...</label>\r\n");
#nullable restore
#line 9 "C:\Users\Tees\source\repos\UXFoodService\Shared\Mesa.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "modal fade");
            __builder.AddAttribute(5, "id", "MesaModal");
            __builder.AddAttribute(6, "tabindex", "-1");
            __builder.AddAttribute(7, "role", "dialog");
            __builder.AddAttribute(8, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(9, "aria-hidden", "true");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-dialog");
            __builder.AddAttribute(13, "role", "document");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "modal-content");
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.AddMarkupContent(18, @"<div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Escolher mesa</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "modal-body");
            __builder.AddMarkupContent(21, "\r\n                    Para qual Mesa deseja pedir o produto ? Selecione a mesa:\r\n                    <input id=\"codProduto\" name=\"user\" type=\"hidden\">\r\n                    <label id=\"texto\"></label>\r\n                    ");
            __builder.OpenElement(22, "select");
            __builder.AddAttribute(23, "class", "form-control");
            __builder.AddAttribute(24, "id", "Mesa");
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 26 "C:\Users\Tees\source\repos\UXFoodService\Shared\Mesa.razor"
                         foreach (var item in listMesa)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                            ");
            __builder.OpenElement(27, "option");
            __builder.AddAttribute(28, "value", 
#nullable restore
#line 28 "C:\Users\Tees\source\repos\UXFoodService\Shared\Mesa.razor"
                                            item.codigo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, "Mesa ");
            __builder.AddContent(30, 
#nullable restore
#line 28 "C:\Users\Tees\source\repos\UXFoodService\Shared\Mesa.razor"
                                                               item.numero

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 29 "C:\Users\Tees\source\repos\UXFoodService\Shared\Mesa.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.AddMarkupContent(35, @"<div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                    <button type=""button"" id=""Pedir"" onclick=""AdicionarConsumo()"" class=""btn btn-primary"">Pedir</button>
                </div>
            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 39 "C:\Users\Tees\source\repos\UXFoodService\Shared\Mesa.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Tees\source\repos\UXFoodService\Shared\Mesa.razor"
       

    public List<MesaModel> listMesa { get; set; }

    protected override async Task OnInitializedAsync()
    {
        listMesa = await MesaService.GetListMesa();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMesaService MesaService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
