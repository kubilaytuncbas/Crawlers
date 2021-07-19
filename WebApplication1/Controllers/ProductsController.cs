using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        ICrawlerService _crawler;
        public ProductsController(ICrawlerService crawler)
        {
            _crawler = crawler;
        }

        [HttpGet("getall")]
        public IActionResult getAll()
        {
            var result = _crawler.GetAll();
            return RedirectToAction("");

        }
        [HttpPost("add")]
        public ActionResult Add()
        {
            _crawler.Add();
            return RedirectToAction("GetProductList");
        }
    }
}
