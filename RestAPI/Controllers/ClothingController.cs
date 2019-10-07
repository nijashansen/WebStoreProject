using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.ApplicationServices;
using Core.DomainServices.Filtering;
using Core.Entity;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothingController : ControllerBase
    {
        private IClothingService _clothingService;

        public ClothingController(IClothingService clothingService)
        {
            _clothingService = clothingService;
        }
        
        // GET api/Clothing
        [HttpGet]
        public ActionResult<FilteringList<Clothing>> Get([FromQuery] Filter filter)
        {
            try
            {
                if(filter.CurrentPage == 0 && filter.InfoPrPage == 0)
                {
                    var list = _clothingService.ReadAllClothes(null);
                    var newList = new List<Clothing>();
                    foreach (var clothing in list.List)
                    {
                        newList.Add(new Clothing()
                        {
                            Id = clothing.Id,
                            Price = clothing.Price,
                            Size = clothing.Size,
                            ClothesTypes = clothing.ClothesTypes,
                            ClothingInformation = clothing.ClothingInformation,
                            ClothingName = clothing.ClothingName
                        }) ;
                    }
                    var newFilteredList = new FilteringList<Clothing>();
                    newFilteredList.List = newList;
                    newFilteredList.Count = list.Count;
                    return Ok(newFilteredList);
                }

                var fl = _clothingService.ReadAllClothes(filter);

                return Ok(fl);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}