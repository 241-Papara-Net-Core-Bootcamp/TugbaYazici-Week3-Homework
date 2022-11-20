using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PaparaThirdWeek.Domain.Entities;
using PaparaThirdWeek.Services.Abstracts;
using PaparaThirdWeek.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PaparaThirdWeek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService companyService;

        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        [HttpPost]
        public IActionResult Post(Company company)
        {
           
            companyService.Add(company);
            return Ok();
        }
        [HttpGet("Companies")]
        public IActionResult Get() 
        {
            var result = companyService.GetAll();
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(Company company) 
        {
          companyService.Delete(company);
            return Ok();

        }

        [HttpPut]
        public IActionResult Put(Company company)
        {
            companyService.Update(company);
            return Ok();
        }

       
      
    }
}
