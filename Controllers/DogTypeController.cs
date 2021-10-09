using Microsoft.AspNetCore.Mvc;
using ReturningEnumValuesOverAPI.DTOs;
using ReturningEnumValuesOverAPI.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReturningEnumValuesOverAPI.Helpers;
using System.Linq;

namespace ReturningEnumValuesOverAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogTypeController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<EnumDTO>> GetDogTypes()
        {
            return Enum<DogTypeEnum>.GetAllValuesAsIEnumerable().Select(d => new EnumDTO(d));
        }
    }
}
