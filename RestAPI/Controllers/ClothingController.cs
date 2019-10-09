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
        readonly IClothingService _clothingService;

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
                            ClothingType = clothing.ClothingType,
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
        public ActionResult<Clothing> Get(int id)
        {
            if (id < 1) return BadRequest("Id must be greater than 1");
            return _clothingService.ReadClothing(id);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Clothing> Post([FromBody] Clothing clothing)
        {
            return _clothingService.CreateClothing(clothing);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<Clothing> Put(int id, [FromBody] Clothing clothing)
        {
            if (id < 1 || id != clothing.Id)
            {
                return BadRequest("Parameter id and owner id must be the same");
            }

            _clothingService.UpdateClothing(clothing);
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<Clothing> Delete(int id)
        {
            Clothing clothing = _clothingService.DeleteClothing(id);
            if (clothing == null)
            {
                return BadRequest("Parameter id must match Clothing id");
            }
            return Ok("Clothing with id: " + id + " Was deleted");
        }
    }
}