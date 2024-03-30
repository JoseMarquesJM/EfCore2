using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       private readonly DataContext _dataContext;

        public WeatherForecastController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet("Alunos")]
        public ActionResult Index() => Ok(_dataContext.Alunos.AsNoTracking().ToList());
    }
}
