using Funda.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using Funda.Domain.Requests;
using Funda.Services.Interfaces;

namespace Funda.Web.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IPropertyService _propertyService;

        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }
        
        /// <summary>
        /// Sets requests parameters and Gets Estate Agents ordered by property count
        /// </summary>
        /// <param name="searchText">Search key text</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Index(string searchText)
        {
            //TODO: in real list page should come from filter object
            var propertyRequest = new PropertyRequest()
            {
                Type = "koop",
                SearchText = $"/amsterdam/{searchText}",
                Count = 10
            };
            ViewBag.SearchText = searchText;
            var properties = await _propertyService.GetEstateAgentsByPropertyAsync(propertyRequest);

            return View(properties);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
