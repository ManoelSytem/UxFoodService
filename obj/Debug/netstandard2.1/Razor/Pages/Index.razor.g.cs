#pragma checksum "C:\Users\Tees\source\repos\UXFoodService\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "531193460c9151d9fa7fa24e98ec7b1dba0cf1ec"
// <auto-generated/>
#pragma warning disable 1591
namespace UxFoodService.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Tees\source\repos\UXFoodService\Pages\Index.razor"
     if (cliente == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.AddMarkupContent(4, "<label>Carregando dados cliente...</label>\r\n");
#nullable restore
#line 11 "C:\Users\Tees\source\repos\UXFoodService\Pages\Index.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "jumbotron p-3 p-md-5 text-white rounded bg-dark");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row justify-content-center");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<div class=\"col-6 col-md-4\">\r\n                    <img class=\"rounded-circle img-fluid\" alt=\"100x100\" src=\"img/logo.jpg\" data-holder-rendered=\"true\">\r\n                </div>\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col");
            __builder.OpenElement(20, "h5");
            __builder.OpenElement(21, "p");
            __builder.AddAttribute(22, "class", "text-center");
            __builder.AddContent(23, 
#nullable restore
#line 22 "C:\Users\Tees\source\repos\UXFoodService\Pages\Index.razor"
                                                                     cliente.nome

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "row");
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "style", "background-color:orange");
            __builder.AddAttribute(31, "class", "col");
            __builder.OpenElement(32, "p");
            __builder.AddAttribute(33, "class", "text-left");
            __builder.AddContent(34, 
#nullable restore
#line 25 "C:\Users\Tees\source\repos\UXFoodService\Pages\Index.razor"
                                                                                               cliente.descricao

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "row");
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col");
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.OpenElement(43, "p");
            __builder.AddAttribute(44, "class", "text-left");
            __builder.AddMarkupContent(45, "\r\n                                ");
            __builder.AddMarkupContent(46, @"<svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-geo-alt"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                                    <path fill-rule=""evenodd"" d=""M12.166 8.94C12.696 7.867 13 6.862 13 6A5 5 0 0 0 3 6c0 .862.305 1.867.834 2.94.524 1.062 1.234 2.12 1.96 3.07A31.481 31.481 0 0 0 8 14.58l.208-.22a31.493 31.493 0 0 0 1.998-2.35c.726-.95 1.436-2.008 1.96-3.07zM8 16s6-5.686 6-10A6 6 0 0 0 2 6c0 4.314 6 10 6 10z""></path>
                                    <path fill-rule=""evenodd"" d=""M8 8a2 2 0 1 0 0-4 2 2 0 0 0 0 4zm0 1a3 3 0 1 0 0-6 3 3 0 0 0 0 6z""></path>
                                </svg>
                                Endereço: <br> ");
            __builder.AddContent(47, 
#nullable restore
#line 34 "C:\Users\Tees\source\repos\UXFoodService\Pages\Index.razor"
                                                  cliente.endereco

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(48, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "row");
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "style", "background-color:cadetblue");
            __builder.AddAttribute(57, "class", "col");
            __builder.AddMarkupContent(58, "\r\n\r\n                            ");
            __builder.OpenElement(59, "p");
            __builder.AddAttribute(60, "class", "text-left");
            __builder.AddMarkupContent(61, "\r\n                                ");
            __builder.AddMarkupContent(62, @"<svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-telephone-outbound"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                                    <path fill-rule=""evenodd"" d=""M3.654 1.328a.678.678 0 0 0-1.015-.063L1.605 2.3c-.483.484-.661 1.169-.45 1.77a17.568 17.568 0 0 0 4.168 6.608 17.569 17.569 0 0 0 6.608 4.168c.601.211 1.286.033 1.77-.45l1.034-1.034a.678.678 0 0 0-.063-1.015l-2.307-1.794a.678.678 0 0 0-.58-.122l-2.19.547a1.745 1.745 0 0 1-1.657-.459L5.482 8.062a1.745 1.745 0 0 1-.46-1.657l.548-2.19a.678.678 0 0 0-.122-.58L3.654 1.328zM1.884.511a1.745 1.745 0 0 1 2.612.163L6.29 2.98c.329.423.445.974.315 1.494l-.547 2.19a.678.678 0 0 0 .178.643l2.457 2.457a.678.678 0 0 0 .644.178l2.189-.547a1.745 1.745 0 0 1 1.494.315l2.306 1.794c.829.645.905 1.87.163 2.611l-1.034 1.034c-.74.74-1.846 1.065-2.877.702a18.634 18.634 0 0 1-7.01-4.42 18.634 18.634 0 0 1-4.42-7.009c-.362-1.03-.037-2.137.703-2.877L1.885.511zM11 .5a.5.5 0 0 1 .5-.5h4a.5.5 0 0 1 .5.5v4a.5.5 0 0 1-1 0V1.707l-4.146 4.147a.5.5 0 0 1-.708-.708L14.293 1H11.5a.5.5 0 0 1-.5-.5z""></path>
                                </svg>
                                Contato: tel ");
            __builder.OpenElement(63, "span");
            __builder.AddAttribute(64, "class", "glyphicon glyphicon-earphone");
            __builder.AddContent(65, 
#nullable restore
#line 45 "C:\Users\Tees\source\repos\UXFoodService\Pages\Index.razor"
                                                                                         cliente.contato

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(66, " - <i class=\"fa fa-whatsapp\" style=\"font-size:24px\"></i> Whatsapp :   <br> ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n                            ");
            __builder.OpenElement(69, "p");
            __builder.AddAttribute(70, "class", "text-left");
            __builder.AddMarkupContent(71, "\r\n                                ");
            __builder.AddMarkupContent(72, @"<svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-envelope"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                                    <path fill-rule=""evenodd"" d=""M0 4a2 2 0 0 1 2-2h12a2 2 0 0 1 2 2v8a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V4zm2-1a1 1 0 0 0-1 1v.217l7 4.2 7-4.2V4a1 1 0 0 0-1-1H2zm13 2.383l-4.758 2.855L15 11.114v-5.73zm-.034 6.878L9.271 8.82 8 9.583 6.728 8.82l-5.694 3.44A1 1 0 0 0 2 13h12a1 1 0 0 0 .966-.739zM1 11.114l4.758-2.876L1 5.383v5.73z""></path>
                                </svg>
                                E-mail:<br>");
            __builder.OpenElement(73, "span");
            __builder.AddAttribute(74, "class", "glyphicon glyphicon-earphone");
            __builder.AddContent(75, 
#nullable restore
#line 52 "C:\Users\Tees\source\repos\UXFoodService\Pages\Index.razor"
                                                                                        cliente.email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n");
#nullable restore
#line 59 "C:\Users\Tees\source\repos\UXFoodService\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(83, "    ");
            __builder.OpenComponent<UxFoodService.Shared.ListaManu>(84);
            __builder.CloseComponent();
            __builder.AddMarkupContent(85, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\Tees\source\repos\UXFoodService\Pages\Index.razor"
      

    public ClienteModel cliente { get; set; }

    protected override async Task OnInitializedAsync()
    {
        cliente = await clienteService.ObterCliente();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClienteService clienteService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
