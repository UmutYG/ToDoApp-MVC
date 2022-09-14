#pragma checksum "C:\Users\umut_\Desktop\GitHubProjects\ToDoApp-MVC\todoapp.webui\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eedba3b5c19119d77630bd89041f6efa01c435d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\umut_\Desktop\GitHubProjects\ToDoApp-MVC\todoapp.webui\Views\_ViewImports.cshtml"
using todoapp.entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eedba3b5c19119d77630bd89041f6efa01c435d4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43360ee57166abe1992f1a90aa5aa115b4ed1c39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<todoapp.entity.Task>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<blockquote class=""blockquote text-center"">
  <p class=""mt-1"" id=""quote""></p>
  <footer class=""blockquote-footer mt-2"" id=""author""><cite title=""Source Title""></cite></footer>
</blockquote>
  <div class=""container mt-3"">
      <p class=""card-text fs-4"">ToDoApp</p>
      <form action=""/home/AddTask"" method=""post"">
      <div class=""input-group mb-3"">
          <input name=""task"" type=""text"" class=""form-control"" placeholder=""Add Task"" aria-label=""Recipient's username"" id=""input"">
          <button type=""submit"" class=""btn btn-outline-secondary"" onclick=""manageTasks()"" type=""button"" id=""button-add"">Add</button>
        </div>
        <div class=""input-group mb-3"">
          <input name=""desc"" type=""text"" class=""form-control"" placeholder=""Add Description"" aria-label=""Recipient's username"" id=""inputDesc"">
        </div>
        </form>
        <ul class=""list-group list-group-horizontal mb-3"">
          <li class=""list-group-item""><a href=""#"">All</a></li>
          <li class=""list-group-item""><a ");
            WriteLiteral("href=\"#\">Pending</a></li>\r\n          <li class=\"list-group-item\"><a href=\"#\">Completed</a></li>\r\n        </ul>\r\n      <div class=\"accordion\" id=\"mainAccordion\">\r\n          <!-- filled with tasks -->\r\n");
#nullable restore
#line 25 "C:\Users\umut_\Desktop\GitHubProjects\ToDoApp-MVC\todoapp.webui\Views\Home\Index.cshtml"
           foreach (var task in Model)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""accordion-item"">
                    <h2 class=""accordion-header"" id=""headingOne"">
                        <button class=""accordion-button"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#a task.TaskId"" aria-expanded=""true"" aria-controls=""collapseOne"">
                        ");
#nullable restore
#line 30 "C:\Users\umut_\Desktop\GitHubProjects\ToDoApp-MVC\todoapp.webui\Views\Home\Index.cshtml"
                   Write(task.TaskHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </button>\r\n                        <div class=\"icons\">\r\n                            <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1761, "\"", 1793, 3);
            WriteAttributeValue("", 1771, "editTask(", 1771, 9, true);
#nullable restore
#line 33 "C:\Users\umut_\Desktop\GitHubProjects\ToDoApp-MVC\todoapp.webui\Views\Home\Index.cshtml"
WriteAttributeValue("", 1780, task.TaskId, 1780, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1792, ")", 1792, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-pen-to-square fa-sm\"></i></a>\r\n                            <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1887, "\"", 1921, 3);
            WriteAttributeValue("", 1897, "deleteTask(", 1897, 11, true);
#nullable restore
#line 34 "C:\Users\umut_\Desktop\GitHubProjects\ToDoApp-MVC\todoapp.webui\Views\Home\Index.cshtml"
WriteAttributeValue("", 1908, task.TaskId, 1908, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1920, ")", 1920, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-trash fa-sm\"></i></a>\r\n                            <a href=\"#\" id=\"status\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2019, "\"", 2053, 3);
            WriteAttributeValue("", 2029, "finishTask(", 2029, 11, true);
#nullable restore
#line 35 "C:\Users\umut_\Desktop\GitHubProjects\ToDoApp-MVC\todoapp.webui\Views\Home\Index.cshtml"
WriteAttributeValue("", 2040, task.TaskId, 2040, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2052, ")", 2052, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""${statusIcon}""></i></a>
                            
                        </div>
                    </h2>
                    <div id=""a${task.id}"" class=""accordion-collapse collapse show"" aria-labelledby=""headingOne"" data-bs-parent=""#accordionExample"">
                        <div class=""accordion-body"">
                          
                        ");
#nullable restore
#line 42 "C:\Users\umut_\Desktop\GitHubProjects\ToDoApp-MVC\todoapp.webui\Views\Home\Index.cshtml"
                   Write(task.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 46 "C:\Users\umut_\Desktop\GitHubProjects\ToDoApp-MVC\todoapp.webui\Views\Home\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>\r\n  </div>\r\n \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<todoapp.entity.Task>> Html { get; private set; }
    }
}
#pragma warning restore 1591
