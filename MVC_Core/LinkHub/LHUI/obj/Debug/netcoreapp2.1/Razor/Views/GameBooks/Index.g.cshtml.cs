#pragma checksum "D:\NumbersOnlyProject\MVC_Core\MVC_Core\LinkHub\LHUI\Views\GameBooks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb38f6d72f26eae0638550066d6d3dd1a934da30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GameBooks_Index), @"mvc.1.0.view", @"/Views/GameBooks/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GameBooks/Index.cshtml", typeof(AspNetCore.Views_GameBooks_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "D:\NumbersOnlyProject\MVC_Core\MVC_Core\LinkHub\LHUI\Views\_ViewImports.cshtml"
using LHBOL;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb38f6d72f26eae0638550066d6d3dd1a934da30", @"/Views/GameBooks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fbeba38c0ce4c34dc54730b5a56900d5e55e4e4", @"/Views/_ViewImports.cshtml")]
    public class Views_GameBooks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LHBOL.Gamebooks>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "pv_GameBookList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\NumbersOnlyProject\MVC_Core\MVC_Core\LinkHub\LHUI\Views\GameBooks\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(80, 110, true);
            WriteLiteral("\r\n<h2>Territory GB</h2>\r\n\r\n\r\n    <p id=\"msg\"></p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(190, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d5cd7127d254210b7f52af1aa33fec0", async() => {
                BeginContext(213, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(227, 418, true);
            WriteLiteral(@"

        </td>
        <td>
            <button id=""btnFilter"" class=""btn btn-secondary my-2 my-sm-0"" type=""button"">
                Filter
            </button>
        </td>
        <td>
            <input class=""mr-sm-2"" type=""text"" id=""txtSearch"" placeholder=""Search"">
            <button class=""btn btn-secondary my-2 my-sm-0"" type=""button"" id=""btnSearch"">Search</button>
        </td>
        <td>
");
            EndContext();
#line 27 "D:\NumbersOnlyProject\MVC_Core\MVC_Core\LinkHub\LHUI\Views\GameBooks\Index.cshtml"
              
                double TotalPages = ViewBag.TotalPages;
            

#line default
#line hidden
            BeginContext(733, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 30 "D:\NumbersOnlyProject\MVC_Core\MVC_Core\LinkHub\LHUI\Views\GameBooks\Index.cshtml"
             for (int i = 1; i <= TotalPages; i++)
            {
                

#line default
#line hidden
#line 32 "D:\NumbersOnlyProject\MVC_Core\MVC_Core\LinkHub\LHUI\Views\GameBooks\Index.cshtml"
                             
                if (i == ViewBag.Page)
                {

#line default
#line hidden
            BeginContext(890, 33, true);
            WriteLiteral("            <b>\r\n                ");
            EndContext();
            BeginContext(924, 187, false);
#line 36 "D:\NumbersOnlyProject\MVC_Core\MVC_Core\LinkHub\LHUI\Views\GameBooks\Index.cshtml"
           Write(Html.ActionLink(i.ToString() + " ", "Index", new { SortOrder = (ViewBag.SortOrder == null ? "Asc" : ViewBag.SortOrder), SortBy = (ViewBag.SortBy == null ? "Id" : ViewBag.SortBy),Page=i }));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 20, true);
            WriteLiteral("\r\n            </b>\r\n");
            EndContext();
#line 38 "D:\NumbersOnlyProject\MVC_Core\MVC_Core\LinkHub\LHUI\Views\GameBooks\Index.cshtml"
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(1212, 187, false);
#line 41 "D:\NumbersOnlyProject\MVC_Core\MVC_Core\LinkHub\LHUI\Views\GameBooks\Index.cshtml"
               Write(Html.ActionLink(i.ToString() + " ", "Index", new { SortOrder = (ViewBag.SortOrder == null ? "Asc" : ViewBag.SortOrder), SortBy = (ViewBag.SortBy == null ? "Id" : ViewBag.SortBy),Page=i }));

#line default
#line hidden
            EndContext();
#line 41 "D:\NumbersOnlyProject\MVC_Core\MVC_Core\LinkHub\LHUI\Views\GameBooks\Index.cshtml"
                                                                                                                                                                                                                
                }
            }

#line default
#line hidden
            BeginContext(1435, 47, true);
            WriteLiteral("        </td>\r\n    </tr>\r\n</table>\r\n    <p>\r\n\r\n");
            EndContext();
            BeginContext(1798, 14, true);
            WriteLiteral("            \r\n");
            EndContext();
            BeginContext(1833, 39, true);
            WriteLiteral("    </p>\r\n    <div id=\"GameBookList\">\r\n");
            EndContext();
            BeginContext(1927, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1935, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2f87aa797a1340db93bc03335cf429bc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 59 "D:\NumbersOnlyProject\MVC_Core\MVC_Core\LinkHub\LHUI\Views\GameBooks\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1982, 669, true);
            WriteLiteral(@"
    </div>
        <div class=""container"">
            <div class=""modal fade"" tabindex=""-1"" id=""FilterModal""
                 data-keyboard=""false"" data-backdrop=""static"">
                <div class=""modal-dialog modal-lg"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <button type=""button"" class=""close"" data-dismiss=""modal"">
                                ×
                            </button>
                            <h4 class=""modal-title"">Filter</h4>
                        </div>
                        <div class=""modal-body"">
                            ");
            EndContext();
            BeginContext(2651, 1495, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fe6b75e5851482fa781595839b81e0d", async() => {
                BeginContext(2659, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(3237, 902, true);
                WriteLiteral(@"        <div class=""form-group"">
            <h3>Select your favorite sports:</h3>
            <label><input class=""ckb"" type=""checkbox"" id=1 value=""football"" name=""sport""> Football</label><br />
            <label><input class=""ckb"" type=""checkbox"" id=2 value=""baseball"" name=""sport""> Baseball</label><br />
            <label><input class=""ckb"" type=""checkbox"" id=3 value=""cricket"" name=""sport""> Cricket</label><br />
            <label><input class=""ckb"" type=""checkbox"" id=4 value=""boxing"" name=""sport""> Boxing</label><br />
            <label><input class=""ckb"" type=""checkbox"" id=5 value=""racing"" name=""sport""> Racing</label><br />
            <label><input class=""ckb"" type=""checkbox"" id=6 value=""swimming"" name=""sport""> Swimming</label><br />
            <br>
            <button type=""button"" id=""getVal"">Get Values</button>
            <p id=""checkid""></p>
        </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4146, 180, true);
            WriteLiteral("\r\n    </div>\r\n                    <div class=\"modal-footer\">\r\n                        <button type=\"Submit\" id=\"SubmitFilter\" class=\"btn btn-primary button button4\">Sign</button>\r\n");
            EndContext();
            BeginContext(4812, 3288, true);
            WriteLiteral(@"                        <button type=""button"" id=""btnHideModal"" class=""btn btn-primary button button4"">
                            Hide
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id=""loading"" class=""modal"">
        <div class=""modal-dialog"" >
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title""> Loading...</h4>
                </div>
                <div class=""modal-body"">
                    <div class=""progress progress-stripped active"">
                        <div class=""progress-bar"" style=""width:100%""></div>
                    </div>
                </div>

            </div>
        </div>
    </div>
    <script type=""text/javascript"">
//    var onURL = function(context){
//    alert(context);
//};
    //$(document).ready(function () {
    //    $(""#loginModal"").modal('hide');



    //        $(""#btnF");
            WriteLiteral(@"ilter"").click(function () {
    //        $(""#loginModal"").modal('show');
    //    }
    //            $(""#btnHideModal"").click(function () {
    //        $(""#loginModal"").modal('hide');
    //            }
    //                });
    //$(document).ready(function () {
    //    $(""#loginModal"").modal('hide');
    //});
    //$(document).ready(function() {

    //    $(""#btnFilter"").click(function () {
    //        var favorite = [];
    //          $('#FilterModal').modal('show').on('shown.bs.modal', function () {
    //              $(""#getVal"").click(function () {
    //                  $.each($(""input[name='sport']:checked""), function () {
    //                      favorite.push($(this).val());
    //                           $(""#checkid"").html(""My favourite sports are: "" + favorite.join("", ""));
    //                  });
    //              });

    //        });
    //    });
    //});
        $(document).ready(function () {
            $(document).ajaxStart(function (");
            WriteLiteral(@") {
                 //$(""#FilterModal"").modal('hide');
                $(""#loading"").show();
            });
            $(document).ajaxStop(function () {
                $(""#loading"").hide();
               
            });
        });

            $(document).ready(function() {

        $(""#btnFilter"").click(function () {
            var favorite = [];
              $('#FilterModal').modal('show').on('btnFilter', function () {
                  $(""#getVal"").click(function () {
                      $.each($(""input[name='sport']:checked""), function () {
                          favorite.push($(this).val());
                               $(""#checkid"").html(""My favourite sports are: "" + favorite.join("", ""));
                      });
                  });

            });
        });
    });
    try {

        $(document).ready(function () {

            $(""#SubmitFilter"").click(function filter() {
                 $(""#FilterModal"").modal('hide');
                //alert('her");
            WriteLiteral("e\');\r\n                var checkedIds = $(\"input[name=\'sport\']:checked\").map(function () { return this.id });\r\n                \r\n                //alert(checkedIds);\r\n                //alert(checkedIds.toArray());\r\n\r\n");
            EndContext();
            BeginContext(8765, 87, true);
            WriteLiteral("                $.ajax({\r\n                    type: \"post\",\r\n                    url: \'");
            EndContext();
            BeginContext(8853, 39, false);
#line 217 "D:\NumbersOnlyProject\MVC_Core\MVC_Core\LinkHub\LHUI\Views\GameBooks\Index.cshtml"
                     Write(Url.Action("FilterRecords","GameBooks"));

#line default
#line hidden
            EndContext();
            BeginContext(8892, 1088, true);
            WriteLiteral(@"',
                    traditional: true,
                    data: { Ids: checkedIds.toArray(), Status: ""A"" },
                    success: function (data) {
                        ShowData(data);
                    },
                    error: function (xhr, status, error) {
                        console.log(""Result: "" + status + "" "" + error + "" "" + xhr.status + "" "" + xhr.statusText)
                    }
                     
                });

                function ShowData(data) {
                    $(""#GameBookList"").html(data);
                    //var strResponse = """";
                    //for (var key in data) {
                    //    strResponse += ""<tr>"";
                    //    for (var key1 in data[key]) {
                    //        strResponse += ""<td>"" + data[key][key1] + ""<td>"";
                    //    }
                    //    strResponse += ""</tr>"";
                    //}
                    //console.log(strResponse)
                    //$(""");
            WriteLiteral("tbody\").html(strResponse);\r\n                }\r\n            });\r\n");
            EndContext();
            BeginContext(10802, 439, true);
            WriteLiteral(@"            //});
        });
        //---------------------------------Search Functionality---------------------------------------
                $(document).ready(function () {

            $(""#btnSearch"").click(function filter() {
                 $(""#FilterModal"").modal('hide');
                var SearchString = $(""#txtSearch"").val();
                $.ajax({
                    type: ""post"",
                    url: '");
            EndContext();
            BeginContext(11242, 39, false);
#line 274 "D:\NumbersOnlyProject\MVC_Core\MVC_Core\LinkHub\LHUI\Views\GameBooks\Index.cshtml"
                     Write(Url.Action("SearchRecords","GameBooks"));

#line default
#line hidden
            EndContext();
            BeginContext(11281, 691, true);
            WriteLiteral(@"',
                    traditional: true,
                    data: {Search: SearchString.toString() },
                    success: function (data) {
                        ShowData(data);
                    },
                    error: function (xhr, status, error) {
                        console.log(""Result: "" + status + "" "" + error + "" "" + xhr.status + "" "" + xhr.statusText)
                    }
                });

                function ShowData(data) {
                    $(""#GameBookList"").html(data);
                    console.log(data)

                }
            });
        });
    }
    catch (e) {
        throw e;
    }

    </script>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LHBOL.Gamebooks>> Html { get; private set; }
    }
}
#pragma warning restore 1591
