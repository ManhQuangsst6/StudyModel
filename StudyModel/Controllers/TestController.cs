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
            var banana = new Food("🍌", 1.95);
            var apple = new
            {
                Name = "🍎",
                Price = 1.21
            };
            var orange = apple with
            {
                Name = "🍊"
                ,
                Price = banana.Price
            };
            return result.ToString();
        }
        public record Food(string Name, double Price);
    }
}
