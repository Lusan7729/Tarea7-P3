#pragma checksum "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24f54818e1c9eb2862a80e232f82fd4511c8cfd7"
// <auto-generated/>
#pragma warning disable 1591
namespace __tarea7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\Lusan\Desktop\Tarea7-P3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lusan\Desktop\Tarea7-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lusan\Desktop\Tarea7-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lusan\Desktop\Tarea7-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lusan\Desktop\Tarea7-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lusan\Desktop\Tarea7-P3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lusan\Desktop\Tarea7-P3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lusan\Desktop\Tarea7-P3\_Imports.razor"
using __tarea7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lusan\Desktop\Tarea7-P3\_Imports.razor"
using __tarea7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RegistrarVacuna")]
    public partial class RegistrarVacuna : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"text-center alert alert-info\"><h4>Registro de vacunas</h4></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-6  border rounded");
            __builder.AddAttribute(7, "style", "background-color: #d9feff; margin-bottom:100px");
#nullable restore
#line 14 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
             if (consulta == false)
            {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "text-center");
            __builder.AddMarkupContent(10, "<label style=\"margin:15px;\"><strong>Ingrese la cedula:</strong></label>\r\n                    ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "class", "form-check form-control");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                                               cedula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cedula = __value, cedula));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-primary");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                               buscarPersona

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "style", "margin-top:5px; margin:20px;");
            __builder.AddContent(21, "Verificar");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                if(registroAgregado == true)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<p class=\"alert alert-success\">Registro de vacuna agregado</p>");
#nullable restore
#line 25 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                }



                if (tieneLas2 == true)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<p class=\"alert alert-success\">Esta persona tiene las 2 dosis</p>");
#nullable restore
#line 32 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
             if (consulta == true)
            {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "class", "alert alert-primary");
            __builder.AddAttribute(26, "style", "margin-top:10px");
            __builder.AddMarkupContent(27, "<strong>Nombre: </strong> ");
            __builder.AddContent(28, 
#nullable restore
#line 38 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                                                                  resultado.Nombres

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "p");
            __builder.AddAttribute(31, "class", "alert alert-primary");
            __builder.AddMarkupContent(32, "<strong>Apellidos : </strong>");
            __builder.AddContent(33, 
#nullable restore
#line 39 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                                             resultado.Apellido1

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(34, " ");
            __builder.AddContent(35, 
#nullable restore
#line 39 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                                                                  resultado.Apellido2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "p");
            __builder.AddAttribute(38, "class", "alert alert-primary");
            __builder.AddMarkupContent(39, "<strong>Fecha de nacimiento: </strong>");
            __builder.AddContent(40, 
#nullable restore
#line 40 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                                                      resultado.FechaNacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"

                //forms

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "alert alert-primary");
            __builder.AddMarkupContent(43, "<strong>Fehca de la dosis:</strong> ");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "type", "date");
            __builder.AddAttribute(46, "class", "form-check form-control");
            __builder.AddAttribute(47, "style", "width:200px");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                                                                                fechaDosis1

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fechaDosis1 = __value, fechaDosis1, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "alert alert-primary");
            __builder.AddMarkupContent(53, "<strong>Telefono: </strong>");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "type", "text");
            __builder.AddAttribute(56, "class", "form-check form-control");
            __builder.AddAttribute(57, "style", "width:200px");
            __builder.AddAttribute(58, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                                                                       telefono

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => telefono = __value, telefono));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                //select tipo de vacuna


#line default
#line hidden
#nullable disable
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "form-group alert alert-primary");
            __builder.AddMarkupContent(62, "<label for=\"exampleFormControlSelect1\"><strong>Tipo de vacuna : </strong></label>\r\n                    ");
            __builder.OpenElement(63, "select");
            __builder.AddAttribute(64, "class", "form-control");
            __builder.AddAttribute(65, "id", "exampleFormControlSelect1");
            __builder.AddAttribute(66, "name", "name");
            __builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                                                                       tipoVacuna

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "style", "width:200px");
            __builder.OpenElement(69, "option");
            __builder.AddContent(70, " -- Sin seleccionar -- ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                        ");
            __builder.OpenElement(72, "option");
            __builder.AddContent(73, "Vacuna tipo A");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.OpenElement(75, "option");
            __builder.AddContent(76, "Vacuna tipo B");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                        ");
            __builder.OpenElement(78, "option");
            __builder.AddContent(79, "Vacuna tipo C");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n\r\n                    ");
            __builder.AddMarkupContent(81, "<label for=\"exampleFormControlSelect1\"><strong>Cantidades de vacunas : </strong></label>\r\n                      ");
            __builder.AddMarkupContent(82, "<div><label for=\"exampleFormControlSelect1\"> Tipo A: 150 </label></div>\r\n                      ");
            __builder.AddMarkupContent(83, "<div><label for=\"exampleFormControlSelect1\"> Tipo B: 115 </label></div>\r\n                      ");
            __builder.AddMarkupContent(84, "<div><label for=\"exampleFormControlSelect1\"> Tipo C: 0 </label></div>");
            __builder.CloseElement();
