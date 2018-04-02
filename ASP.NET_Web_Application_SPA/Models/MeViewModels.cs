using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Web_Application_SPA.Models
{
    // Models returned by MeController actions.
    public class GetViewModel
    {
        public string Hometown { get; set; }
    }
}