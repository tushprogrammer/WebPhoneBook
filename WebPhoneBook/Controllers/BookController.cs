using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace WebPhoneBook.Controllers
{
    public class BookController : Controller
    {
     
        public IActionResult Index()
        {
            Console.WriteLine("какой нибудь текст, о том, что сработал метод index");
            return View();
            
        }
    }
}