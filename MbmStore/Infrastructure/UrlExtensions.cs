using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MbmStore.Models;

namespace MbmStore.Infrastructure
{
    public static class UrlExtensions
    {
        public static string PathandQuery(this HttpRequest request) => request.QueryString.HasValue
            ? $"{request.Path}{request.QueryString}" : request.Path.ToString();
    }
}
