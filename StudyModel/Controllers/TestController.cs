using Microsoft.AspNetCore.Mvc;
using StudyModel.NewFolder;

namespace StudyModel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public TestController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        [HttpGet]
        public async Task<string> Get()
        {
            var result = await _dataContext.SaveChangesAsync();
            return result.ToString();
        }
    }
}
