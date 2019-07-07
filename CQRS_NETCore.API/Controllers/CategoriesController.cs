using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_NETCore.Application.Categories.Models;
using CQRS_NETCore.Application.Categories.Queries;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CQRS_NETCore.API.Controllers
{

    public class CategoriesController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryPreviewDto>>> GetCategoryPreview([FromQuery] GetCategoryPreviewQuery query)
        {
            return Ok(await Mediator.Send(query));
        }
    }
}
