using Microsoft.AspNetCore.Mvc;
using MohmlML.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mohml.Controllers
{
    public class StockPredictionController : Controller
    {
        [HttpGet]
        public IActionResult StockPrediction()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StockPrediction(ModelInput input)
        {
            ViewBag.Result = "";
            var stockPredictions = ConsumeModel.Predict(input);
            ViewBag.Result = stockPredictions;

            ViewData["ItemID"] = input.ItemID;
            ViewData["Loccode"] = input.Loccode;
            return View();
        }
    }
}
