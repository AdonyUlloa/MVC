using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using primeraAplicacion.Models;

namespace primeraAplicacion.Controllers
{
    public class  PersonalController : Controller
    {
        public IActionResult Index()
        {
            Personal personal = new Personal();
            personal.name = "Edwin Adony";
            personal.lastname = "Ulloa Diaz";
            personal.age = 24;
            personal.email = "adonyulloa@gmail.com";
            personal.direccion = "San Miguel, San Miguel";
            return View(personal);
        }
        
    }  
    
}