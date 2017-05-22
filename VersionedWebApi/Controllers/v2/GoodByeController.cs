using Microsoft.AspNetCore.Mvc;
using VersionedWebApi.Model;

namespace VersionedWebApi.Controllers.v2
{
	/// <summary>
	/// GoodByeController, just saying Goodbye!
	/// </summary>
    [ApiVersionAttribute("2.0")]
    [Route("api/v{api-version:apiVersion}/[controller]")]
    public class GoodByeController : Controller
	{
		/// <summary>
		/// Default Get call returning Goodbye world!
		/// </summary>
		/// <returns></returns>
		[HttpGet]
        [ProducesResponseType(typeof(VersionedWebApi.Model.v2.GoodByeWorldModel), 200)]
        [ProducesResponseType(typeof(void), 404)]
		public VersionedWebApi.Model.v2.GoodByeWorldModel Get()
		{
			return new VersionedWebApi.Model.v2.GoodByeWorldModel();
		}
	}
}
