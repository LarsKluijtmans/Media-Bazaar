using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazzar.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        //    public string RequestId { get; set; }

        //    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        //    private readonly ILogger<ProfileModel> _logger;

        //    public ProfileModel(ILogger<ProfileModel> logger)
        //    {
        //        _logger = logger;
        //    }

        public void OnGet()
    {
    }
    }
}
