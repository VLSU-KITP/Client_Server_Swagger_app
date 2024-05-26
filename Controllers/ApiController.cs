using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyRazorApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiController : ControllerBase
    {
        /// <summary>
        /// Получить список данных.
        /// </summary>
        /// <returns>Список строк.</returns>
        [HttpGet("data")]
        public IEnumerable<string> GetData()
        {
            return new string[] { "data1", "data2", "data3" };
        }
    }
}