#nullable restore
#line 67 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"

                //select provincias

#line default
#line hidden
#nullable disable
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "form-group alert alert-primary");
            __builder.AddMarkupContent(87, "<label for=\"exampleFormControlSelect1\"><strong>Provincia : </strong></label>\r\n                    ");
            __builder.OpenElement(88, "select");
            __builder.AddAttribute(89, "class", "form-control");
            __builder.AddAttribute(90, "id", "exampleFormControlSelect1");
            __builder.AddAttribute(91, "name", "nam");
            __builder.AddAttribute(92, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                                                                      provincias

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "style", "width:200px");
            __builder.OpenElement(94, "option");
            __builder.AddContent(95, " -- Sin seleccionar -- ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                        ");
            __builder.OpenElement(97, "option");
            __builder.AddContent(98, "Azua");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.OpenElement(100, "option");
            __builder.AddContent(101, "Bahoruco");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                        ");
            __builder.OpenElement(103, "option");
            __builder.AddContent(104, "Barahona");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                        ");
            __builder.OpenElement(106, "option");
            __builder.AddMarkupContent(107, "Dajabón");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                        ");
            __builder.OpenElement(109, "option");
            __builder.AddContent(110, "Distrito Nacional");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                        ");
            __builder.OpenElement(112, "option");
            __builder.AddContent(113, "Duarte");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                        ");
            __builder.OpenElement(115, "option");
            __builder.AddMarkupContent(116, "Elías Piña");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                        ");
            __builder.OpenElement(118, "option");
            __builder.AddContent(119, "El Seibo");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                        ");
            __builder.OpenElement(121, "option");
            __builder.AddContent(122, "Espaillat");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                        ");
            __builder.OpenElement(124, "option");
            __builder.AddContent(125, "Hato Mayor");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                        ");
            __builder.OpenElement(127, "option");
            __builder.AddContent(128, "Hermanas Mirabal");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                        ");
            __builder.OpenElement(130, "option");
            __builder.AddContent(131, "Independencia");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                        ");
            __builder.OpenElement(133, "option");
            __builder.AddContent(134, "La Altagracia");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                        ");
            __builder.OpenElement(136, "option");
            __builder.AddContent(137, "La Romana");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                        ");
            __builder.OpenElement(139, "option");
            __builder.AddContent(140, "La Vega");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                        ");
            __builder.OpenElement(142, "option");
            __builder.AddMarkupContent(143, "María Trinidad Sánchez");
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                        ");
            __builder.OpenElement(145, "option");
            __builder.AddMarkupContent(146, "Monseñor Nouel");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n                        ");
            __builder.OpenElement(148, "option");
            __builder.AddContent(149, "Monte Cristi");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                        ");
            __builder.OpenElement(151, "option");
            __builder.AddContent(152, "Monte Plata");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n                        ");
            __builder.OpenElement(154, "option");
            __builder.AddContent(155, "Pedernales");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n                        ");
            __builder.OpenElement(157, "option");
            __builder.AddContent(158, "Peravia");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                        ");
            __builder.OpenElement(160, "option");
            __builder.AddContent(161, "Puerto Plata");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n                        ");
            __builder.OpenElement(163, "option");
            __builder.AddMarkupContent(164, "Samaná");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n                        ");
            __builder.OpenElement(166, "option");
            __builder.AddMarkupContent(167, "San José de Ocoa");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n                        ");
            __builder.OpenElement(169, "option");
            __builder.AddContent(170, "San Juan");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n                        ");
            __builder.OpenElement(172, "option");
            __builder.AddMarkupContent(173, "San Pedro de Macorís");
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n                        ");
            __builder.OpenElement(175, "option");
            __builder.AddMarkupContent(176, "Sánchez Ramírez");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n                        ");
            __builder.OpenElement(178, "option");
            __builder.AddContent(179, "Santiago");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n                        ");
            __builder.OpenElement(181, "option");
            __builder.AddMarkupContent(182, "Santiago Rodríguez");
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\r\n                        ");
            __builder.OpenElement(184, "option");
            __builder.AddContent(185, "Santo Domingo");
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n                        ");
            __builder.OpenElement(187, "option");
            __builder.AddContent(188, "Valverde");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 107 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                BotonAgregar = true;
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
             if (tipoDeVacuna != "-- Sin seleccionar --" && tipoDeVacuna != "Vacuna tipo C" && provincia != "-- Sin seleccionar --" && BotonAgregar == true)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(189, "center");
            __builder.OpenElement(190, "button");
            __builder.AddAttribute(191, "class", "btn btn-success");
            __builder.AddAttribute(192, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 114 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                      nuevoVacunado

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(193, "style", "margin:20px;");
            __builder.AddContent(194, "Agregar Registro");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 116 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(195, "\r\n        \r\n        ");
            __builder.OpenElement(196, "div");
            __builder.AddAttribute(197, "class", "col-md-6");
#nullable restore
#line 122 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
             if (existe == true)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(198, "<div class=\"header\"><h1 class=\"alert alert-info\">Vacunado encontrado</h1></div>\r\n                 ");
            __builder.AddMarkupContent(199, "<div class=\"text-center\"><p class=\"alert alert-success\">Esta persona se encuentra en el registros</p></div>\r\n                ");
            __builder.OpenElement(200, "p");
            __builder.AddAttribute(201, "class", "alert alert-primary");
            __builder.AddMarkupContent(202, "<strong>Nombre : </strong>");
            __builder.AddContent(203, 
#nullable restore
#line 130 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                                          resultado.Nombres

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(204, "\r\n                ");
            __builder.OpenElement(205, "p");
            __builder.AddAttribute(206, "class", "alert alert-primary");
            __builder.AddMarkupContent(207, "<strong>Apellido :</strong> ");
            __builder.AddContent(208, 
#nullable restore
#line 131 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                                            resultado.Apellido1

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(209, " ");
            __builder.AddContent(210, 
#nullable restore
#line 131 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                                                                 resultado.Apellido2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(211, "\r\n                ");
            __builder.OpenElement(212, "p");
            __builder.AddAttribute(213, "class", "alert alert-primary");
            __builder.AddMarkupContent(214, "<strong>Telefono :</strong> ");
            __builder.AddContent(215, 
#nullable restore
#line 132 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                                            TelefonoR

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(216, "\r\n                ");
            __builder.OpenElement(217, "p");
            __builder.AddAttribute(218, "class", "alert alert-primary");
            __builder.AddMarkupContent(219, "<strong>Fecha de nacimiento :</strong> ");
            __builder.AddContent(220, 
#nullable restore
#line 133 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                                                       resultado.FechaNacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(221, "\r\n                ");
            __builder.OpenElement(222, "p");
            __builder.AddAttribute(223, "class", "alert alert-primary");
            __builder.AddMarkupContent(224, "<strong>Tipo de vacuna :</strong> ");
            __builder.AddContent(225, 
#nullable restore
#line 134 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                                                  vacunaTipoR

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(226, "\r\n                ");
            __builder.OpenElement(227, "p");
            __builder.AddAttribute(228, "class", "alert alert-warning");
            __builder.AddMarkupContent(229, "<strong>Fecha de primera dosis :</strong>Fecha de primera dosis : ");
            __builder.AddContent(230, 
#nullable restore
#line 135 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                                                                                  FechaD1Registrado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(231, "\r\n                ");
            __builder.OpenElement(232, "div");
            __builder.AddAttribute(233, "class", "alert alert-primary");
            __builder.AddMarkupContent(234, "<p>agregar fecha de 2da dosis</p>");
            __builder.OpenElement(235, "input");
            __builder.AddAttribute(236, "type", "date");
            __builder.AddAttribute(237, "class", "form-check form-control");
            __builder.AddAttribute(238, "style", "width:200px");
            __builder.AddAttribute(239, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 137 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                                                fechaDosis2

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(240, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => fechaDosis2 = __value, fechaDosis2, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(241, "\r\n                ");
            __builder.OpenElement(242, "div");
            __builder.AddAttribute(243, "class", "text-center");
            __builder.AddAttribute(244, "style", "margin-bottom:50px");
            __builder.OpenElement(245, "button");
            __builder.AddAttribute(246, "class", "btn btn-primary");
            __builder.AddAttribute(247, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 140 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                                                               dosis2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(248, "style", "margin:15px;");
            __builder.AddContent(249, "Agregar");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 142 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
                if (vc2 == true)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(250, "<p class=\"alert alert-success\">!Listo, fecha agregada, esta persona tiene las 2 dosis</p>");
#nullable restore
#line 146 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 156 "C:\Users\Lusan\Desktop\Tarea7-P3\Pages\RegistrarVacuna.razor"
       

    public class Persona
    {
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string FechaNacimiento { get; set; }
        public string LugarNacimiento { get; set; }
        public int IDCategoria { get; set; }
        public string IdSexo { get; set; }
        public string IdEstadoCivil { get; set; }
        public int IdOcupacion { get; set; }
        public int IDNacionalidad { get; set; }
        public int IDMunicipio { get; set; }
        public int IDColegio { get; set; }
        public object IDCausaCancelacion { get; set; }
        public string IDEstatus { get; set; }
        public object EstatusCedulaAzul { get; set; }
        public object CedulaAnterior { get; set; }
        public string mun_ced { get; set; }
        public string seq_ced { get; set; }
        public string ver_ced { get; set; }
        public object V2004 { get; set; }
        public object V2008 { get; set; }
        public object V2012 { get; set; }
        public object V2016 { get; set; }
        public object PLD { get; set; }
        public object PRD { get; set; }
        public object PRSC { get; set; }
        public object PRM { get; set; }
        public object Multiplicador_NombreCompleto { get; set; }
        public object Multiplicador_Cedula { get; set; }
        public object Simpatia_Descripcion { get; set; }
        public object Ilocalizable { get; set; }
        public object Apodo { get; set; }
        public object PadronLF { get; set; }
        public bool ok { get; set; }
        public string foto { get; set; }
    }

    bool consulta = false;
    bool existe = false;
    bool vc2 = false;
    bool tieneLas2 = false;
    bool BotonAgregar = false;

    String cedula;
    String tipoDeVacuna = "-- Sin seleccionar --";
    String provincia = "-- Sin seleccionar --";
    DateTime fechaDosis1;
    long telefono;
    
    int VacA;
    int VacB;
    int  VacC;


    //Registrados
    String FechaD1Registrado;
    long TelefonoR;
    String vacunaTipoR;
    bool registroAgregado;

    //Segunda fecha
    DateTime fechaDosis2;

    Persona resultado = null;
    String ced;


    static readonly HttpClient http = new HttpClient();

    async Task dosis2()
    {
        vc2 = true;
        existe = false;
        resultado = await http.GetFromJsonAsync<Persona>("https://api.adamix.net/apec/cedula/" + cedula);
        string fecha = fechaDosis2.ToString("dd/MM/yyyy");

        //Verifica si esta cedula esta registrada
        foreach (var data in Products)
        {
            if (cedula == data.Id)
            {
                SetProductForUpdate(data);
                UpdateProduct.fecahDosis2 = fecha;
                UpdateProductData();
                return;
            }
        }

    }

    async Task buscarPersona()
    {
        resultado = await http.GetFromJsonAsync<Persona>("https://api.adamix.net/apec/cedula/" + cedula);

        registroAgregado = false;
        //Verifica si esta cedula esta registrada
        foreach (var data in Products)
        {
            if(cedula == data.Id)
            {
                if(data.fecahDosis2 != "Sin recibir")
                {
                    tieneLas2 = true;
                    return;
                }
                existe = true;
                FechaD1Registrado = data.fecahDosis1;
                vacunaTipoR = data.tipoVacuna;
                TelefonoR = data.telefono;
                SetProductForUpdate(data);
                UpdateProductData();
                return;
            }
        }



        //fin veridicacion

        if (resultado.ok)
        {
            consulta = true;
        }
        else
        {
            ced = "Cedula no encontrada";
        }

    }

    public void tipoVacuna(ChangeEventArgs e)
    {
        tipoDeVacuna = e.Value.ToString();
    }
    public void provincias(ChangeEventArgs e)
    {
        provincia = e.Value.ToString();
    }

    public void nuevoVacunado()
    {
        registroAgregado = true;
        string fecha = fechaDosis1.ToString("dd/MM/yyyy");
        NewProduct.nombre = resultado.Nombres;
        NewProduct.apellido = resultado.Apellido1 + " " + resultado.Apellido2;
        NewProduct.fechaNacimiento = resultado.FechaNacimiento;
        NewProduct.tipoVacuna = tipoDeVacuna;
        NewProduct.provincia = provincia;
        NewProduct.fecahDosis1 = fecha;
        NewProduct.fecahDosis2 = "Sin recibir";
        NewProduct.telefono = telefono;
        NewProduct.Id = cedula;
        AddNewProduct();
        consulta = false;
        cedula = "";
    }

    //Agregar,Altualizar

    List<vacunados>
    Products = new List<vacunados>
        ();

    protected override async Task OnInitializedAsync()
    {
        await RefreshProducts();
    }

    private async Task RefreshProducts()
    {
        Products = await service.GetProductAsync();
    }


    public vacunados NewProduct { get; set; } = new vacunados();

    private async Task AddNewProduct()
    {
        BotonAgregar = false;
        await service.AddProductAsync(NewProduct);
        NewProduct = new vacunados();
        await RefreshProducts();
    }

    vacunados UpdateProduct = new vacunados();
    private void SetProductForUpdate(vacunados product)
    {
        UpdateProduct = product;
    }

    private async Task UpdateProductData()
    {
        await service.UpdateProductAsync(UpdateProduct);
        await RefreshProducts();
    }

    private async Task DeleteProduct(vacunados product)
    {
        await service.DeleteProductAsync(product);
        await RefreshProducts();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private vacunadosServices service { get; set; }
    }
}
#pragma warning restore 1591
