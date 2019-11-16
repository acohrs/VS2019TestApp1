using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestApplication1.Pages
{
    public class HandlersModel : PageModel
    {
        public string Message { get; set; } = "";

        public void OnGet()
        {
            Message = "Get used";
        }
        public void OnPost()
        {
            Message = "Post used";
        }

        public void OnPostEdit()
        {
            Message = "Edit used";
        }

        public void OnPostView()
        {
            Message = "View used";
        }

        public void OnPostDelete()
        {
            Message = "Delete used";
        }

    }
}