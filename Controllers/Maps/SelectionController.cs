using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EJ2CoreSampleBrowser.Controllers.Maps
{
    public partial class MapsController: Controller
    {
        public IActionResult Selection()
        {
            ViewBag.usmap = getusMap();
            ViewBag.electiondata = GetElectiondata();
            return View();
        }
		
        public object GetElectiondata()
        {
            string allText = System.IO.File.ReadAllText("./wwwroot/scripts/MapsData/electiondata.js");
            return JsonConvert.DeserializeObject(allText);
        }
    }
}