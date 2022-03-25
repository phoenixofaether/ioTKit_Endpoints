using Endpoints.Models;
using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration configuration;
        private bool isAuthorized;
        private bool startMotor = false;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            this.configuration = configuration;
        }

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

            if("2A519929" == uID)
            {
                return this.Ok(SecurityCodes.generateNewCode());
            }

            return this.NotFound();
        }

        public IActionResult CheckSecurityCode([FromForm] string securityCode)
        {
            if(SecurityCodes.codes.FirstOrDefault(s => s == securityCode) != null)
            {
                isAuthorized = true;
                return this.RedirectToPage("Home/Tools");
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
