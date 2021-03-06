﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Infrastructure.Common
{
    public static class HttpResponseExtensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            /*  response.Headers.Add("Application-Error", Uri.EscapeDataString( message));
              response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
              response.Headers.Add("Access-Control-Allow-Origin", "*");*/
            response.Headers.Add("Application-Error", "Error");
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}
