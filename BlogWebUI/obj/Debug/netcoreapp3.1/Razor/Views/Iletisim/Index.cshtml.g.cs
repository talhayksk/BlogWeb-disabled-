#pragma checksum "C:\Users\Kardelen\Desktop\Çalışmalarım\BlogY\Blogum\BlogWebUI\Views\Iletisim\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfb8ee3224c4cfd74a9947f6f14ae11823ab7a6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Iletisim_Index), @"mvc.1.0.view", @"/Views/Iletisim/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Kardelen\Desktop\Çalışmalarım\BlogY\Blogum\BlogWebUI\Views\_ViewImports.cshtml"
using BlogWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kardelen\Desktop\Çalışmalarım\BlogY\Blogum\BlogWebUI\Views\_ViewImports.cshtml"
using BlogWebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfb8ee3224c4cfd74a9947f6f14ae11823ab7a6d", @"/Views/Iletisim/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"787623a88472e60d6fba24ba40327cb4d09ea29f", @"/Views/_ViewImports.cshtml")]
    public class Views_Iletisim_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogWebUI.Models.IletisimModelView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("sentMessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Kardelen\Desktop\Çalışmalarım\BlogY\Blogum\BlogWebUI\Views\Iletisim\Index.cshtml"
  
    ViewData["Title"] = "İletişim Bilgileri";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script type=""text/javascript"">
function Temizle(){
 //alert(""Form temizlenecek"");
 document.forms[0].reset();
}
</script>
<!-- Page Content -->
<div class=""container"">

    <!-- Page Heading/Breadcrumbs -->
    <h1 class=""mt-4 mb-3"">
        İletişim
        <small>Bilgilerim</small>
    </h1>

    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfb8ee3224c4cfd74a9947f6f14ae11823ab7a6d5662", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </li>
        <li class=""breadcrumb-item active"">İletişim</li>
    </ol>

    <!-- Content Row -->
    <div class=""row"">
        <!-- Map Column -->
        <div class=""col-lg-8 mb-4"">
            <!-- Embedded Google Map -->
            <iframe src=""https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d1529.8304100672067!2d32.822493!3d39.926606!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x975e90b2cf7d2d48!2sMado%20Emek!5e0!3m2!1str!2str!4v1594989677394!5m2!1str!2str"" width=""600"" height=""450"" frameborder=""0"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1100, "\"", 1118, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""false"" tabindex=""0""></iframe>

        </div>
        <!-- Contact Details Column -->
        <div class=""col-lg-4 mb-4"">
            <h3>iletişim Detayları</h3>
            <p>
                Bahçelievler,Emek
                <br>Ankara, Türkiye-2020
                <br>
            </p>
            <p>
                <abbr title=""Phone"">Telefon</abbr>: (123) 456-7890
            </p>
            <p>
                <abbr title=""Email"">Email</abbr>:
                <a href=""mailto:name@example.com"">
                    name@example.com
                </a>
            </p>
            <p>
                <abbr title=""Hours"">Tarih</abbr>: Monday - Friday: 9:00 AM to 5:00 PM
            </p>
        </div>
    </div>
    <!-- /.row -->
    <!-- Contact Form -->
    <!-- In order to set the email address and subject line for the contact form go to the bin/contact_me.php file. -->
");
#nullable restore
#line 61 "C:\Users\Kardelen\Desktop\Çalışmalarım\BlogY\Blogum\BlogWebUI\Views\Iletisim\Index.cshtml"
     using (Html.BeginForm(null, null, FormMethod.Post, new { id = "contact-form", action = "" }))
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-lg-8 mb-4\">\r\n                <h3>Bana Mesaj Gönder..</h3>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfb8ee3224c4cfd74a9947f6f14ae11823ab7a6d9345", async() => {
                WriteLiteral("\r\n                    <div class=\"control-group form-group\">\r\n                        <div class=\"controls\">\r\n                            <label><span class=\"text-danger\">*</span>Ad Soyad:</label>\r\n");
                WriteLiteral("                            ");
#nullable restore
#line 73 "C:\Users\Kardelen\Desktop\Çalışmalarım\BlogY\Blogum\BlogWebUI\Views\Iletisim\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.AdSoyad, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 74 "C:\Users\Kardelen\Desktop\Çalışmalarım\BlogY\Blogum\BlogWebUI\Views\Iletisim\Index.cshtml"
                       Write(Html.ValidationMessageFor(m => m.AdSoyad, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <p class=""help-block""></p>
                        </div>
                    </div>
                    <div class=""control-group form-group"">
                        <div class=""controls"">
                            <span class=""text-danger"">*</span><label>Konu:</label>
");
                WriteLiteral("                            ");
#nullable restore
#line 82 "C:\Users\Kardelen\Desktop\Çalışmalarım\BlogY\Blogum\BlogWebUI\Views\Iletisim\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Konu, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 83 "C:\Users\Kardelen\Desktop\Çalışmalarım\BlogY\Blogum\BlogWebUI\Views\Iletisim\Index.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Konu, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"control-group form-group\">\r\n                        <div class=\"controls\">\r\n                            <label><span class=\"text-danger\">*</span>Email:</label>\r\n");
                WriteLiteral("                            ");
#nullable restore
#line 90 "C:\Users\Kardelen\Desktop\Çalışmalarım\BlogY\Blogum\BlogWebUI\Views\Iletisim\Index.cshtml"
                       Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 91 "C:\Users\Kardelen\Desktop\Çalışmalarım\BlogY\Blogum\BlogWebUI\Views\Iletisim\Index.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""control-group form-group"">
                        <div class=""controls"">
                            <label><span class=""text-danger"">*</span>Mesajınız</label>
");
                WriteLiteral("                            ");
#nullable restore
#line 98 "C:\Users\Kardelen\Desktop\Çalışmalarım\BlogY\Blogum\BlogWebUI\Views\Iletisim\Index.cshtml"
                       Write(Html.TextAreaFor(m => m.Mesaj, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 99 "C:\Users\Kardelen\Desktop\Çalışmalarım\BlogY\Blogum\BlogWebUI\Views\Iletisim\Index.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Mesaj, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div id=\"success\"></div>\r\n                    <!-- For success/fail messages -->\r\n");
#nullable restore
#line 104 "C:\Users\Kardelen\Desktop\Çalışmalarım\BlogY\Blogum\BlogWebUI\Views\Iletisim\Index.cshtml"
                     if (ViewBag.MailGonderildiMi == true)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""alert alert-success"" role=""alert"">
                            Mesajınız başarıyla gönderilmiştir.En kısa zamanda Size Geri Dönüş Yapılacaktır...

                        </div>
                        <span> Temizle();</span>
");
#nullable restore
#line 111 "C:\Users\Kardelen\Desktop\Çalışmalarım\BlogY\Blogum\BlogWebUI\Views\Iletisim\Index.cshtml"


                    }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-danger float-right\" id=\"sendMessageButton\">Gönder</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n        <!-- /.row -->\r\n");
#nullable restore
#line 126 "C:\Users\Kardelen\Desktop\Çalışmalarım\BlogY\Blogum\BlogWebUI\Views\Iletisim\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<!-- /.container -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogWebUI.Models.IletisimModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591
