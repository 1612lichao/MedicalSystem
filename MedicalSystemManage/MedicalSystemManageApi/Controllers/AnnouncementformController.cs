using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MedicalSystemManageApi.Controllers
{
    public class AnnouncementformController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}