using Endpoints.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Endpoints.Controllers
{
    public class HomeController : Controller
    {
        private bool isAuthorized;
        public static bool startMotor = false;
        private static readonly string keyCardCode = "B9D45363";

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        public IActionResult IsUIDAllowed([FromQuery]string uID)
        {
            if(string.IsNullOrWhiteSpace(uID))
            {
                return this.BadRequest();
            }

            if(keyCardCode == uID)
            {
                return this.Ok(SecurityCodes.generateNewCode());
            }

            return this.NotFound();
        }
        public IActionResult CheckSecurityCode([FromForm] string securityCode, [FromForm] bool startMotorOn)
        {
            if (SecurityCodes.codes.FirstOrDefault(s => s == securityCode) != null)
            {
                isAuthorized = true;
                if (startMotorOn)
                {
                    startMotor = true;
                }
                else
                {
                    startMotor = false;
                }
                return this.Ok();
            }

            return this.Unauthorized();
        }

        public IActionResult IsMotorActivated()
        {
            return Ok(startMotor);
        }

        public IActionResult StartMotor()
        {
            if (!isAuthorized)
            {
                return this.Unauthorized();
            }

            startMotor = true;
            return Ok();
        }
    }
}
