using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using page1.Models;

namespace page1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       
        public IActionResult Index()
        {
            return PartialView("index");
        }
        [Route("Pannel")]
        public IActionResult Pannel()
        {
            return View();
        }
        [Route("NewQuiz")]
        public IActionResult NewQuiz()
        {
            return View();
        }
        [Route("Answers")]
        public IActionResult Answers()
        {
            return View();
        }
        [Route("BuyPage")]
        public IActionResult BuyPage()
        {
            return PartialView("BuyPage");
        }
        [Route("Exit")]
        public IActionResult Exit()
        {
            return View();
        }
        [Route("ALI")]
        public IActionResult Ali()
        {
            return View();
        }
        [Route("QuizAnswer")]
        public IActionResult QuizAnswer()
        {
            return View();
        }

        [Route("EditQuiz")]
        public IActionResult EditQuiz()
        {
            return View();
        }
        [Route("QuizInfo")]
        public IActionResult QuizInfo()
        {
            return View();
        }
        [Route("Login")]
        public IActionResult Login()
        {
            return PartialView("Login");
        }
        [Route("Signin")]
        public IActionResult Signin()
        {
            return PartialView("Signin");
        }
        [Route("BuyQuiz")]
        public IActionResult BuyQuiz()
        {
            return View();
        }
        [Route("ForgotPassWord")]
        public IActionResult ForgotPassWord()
        {
            return PartialView("ForgotPassWord");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Route("Error")]
        public IActionResult ErrorNotFound()
        {
            return View();
        }
    }
}
