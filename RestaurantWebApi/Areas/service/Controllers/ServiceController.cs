﻿using dataRepository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebApi.Areas.service.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ServiceController : Controller
    {
        private readonly IServiceRepository _servicerepo;
        private readonly IConfiguration _configuration;
        public string connectionstring = "Server=PCA59\\SQL2019;Database=RestaurantPOS;User Id=sa;Password=Tatva@123;Trusted_Connection=True;Encrypt=False";
        public ServiceController(IServiceRepository servicerepo, IConfiguration configuration)
        {
            _servicerepo = servicerepo;
            _configuration = configuration;

        }
        [HttpGet]
        public IActionResult GetCategoryNames()
        {
            var names = _servicerepo.GetCategoryNames();
            return Ok(names);
        }
        [HttpGet("{id}")]
        public IActionResult GetProductsById(int id)
        {
            try
            {
                var names = _servicerepo.GetProductsById(id);
                return Ok(names);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
       
    }
}
